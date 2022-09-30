← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingFrustum Class

```csharp
public class BoundingFrustum: IEquatable<BoundingFrustum>
```

Defines a frustum and helps determine whether forms intersect with it.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingFrustum&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static int CornerCount](VRageMath.BoundingFrustum.CornerCount)

> Specifies the total number of corners (8) in the BoundingFrustum.

#### Properties

[Plane Bottom { get; }](VRageMath.BoundingFrustum.Bottom)

> Gets the bottom plane of the BoundingFrustum.

[Plane Far { get; }](VRageMath.BoundingFrustum.Far)

> Gets the far plane of the BoundingFrustum.

[Plane Item { get; }](VRageMath.BoundingFrustum.Item)

> 

[Plane Left { get; }](VRageMath.BoundingFrustum.Left)

> Gets the left plane of the BoundingFrustum.

[Matrix Matrix { get; set; }](VRageMath.BoundingFrustum.Matrix)

> Gets or sets the Matrix that describes this bounding frustum.

[Plane Near { get; }](VRageMath.BoundingFrustum.Near)

> Gets the near plane of the BoundingFrustum.

[Plane&#91&#93; Planes { get; }](VRageMath.BoundingFrustum.Planes)

> 

[Plane Right { get; }](VRageMath.BoundingFrustum.Right)

> Gets the right plane of the BoundingFrustum.

[Plane Top { get; }](VRageMath.BoundingFrustum.Top)

> Gets the top plane of the BoundingFrustum.

#### Constructors

[BoundingFrustum()](VRageMath.BoundingFrustum..ctor)

> 

[BoundingFrustum(Matrix value)](VRageMath.BoundingFrustum..ctor)

> 

#### 方法

[ContainmentType Contains(ref BoundingBox box)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified BoundingBox.

[void Contains(ref BoundingBox box, out ContainmentType result)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified BoundingBox.

[ContainmentType Contains(BoundingFrustum frustum)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified BoundingFrustum.

[ContainmentType Contains(Vector3 point)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified point.

[void Contains(ref Vector3 point, out ContainmentType result)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified point.

[ContainmentType Contains(BoundingSphere sphere)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified BoundingSphere.

[void Contains(ref BoundingSphere sphere, out ContainmentType result)](VRageMath.BoundingFrustum.Contains)

> Checks whether the current BoundingFrustum contains the specified BoundingSphere.

[bool Equals(BoundingFrustum other)](VRageMath.BoundingFrustum.Equals)

> Determines whether the specified BoundingFrustum is equal to the current BoundingFrustum.

[bool Equals(object obj)](VRageMath.BoundingFrustum.Equals)

> Determines whether the specified Object is equal to the BoundingFrustum.

[Vector3&#91&#93; GetCorners()](VRageMath.BoundingFrustum.GetCorners)

> Gets an array of points that make up the corners of the BoundingFrustum. ALLOCATION!

[void GetCorners(Vector3&#91&#93; corners)](VRageMath.BoundingFrustum.GetCorners)

> Gets an array of points that make up the corners of the BoundingFrustum.

[void GetCornersUnsafe(*Vector3 corners)](VRageMath.BoundingFrustum.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingFrustum.GetHashCode)

> Gets the hash code for this instance.

[bool Intersects(BoundingBox box)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects the specified BoundingBox.

[void Intersects(ref BoundingBox box, out bool result)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects a BoundingBox.

[bool Intersects(BoundingFrustum frustum)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects the specified BoundingFrustum.

[PlaneIntersectionType Intersects(Plane plane)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects the specified Plane.

[void Intersects(ref Plane plane, out PlaneIntersectionType result)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects a Plane.

[float? Intersects(Ray ray)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects the specified Ray.

[void Intersects(ref Ray ray, out float? result)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects a Ray.

[bool Intersects(BoundingSphere sphere)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects the specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out bool result)](VRageMath.BoundingFrustum.Intersects)

> Checks whether the current BoundingFrustum intersects a BoundingSphere.

[string ToString()](VRageMath.BoundingFrustum.ToString)

> Returns a String that represents the current BoundingFrustum.

