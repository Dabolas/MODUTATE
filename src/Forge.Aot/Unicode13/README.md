# Pinned character mapping data

Source: Unicode Character Database 13.0.0, corresponding to the Unicode version of Java 17 (the source project's compiler target). These are passive data resources embedded in the C# assembly; no JVM is used.

- https://www.unicode.org/Public/13.0.0/ucd/UnicodeData.txt
- https://www.unicode.org/Public/13.0.0/ucd/SpecialCasing.txt
- https://www.unicode.org/Public/13.0.0/ucd/DerivedCoreProperties.txt
- https://www.unicode.org/Public/13.0.0/ucd/PropList.txt

Original notices are retained. Terms: https://www.unicode.org/copyright.html .

`UnicodeCase` uses simple upper/lower mappings for case-insensitive comparison, and full mappings plus contextual/locale conditions for String casing. The console's default casing locale is explicitly English, independent of the Windows user locale. Locale overloads use the supplied locale. UTF-16 isolated surrogates remain unchanged. This does not certify every other Character/regex/text adapter as Unicode-complete.

Comparison behavior reference: https://github.com/openjdk/jdk17u/blob/master/src/java.base/share/classes/java/lang/StringUTF16.java (`compareToCIImpl`). Contracts cover accented names, sharp-s/ligature expansion, dotted/dotless I, final sigma, Lithuanian dot rules, supplementary letters and malformed UTF-16.
