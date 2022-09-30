← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### StringSegment Struct

```csharp
public struct StringSegment
```

Represents a segment of a string.

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

#### Fields

[int Length](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Length)

> The length of the segment

[int Start](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Start)

> Where the segment starts

[string Text](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Text)

> The original text string

#### Properties

[bool IsCached { get; }](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.IsCached)

> Determines whether this segment has been pre-cached in such a way that no allocation will occur when using [ToString()](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.ToString) 

[bool IsEmpty { get; }](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.IsEmpty)

> Determines whether this is an empty/undefined string segment

[char Item { get; }](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Item)

> 

#### Constructors

[StringSegment(string text)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment..ctor)

> 

[StringSegment(string text, int start, int length)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment..ctor)

> 

#### 方法

[bool Equals(object obj)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Equals)

> Indicates whether this instance and a specified object are equal.

[bool Equals(string other)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Equals)

> Compares this string segment with the given string in a case sensitive manner.

[bool Equals(StringSegment other)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Equals)

> Compares this string segment with another in a case sensitive manner.

[bool EqualsIgnoreCase(string other)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.EqualsIgnoreCase)

> Compares this string segment with the given string in a case insensitive manner.

[bool EqualsIgnoreCase(StringSegment other)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.EqualsIgnoreCase)

> Compares this string segment with another in a case insensitive manner.

[int GetHashCode()](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.GetHashCode)

> Returns the hash code for this instance.

[void GetLines(List&lt;StringSegment&gt; lines)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.GetLines)

> Fills a list with individual string segments representing the lines of text within this string segment, separated by newlines.

[void GetLines(List&lt;string&gt; lines)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.GetLines)

> Fills a list with individual strings representing the lines of text within this string segment, separated by newlines.

[int IndexOf(char ch)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.IndexOf)

> Reports the zero-based index of the first occurence of the specified character, relative to [Start](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Start) . Returns -1 if nothing was found.

[int IndexOf(char ch, int start)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.IndexOf)

> Reports the zero-based index of the first occurence of the specified character, relative to [Start](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Start) . Returns -1 if nothing was found.

[int IndexOfAny(Char&#91&#93; chars)](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.IndexOfAny)

> Reports the zero-based index of the first occurence of one of the provided characters, relative to [Start](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.Start) . Returns -1 if nothing was found.

[string ToString()](VRage.Game.ModAPI.Ingame.Utilities.StringSegment.ToString)

> Returns a string containing just this segment.

