← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector3I Struct

```csharp
public struct Vector3I: IEquatable<Vector3I>, IComparable<Vector3I>
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IComparable&lt;Vector3I&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable&lt;Vector3I&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector3I Backward](VRageMath.Vector3I.Backward)

> 

[static EqualityComparer Comparer](VRageMath.Vector3I.Comparer)

> 

[static Vector3I Down](VRageMath.Vector3I.Down)

> 

[static Vector3I Forward](VRageMath.Vector3I.Forward)

> 

[static Vector3I Left](VRageMath.Vector3I.Left)

> 

[static Vector3I MaxValue](VRageMath.Vector3I.MaxValue)

> 

[static Vector3I MinValue](VRageMath.Vector3I.MinValue)

> 

[static Vector3I One](VRageMath.Vector3I.One)

> 

[static Vector3I Right](VRageMath.Vector3I.Right)

> 

[static Vector3I UnitX](VRageMath.Vector3I.UnitX)

> 

[static Vector3I UnitY](VRageMath.Vector3I.UnitY)

> 

[static Vector3I UnitZ](VRageMath.Vector3I.UnitZ)

> 

[static Vector3I Up](VRageMath.Vector3I.Up)

> 

[static Vector3I Zero](VRageMath.Vector3I.Zero)

> 

[int X](VRageMath.Vector3I.X)

> 

[int Y](VRageMath.Vector3I.Y)

> 

[int Z](VRageMath.Vector3I.Z)

> 

#### Properties

[bool IsPowerOfTwo { get; }](VRageMath.Vector3I.IsPowerOfTwo)

> 

[int Item { get; set; }](VRageMath.Vector3I.Item)

> 

[int Size { get; }](VRageMath.Vector3I.Size)

> How many cubes are in block with this size

[long SizeLong { get; }](VRageMath.Vector3I.SizeLong)

> 

#### Constructors

[Vector3I(int xyz)](VRageMath.Vector3I..ctor)

> 

[Vector3I(int x, int y, int z)](VRageMath.Vector3I..ctor)

> 

[Vector3I(Vector2I xy, int z)](VRageMath.Vector3I..ctor)

> 

[Vector3I(Vector3 xyz)](VRageMath.Vector3I..ctor)

> 

[Vector3I(Vector3D xyz)](VRageMath.Vector3I..ctor)

> 

[Vector3I(Vector3S xyz)](VRageMath.Vector3I..ctor)

> 

[Vector3I(float x, float y, float z)](VRageMath.Vector3I..ctor)

> 

[Vector3I(Byte&#91&#93; bytes, int index)](VRageMath.Vector3I..ctor)

> 

#### 方法

[static Vector3I Abs(Vector3I value)](VRageMath.Vector3I.Abs)

> 

[static void Abs(ref Vector3I value, out Vector3I result)](VRageMath.Vector3I.Abs)

> 

[static bool BoxContains(Vector3I boxMin, Vector3I boxMax, Vector3I pt)](VRageMath.Vector3I.BoxContains)

> 

[static bool BoxContains(ref Vector3I boxMin, ref Vector3I boxMax, ref Vector3I pt)](VRageMath.Vector3I.BoxContains)

> 

[static bool BoxIntersects(Vector3I minA, Vector3I maxA, Vector3I minB, Vector3I maxB)](VRageMath.Vector3I.BoxIntersects)

> 

[static bool BoxIntersects(ref Vector3I minA, ref Vector3I maxA, ref Vector3I minB, ref Vector3I maxB)](VRageMath.Vector3I.BoxIntersects)

> 

[static Vector3I Ceiling(Vector3 value)](VRageMath.Vector3I.Ceiling)

> 

[static Vector3I Ceiling(Vector3D value)](VRageMath.Vector3I.Ceiling)

> 

[static Vector3I Clamp(Vector3I value1, Vector3I min, Vector3I max)](VRageMath.Vector3I.Clamp)

> 

[static void Clamp(ref Vector3I value1, ref Vector3I min, ref Vector3I max, out Vector3I result)](VRageMath.Vector3I.Clamp)

> 

[static void Cross(ref Vector3I vector1, ref Vector3I vector2, out Vector3I result)](VRageMath.Vector3I.Cross)

> Calculates the cross product of two vectors.

[static int DistanceManhattan(Vector3I first, Vector3I second)](VRageMath.Vector3I.DistanceManhattan)

> Manhattan distance (cube distance) X + Y + Z of Abs(first - second)

[static Vector3I DominantAxisProjection(Vector3I value1)](VRageMath.Vector3I.DominantAxisProjection)

> Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

[static void DominantAxisProjection(ref Vector3I value1, out Vector3I result)](VRageMath.Vector3I.DominantAxisProjection)

> Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved into a user-specified variable.

[static int Dot(Vector3I vector1, Vector3I vector2)](VRageMath.Vector3I.Dot)

> 

[static int Dot(ref Vector3I vector1, ref Vector3I vector2)](VRageMath.Vector3I.Dot)

> 

[static void Dot(ref Vector3I vector1, ref Vector3I vector2, out int dot)](VRageMath.Vector3I.Dot)

> 

[static IEnumerable&lt;Vector3I&gt; EnumerateRange(Vector3I minInclusive, Vector3I maxExclusive)](VRageMath.Vector3I.EnumerateRange)

> Enumerate all values in a integer interval (a cuboid). This method is an allocating version of the Vector3I_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

[static Vector3I Floor(Vector3 value)](VRageMath.Vector3I.Floor)

> 

[static Vector3I Floor(Vector3D value)](VRageMath.Vector3I.Floor)

> 

[static void Floor(ref Vector3 v, out Vector3I r)](VRageMath.Vector3I.Floor)

> 

[static void Floor(ref Vector3D v, out Vector3I r)](VRageMath.Vector3I.Floor)

> 

[static CubeFace GetDominantDirection(Vector3I val)](VRageMath.Vector3I.GetDominantDirection)

> 

[static Vector3I GetDominantDirectionVector(Vector3I val)](VRageMath.Vector3I.GetDominantDirectionVector)

> 

[static Vector3I Max(Vector3I value1, Vector3I value2)](VRageMath.Vector3I.Max)

> 

[static void Max(ref Vector3I value1, ref Vector3I value2, out Vector3I result)](VRageMath.Vector3I.Max)

> 

[static Vector3I Min(Vector3I value1, Vector3I value2)](VRageMath.Vector3I.Min)

> 

[static void Min(ref Vector3I value1, ref Vector3I value2, out Vector3I result)](VRageMath.Vector3I.Min)

> 

[static void MinMax(ref Vector3I min, ref Vector3I max)](VRageMath.Vector3I.MinMax)

> Separates minimal and maximal values of any two input vectors

[static Vector3I Round(Vector3 value)](VRageMath.Vector3I.Round)

> 

[static Vector3I Round(Vector3D value)](VRageMath.Vector3I.Round)

> 

[static void Round(ref Vector3 v, out Vector3I r)](VRageMath.Vector3I.Round)

> 

[static void Round(ref Vector3D v, out Vector3I r)](VRageMath.Vector3I.Round)

> 

[static Vector3I Shift(Vector3I value)](VRageMath.Vector3I.Shift)

> 

[static Vector3I Sign(Vector3 value)](VRageMath.Vector3I.Sign)

> 

[static Vector3I Sign(Vector3I value)](VRageMath.Vector3I.Sign)

> 

[static void Transform(ref Vector3I position, ref Matrix matrix, out Vector3I result)](VRageMath.Vector3I.Transform)

> Transforms a Vector3I by the given Matrix.

[static void Transform(ref Vector3I value, ref Quaternion rotation, out Vector3I result)](VRageMath.Vector3I.Transform)

> 

[static Vector3I Transform(Vector3I value, Quaternion rotation)](VRageMath.Vector3I.Transform)

> 

[static void Transform(ref Vector3I value, ref MatrixI matrix, out Vector3I result)](VRageMath.Vector3I.Transform)

> 

[static Vector3I Transform(Vector3I value, MatrixI transformation)](VRageMath.Vector3I.Transform)

> 

[static Vector3I Transform(Vector3I value, ref MatrixI transformation)](VRageMath.Vector3I.Transform)

> 

[static Vector3I TransformNormal(Vector3I value, ref MatrixI transformation)](VRageMath.Vector3I.TransformNormal)

> 

[static void TransformNormal(ref Vector3I normal, ref Matrix matrix, out Vector3I result)](VRageMath.Vector3I.TransformNormal)

> Transforms a vector normal by a matrix.

[static void TransformNormal(ref Vector3I normal, ref MatrixI matrix, out Vector3I result)](VRageMath.Vector3I.TransformNormal)

> 

[static Vector3I Trunc(Vector3 value)](VRageMath.Vector3I.Trunc)

> 

[static bool TryParseFromString(string p, out Vector3I vec)](VRageMath.Vector3I.TryParseFromString)

> 

[int AbsMax()](VRageMath.Vector3I.AbsMax)

> Returns the component of the vector, whose absolute value is largest of all the three components.

[int AbsMin()](VRageMath.Vector3I.AbsMin)

> Returns the component of the vector, whose absolute value is smallest of all the three components.

[int AxisValue(Axis axis)](VRageMath.Vector3I.AxisValue)

> 

[int CompareTo(Vector3I other)](VRageMath.Vector3I.CompareTo)

> 

[int Dot(ref Vector3I v)](VRageMath.Vector3I.Dot)

> 

[bool Equals(Vector3I other)](VRageMath.Vector3I.Equals)

> 

[bool Equals(object obj)](VRageMath.Vector3I.Equals)

> 

[int GetHashCode()](VRageMath.Vector3I.GetHashCode)

> 

[bool IsAxisAligned()](VRageMath.Vector3I.IsAxisAligned)

> 

[bool IsInside(ref Vector3I inclusiveMin, ref Vector3I exclusiveMax)](VRageMath.Vector3I.IsInside)

> 

[bool IsInside(Vector3I inclusiveMin, Vector3I exclusiveMax)](VRageMath.Vector3I.IsInside)

> 

[bool IsInsideInclusiveEnd(ref Vector3I min, ref Vector3I max)](VRageMath.Vector3I.IsInsideInclusiveEnd)

> 

[bool IsInsideInclusiveEnd(Vector3I min, Vector3I max)](VRageMath.Vector3I.IsInsideInclusiveEnd)

> 

[int Length()](VRageMath.Vector3I.Length)

> 

[int RectangularDistance(Vector3I otherVector)](VRageMath.Vector3I.RectangularDistance)

> Calculates rectangular distance. It's how many sectors you have to travel to get to other sector from current sector.

[int RectangularLength()](VRageMath.Vector3I.RectangularLength)

> Calculates rectangular distance of this vector, interpreted as a point, from the origin.

[void ToBytes(List&lt;byte&gt; result)](VRageMath.Vector3I.ToBytes)

> 

[string ToString()](VRageMath.Vector3I.ToString)

> 

[int Volume()](VRageMath.Vector3I.Volume)

> 

