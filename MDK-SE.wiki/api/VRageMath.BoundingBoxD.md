← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBoxD Struct

```csharp
public struct BoundingBoxD: IEquatable<BoundingBoxD>
```

Defines an axis-aligned box-shaped 3D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBoxD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static ComparerType Comparer](VRageMath.BoundingBoxD.Comparer)

> 

[Vector3D Max](VRageMath.BoundingBoxD.Max)

> The maximum point the BoundingBox contains.

[Vector3D Min](VRageMath.BoundingBoxD.Min)

> The minimum point the BoundingBox contains.

#### Properties

[Vector3D Center { get; }](VRageMath.BoundingBoxD.Center)

> Calculates center

[Vector3D Extents { get; }](VRageMath.BoundingBoxD.Extents)

> 

[Vector3D HalfExtents { get; }](VRageMath.BoundingBoxD.HalfExtents)

> 

[MatrixD Matrix { get; }](VRageMath.BoundingBoxD.Matrix)

> Matrix of AABB, respecting center and size

[double Perimeter { get; }](VRageMath.BoundingBoxD.Perimeter)

> return perimeter of edges

[Vector3D Size { get; }](VRageMath.BoundingBoxD.Size)

> Size

[double SurfaceArea { get; }](VRageMath.BoundingBoxD.SurfaceArea)

> 

[bool Valid { get; }](VRageMath.BoundingBoxD.Valid)

> 

[double Volume { get; }](VRageMath.BoundingBoxD.Volume)

> 

#### Constructors

[BoundingBoxD(Vector3D min, Vector3D max)](VRageMath.BoundingBoxD..ctor)

> 

#### 方法

[static BoundingBoxD CreateFromPoints(IEnumerable&lt;Vector3D&gt; points)](VRageMath.BoundingBoxD.CreateFromPoints)

> Creates the smallest BoundingBox that will contain a group of points.

[static BoundingBoxD CreateFromSphere(BoundingSphereD sphere)](VRageMath.BoundingBoxD.CreateFromSphere)

> Creates the smallest BoundingBox that will contain the specified BoundingSphere.

[static void CreateFromSphere(ref BoundingSphereD sphere, out BoundingBoxD result)](VRageMath.BoundingBoxD.CreateFromSphere)

> Creates the smallest BoundingBox that will contain the specified BoundingSphere.

[static BoundingBoxD CreateInvalid()](VRageMath.BoundingBoxD.CreateInvalid)

> 

[static BoundingBoxD CreateMerged(BoundingBoxD original, BoundingBoxD additional)](VRageMath.BoundingBoxD.CreateMerged)

> Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

[static void CreateMerged(ref BoundingBoxD original, ref BoundingBoxD additional, out BoundingBoxD result)](VRageMath.BoundingBoxD.CreateMerged)

> Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

[void AssertIsValid()](VRageMath.BoundingBoxD.AssertIsValid)

> 

[void Centerize(Vector3D center)](VRageMath.BoundingBoxD.Centerize)

> 

[ContainmentType Contains(BoundingBoxD box)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains another BoundingBox.

[void Contains(ref BoundingBoxD box, out ContainmentType result)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a BoundingBox.

[ContainmentType Contains(BoundingFrustumD frustum)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a BoundingFrustum.

[ContainmentType Contains(Vector3D point)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a point.

[void Contains(ref Vector3D point, out ContainmentType result)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a point.

[ContainmentType Contains(BoundingSphereD sphere)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a BoundingSphere.

[void Contains(ref BoundingSphereD sphere, out ContainmentType result)](VRageMath.BoundingBoxD.Contains)

> Tests whether the BoundingBox contains a BoundingSphere.

[double Distance(Vector3D point)](VRageMath.BoundingBoxD.Distance)

> 

[double Distance(ref BoundingBoxD other)](VRageMath.BoundingBoxD.Distance)

> 

[double DistanceSquared(Vector3D point)](VRageMath.BoundingBoxD.DistanceSquared)

> 

[double DistanceSquared(ref Vector3D point)](VRageMath.BoundingBoxD.DistanceSquared)

> 

[double DistanceSquared(ref BoundingBoxD other)](VRageMath.BoundingBoxD.DistanceSquared)

> 

[bool Equals(BoundingBoxD other)](VRageMath.BoundingBoxD.Equals)

> Determines whether two instances of BoundingBox are equal.

[bool Equals(object obj)](VRageMath.BoundingBoxD.Equals)

> Determines whether two instances of BoundingBox are equal.

[bool Equals(BoundingBoxD other, double epsilon)](VRageMath.BoundingBoxD.Equals)

> 

[Vector3D&#91&#93; GetCorners()](VRageMath.BoundingBoxD.GetCorners)

> Gets an array of points that make up the corners of the BoundingBox. ALLOCATION!

[void GetCorners(Vector3D&#91&#93; corners)](VRageMath.BoundingBoxD.GetCorners)

> Gets the array of points that make up the corners of the BoundingBox.

[void GetCornersUnsafe(*Vector3D corners)](VRageMath.BoundingBoxD.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBoxD.GetHashCode)

> Gets the hash code for this instance.

[BoundingBoxD GetInflated(double size)](VRageMath.BoundingBoxD.GetInflated)

> 

[BoundingBoxD GetInflated(Vector3 size)](VRageMath.BoundingBoxD.GetInflated)

> 

[BoundingBoxD GetInflated(Vector3D size)](VRageMath.BoundingBoxD.GetInflated)

> 

[BoundingBoxD Include(ref Vector3D point)](VRageMath.BoundingBoxD.Include)

> return expanded aabb (aabb include point)

[BoundingBoxD Include(Vector3D point)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(Vector3D p0, Vector3D p1, Vector3D p2)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(ref Vector3D p0, ref Vector3D p1, ref Vector3D p2)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(ref BoundingBoxD box)](VRageMath.BoundingBoxD.Include)

> return expanded aabb (aabb include aabb)

[BoundingBoxD Include(BoundingBoxD box)](VRageMath.BoundingBoxD.Include)

> 

[void Include(ref LineD line)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(BoundingSphereD sphere)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(ref BoundingSphereD sphere)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Include(ref BoundingFrustumD frustum)](VRageMath.BoundingBoxD.Include)

> 

[BoundingBoxD Inflate(double size)](VRageMath.BoundingBoxD.Inflate)

> 

[BoundingBoxD Inflate(Vector3D size)](VRageMath.BoundingBoxD.Inflate)

> 

[void InflateToMinimum(Vector3D minimumSize)](VRageMath.BoundingBoxD.InflateToMinimum)

> 

[void InflateToMinimum(double minimumSize)](VRageMath.BoundingBoxD.InflateToMinimum)

> 

[BoundingBoxD Intersect(BoundingBoxD box)](VRageMath.BoundingBoxD.Intersect)

> Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

[bool Intersect(ref LineD line, out LineD intersectedLine)](VRageMath.BoundingBoxD.Intersect)

> 

[bool Intersect(ref LineD line, out double t1, out double t2)](VRageMath.BoundingBoxD.Intersect)

> 

[bool Intersect(ref RayD ray, out double tmin, out double tmax)](VRageMath.BoundingBoxD.Intersect)

> 

[bool Intersects(BoundingBoxD box)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects another BoundingBox.

[bool Intersects(ref BoundingBoxD box)](VRageMath.BoundingBoxD.Intersects)

> 

[void Intersects(ref BoundingBoxD box, out bool result)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects another BoundingBox.

[void Intersects(ref BoundingBox box, out bool result)](VRageMath.BoundingBoxD.Intersects)

> 

[bool Intersects(BoundingFrustumD frustum)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a BoundingFrustum.

[PlaneIntersectionType Intersects(PlaneD plane)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a Plane.

[void Intersects(ref PlaneD plane, out PlaneIntersectionType result)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a Plane.

[bool Intersects(ref LineD line)](VRageMath.BoundingBoxD.Intersects)

> 

[bool Intersects(ref LineD line, out double distance)](VRageMath.BoundingBoxD.Intersects)

> 

[double? Intersects(Ray ray)](VRageMath.BoundingBoxD.Intersects)

> 

[double? Intersects(RayD ray)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a Ray.

[void Intersects(ref RayD ray, out double? result)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a Ray.

[bool Intersects(BoundingSphereD sphere)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a BoundingSphere.

[void Intersects(ref BoundingSphereD sphere, out bool result)](VRageMath.BoundingBoxD.Intersects)

> Checks whether the current BoundingBox intersects a BoundingSphere.

[bool Intersects(ref BoundingSphereD sphere)](VRageMath.BoundingBoxD.Intersects)

> 

[bool IntersectsTriangle(Vector3D v0, Vector3D v1, Vector3D v2)](VRageMath.BoundingBoxD.IntersectsTriangle)

> 

[bool IntersectsTriangle(ref Vector3D v0, ref Vector3D v1, ref Vector3D v2)](VRageMath.BoundingBoxD.IntersectsTriangle)

> 

[double ProjectedArea(Vector3D viewDir)](VRageMath.BoundingBoxD.ProjectedArea)

> 

[BoundingBoxD Round(int decimals)](VRageMath.BoundingBoxD.Round)

> 

[BoundingBoxI Round()](VRageMath.BoundingBoxD.Round)

> 

[string ToString()](VRageMath.BoundingBoxD.ToString)

> Returns a String that represents the current BoundingBox.

[BoundingBoxD TransformFast(MatrixD m)](VRageMath.BoundingBoxD.TransformFast)

> Transform this AABB by matrix. Matrix has to be only rotation and translation.

[BoundingBoxD TransformFast(ref MatrixD m)](VRageMath.BoundingBoxD.TransformFast)

> Transform this AABB by matrix. Matrix has to be only rotation and translation.

[void TransformFast(ref MatrixD m, ref BoundingBoxD bb)](VRageMath.BoundingBoxD.TransformFast)

> Transform this AABB by matrix. Matrix has to be only rotation and translation.

[BoundingBoxD TransformSlow(MatrixD m)](VRageMath.BoundingBoxD.TransformSlow)

> Transform this AABB by matrix.

[BoundingBoxD TransformSlow(ref MatrixD worldMatrix)](VRageMath.BoundingBoxD.TransformSlow)

> Transform this AABB by matrix.

[BoundingBoxD Translate(MatrixD worldMatrix)](VRageMath.BoundingBoxD.Translate)

> Translate

[BoundingBoxD Translate(Vector3D vctTranlsation)](VRageMath.BoundingBoxD.Translate)

> Translate

