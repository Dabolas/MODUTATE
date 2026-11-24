using Planeswalker.Core;

namespace Planeswalker.TableHost;

public enum BotMotionKind { Turn, Draw, Cast, Activate, Enter }

public sealed record BotTableMotion(BotMotionKind Kind, CardView? Card=null, string Origin="");
