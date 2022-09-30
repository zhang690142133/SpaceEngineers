← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingSphereD Struct

```csharp
public struct BoundingSphereD: IEquatable<BoundingSphereD>
```

Defines a sphere.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingSphereD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector3D Center](VRageMath.BoundingSphereD.Center)

> The center point of the sphere.

[double Radius](VRageMath.BoundingSphereD.Radius)

> The radius of the sphere.

#### Constructors

[BoundingSphereD(Vector3D center, double radius)](VRageMath.BoundingSphereD..ctor)

> 

#### 方法

[static BoundingSphereD CreateFromBoundingBox(BoundingBoxD box)](VRageMath.BoundingSphereD.CreateFromBoundingBox)

> Creates the smallest BoundingSphereD that can contain a specified BoundingBoxD.

[static void CreateFromBoundingBox(ref BoundingBoxD box, out BoundingSphereD result)](VRageMath.BoundingSphereD.CreateFromBoundingBox)

> Creates the smallest BoundingSphereD that can contain a specified BoundingBoxD.

[static BoundingSphereD CreateFromFrustum(BoundingFrustumD frustum)](VRageMath.BoundingSphereD.CreateFromFrustum)

> Creates the smallest BoundingSphereD that can contain a specified BoundingFrustum.

[static BoundingSphereD CreateFromPoints(Vector3D&#91&#93; points)](VRageMath.BoundingSphereD.CreateFromPoints)

> Creates a BoundingSphereD that can contain a specified list of points.

[static BoundingSphereD CreateInvalid()](VRageMath.BoundingSphereD.CreateInvalid)

> 

[static BoundingSphereD CreateMerged(BoundingSphereD original, BoundingSphereD additional)](VRageMath.BoundingSphereD.CreateMerged)

> Creates a BoundingSphereD that contains the two specified BoundingSphereD instances.

[static void CreateMerged(ref BoundingSphereD original, ref BoundingSphereD additional, out BoundingSphereD result)](VRageMath.BoundingSphereD.CreateMerged)

> Creates a BoundingSphereD that contains the two specified BoundingSphereD instances.

[static void Include(ref BoundingSphereD sphere, ref BoundingSphereD otherSphere)](VRageMath.BoundingSphereD.Include)

> 

[ContainmentType Contains(BoundingBoxD box)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified BoundingBoxD.

[void Contains(ref BoundingBoxD box, out ContainmentType result)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified BoundingBoxD.

[ContainmentType Contains(BoundingFrustumD frustum)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified BoundingFrustum.

[ContainmentType Contains(Vector3D point)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified point.

[void Contains(ref Vector3D point, out ContainmentType result)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified point.

[ContainmentType Contains(BoundingSphereD sphere)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified BoundingSphereD.

[void Contains(ref BoundingSphereD sphere, out ContainmentType result)](VRageMath.BoundingSphereD.Contains)

> Checks whether the current BoundingSphereD contains the specified BoundingSphereD.

[bool Equals(BoundingSphereD other)](VRageMath.BoundingSphereD.Equals)

> Determines whether the specified BoundingSphereD is equal to the current BoundingSphereD.

[bool Equals(object obj)](VRageMath.BoundingSphereD.Equals)

> Determines whether the specified Object is equal to the BoundingSphereD.

[BoundingBoxD GetBoundingBox()](VRageMath.BoundingSphereD.GetBoundingBox)

> 

[int GetHashCode()](VRageMath.BoundingSphereD.GetHashCode)

> Gets the hash code for this instance.

[BoundingSphereD Include(BoundingSphereD sphere)](VRageMath.BoundingSphereD.Include)

> 

[bool IntersectRaySphere(RayD ray, out double tmin, out double tmax)](VRageMath.BoundingSphereD.IntersectRaySphere)

> NOTE: This function doesn't calculate the normal because it's easily derived for a sphere (p - center).

[bool Intersects(BoundingBoxD box)](VRageMath.BoundingSphereD.Intersects)

> Checks whether the current BoundingSphereD intersects with a specified BoundingBoxD.

[void Intersects(ref BoundingBoxD box, out bool result)](VRageMath.BoundingSphereD.Intersects)

> Checks whether the current BoundingSphereD intersects a BoundingBoxD.

[double? Intersects(RayD ray)](VRageMath.BoundingSphereD.Intersects)

> 

[bool Intersects(BoundingFrustumD frustum)](VRageMath.BoundingSphereD.Intersects)

> Checks whether the current BoundingSphereD intersects with a specified BoundingFrustum.

[bool Intersects(BoundingSphereD sphere)](VRageMath.BoundingSphereD.Intersects)

> Checks whether the current BoundingSphereD intersects with a specified BoundingSphereD.

[void Intersects(ref BoundingSphereD sphere, out bool result)](VRageMath.BoundingSphereD.Intersects)

> Checks whether the current BoundingSphereD intersects another BoundingSphereD.

[Vector3D RandomToUniformPointInSphere(double ranX, double ranY, double ranZ)](VRageMath.BoundingSphereD.RandomToUniformPointInSphere)

> If ranX, ranY, ranZ are uniformly distributed across ranges <0,1>, Resulting point will be uniformly distributed inside sphere

[Vector3D? RandomToUniformPointInSphereWithInnerCutout(double ranX, double ranY, double ranZ, double cutoutRadius)](VRageMath.BoundingSphereD.RandomToUniformPointInSphereWithInnerCutout)

> Similar to RandomToUniformPointInSphere(...) but excludes points within distance of cutoutRadius from center. (Results are randomly distributed in the shape that remains from sphere that had another sphere cut out from center. )

[Vector3D RandomToUniformPointOnSphere(double ranX, double ranY)](VRageMath.BoundingSphereD.RandomToUniformPointOnSphere)

> 

[string ToString()](VRageMath.BoundingSphereD.ToString)

> Returns a String that represents the current BoundingSphereD.

[BoundingSphereD Transform(MatrixD matrix)](VRageMath.BoundingSphereD.Transform)

> Translates and scales the BoundingSphereD using a given Matrix.

[void Transform(ref MatrixD matrix, out BoundingSphereD result)](VRageMath.BoundingSphereD.Transform)

> Translates and scales the BoundingSphereD using a given Matrix.

