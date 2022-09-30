← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBoxI Struct

```csharp
public struct BoundingBoxI: IEquatable<BoundingBoxI>
```

Defines an axis-aligned box-shaped 3D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBoxI&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector3I Max](VRageMath.BoundingBoxI.Max)

> The maximum point the BoundingBoxI contains.

[Vector3I Min](VRageMath.BoundingBoxI.Min)

> The minimum point the BoundingBoxI contains.

#### Properties

[Vector3I Center { get; }](VRageMath.BoundingBoxI.Center)

> Calculates center

[Vector3I HalfExtents { get; }](VRageMath.BoundingBoxI.HalfExtents)

> 

[bool IsValid { get; }](VRageMath.BoundingBoxI.IsValid)

> 

[float Perimeter { get; }](VRageMath.BoundingBoxI.Perimeter)

> return perimeter of edges

[Vector3I Size { get; }](VRageMath.BoundingBoxI.Size)

> Size

#### Constructors

[BoundingBoxI(BoundingBox box)](VRageMath.BoundingBoxI..ctor)

> 

[BoundingBoxI(Vector3I min, Vector3I max)](VRageMath.BoundingBoxI..ctor)

> 

[BoundingBoxI(int min, int max)](VRageMath.BoundingBoxI..ctor)

> 

#### 方法

[static BoundingBoxI CreateFromPoints(IEnumerable&lt;Vector3I&gt; points)](VRageMath.BoundingBoxI.CreateFromPoints)

> Creates the smallest BoundingBoxI that will contain a group of points.

[static BoundingBoxI CreateFromSphere(BoundingSphere sphere)](VRageMath.BoundingBoxI.CreateFromSphere)

> Creates the smallest BoundingBoxI that will contain the specified BoundingSphere.

[static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBoxI result)](VRageMath.BoundingBoxI.CreateFromSphere)

> Creates the smallest BoundingBoxI that will contain the specified BoundingSphere.

[static BoundingBoxI CreateInvalid()](VRageMath.BoundingBoxI.CreateInvalid)

> 

[static BoundingBoxI CreateMerged(BoundingBoxI original, BoundingBoxI additional)](VRageMath.BoundingBoxI.CreateMerged)

> Creates the smallest BoundingBoxI that contains the two specified BoundingBoxI instances.

[static void CreateMerged(ref BoundingBoxI original, ref BoundingBoxI additional, out BoundingBoxI result)](VRageMath.BoundingBoxI.CreateMerged)

> Creates the smallest BoundingBoxI that contains the two specified BoundingBoxI instances.

[static IEnumerable&lt;Vector3I&gt; EnumeratePoints(BoundingBoxI rangeInclusive)](VRageMath.BoundingBoxI.EnumeratePoints)

> Enumerate all values in a integer interval (a cuboid). This method is an allocating version of the Vector3I_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

[static IEnumerable&lt;Vector3I&gt; IterateDifference(BoundingBoxI left, BoundingBoxI right)](VRageMath.BoundingBoxI.IterateDifference)

> Iterate every cell contained in {left} - {right}, where we interpret {box} as the set of all distinct Vector3I points inside a 'box'. Containment is taken in a typical inclusive start, exclusive end fashion.

[ContainmentType Contains(BoundingBoxI box)](VRageMath.BoundingBoxI.Contains)

> Tests whether the BoundingBoxI contains another BoundingBoxI.

[void Contains(ref BoundingBoxI box, out ContainmentType result)](VRageMath.BoundingBoxI.Contains)

> Tests whether the BoundingBoxI contains a BoundingBoxI.

[ContainmentType Contains(Vector3I point)](VRageMath.BoundingBoxI.Contains)

> Tests whether the BoundingBoxI contains a point.

[ContainmentType Contains(Vector3 point)](VRageMath.BoundingBoxI.Contains)

> 

[void Contains(ref Vector3I point, out ContainmentType result)](VRageMath.BoundingBoxI.Contains)

> Tests whether the BoundingBoxI contains a point.

[float Distance(Vector3I point)](VRageMath.BoundingBoxI.Distance)

> 

[bool Equals(BoundingBoxI other)](VRageMath.BoundingBoxI.Equals)

> Determines whether two instances of BoundingBoxI are equal.

[bool Equals(object obj)](VRageMath.BoundingBoxI.Equals)

> Determines whether two instances of BoundingBoxI are equal.

[Vector3I&#91&#93; GetCorners()](VRageMath.BoundingBoxI.GetCorners)

> Gets an array of points that make up the corners of the BoundingBoxI.

[void GetCorners(Vector3I&#91&#93; corners)](VRageMath.BoundingBoxI.GetCorners)

> Gets the array of points that make up the corners of the BoundingBoxI.

[void GetCornersUnsafe(*Vector3I corners)](VRageMath.BoundingBoxI.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBoxI.GetHashCode)

> Gets the hash code for this instance.

[BoundingBoxI GetIncluded(Vector3I point)](VRageMath.BoundingBoxI.GetIncluded)

> 

[BoundingBoxI Include(ref Vector3I point)](VRageMath.BoundingBoxI.Include)

> return expanded aabb (abb include point)

[BoundingBoxI Include(Vector3I point)](VRageMath.BoundingBoxI.Include)

> 

[BoundingBoxI Include(Vector3I p0, Vector3I p1, Vector3I p2)](VRageMath.BoundingBoxI.Include)

> 

[BoundingBoxI Include(ref Vector3I p0, ref Vector3I p1, ref Vector3I p2)](VRageMath.BoundingBoxI.Include)

> 

[BoundingBoxI Include(ref BoundingBoxI box)](VRageMath.BoundingBoxI.Include)

> return expanded aabb (abb include point)

[BoundingBoxI Include(BoundingBoxI box)](VRageMath.BoundingBoxI.Include)

> 

[void Inflate(int size)](VRageMath.BoundingBoxI.Inflate)

> 

[void InflateToMinimum(Vector3I minimumSize)](VRageMath.BoundingBoxI.InflateToMinimum)

> 

[BoundingBoxI Intersect(BoundingBoxI box)](VRageMath.BoundingBoxI.Intersect)

> Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

[bool Intersects(BoundingBoxI box)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects another BoundingBoxI.

[bool Intersects(ref BoundingBoxI box)](VRageMath.BoundingBoxI.Intersects)

> 

[void Intersects(ref BoundingBoxI box, out bool result)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects another BoundingBoxI.

[PlaneIntersectionType Intersects(Plane plane)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects a Plane.

[void Intersects(ref Plane plane, out PlaneIntersectionType result)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects a Plane.

[bool Intersects(Line line, out float distance)](VRageMath.BoundingBoxI.Intersects)

> 

[float? Intersects(Ray ray)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects a Ray.

[void Intersects(ref Ray ray, out float? result)](VRageMath.BoundingBoxI.Intersects)

> Checks whether the current BoundingBoxI intersects a Ray.

[bool IntersectsTriangle(Vector3I v0, Vector3I v1, Vector3I v2)](VRageMath.BoundingBoxI.IntersectsTriangle)

> 

[bool IntersectsTriangle(ref Vector3I v0, ref Vector3I v1, ref Vector3I v2)](VRageMath.BoundingBoxI.IntersectsTriangle)

> 

[void IntersectWith(ref BoundingBoxI box)](VRageMath.BoundingBoxI.IntersectWith)

> Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

[float SurfaceArea()](VRageMath.BoundingBoxI.SurfaceArea)

> 

[string ToString()](VRageMath.BoundingBoxI.ToString)

> Returns a String that represents the current BoundingBoxI.

[BoundingBoxI Translate(Vector3I vctTranlsation)](VRageMath.BoundingBoxI.Translate)

> Translate

[float Volume()](VRageMath.BoundingBoxI.Volume)

> 

