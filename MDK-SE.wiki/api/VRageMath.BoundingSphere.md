← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingSphere Struct

```csharp
public struct BoundingSphere: IEquatable<BoundingSphere>
```

Defines a sphere.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingSphere&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector3 Center](VRageMath.BoundingSphere.Center)

> The center point of the sphere.

[float Radius](VRageMath.BoundingSphere.Radius)

> The radius of the sphere.

#### Constructors

[BoundingSphere(Vector3 center, float radius)](VRageMath.BoundingSphere..ctor)

> 

#### 方法

[static BoundingSphere CreateFromBoundingBox(BoundingBox box)](VRageMath.BoundingSphere.CreateFromBoundingBox)

> Creates the smallest BoundingSphere that can contain a specified BoundingBox.

[static void CreateFromBoundingBox(ref BoundingBox box, out BoundingSphere result)](VRageMath.BoundingSphere.CreateFromBoundingBox)

> Creates the smallest BoundingSphere that can contain a specified BoundingBox.

[static BoundingSphere CreateFromFrustum(BoundingFrustum frustum)](VRageMath.BoundingSphere.CreateFromFrustum)

> Creates the smallest BoundingSphere that can contain a specified BoundingFrustum.

[static BoundingSphere CreateFromPoints(IEnumerable&lt;Vector3&gt; points)](VRageMath.BoundingSphere.CreateFromPoints)

> Creates a BoundingSphere that can contain a specified list of points.

[static BoundingSphere CreateInvalid()](VRageMath.BoundingSphere.CreateInvalid)

> 

[static BoundingSphere CreateMerged(BoundingSphere original, BoundingSphere additional)](VRageMath.BoundingSphere.CreateMerged)

> Creates a BoundingSphere that contains the two specified BoundingSphere instances.

[static void CreateMerged(ref BoundingSphere original, ref BoundingSphere additional, out BoundingSphere result)](VRageMath.BoundingSphere.CreateMerged)

> Creates a BoundingSphere that contains the two specified BoundingSphere instances.

[static void Include(ref BoundingSphere sphere, ref BoundingSphere otherSphere)](VRageMath.BoundingSphere.Include)

> 

[ContainmentType Contains(BoundingBox box)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified BoundingBox.

[void Contains(ref BoundingBox box, out ContainmentType result)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified BoundingBox.

[ContainmentType Contains(BoundingFrustum frustum)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified BoundingFrustum.

[ContainmentType Contains(Vector3 point)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified point.

[void Contains(ref Vector3 point, out ContainmentType result)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified point.

[ContainmentType Contains(BoundingSphere sphere)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified BoundingSphere.

[void Contains(ref BoundingSphere sphere, out ContainmentType result)](VRageMath.BoundingSphere.Contains)

> Checks whether the current BoundingSphere contains the specified BoundingSphere.

[bool Equals(BoundingSphere other)](VRageMath.BoundingSphere.Equals)

> Determines whether the specified BoundingSphere is equal to the current BoundingSphere.

[bool Equals(object obj)](VRageMath.BoundingSphere.Equals)

> Determines whether the specified Object is equal to the BoundingSphere.

[BoundingBox GetBoundingBox()](VRageMath.BoundingSphere.GetBoundingBox)

> 

[int GetHashCode()](VRageMath.BoundingSphere.GetHashCode)

> Gets the hash code for this instance.

[BoundingSphere Include(BoundingSphere sphere)](VRageMath.BoundingSphere.Include)

> 

[bool IntersectRaySphere(Ray ray, out float tmin, out float tmax)](VRageMath.BoundingSphere.IntersectRaySphere)

> 

[bool Intersects(BoundingBox box)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects with a specified BoundingBox.

[void Intersects(ref BoundingBox box, out bool result)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects a BoundingBox.

[bool Intersects(BoundingFrustum frustum)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects with a specified BoundingFrustum.

[PlaneIntersectionType Intersects(Plane plane)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects with a specified Plane.

[void Intersects(ref Plane plane, out PlaneIntersectionType result)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects a Plane.

[float? Intersects(Ray ray)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects with a specified Ray.

[void Intersects(ref Ray ray, out float? result)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects a Ray.

[bool Intersects(BoundingSphere sphere)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects with a specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out bool result)](VRageMath.BoundingSphere.Intersects)

> Checks whether the current BoundingSphere intersects another BoundingSphere.

[string ToString()](VRageMath.BoundingSphere.ToString)

> Returns a String that represents the current BoundingSphere.

[BoundingSphere Transform(Matrix matrix)](VRageMath.BoundingSphere.Transform)

> Translates and scales the BoundingSphere using a given Matrix.

[void Transform(ref Matrix matrix, out BoundingSphere result)](VRageMath.BoundingSphere.Transform)

> Translates and scales the BoundingSphere using a given Matrix.

[BoundingSphere Translate(ref Vector3 translation)](VRageMath.BoundingSphere.Translate)

> 

