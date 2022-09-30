← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Ray Struct

```csharp
public struct Ray: IEquatable<Ray>
```

Defines a ray.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Ray&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector3 Direction](VRageMath.Ray.Direction)

> Unit vector specifying the direction the Ray is pointing.

[Vector3 Position](VRageMath.Ray.Position)

> Specifies the starting point of the Ray.

#### Constructors

[Ray(Vector3 position, Vector3 direction)](VRageMath.Ray..ctor)

> 

#### 方法

[bool Equals(Ray other)](VRageMath.Ray.Equals)

> Determines whether the specified Ray is equal to the current Ray.

[bool Equals(object obj)](VRageMath.Ray.Equals)

> Determines whether two instances of Ray are equal.

[int GetHashCode()](VRageMath.Ray.GetHashCode)

> Gets the hash code for this instance.

[float? Intersects(BoundingBox box)](VRageMath.Ray.Intersects)

> Checks whether the Ray intersects a specified BoundingBox.

[void Intersects(ref BoundingBox box, out float? result)](VRageMath.Ray.Intersects)

> Checks whether the current Ray intersects a BoundingBox.

[float? Intersects(BoundingFrustum frustum)](VRageMath.Ray.Intersects)

> Checks whether the Ray intersects a specified BoundingFrustum.

[float? Intersects(Plane plane)](VRageMath.Ray.Intersects)

> Determines whether this Ray intersects a specified Plane.

[void Intersects(ref Plane plane, out float? result)](VRageMath.Ray.Intersects)

> Determines whether this Ray intersects a specified Plane.

[float? Intersects(BoundingSphere sphere)](VRageMath.Ray.Intersects)

> Checks whether the Ray intersects a specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out float? result)](VRageMath.Ray.Intersects)

> Checks whether the current Ray intersects a BoundingSphere.

[string ToString()](VRageMath.Ray.ToString)

> Returns a String that represents the current Ray.

