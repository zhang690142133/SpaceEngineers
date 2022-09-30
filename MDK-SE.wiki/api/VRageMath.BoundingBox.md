← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBox Struct

```csharp
public struct BoundingBox: IEquatable<BoundingBox>
```

Defines an axis-aligned box-shaped 3D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBox&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static ComparerType Comparer](VRageMath.BoundingBox.Comparer)

> 

[static int CornerCount](VRageMath.BoundingBox.CornerCount)

> Specifies the total number of corners (8) in the BoundingBox.

[static BoundingBox Invalid](VRageMath.BoundingBox.Invalid)

> 

[Vector3 Max](VRageMath.BoundingBox.Max)

> The maximum point the BoundingBox contains.

[Vector3 Min](VRageMath.BoundingBox.Min)

> The minimum point the BoundingBox contains.

#### Properties

[Vector3 Center { get; }](VRageMath.BoundingBox.Center)

> Calculates center

[BoxCornerEnumerator Corners { get; set; }](VRageMath.BoundingBox.Corners)

> 

[float Depth { get; }](VRageMath.BoundingBox.Depth)

> 

[Vector3 Extents { get; }](VRageMath.BoundingBox.Extents)

> 

[Vector3 HalfExtents { get; }](VRageMath.BoundingBox.HalfExtents)

> 

[float Height { get; }](VRageMath.BoundingBox.Height)

> 

[Matrix Matrix { get; }](VRageMath.BoundingBox.Matrix)

> Matrix of AABB, respecting center and size

[float Perimeter { get; }](VRageMath.BoundingBox.Perimeter)

> return perimeter of edges

[Vector3 Size { get; }](VRageMath.BoundingBox.Size)

> Size

[float Width { get; }](VRageMath.BoundingBox.Width)

> 

#### Constructors

[BoundingBox(Vector3 min, Vector3 max)](VRageMath.BoundingBox..ctor)

> 

[BoundingBox(BoundingBoxD bbd)](VRageMath.BoundingBox..ctor)

> 

[BoundingBox(BoundingBoxI bbd)](VRageMath.BoundingBox..ctor)

> 

#### 方法

[static BoundingBox CreateFromHalfExtent(Vector3 center, float halfExtent)](VRageMath.BoundingBox.CreateFromHalfExtent)

> 

[static BoundingBox CreateFromHalfExtent(Vector3 center, Vector3 halfExtent)](VRageMath.BoundingBox.CreateFromHalfExtent)

> 

[static BoundingBox CreateFromPoints(IEnumerable&lt;Vector3&gt; points)](VRageMath.BoundingBox.CreateFromPoints)

> Creates the smallest BoundingBox that will contain a group of points.

[static BoundingBox CreateFromSphere(BoundingSphere sphere)](VRageMath.BoundingBox.CreateFromSphere)

> Creates the smallest BoundingBox that will contain the specified BoundingSphere.

[static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBox result)](VRageMath.BoundingBox.CreateFromSphere)

> Creates the smallest BoundingBox that will contain the specified BoundingSphere.

[static BoundingBox CreateInvalid()](VRageMath.BoundingBox.CreateInvalid)

> 

[static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)](VRageMath.BoundingBox.CreateMerged)

> Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

[static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result)](VRageMath.BoundingBox.CreateMerged)

> Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

[ContainmentType Contains(BoundingBox box)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains another BoundingBox.

[void Contains(ref BoundingBox box, out ContainmentType result)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a BoundingBox.

[ContainmentType Contains(BoundingFrustum frustum)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a BoundingFrustum.

[ContainmentType Contains(Vector3 point)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a point.

[ContainmentType Contains(Vector3D point)](VRageMath.BoundingBox.Contains)

> 

[void Contains(ref Vector3 point, out ContainmentType result)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a point.

[ContainmentType Contains(BoundingSphere sphere)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a BoundingSphere.

[void Contains(ref BoundingSphere sphere, out ContainmentType result)](VRageMath.BoundingBox.Contains)

> Tests whether the BoundingBox contains a BoundingSphere.

[float Distance(Vector3 point)](VRageMath.BoundingBox.Distance)

> 

[float DistanceSquared(Vector3 point)](VRageMath.BoundingBox.DistanceSquared)

> 

[bool Equals(BoundingBox other)](VRageMath.BoundingBox.Equals)

> Determines whether two instances of BoundingBox are equal.

[bool Equals(object obj)](VRageMath.BoundingBox.Equals)

> Determines whether two instances of BoundingBox are equal.

[bool Equals(BoundingBox other, float epsilon)](VRageMath.BoundingBox.Equals)

> 

[Vector3&#91&#93; GetCorners()](VRageMath.BoundingBox.GetCorners)

> Gets an array of points that make up the corners of the BoundingBox. ALLOCATION!

[void GetCorners(Vector3&#91&#93; corners)](VRageMath.BoundingBox.GetCorners)

> Gets the array of points that make up the corners of the BoundingBox.

[void GetCornersUnsafe(*Vector3 corners)](VRageMath.BoundingBox.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBox.GetHashCode)

> Gets the hash code for this instance.

[BoundingBox GetIncluded(Vector3 point)](VRageMath.BoundingBox.GetIncluded)

> 

[BoundingBox Include(ref Vector3 point)](VRageMath.BoundingBox.Include)

> return expanded aabb (aabb include point)

[BoundingBox Include(Vector3 point)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(Vector3 p0, Vector3 p1, Vector3 p2)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(ref BoundingBox box)](VRageMath.BoundingBox.Include)

> return expanded aabb (aabb include aabb)

[BoundingBox Include(BoundingBox box)](VRageMath.BoundingBox.Include)

> 

[void Include(ref Line line)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(BoundingSphere sphere)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(ref BoundingSphere sphere)](VRageMath.BoundingBox.Include)

> 

[BoundingBox Include(ref BoundingFrustum frustum)](VRageMath.BoundingBox.Include)

> 

[void Inflate(float size)](VRageMath.BoundingBox.Inflate)

> 

[void Inflate(Vector3 size)](VRageMath.BoundingBox.Inflate)

> 

[void InflateToMinimum(Vector3 minimumSize)](VRageMath.BoundingBox.InflateToMinimum)

> 

[BoundingBox Intersect(BoundingBox box)](VRageMath.BoundingBox.Intersect)

> Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

[bool Intersects(BoundingBox box)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects another BoundingBox.

[bool Intersects(ref BoundingBox box)](VRageMath.BoundingBox.Intersects)

> 

[void Intersects(ref BoundingBox box, out bool result)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects another BoundingBox.

[bool Intersects(BoundingFrustum frustum)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a BoundingFrustum.

[PlaneIntersectionType Intersects(Plane plane)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a Plane.

[void Intersects(ref Plane plane, out PlaneIntersectionType result)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a Plane.

[bool Intersects(Line line, out float distance)](VRageMath.BoundingBox.Intersects)

> 

[float? Intersects(Ray ray)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a Ray.

[void Intersects(ref Ray ray, out float? result)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a Ray.

[bool Intersects(BoundingSphere sphere)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out bool result)](VRageMath.BoundingBox.Intersects)

> Checks whether the current BoundingBox intersects a BoundingSphere.

[bool Intersects(ref BoundingSphere sphere)](VRageMath.BoundingBox.Intersects)

> 

[bool Intersects(ref BoundingSphereD sphere)](VRageMath.BoundingBox.Intersects)

> 

[bool IntersectsTriangle(Vector3 v0, Vector3 v1, Vector3 v2)](VRageMath.BoundingBox.IntersectsTriangle)

> 

[bool IntersectsTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2)](VRageMath.BoundingBox.IntersectsTriangle)

> 

[float ProjectedArea(Vector3 viewDir)](VRageMath.BoundingBox.ProjectedArea)

> 

[BoundingBox Round(int decimals)](VRageMath.BoundingBox.Round)

> 

[BoundingBoxI Round()](VRageMath.BoundingBox.Round)

> 

[void Scale(Vector3 scale)](VRageMath.BoundingBox.Scale)

> 

[float SurfaceArea()](VRageMath.BoundingBox.SurfaceArea)

> 

[string ToString()](VRageMath.BoundingBox.ToString)

> Returns a String that represents the current BoundingBox.

[BoundingBox Transform(Matrix worldMatrix)](VRageMath.BoundingBox.Transform)

> 

[BoundingBoxD Transform(MatrixD worldMatrix)](VRageMath.BoundingBox.Transform)

> 

[BoundingBox Transform(ref Matrix m)](VRageMath.BoundingBox.Transform)

> 

[void Transform(ref Matrix m, ref BoundingBox bb)](VRageMath.BoundingBox.Transform)

> 

[BoundingBoxD Transform(ref MatrixD m)](VRageMath.BoundingBox.Transform)

> 

[void Transform(ref MatrixD m, ref BoundingBoxD bb)](VRageMath.BoundingBox.Transform)

> 

[BoundingBox Translate(Matrix worldMatrix)](VRageMath.BoundingBox.Translate)

> Translate

[BoundingBox Translate(Vector3 vctTranlsation)](VRageMath.BoundingBox.Translate)

> Translate

[float Volume()](VRageMath.BoundingBox.Volume)

> 

