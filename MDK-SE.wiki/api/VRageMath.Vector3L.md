← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector3L Struct

```csharp
public struct Vector3L: IEquatable<Vector3L>, IComparable<Vector3L>
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IComparable&lt;Vector3L&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable&lt;Vector3L&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector3L Backward](VRageMath.Vector3L.Backward)

> 

[static EqualityComparer Comparer](VRageMath.Vector3L.Comparer)

> 

[static Vector3L Down](VRageMath.Vector3L.Down)

> 

[static Vector3L Forward](VRageMath.Vector3L.Forward)

> 

[static Vector3L Left](VRageMath.Vector3L.Left)

> 

[static Vector3L MaxValue](VRageMath.Vector3L.MaxValue)

> 

[static Vector3L MinValue](VRageMath.Vector3L.MinValue)

> 

[static Vector3L One](VRageMath.Vector3L.One)

> 

[static Vector3L Right](VRageMath.Vector3L.Right)

> 

[static Vector3L UnitX](VRageMath.Vector3L.UnitX)

> 

[static Vector3L UnitY](VRageMath.Vector3L.UnitY)

> 

[static Vector3L UnitZ](VRageMath.Vector3L.UnitZ)

> 

[static Vector3L Up](VRageMath.Vector3L.Up)

> 

[static Vector3L Zero](VRageMath.Vector3L.Zero)

> 

[long X](VRageMath.Vector3L.X)

> 

[long Y](VRageMath.Vector3L.Y)

> 

[long Z](VRageMath.Vector3L.Z)

> 

#### Properties

[long Item { get; set; }](VRageMath.Vector3L.Item)

> 

[long Size { get; }](VRageMath.Vector3L.Size)

> How many cubes are in block with this size

[long SizeLong { get; }](VRageMath.Vector3L.SizeLong)

> 

#### Constructors

[Vector3L(long xyz)](VRageMath.Vector3L..ctor)

> 

[Vector3L(long x, long y, long z)](VRageMath.Vector3L..ctor)

> 

[Vector3L(Vector3 xyz)](VRageMath.Vector3L..ctor)

> 

[Vector3L(Vector3D xyz)](VRageMath.Vector3L..ctor)

> 

[Vector3L(Vector3S xyz)](VRageMath.Vector3L..ctor)

> 

[Vector3L(float x, float y, float z)](VRageMath.Vector3L..ctor)

> 

#### 方法

[static Vector3L Abs(Vector3L value)](VRageMath.Vector3L.Abs)

> 

[static void Abs(ref Vector3L value, out Vector3L result)](VRageMath.Vector3L.Abs)

> 

[static bool BoxContains(Vector3L boxMin, Vector3L boxMax, Vector3L pt)](VRageMath.Vector3L.BoxContains)

> 

[static bool BoxContains(ref Vector3L boxMin, ref Vector3L boxMax, ref Vector3L pt)](VRageMath.Vector3L.BoxContains)

> 

[static bool Boxlongersects(Vector3L minA, Vector3L maxA, Vector3L minB, Vector3L maxB)](VRageMath.Vector3L.Boxlongersects)

> 

[static bool Boxlongersects(ref Vector3L minA, ref Vector3L maxA, ref Vector3L minB, ref Vector3L maxB)](VRageMath.Vector3L.Boxlongersects)

> 

[static Vector3L Ceiling(Vector3 value)](VRageMath.Vector3L.Ceiling)

> 

[static Vector3L Clamp(Vector3L value1, Vector3L min, Vector3L max)](VRageMath.Vector3L.Clamp)

> 

[static void Clamp(ref Vector3L value1, ref Vector3L min, ref Vector3L max, out Vector3L result)](VRageMath.Vector3L.Clamp)

> 

[static void Cross(ref Vector3L vector1, ref Vector3L vector2, out Vector3L result)](VRageMath.Vector3L.Cross)

> Calculates the cross product of two vectors.

[static long DistanceManhattan(Vector3L first, Vector3L second)](VRageMath.Vector3L.DistanceManhattan)

> Manhattan distance (cube distance) X + Y + Z of Abs(first - second)

[static Vector3L DominantAxisProjection(Vector3L value1)](VRageMath.Vector3L.DominantAxisProjection)

> Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

[static void DominantAxisProjection(ref Vector3L value1, out Vector3L result)](VRageMath.Vector3L.DominantAxisProjection)

> Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved longo a user-specified variable.

[static long Dot(Vector3L vector1, Vector3L vector2)](VRageMath.Vector3L.Dot)

> 

[static long Dot(ref Vector3L vector1, ref Vector3L vector2)](VRageMath.Vector3L.Dot)

> 

[static void Dot(ref Vector3L vector1, ref Vector3L vector2, out long dot)](VRageMath.Vector3L.Dot)

> 

[static IEnumerable&lt;Vector3L&gt; EnumerateRange(Vector3L minInclusive, Vector3L maxExclusive)](VRageMath.Vector3L.EnumerateRange)

> Enumerate all values in a longeger longerval (a cuboid). This method is an allocating version of the Vector3L_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

[static Vector3L Floor(Vector3 value)](VRageMath.Vector3L.Floor)

> 

[static Vector3L Floor(Vector3D value)](VRageMath.Vector3L.Floor)

> 

[static void Floor(ref Vector3 v, out Vector3L r)](VRageMath.Vector3L.Floor)

> 

[static void Floor(ref Vector3D v, out Vector3L r)](VRageMath.Vector3L.Floor)

> 

[static CubeFace GetDominantDirection(Vector3L val)](VRageMath.Vector3L.GetDominantDirection)

> 

[static Vector3L GetDominantDirectionVector(Vector3L val)](VRageMath.Vector3L.GetDominantDirectionVector)

> 

[static Vector3L Max(Vector3L value1, Vector3L value2)](VRageMath.Vector3L.Max)

> 

[static void Max(ref Vector3L value1, ref Vector3L value2, out Vector3L result)](VRageMath.Vector3L.Max)

> 

[static Vector3L Min(Vector3L value1, Vector3L value2)](VRageMath.Vector3L.Min)

> 

[static void Min(ref Vector3L value1, ref Vector3L value2, out Vector3L result)](VRageMath.Vector3L.Min)

> 

[static Vector3L Round(Vector3 value)](VRageMath.Vector3L.Round)

> 

[static Vector3L Round(Vector3D value)](VRageMath.Vector3L.Round)

> 

[static void Round(ref Vector3 v, out Vector3L r)](VRageMath.Vector3L.Round)

> 

[static void Round(ref Vector3D v, out Vector3L r)](VRageMath.Vector3L.Round)

> 

[static Vector3L Shift(Vector3L value)](VRageMath.Vector3L.Shift)

> 

[static Vector3L Sign(Vector3 value)](VRageMath.Vector3L.Sign)

> 

[static Vector3L Sign(Vector3L value)](VRageMath.Vector3L.Sign)

> 

[static void Transform(ref Vector3L position, ref Matrix matrix, out Vector3L result)](VRageMath.Vector3L.Transform)

> Transforms a Vector3L by the given Matrix.

[static void Transform(ref Vector3L value, ref Quaternion rotation, out Vector3L result)](VRageMath.Vector3L.Transform)

> 

[static Vector3L Transform(Vector3L value, Quaternion rotation)](VRageMath.Vector3L.Transform)

> 

[static void TransformNormal(ref Vector3L normal, ref Matrix matrix, out Vector3L result)](VRageMath.Vector3L.TransformNormal)

> Transforms a vector normal by a matrix.

[static Vector3L Trunc(Vector3 value)](VRageMath.Vector3L.Trunc)

> 

[static bool TryParseFromString(string p, out Vector3L vec)](VRageMath.Vector3L.TryParseFromString)

> 

[long AbsMax()](VRageMath.Vector3L.AbsMax)

> Returns the component of the vector, whose absolute value is largest of all the three components.

[long AbsMin()](VRageMath.Vector3L.AbsMin)

> Returns the component of the vector, whose absolute value is smallest of all the three components.

[long AxisValue(Axis axis)](VRageMath.Vector3L.AxisValue)

> 

[int CompareTo(Vector3L other)](VRageMath.Vector3L.CompareTo)

> 

[long Dot(ref Vector3L v)](VRageMath.Vector3L.Dot)

> 

[bool Equals(Vector3L other)](VRageMath.Vector3L.Equals)

> 

[bool Equals(object obj)](VRageMath.Vector3L.Equals)

> 

[int GetHashCode()](VRageMath.Vector3L.GetHashCode)

> 

[bool IsInside(ref Vector3L inclusiveMin, ref Vector3L exclusiveMax)](VRageMath.Vector3L.IsInside)

> 

[bool IsInside(Vector3L inclusiveMin, Vector3L exclusiveMax)](VRageMath.Vector3L.IsInside)

> 

[bool IsInsideInclusiveEnd(ref Vector3L min, ref Vector3L max)](VRageMath.Vector3L.IsInsideInclusiveEnd)

> 

[bool IsInsideInclusiveEnd(Vector3L min, Vector3L max)](VRageMath.Vector3L.IsInsideInclusiveEnd)

> 

[long Length()](VRageMath.Vector3L.Length)

> 

[long RectangularDistance(Vector3L otherVector)](VRageMath.Vector3L.RectangularDistance)

> Calculates rectangular distance. It's how many sectors you have to travel to get to other sector from current sector.

[long RectangularLength()](VRageMath.Vector3L.RectangularLength)

> Calculates rectangular distance of this vector, longerpreted as a polong, from the origin.

[void ToBytes(List&lt;byte&gt; result)](VRageMath.Vector3L.ToBytes)

> 

[string ToString()](VRageMath.Vector3L.ToString)

> 

[long Volume()](VRageMath.Vector3L.Volume)

> 

