← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBox2I Struct

```csharp
public struct BoundingBox2I: IEquatable<BoundingBox2I>
```

Defines an axis-aligned box-shaped 3D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBox2I&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector2I Max](VRageMath.BoundingBox2I.Max)

> The maximum point the BoundingBox2I contains.

[Vector2I Min](VRageMath.BoundingBox2I.Min)

> The minimum point the BoundingBox2I contains.

#### Properties

[Vector2I Center { get; }](VRageMath.BoundingBox2I.Center)

> Calculates center

[Vector2I Extents { get; }](VRageMath.BoundingBox2I.Extents)

> 

[Vector2I HalfExtents { get; }](VRageMath.BoundingBox2I.HalfExtents)

> 

[float Height { get; }](VRageMath.BoundingBox2I.Height)

> 

[Vector2I Size { get; }](VRageMath.BoundingBox2I.Size)

> Size

[float Width { get; }](VRageMath.BoundingBox2I.Width)

> 

#### Constructors

[BoundingBox2I(Vector2I min, Vector2I max)](VRageMath.BoundingBox2I..ctor)

> 

#### 方法

[static BoundingBox2I CreateFromHalfExtent(Vector2I center, int halfExtent)](VRageMath.BoundingBox2I.CreateFromHalfExtent)

> 

[static BoundingBox2I CreateFromHalfExtent(Vector2I center, Vector2I halfExtent)](VRageMath.BoundingBox2I.CreateFromHalfExtent)

> 

[static BoundingBox2I CreateFromPoints(IEnumerable&lt;Vector2I&gt; points)](VRageMath.BoundingBox2I.CreateFromPoints)

> Creates the smallest BoundingBox2I that will contain a group of points.

[static BoundingBox2I CreateInvalid()](VRageMath.BoundingBox2I.CreateInvalid)

> 

[static BoundingBox2I CreateMerged(BoundingBox2I original, BoundingBox2I additional)](VRageMath.BoundingBox2I.CreateMerged)

> Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

[static void CreateMerged(ref BoundingBox2I original, ref BoundingBox2I additional, out BoundingBox2I result)](VRageMath.BoundingBox2I.CreateMerged)

> Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

[float Area()](VRageMath.BoundingBox2I.Area)

> 

[ContainmentType Contains(BoundingBox2I box)](VRageMath.BoundingBox2I.Contains)

> Tests whether the BoundingBox2I contains another BoundingBox2I.

[void Contains(ref BoundingBox2I box, out ContainmentType result)](VRageMath.BoundingBox2I.Contains)

> Tests whether the BoundingBox2I contains a BoundingBox2I.

[ContainmentType Contains(Vector2I point)](VRageMath.BoundingBox2I.Contains)

> Tests whether the BoundingBox2I contains a point.

[void Contains(ref Vector2I point, out ContainmentType result)](VRageMath.BoundingBox2I.Contains)

> Tests whether the BoundingBox2I contains a point.

[bool Equals(BoundingBox2I other)](VRageMath.BoundingBox2I.Equals)

> Determines whether two instances of BoundingBox2I are equal.

[bool Equals(object obj)](VRageMath.BoundingBox2I.Equals)

> Determines whether two instances of BoundingBox2I are equal.

[Vector2I&#91&#93; GetCorners()](VRageMath.BoundingBox2I.GetCorners)

> Gets an array of points that make up the corners of the BoundingBox2I.

[void GetCorners(Vector2I&#91&#93; corners)](VRageMath.BoundingBox2I.GetCorners)

> Gets the array of points that make up the corners of the BoundingBox2I.

[void GetCornersUnsafe(*Vector2I corners)](VRageMath.BoundingBox2I.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBox2I.GetHashCode)

> Gets the hash code for this instance.

[BoundingBox2I GetIncluded(Vector2I point)](VRageMath.BoundingBox2I.GetIncluded)

> 

[BoundingBox2I Include(ref Vector2I point)](VRageMath.BoundingBox2I.Include)

> return expanded aabb (abb include point)

[BoundingBox2I Include(Vector2I point)](VRageMath.BoundingBox2I.Include)

> 

[BoundingBox2I Include(Vector2I p0, Vector2I p1, Vector2I p2)](VRageMath.BoundingBox2I.Include)

> 

[BoundingBox2I Include(ref Vector2I p0, ref Vector2I p1, ref Vector2I p2)](VRageMath.BoundingBox2I.Include)

> 

[BoundingBox2I Include(ref BoundingBox2I box)](VRageMath.BoundingBox2I.Include)

> return expanded aabb (abb include point)

[BoundingBox2I Include(BoundingBox2I box)](VRageMath.BoundingBox2I.Include)

> 

[void Inflate(int size)](VRageMath.BoundingBox2I.Inflate)

> 

[void InflateToMinimum(Vector2I minimumSize)](VRageMath.BoundingBox2I.InflateToMinimum)

> 

[BoundingBox2I Intersect(BoundingBox2I box)](VRageMath.BoundingBox2I.Intersect)

> Returns bounding box which is intersection of this and box It's called 'Prunik' Result is invalid box when there's no intersection (Min > Max)

[bool Intersects(BoundingBox2I box)](VRageMath.BoundingBox2I.Intersects)

> Checks whether the current BoundingBox2I intersects another BoundingBox2I.

[bool Intersects(ref BoundingBox2I box)](VRageMath.BoundingBox2I.Intersects)

> 

[void Intersects(ref BoundingBox2I box, out bool result)](VRageMath.BoundingBox2I.Intersects)

> Checks whether the current BoundingBox2I intersects another BoundingBox2I.

[float Perimeter()](VRageMath.BoundingBox2I.Perimeter)

> 

[void Scale(Vector2I scale)](VRageMath.BoundingBox2I.Scale)

> 

[string ToString()](VRageMath.BoundingBox2I.ToString)

> Returns a String that represents the current BoundingBox2I.

[BoundingBox2I Translate(Vector2I vctTranlsation)](VRageMath.BoundingBox2I.Translate)

> Translate

