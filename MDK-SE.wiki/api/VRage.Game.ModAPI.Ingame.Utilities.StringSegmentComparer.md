← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### StringSegmentComparer Class

```csharp
public class StringSegmentComparer: IEqualityComparer<StringSegment>
```

A comparer designed to compare [StringSegment](VRage.Game.ModAPI.Ingame.Utilities.StringSegment) instances in a case sensitive manner. Use [DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.DEFAULT) for a default instance

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IEqualityComparer&lt;StringSegment&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)

#### Fields

[static StringSegmentComparer DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.DEFAULT)

> A default instance of [StringSegmentComparer](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer) 

#### Constructors

[StringSegmentComparer()](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer..ctor)

> 

#### 方法

[bool Equals(StringSegment x, StringSegment y)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.Equals)

> Determines whether the specified objects are equal.

[int GetHashCode(StringSegment obj)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.GetHashCode)

> Returns a hash code for the specified object.

