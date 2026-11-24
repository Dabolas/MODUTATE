// Strict parser for migrated Forge operators. Unknown parameters fail closed.
const keywordFlags={Flying:'Flying',Haste:'Haste',Vigilance:'Vigilance','First Strike':'FirstStrike','Double Strike':'DoubleStrike',Trample:'Trample',Deathtouch:'Deathtouch',Lifelink:'Lifelink',Reach:'Reach',Menace:'Menace',Defender:'Defender',Flash:'Flash',Hexproof:'Hexproof',Shroud:'Shroud',Indestructible:'Indestructible',Infect:'Infect',Wither:'Wither',Shadow:'Shadow',Fear:'Fear',Intimidate:'Intimidate',Skulk:'Skulk',Horsemanship:'Horsemanship','Landwalk:Plains':'Plainswalk','Landwalk:Island':'Islandwalk','Landwalk:Swamp':'Swampwalk','Landwalk:Mountain':'Mountainwalk','Landwalk:Forest':'Forestwalk'};
const targetKinds={Creature:'Creature',Player:'Player',Opponent:'Opponent','Creature,Player':'CreatureOrPlayer','Creature, Player':'CreatureOrPlayer',Any:'DamageTarget',Permanent:'Permanent',Artifact:'Artifact',Enchantment:'Enchantment'};
const topFields=new Set(['Name','ManaCost','Types','PT','K','Oracle','DeckHints','DeckHas','DeckNeeds','A','T','SVar','S','AI']);
function fail(message) { throw new Error(message); }
function integer(value,negative=false) { if(!(negative?/^[+-]?\d+$/:/^\d+$/).test(value??'')) fail('expression:'+value);const n=Number(value); if(!Number.isSafeInteger(n)||Math.abs(n)>100000) fail('numeric-range');return n; }
function params(text) {
  const map={};
  for(const section of text.split('|')) {const i=section.indexOf('$');if(i<1) fail('invalid-parameter:'+section);const key=section.slice(0,i).trim();if(Object.hasOwn(map,key)) fail('duplicate-parameter:'+key);map[key]=section.slice(i+1).trim();}
  return map;
}
function keys(map,allowed) { for(const key of Object.keys(map)) if(!allowed.includes(key)) fail('parameter:'+key); }
const cs=JSON.stringify;
function effectSource(e) {return `new RuleEffect(RuleOp.${e.op},${e.amount},RuleSubject.${e.subject},${e.secondary??0},${cs(e.counter??'')},${e.x??0},${e.secondaryX??0})`;}
export function compileCard(fields,options={}) {
  try {
    for(const field of fields) if(!topFields.has(field.key)) fail('field:'+field.key);
    for(const field of fields.filter(f=>f.key==='AI'))if(!/^RemoveDeck:(Random|All)$/.test(field.value))fail('AI-field');
    const get=k=>fields.find(f=>f.key===k)?.value??'';
    for(const key of ['Name','ManaCost','Types','PT','Oracle']) if(fields.filter(f=>f.key===key).length>1) fail('duplicate-field:'+key);
    const name=get('Name'),types=get('Types').split(' '),colored=[0,0,0,0,0,0]; let generic=0,snowCost=0,xSymbols=0;const alternativeCosts=[];
    for(const c of get('ManaCost').split(' ')) {
      if(/^\d+$/.test(c))generic+=integer(c);
      else if(c==='S')snowCost++;
      else if(c==='X')xSymbols++;
      else if(c.length===1&&'WUBRGC'.includes(c))colored['WUBRGC'.indexOf(c)]++;
      else {
        const symbol=c.includes('/')?c:c.split('').join('/');
        if(/^(?:[WUBRGC]\/[WUBRGC]|2\/[WUBRGC]|[WUBRGC]\/P|[WUBRGC]\/[WUBRGC]\/P)$/.test(symbol)&&new Set(symbol.split('/')).size===symbol.split('/').length)alternativeCosts.push(symbol);
        else fail('mana:'+c);
      }
    }
    const kind=types.includes('Creature')?'Creature':types.includes('Artifact')?'Artifact':types.includes('Enchantment')?'Enchantment':types.includes('Instant')?'Instant':types.includes('Sorcery')?'Sorcery':fail('card-type');
    const primary=types.indexOf(kind);if(types.slice(0,primary).some(t=>!['Snow','Artifact','Enchantment','Legendary'].includes(t)))fail('supertype');
    if(types.includes('Aura')||types.includes('Equipment')||types.includes('Fortification')||types.includes('Saga')||types.includes('Class')||types.includes('Room')||types.includes('Case')||types.includes('Curse')||types.includes('Role'))fail('special-permanent-type');
    if(kind!=='Creature'&&types.slice(primary+1).some(t=>!((['Instant','Sorcery'].includes(kind)&&['Arcane','Lesson','Trap'].includes(t)||kind==='Artifact'&&t==='Book'))))fail('special-card-subtype');
    let power=0,toughness=0;
    if(kind==='Creature') { const pt=/^(\d+)\/(\d+)$/.exec(get('PT'));if(!pt)fail('variable-stats');power=integer(pt[1]);toughness=integer(pt[2]); }
    let toxicValue=0;const keywords=[];
    for(const f of fields.filter(f=>f.key==='K')) {
      if(/^Toxic:\d+$/.test(f.value)) {toxicValue+=integer(f.value.slice(6));if(toxicValue>100000)fail('toxic-range');}
      else keywords.push(keywordFlags[f.value]??fail('keyword:'+f.value));
    }
    let cannotBlock=false,noMaximumHandSize=false;
    for(const f of fields.filter(f=>f.key==='S')) {
      const map=params(f.value);
      if(map.Mode==='Continuous'&&map.Affected==='You'&&map.SetMaxHandSize==='Unlimited'){keys(map,['Mode','Affected','SetMaxHandSize','Description']);noMaximumHandSize=true;}
      else if(map.Mode==='CantBlockBy') {keys(map,['Mode','ValidAttacker','Description']);if(map.ValidAttacker!=='Creature.Self')fail('static-ability');keywords.push('Unblockable');}
      else {keys(map,['Mode','ValidCard','Description']);if(map.Mode!=='CantBlock'||map.ValidCard!=='Card.Self')fail('static-ability');cannotBlock=true;}
    }
    const svars=new Map(),used=new Set();
    for(const field of fields.filter(f=>f.key==='SVar')) {const i=field.value.indexOf(':');if(i<1)fail('svar');const key=field.value.slice(0,i);if(svars.has(key))fail('duplicate-svar');svars.set(key,field.value.slice(i+1));}
    function expression(value,negative=false) {
      if(value==='X'||negative&&(value==='+X'||value==='-X')) {
        if(!xSymbols||svars.get('X')!=='Count$xPaid')fail('X-expression');used.add('X');return {constant:0,x:value==='-X'?-1:1};
      }
      return integer(value,negative);
    }
    function program(text,prefix,depth=0,selfEvent=false,eventMode='') {
      if(depth>16)fail('subability-depth');
      const map=params(text),op=map[prefix];
      const allowed=[prefix,'SpellDescription','SubAbility','Defined','ValidTgts','TgtPrompt','IsCurse','AIPhyrexianPayment','StackDescription'];
      if(map.StackDescription&&map.StackDescription!=='SpellDescription')fail('stack-description');
      if(map.IsCurse&&!['True','False'].includes(map.IsCurse))fail('curse-hint');
      let effect,target='None';
      if(map.ValidTgts)target=targetKinds[map.ValidTgts]??'UNSUPPORTED';
      let subject=selfEvent&&map.Defined==='TriggeredCardController'?'You':map.Defined??(map.ValidTgts?'Targeted':['Pump','PutCounter','Tap','Untap','ChangeZone','Destroy'].includes(op)?'Self':'You');
      if(subject==='TriggeredTarget'&&eventMode==='DamageDone'||subject==='TriggeredPlayer'&&eventMode.startsWith('Phase:'))subject='TriggeredPlayer';
      if(!['You','Targeted','Opponent','EachPlayer','Self','TriggeredPlayer'].includes(subject))fail('defined:'+subject);
      if(subject==='Self'&&(prefix!=='DB'||!eventMode))fail('self-program-context');
      if(subject==='TriggeredPlayer'&&eventMode!=='DamageDone'&&!eventMode.startsWith('Phase:'))fail('event-player-context');
      const e=(op,amount=0,secondary=0,counter='')=>({op,amount:typeof amount==='object'?amount.constant:amount,x:amount.x??0,subject,secondary:typeof secondary==='object'?secondary.constant:secondary,secondaryX:secondary.x??0,counter});
      switch(op) {
        case 'DestroyAll':case 'DamageAll':case 'PumpAll':case 'TapAll':case 'UntapAll': {
          allowed.push('ValidCards');if(op==='DamageAll')allowed.push('ValidPlayers','NumDmg');if(op==='PumpAll')allowed.push('NumAtt','NumDef','Duration');
          if(map.Defined||map.ValidTgts)fail('mass-effect-target');
          if(!['Creature','Creature.YouCtrl','Creature.YouDontCtrl','Creature.Other+YouCtrl','Artifact','Enchantment','Land','Permanent','Creature.nonArtifact'].includes(map.ValidCards))fail('mass-filter');
          if(map.ValidPlayers&&!['Player','You','Opponent'].includes(map.ValidPlayers))fail('mass-player-filter');
          if(map.ValidPlayers&&op!=='DamageAll')fail('mass-player-operation');
          if(map.Duration&&op!=='PumpAll'||map.Duration&&!['UntilEndOfTurn','EndOfTurn'].includes(map.Duration))fail('mass-duration');
          const payload=map.ValidCards+'#'+(map.ValidPlayers??'');
          effect=e(op,op==='DamageAll'?expression(map.NumDmg):op==='PumpAll'?expression(map.NumAtt??'0',true):0,op==='PumpAll'?expression(map.NumDef??'0',true):0,payload);break;
        }
        case 'BecomeMonarch':case 'RingTemptsYou':
          if(map.ValidTgts||subject!=='You')fail('designation-controller');effect=e(op);break;
        case 'Discard':
          allowed.push('NumCards','Mode','DiscardValid');
          if(!['TgtChoose','RevealYouChoose'].includes(map.Mode)||!['Card','Card.nonLand','Card.nonCreature+nonLand','Creature'].includes(map.DiscardValid??'Card'))fail('discard-mode-or-filter');
          if(map.ValidTgts&&!['Player','Opponent'].includes(target)||subject==='Self')fail('discard-subject');
          effect=e('Discard',expression(map.NumCards??'1'),0,map.Mode+'#'+(map.DiscardValid??'Card'));break;
        case 'RevealHand':
          allowed.push('Look');if(map.Look!=='True'||map.ValidTgts&&!['Player','Opponent'].includes(target)||subject==='Self')fail('look-hand');effect=e('RevealHand');break;
        case 'NameCard':
          if(map.ValidTgts||subject!=='You')fail('name-controller');effect=e('NameCard');break;
        case 'ChooseType':
          allowed.push('Type','AILogic');if(map.Type!=='Creature'||map.ValidTgts||subject!=='You')fail('type-choice');effect=e('ChooseCreatureType');break;
        case 'Draw': allowed.push('NumCards');effect=e('Draw',expression(map.NumCards??'1'));break;
        case 'GainLife':case 'LoseLife':allowed.push('LifeAmount');effect=e(op,expression(map.LifeAmount));break;
        case 'Mill':allowed.push('NumCards');effect=e('Mill',expression(map.NumCards));break;
        case 'DealDamage':allowed.push('NumDmg');if(!map.ValidTgts)fail('untargeted-damage');effect=e('Damage',expression(map.NumDmg));break;
        case 'Destroy':if(!map.ValidTgts)fail('untargeted-destroy');effect=e('Destroy');break;
        case 'ChangeZone':
          allowed.push('Origin','Destination');
          if(map.Origin==='Graveyard'&&map.Destination==='Hand'&&['Creature.YouOwn','Creature.YouCtrl'].includes(map.ValidTgts))target='OwnGraveyardCreature';
          else if(map.Origin!=='Battlefield')fail('zone-origin:'+map.Origin);
          if(!map.ValidTgts)fail('untargeted-zone-change');
          effect=e(map.Destination==='Hand'?'ReturnToHand':map.Destination==='Exile'?'Exile':fail('zone-destination:'+map.Destination));break;
        case 'Counter':allowed.push('TargetType');if(map.TargetType!=='Spell'||map.ValidTgts!=='Card')fail('counter-filter');target='Spell';effect=e('Counter');break;
        case 'Pump':
          allowed.push('NumAtt','NumDef','Duration');if(map.Duration&&map.Duration!=='UntilEndOfTurn'&&map.Duration!=='EndOfTurn')fail('pump-duration');
          if(target!=='Creature'&&subject!=='Self')fail('pump-target');effect=e('Pump',expression(map.NumAtt??'0',true),expression(map.NumDef??'0',true));break;
        case 'Tap':case 'Untap':if(!map.ValidTgts)fail('untargeted-tap');effect=e(op);break;
        case 'PutCounter':
          allowed.push('CounterType','CounterNum');if(!['P1P1','M1M1','POISON','ENERGY','EXPERIENCE','RAD'].includes(map.CounterType))fail('counter-type:'+map.CounterType);
          effect=e('AddCounter',expression(map.CounterNum??'1'),0,map.CounterType);break;
        case 'Token':
          allowed.push('TokenAmount','TokenScript','TokenOwner');
          if(map.ValidTgts||map.Defined)fail('token-controller-selection');
          if(!map.TokenScript||!options.tokens?.has(map.TokenScript))fail('token-script:'+map.TokenScript);
          if(map.TokenOwner&&!['You','Opponent','EachPlayer'].includes(map.TokenOwner))fail('token-owner:'+map.TokenOwner);
          subject=map.TokenOwner??'You';effect=e('CreateToken',expression(map.TokenAmount??'1'),0,map.TokenScript);break;
        default:fail('effect:'+op);
      }
      keys(map,allowed);
      if(target==='UNSUPPORTED')fail('target-filter:'+map.ValidTgts);
      if(['Draw','GainLife','LoseLife','Mill'].includes(op)&&(subject==='Self'||map.ValidTgts&&target!=='Player'))fail('player-effect-target');
      if(prefix==='DB'&&map.ValidTgts)fail('subability-target-choice');
      if(map.Defined&&['DealDamage','Destroy','ChangeZone','Counter','Pump','Tap','Untap'].includes(op)&&!(subject==='Self'&&op==='Pump'))fail('defined-card-effect');
      const effects=[effect];
      if(map.SubAbility) {
        if(!svars.has(map.SubAbility)||used.has(map.SubAbility))fail('subability-reference:'+map.SubAbility);
        used.add(map.SubAbility);const sub=program(svars.get(map.SubAbility),'DB',depth+1,selfEvent,eventMode);if(sub.target!=='None')fail('subability-new-target');effects.push(...sub.effects);
      }
      return {target,effects};
    }
    let effects=[],target='None';const triggers=[];
    const abilities=fields.filter(f=>f.key==='A');
    if(abilities.length) {
      if(!['Instant','Sorcery'].includes(kind)||abilities.length!==1)fail('activated-or-multiple-abilities');
      const compiled=program(abilities[0].value,'SP');effects=compiled.effects;target=compiled.target;
    }
    if(['Instant','Sorcery'].includes(kind)&&!effects.length)fail('missing-spell-program');
    for(const field of fields.filter(f=>f.key==='T')) {
      if(['Instant','Sorcery'].includes(kind))fail('spell-trigger');
      const map=params(field.value);
      if(map.TriggerZones&&map.TriggerZones!=='Battlefield'&&!(map.Mode==='SpellCast'&&map.TriggerZones==='Stack'&&map.ValidCard==='Card.Self'))fail('trigger-zone');
      if(map.OptionalDecider&&map.OptionalDecider!=='You')fail('optional-controller');
      let filter=map.ValidCard,combatDamage=null,playerFilter='',eventMode=map.Mode;
      if(map.Mode==='ChangesZone') {
        keys(map,['Mode','Origin','Destination','ValidCard','Execute','TriggerDescription','TriggerZones','OptionalDecider']);
        if(!['Any','Battlefield','Graveyard','Hand','Library','Exile','Stack'].includes(map.Origin)||!['Battlefield','Graveyard'].includes(map.Destination))fail('trigger-event');
      } else if(['Attacks','Blocks','SpellCast'].includes(map.Mode)) {
        keys(map,['Mode','ValidCard','Execute','TriggerDescription','TriggerZones','OptionalDecider']);
      } else if(map.Mode==='DamageDone') {
        keys(map,['Mode','ValidSource','ValidTarget','CombatDamage','Execute','TriggerDescription','TriggerZones','OptionalDecider']);
        filter=map.ValidSource;playerFilter=map.ValidTarget;
        if(!['Player','Opponent'].includes(playerFilter))fail('damage-trigger-target');
        if(map.CombatDamage&&!['True','False'].includes(map.CombatDamage))fail('combat-damage-filter');
        combatDamage=map.CombatDamage?map.CombatDamage==='True':null;
      } else if(map.Mode==='Phase') {
        keys(map,['Mode','Phase','ValidPlayer','Execute','TriggerDescription','TriggerZones','OptionalDecider']);
        if(!['Upkeep','Draw','Main1','Main2','BeginCombat','EndCombat','End of Turn'].includes(map.Phase)||map.ValidPlayer&&!['You','Opponent','Player'].includes(map.ValidPlayer))fail('phase-filter');
        eventMode='Phase:'+map.Phase;filter='Card.Self';playerFilter=map.ValidPlayer??'Player';
      } else fail('trigger-event');
      if(!['Card.Self','Creature','Creature.Other','Creature.YouCtrl','Creature.Other+YouCtrl','Card','Card.YouCtrl','Card.YouDontCtrl','Card.White','Card.Blue','Card.Black','Card.Red','Card.Green','Instant','Sorcery','Instant,Sorcery','Artifact','Enchantment'].includes(filter))fail('trigger-filter');
      if(!svars.has(map.Execute)||used.has(map.Execute))fail('trigger-reference:'+map.Execute);
      used.add(map.Execute);const compiled=program(svars.get(map.Execute),'DB',0,filter==='Card.Self',eventMode);
      if(compiled.target!=='None'||compiled.effects.some(e=>e.x||e.secondaryX||!['Draw','GainLife','LoseLife','AddCounter','Mill','CreateToken','Pump','Discard','RevealHand','NameCard','ChooseCreatureType','BecomeMonarch','RingTemptsYou'].includes(e.op)||e.subject==='Targeted'||
        e.op==='Pump'&&e.subject!=='Self'||e.subject==='Self'&&!['Pump','AddCounter'].includes(e.op)||
        e.op==='AddCounter'&&['P1P1','M1M1'].includes(e.counter)&&e.subject!=='Self'))fail('trigger-program');
      triggers.push({event:eventMode,optional:map.OptionalDecider==='You',origin:map.Origin,destination:map.Destination,filter,combatDamage,playerFilter,effects:compiled.effects});
    }
    if([...svars.keys()].some(k=>!used.has(k)&&!(k==='SacMe'&&/^[1-6]$/.test(svars.get(k)))&&!(k==='NonStackingEffect'&&/^(True|TRUE)$/.test(svars.get(k)))))fail('unconsumed-svar');
    // Keyword-only definitions must have no unexplained Oracle text. Reminder text
    // is ignored only after every executable script field has passed validation.
    if(!effects.length&&!triggers.length&&!cannotBlock&&!keywords.includes('Unblockable')&&!noMaximumHandSize) {
      let oracle=get('Oracle');for(let i=0;i<8&&/\([^()]*\)/.test(oracle);i++)oracle=oracle.replace(/\([^()]*\)/g,'');
      const words=s=>s.toLowerCase().replaceAll('\\n',' ').replace(/[.,]/g,' ').split(/\s+/).filter(Boolean).sort();
      if(JSON.stringify(words(oracle))!==JSON.stringify(words(fields.filter(f=>f.key==='K').map(f=>f.value.replace(/^Toxic:/,'Toxic ').replace(/^Landwalk:(Plains|Island|Swamp|Mountain|Forest)$/,(_,land)=>land+'walk')).join(' '))))fail('oracle-not-covered');
    }
    return {blockers:[],definition:{name,kind,types:types.join(' '),generic,snowCost,xSymbols,alternativeCosts,snow:types.includes('Snow'),colored,power,toughness,keywords,toxicValue,cannotBlock,noMaximumHandSize,
      flying:keywords.includes('Flying'),haste:keywords.includes('Haste'),vigilance:keywords.includes('Vigilance'),text:effects.length||triggers.length?get('Oracle').replaceAll('\\n','\n'):'',
      target,effectsSource:'new RuleEffect[]{'+effects.map(effectSource).join(',')+'}',
      triggersSource:'new RuleTrigger[]{'+triggers.map(t=>(t.event==='ChangesZone'?`new RuleTrigger(${cs(t.origin)},Zone.${t.destination},${cs(t.filter)},${t.effects.map(effectSource).join(',')})`:
        `new RuleTrigger(${cs(t.event)},${cs(t.filter)},${cs(t.playerFilter)},${t.combatDamage===null?'null':t.combatDamage},${t.effects.map(effectSource).join(',')})`)+(t.optional?'{Optional=true}':'')).join(',')+'}'}};
  } catch(error) {return {blockers:[error.message]};}
}

export function compileToken(fields,id) {
  const printedCost=fields.find(f=>f.key==='ManaCost')?.value;
  if(printedCost!=='no cost'&&printedCost!=='0')return {blockers:['token-printed-cost']};
  const colors=fields.find(f=>f.key==='Colors')?.value??'';
  const names={white:1,blue:2,black:4,red:8,green:16,colorless:0};let colorMask=0;
  for(const color of colors.toLowerCase().split(/[, ]+/).filter(Boolean)) {
    if(!Object.hasOwn(names,color))return {blockers:['token-color:'+color]};colorMask|=names[color];
  }
  const transformed=fields.filter(f=>f.key!=='Colors').map(f=>f.key==='ManaCost'?{key:'ManaCost',value:'0'}:f);
  const result=compileCard(transformed);
  if(result.definition&&!['Creature','Artifact','Enchantment'].includes(result.definition.kind))return {blockers:['token-nonpermanent']};
  if(result.definition) { result.definition.tokenId=id;result.definition.colorMask=colorMask; }
  return result;
}
