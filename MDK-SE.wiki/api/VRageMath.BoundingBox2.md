← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBox2 Struct

```csharp
public struct BoundingBox2: IEquatable<BoundingBox2>
```

Defines an axis-aligned box-shaped 3D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBox2&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector2 Max](VRageMath.BoundingBox2.Max)

> The maximum point the BoundingBox2 contains.

[Vector2 Min](VRageMath.BoundingBox2.Min)

> The minimum point the BoundingBox2 contains.

#### Properties

[Vector2 Center { get; }](VRageMath.BoundingBox2.Center)

> Calculates center

[Vector2 Extents { get; }](VRageMath.BoundingBox2.Extents)

> 

[Vector2 HalfExtents { get; }](VRageMath.BoundingBox2.HalfExtents)

> 

[float Height { get; }](VRageMath.BoundingBox2.Height)

> 

[Vector2 Size { get; }](VRageMath.BoundingBox2.Size)

> Size

[float Width { get; }](VRageMath.BoundingBox2.Width)

> 

#### Constructors

[BoundingBox2(Vector2 min, Vector2 max)](VRageMath.BoundingBox2..ctor)

> 

#### 方法

[static BoundingBox2 CreateFromHalfExtent(Vector2 center, float halfExtent)](VRageMath.BoundingBox2.CreateFromHalfExtent)

> 

[static BoundingBox2 CreateFromHalfExtent(Vector2 center, Vector2 halfExtent)](VRageMath.BoundingBox2.CreateFromHalfExtent)

> 

[static BoundingBox2 CreateFromPoints(IEnumerable&lt;Vector2&gt; points)](VRageMath.BoundingBox2.CreateFromPoints)

> Creates the smallest BoundingBox2 that will contain a group of points.

[static BoundingBox2 CreateInvalid()](VRageMath.BoundingBox2.CreateInvalid)

> 

[static BoundingBox2 CreateMerged(BoundingBox2 original, BoundingBox2 additional)](VRageMath.BoundingBox2.CreateMerged)

> Creates the smallest BoundingBox2 that contains the two specified BoundingBox2 instances.

[static void CreateMerged(ref BoundingBox2 original, ref BoundingBox2 additional, out BoundingBox2 result)](VRageMath.BoundingBox2.CreateMerged)

> Creates the smallest BoundingBox2 that contains the two specified BoundingBox2 instances.

[float Area()](VRageMath.BoundingBox2.Area)

> 

[ContainmentType Contains(BoundingBox2 box)](VRageMath.BoundingBox2.Contains)

> Tests whether the BoundingBox2 contains another BoundingBox2.

[void Contains(ref BoundingBox2 box, out ContainmentType result)](VRageMath.BoundingBox2.Contains)

> Tests whether the BoundingBox2 contains a BoundingBox2.

[ContainmentType Contains(Vector2 point)](VRageMath.BoundingBox2.Contains)

> Tests whether the BoundingBox2 contains a point.

[void Contains(ref Vector2 point, out ContainmentType result)](VRageMath.BoundingBox2.Contains)

> Tests whether the BoundingBox2 contains a point.

[float Distance(Vector2 point)](VRageMath.BoundingBox2.Distance)

> 

[bool Equals(BoundingBox2 other)](VRageMath.BoundingBox2.Equals)

> Determines whether two instances of BoundingBox2 are equal.

[bool Equals(object obj)](VRageMath.BoundingBox2.Equals)

> Determines whether two instances of BoundingBox2 are equal.

[Vector2&#91&#93; GetCorners()](VRageMath.BoundingBox2.GetCorners)

> Gets an array of points that make up the corners of the BoundingBox2.

[void GetCorners(Vector2&#91&#93; corners)](VRageMath.BoundingBox2.GetCorners)

> Gets the array of points that make up the corners of the BoundingBox2.

[void GetCornersUnsafe(*Vector2 corners)](VRageMath.BoundingBox2.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBox2.GetHashCode)

> Gets the hash code for this instance.

[BoundingBox2 GetIncluded(Vector2 point)](VRageMath.BoundingBox2.GetIncluded)

> 

[BoundingBox2 Include(ref Vector2 point)](VRageMath.BoundingBox2.Include)

> return expanded aabb (abb include point)

[BoundingBox2 Include(Vector2 point)](VRageMath.BoundingBox2.Include)

> 

[BoundingBox2 Include(Vector2 p0, Vector2 p1, Vector2 p2)](VRageMath.BoundingBox2.Include)

> 

[BoundingBox2 Include(ref Vector2 p0, ref Vector2 p1, ref Vector2 p2)](VRageMath.BoundingBox2.Include)

> 

[BoundingBox2 Include(ref BoundingBox2 box)](VRageMath.BoundingBox2.Include)

> return expanded aabb (abb include point)

[BoundingBox2 Include(BoundingBox2 box)](VRageMath.BoundingBox2.Include)

> 

[void Inflate(float size)](VRageMath.BoundingBox2.Inflate)

> 

[void InflateToMinimum(Vector2 minimumSize)](VRageMath.BoundingBox2.InflateToMinimum)

> 

[BoundingBox2 Intersect(BoundingBox2 box)](VRageMath.BoundingBox2.Intersect)

> Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

[bool Intersects(BoundingBox2 box)](VRageMath.BoundingBox2.Intersects)

> Checks whether the current BoundingBox2 intersects another BoundingBox2.

[bool Intersects(ref BoundingBox2 box)](VRageMath.BoundingBox2.Intersects)

> 

[void Intersects(ref BoundingBox2 box, out bool result)](VRageMath.BoundingBox2.Intersects)

> Checks whether the current BoundingBox2 intersects another BoundingBox2.

[float Perimeter()](VRageMath.BoundingBox2.Perimeter)

> 

[void Scale(Vector2 scale)](VRageMath.BoundingBox2.Scale)

> 

[string ToString()](VRageMath.BoundingBox2.ToString)

> Returns a String that represents the current BoundingBox2.

[BoundingBox2 Translate(Vector2 vctTranlsation)](VRageMath.BoundingBox2.Translate)

> Translate

