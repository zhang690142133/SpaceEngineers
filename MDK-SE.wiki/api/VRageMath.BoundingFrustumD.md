← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingFrustumD Class

```csharp
public class BoundingFrustumD: IEquatable<BoundingFrustumD>
```

Defines a frustum and helps determine whether forms intersect with it.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingFrustumD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static int CornerCount](VRageMath.BoundingFrustumD.CornerCount)

> Specifies the total number of corners (8) in the BoundingFrustumD.

#### Properties

[PlaneD Bottom { get; }](VRageMath.BoundingFrustumD.Bottom)

> Gets the bottom plane of the BoundingFrustumD.

[PlaneD Far { get; }](VRageMath.BoundingFrustumD.Far)

> Gets the far plane of the BoundingFrustumD.

[PlaneD Item { get; }](VRageMath.BoundingFrustumD.Item)

> 

[PlaneD Left { get; }](VRageMath.BoundingFrustumD.Left)

> Gets the left plane of the BoundingFrustumD.

[MatrixD Matrix { get; set; }](VRageMath.BoundingFrustumD.Matrix)

> Gets or sets the Matrix that describes this bounding frustum.

[PlaneD Near { get; }](VRageMath.BoundingFrustumD.Near)

> Gets the near plane of the BoundingFrustumD.

[PlaneD Right { get; }](VRageMath.BoundingFrustumD.Right)

> Gets the right plane of the BoundingFrustumD.

[PlaneD Top { get; }](VRageMath.BoundingFrustumD.Top)

> Gets the top plane of the BoundingFrustumD.

#### Constructors

[BoundingFrustumD()](VRageMath.BoundingFrustumD..ctor)

> 

[BoundingFrustumD(MatrixD value)](VRageMath.BoundingFrustumD..ctor)

> 

#### 方法

[ContainmentType Contains(BoundingBoxD box)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified BoundingBoxD.

[void Contains(ref BoundingBoxD box, out ContainmentType result)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified BoundingBoxD.

[ContainmentType Contains(BoundingFrustumD frustum)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified BoundingFrustumD.

[ContainmentType Contains(Vector3D point)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified point.

[void Contains(ref Vector3D point, out ContainmentType result)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified point.

[ContainmentType Contains(BoundingSphereD sphere)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified BoundingSphere.

[void Contains(ref BoundingSphereD sphere, out ContainmentType result)](VRageMath.BoundingFrustumD.Contains)

> Checks whether the current BoundingFrustumD contains the specified BoundingSphere.

[bool Equals(BoundingFrustumD other)](VRageMath.BoundingFrustumD.Equals)

> Determines whether the specified BoundingFrustumD is equal to the current BoundingFrustumD.

[bool Equals(object obj)](VRageMath.BoundingFrustumD.Equals)

> Determines whether the specified Object is equal to the BoundingFrustumD.

[Vector3D&#91&#93; GetCorners()](VRageMath.BoundingFrustumD.GetCorners)

> Gets an array of points that make up the corners of the BoundingFrustumD. ALLOCATION!

[void GetCorners(Vector3D&#91&#93; corners)](VRageMath.BoundingFrustumD.GetCorners)

> Gets an array of points that make up the corners of the BoundingFrustumD.

[void GetCornersUnsafe(*Vector3D corners)](VRageMath.BoundingFrustumD.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingFrustumD.GetHashCode)

> Gets the hash code for this instance.

[bool Intersects(BoundingBoxD box)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects the specified BoundingBoxD.

[void Intersects(ref BoundingBoxD box, out bool result)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects a BoundingBoxD.

[bool Intersects(BoundingFrustumD frustum)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects the specified BoundingFrustumD.

[PlaneIntersectionType Intersects(PlaneD plane)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects the specified Plane.

[void Intersects(ref PlaneD plane, out PlaneIntersectionType result)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects a Plane.

[double? Intersects(RayD ray)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects the specified Ray.

[void Intersects(ref RayD ray, out double? result)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects a Ray.

[bool Intersects(BoundingSphereD sphere)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects the specified BoundingSphere.

[void Intersects(ref BoundingSphereD sphere, out bool result)](VRageMath.BoundingFrustumD.Intersects)

> Checks whether the current BoundingFrustumD intersects a BoundingSphere.

[string ToString()](VRageMath.BoundingFrustumD.ToString)

> Returns a String that represents the current BoundingFrustumD.

