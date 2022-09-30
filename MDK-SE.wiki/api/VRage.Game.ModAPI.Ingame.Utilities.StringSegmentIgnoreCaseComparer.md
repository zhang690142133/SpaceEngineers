← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### StringSegmentIgnoreCaseComparer Class

```csharp
public class StringSegmentIgnoreCaseComparer: IEqualityComparer<StringSegment>
```

A comparer designed to compare [StringSegment](VRage.Game.ModAPI.Ingame.Utilities.StringSegment) instances in a case insensitive manner. Use [DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.DEFAULT) for a default instance

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IEqualityComparer&lt;StringSegment&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)

#### Fields

[static StringSegmentIgnoreCaseComparer DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.DEFAULT)

> A default instance of [StringSegmentIgnoreCaseComparer](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer) 

#### Constructors

[StringSegmentIgnoreCaseComparer()](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer..ctor)

> 

#### 方法

[bool Equals(StringSegment x, StringSegment y)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.Equals)

> Determines whether the specified objects are equal.

[int GetHashCode(StringSegment obj)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.GetHashCode)

> Returns a hash code for the specified object.

