← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### RayD Struct

```csharp
public struct RayD: IEquatable<RayD>
```

Defines a ray.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;RayD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector3D Direction](VRageMath.RayD.Direction)

> Unit vector specifying the direction the Ray is pointing.

[Vector3D Position](VRageMath.RayD.Position)

> Specifies the starting point of the Ray.

#### Constructors

[RayD(Vector3D position, Vector3D direction)](VRageMath.RayD..ctor)

> 

[RayD(ref Vector3D position, ref Vector3D direction)](VRageMath.RayD..ctor)

> 

#### 方法

[bool Equals(RayD other)](VRageMath.RayD.Equals)

> Determines whether the specified Ray is equal to the current Ray.

[bool Equals(object obj)](VRageMath.RayD.Equals)

> Determines whether two instances of Ray are equal.

[int GetHashCode()](VRageMath.RayD.GetHashCode)

> Gets the hash code for this instance.

[double? Intersects(BoundingBoxD box)](VRageMath.RayD.Intersects)

> Checks whether the Ray intersects a specified BoundingBox.

[void Intersects(ref BoundingBoxD box, out double? result)](VRageMath.RayD.Intersects)

> Checks whether the current Ray intersects a BoundingBox.

[double? Intersects(BoundingFrustumD frustum)](VRageMath.RayD.Intersects)

> Checks whether the Ray intersects a specified BoundingFrustum.

[double? Intersects(PlaneD plane)](VRageMath.RayD.Intersects)

> Determines whether this Ray intersects a specified Plane.

[void Intersects(ref PlaneD plane, out double? result)](VRageMath.RayD.Intersects)

> Determines whether this Ray intersects a specified Plane.

[double? Intersects(BoundingSphereD sphere)](VRageMath.RayD.Intersects)

> Checks whether the Ray intersects a specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out double? result)](VRageMath.RayD.Intersects)

> Checks whether the current Ray intersects a BoundingSphere.

[string ToString()](VRageMath.RayD.ToString)

> Returns a String that represents the current Ray.

