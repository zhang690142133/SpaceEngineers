← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Plane Struct

```csharp
public struct Plane: IEquatable<Plane>
```

Defines a plane.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Plane&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[float D](VRageMath.Plane.D)

> The distance of the Plane along its normal from the origin. Note: Be careful! The distance is signed and is the opposite of what people usually expect. If you look closely at the plane equation: (n dot P) - D = 0, you'll realize that D = - (n dot P) (that is, negative instead of positive)

[Vector3 Normal](VRageMath.Plane.Normal)

> The normal vector of the Plane.

#### Constructors

[Plane(float a, float b, float c, float d)](VRageMath.Plane..ctor)

> 

[Plane(Vector3 normal, float d)](VRageMath.Plane..ctor)

> 

[Plane(Vector3 position, Vector3 normal)](VRageMath.Plane..ctor)

> 

[Plane(Vector4 value)](VRageMath.Plane..ctor)

> 

[Plane(Vector3 point1, Vector3 point2, Vector3 point3)](VRageMath.Plane..ctor)

> 

[Plane(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3)](VRageMath.Plane..ctor)

> 

#### 方法

[static Plane Normalize(Plane value)](VRageMath.Plane.Normalize)

> Changes the coefficients of the Normal vector of a Plane to make it of unit length.

[static void Normalize(ref Plane value, out Plane result)](VRageMath.Plane.Normalize)

> Changes the coefficients of the Normal vector of a Plane to make it of unit length.

[static Plane Transform(Plane plane, Matrix matrix)](VRageMath.Plane.Transform)

> Transforms a normalized Plane by a Matrix.

[static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)](VRageMath.Plane.Transform)

> Transforms a normalized Plane by a Matrix.

[float Dot(Vector4 value)](VRageMath.Plane.Dot)

> Calculates the dot product of a specified Vector4 and this Plane.

[void Dot(ref Vector4 value, out float result)](VRageMath.Plane.Dot)

> Calculates the dot product of a specified Vector4 and this Plane.

[float DotCoordinate(Vector3 value)](VRageMath.Plane.DotCoordinate)

> Returns the dot product of a specified Vector3 and the Normal vector of this Plane plus the distance (D) value of the Plane.

[void DotCoordinate(ref Vector3 value, out float result)](VRageMath.Plane.DotCoordinate)

> Returns the dot product of a specified Vector3 and the Normal vector of this Plane plus the distance (D) value of the Plane.

[double DotNormal(Vector3D value)](VRageMath.Plane.DotNormal)

> Returns the dot product of a specified Vector3 and the Normal vector of this Plane.

[void DotNormal(ref Vector3 value, out float result)](VRageMath.Plane.DotNormal)

> Returns the dot product of a specified Vector3 and the Normal vector of this Plane.

[bool Equals(Plane other)](VRageMath.Plane.Equals)

> Determines whether the specified Plane is equal to the Plane.

[bool Equals(object obj)](VRageMath.Plane.Equals)

> Determines whether the specified Object is equal to the Plane.

[int GetHashCode()](VRageMath.Plane.GetHashCode)

> Gets the hash code for this object.

[Vector3D Intersection(ref Vector3D from, ref Vector3D direction)](VRageMath.Plane.Intersection)

> Gets intersection point in Plane.

[PlaneIntersectionType Intersects(BoundingBox box)](VRageMath.Plane.Intersects)

> Checks whether the current Plane intersects a specified BoundingBox.

[void Intersects(ref BoundingBox box, out PlaneIntersectionType result)](VRageMath.Plane.Intersects)

> Checks whether the current Plane intersects a BoundingBox.

[PlaneIntersectionType Intersects(BoundingFrustum frustum)](VRageMath.Plane.Intersects)

> Checks whether the current Plane intersects a specified BoundingFrustum.

[PlaneIntersectionType Intersects(BoundingSphere sphere)](VRageMath.Plane.Intersects)

> Checks whether the current Plane intersects a specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)](VRageMath.Plane.Intersects)

> Checks whether the current Plane intersects a BoundingSphere.

[void Normalize()](VRageMath.Plane.Normalize)

> Changes the coefficients of the Normal vector of this Plane to make it of unit length.

[Vector3 RandomPoint()](VRageMath.Plane.RandomPoint)

> 

[string ToString()](VRageMath.Plane.ToString)

> Returns a String that represents the current Plane.

