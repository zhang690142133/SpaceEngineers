← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### TextPtr Struct

```csharp
public struct TextPtr
```

A parser utility structure representing a pointer to a location within a string.

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

#### Fields

[string Content](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.Content)

> The original content string

[int Index](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.Index)

> The index being pointed at by this structure

#### Properties

[char Char { get; }](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.Char)

> Returns the character currently being pointed at, or`\0`if out of bounds

[bool IsEmpty { get; }](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.IsEmpty)

> Determines whether this pointer is an empty pointer, i.e. not pointing at anything at all.

#### Constructors

[TextPtr(string content)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr..ctor)

> 

[TextPtr(string content, int index)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr..ctor)

> 

#### 方法

[TextPtr Find(string str)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.Find)

> Finds the given text string

[TextPtr Find(char ch)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.Find)

> Finds the given character

[TextPtr FindAny(Char&#91&#93; chs)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.FindAny)

> Finds one of the given characters

[TextPtr FindAnyInLine(Char&#91&#93; chs)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.FindAnyInLine)

> Finds one of the given characters within the current line

[TextPtr FindEndOfLine(bool skipNewline = default)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.FindEndOfLine)

> Finds the end of the current line

[TextPtr FindInLine(char ch)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.FindInLine)

> Finds the given character within the current line

[int FindLineNo()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.FindLineNo)

> Determines what line number this pointer is currently at.

[bool IsEndOfLine()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.IsEndOfLine)

> Determines whether the pointer is currently at the end of a line (right before a newline character set or end of the string)

[bool IsNewLine()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.IsNewLine)

> Determines whether the pointer is currently at a newline (end of the string is not a newline)

[bool IsOutOfBounds()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.IsOutOfBounds)

> Determines whether this pointer is currently out of bounds (before or after the string content)

[bool IsStartOfLine()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.IsStartOfLine)

> Determines whether the pointer is currently at the beginning of a line (right after a newline character set or start of the string)

[TextPtr SkipWhitespace(bool skipNewline = default)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.SkipWhitespace)

> Skips whitespace

[bool StartsWith(string what)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.StartsWith)

> Determines if the current pointer location starts with the given string - in a case sensitive manner.

[bool StartsWithCaseInsensitive(string what)](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.StartsWithCaseInsensitive)

> Determines if the current pointer location starts with the given string - in a case insensitive manner.

[TextPtr TrimEnd()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.TrimEnd)

> Reverses the pointer location until all whitespace is skipped - does not skip newlines

[TextPtr TrimStart()](VRage.Game.ModAPI.Ingame.Utilities.TextPtr.TrimStart)

> Advances the pointer location until all whitespace is skipped - does not skip newlines

