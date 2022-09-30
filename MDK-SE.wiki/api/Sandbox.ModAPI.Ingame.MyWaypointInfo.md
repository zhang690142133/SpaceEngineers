← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyWaypointInfo Struct

```csharp
public struct MyWaypointInfo: IEquatable<MyWaypointInfo>
```

Represents a GPS coordinate

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Implements:**  
* [IEquatable&lt;MyWaypointInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static MyWaypointInfo Empty](Sandbox.ModAPI.Ingame.MyWaypointInfo.Empty)

> Returns an empty (undefined) GPS coordinate

[Vector3D Coords](Sandbox.ModAPI.Ingame.MyWaypointInfo.Coords)

> Gets the target coordinate as a [Vector3D](VRageMath.Vector3D) 

[string Name](Sandbox.ModAPI.Ingame.MyWaypointInfo.Name)

> The name of this GPS coordinate

#### Constructors

[MyWaypointInfo(string name, double x, double y, double z)](Sandbox.ModAPI.Ingame.MyWaypointInfo..ctor)

> 

[MyWaypointInfo(string name, Vector3D coords)](Sandbox.ModAPI.Ingame.MyWaypointInfo..ctor)

> 

#### 方法

[static void FindAll(string source, List&lt;MyWaypointInfo&gt; gpsList)](Sandbox.ModAPI.Ingame.MyWaypointInfo.FindAll)

> Searches for all GPS coordinates in the given text.

[static bool TryParse(string text, out MyWaypointInfo gps)](Sandbox.ModAPI.Ingame.MyWaypointInfo.TryParse)

> Attempts to parse a GPS coordinate from the given text. The text cannot contain anything but the GPS coordinate.    
>     
> A GPS coordinate has the format GPS:Name:X:Y:Z:

[bool Equals(MyWaypointInfo other)](Sandbox.ModAPI.Ingame.MyWaypointInfo.Equals)

> Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

[bool Equals(MyWaypointInfo other, double epsilon)](Sandbox.ModAPI.Ingame.MyWaypointInfo.Equals)

> Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

[bool Equals(object obj)](Sandbox.ModAPI.Ingame.MyWaypointInfo.Equals)

> Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

[int GetHashCode()](Sandbox.ModAPI.Ingame.MyWaypointInfo.GetHashCode)

> Gets the hashcode of this coordinate

[bool IsEmpty()](Sandbox.ModAPI.Ingame.MyWaypointInfo.IsEmpty)

> Determines whether this coordinate is empty (undefined)

[string ToString()](Sandbox.ModAPI.Ingame.MyWaypointInfo.ToString)

> Converts this GPS coordinate to its string equivalent

