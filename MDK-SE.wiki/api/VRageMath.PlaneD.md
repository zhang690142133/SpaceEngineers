← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### PlaneD Struct

```csharp
public struct PlaneD: IEquatable<PlaneD>
```

Defines a PlaneD.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;PlaneD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[double D](VRageMath.PlaneD.D)

> The distance of the PlaneD along its normal from the origin. Note: Be careful! The distance is signed and is the opposite of what people usually expect. If you look closely at the plane equation: (n dot P) + D = 0, you'll realize that D = - (n dot P) (that is, negative instead of positive)

[Vector3D Normal](VRageMath.PlaneD.Normal)

> The normal vector of the PlaneD.

#### Constructors

[PlaneD(double a, double b, double c, double d)](VRageMath.PlaneD..ctor)

> 

[PlaneD(Vector3D normal, double d)](VRageMath.PlaneD..ctor)

> 

[PlaneD(Vector3D position, Vector3D normal)](VRageMath.PlaneD..ctor)

> 

[PlaneD(Vector3D position, Vector3 normal)](VRageMath.PlaneD..ctor)

> 

[PlaneD(Vector4 value)](VRageMath.PlaneD..ctor)

> 

[PlaneD(Vector3D point1, Vector3D point2, Vector3D point3)](VRageMath.PlaneD..ctor)

> 

#### 方法

[static PlaneD Normalize(PlaneD value)](VRageMath.PlaneD.Normalize)

> Changes the coefficients of the Normal vector of a PlaneD to make it of unit length.

[static void Normalize(ref PlaneD value, out PlaneD result)](VRageMath.PlaneD.Normalize)

> Changes the coefficients of the Normal vector of a PlaneD to make it of unit length.

[static PlaneD Transform(PlaneD plane, MatrixD matrix)](VRageMath.PlaneD.Transform)

> Transforms a normalized plane by a Matrix.

[static void Transform(ref PlaneD plane, ref MatrixD matrix, out PlaneD result)](VRageMath.PlaneD.Transform)

> Transforms a normalized plane by a Matrix.

[double DistanceToPoint(Vector3D point)](VRageMath.PlaneD.DistanceToPoint)

> 

[double DistanceToPoint(ref Vector3D point)](VRageMath.PlaneD.DistanceToPoint)

> 

[double Dot(Vector4 value)](VRageMath.PlaneD.Dot)

> Calculates the dot product of a specified Vector4 and this PlaneD.

[void Dot(ref Vector4 value, out double result)](VRageMath.PlaneD.Dot)

> Calculates the dot product of a specified Vector4 and this PlaneD.

[double DotCoordinate(Vector3D value)](VRageMath.PlaneD.DotCoordinate)

> Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD plus the distance (D) value of the PlaneD.

[void DotCoordinate(ref Vector3D value, out double result)](VRageMath.PlaneD.DotCoordinate)

> Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD plus the distance (D) value of the PlaneD.

[double DotNormal(Vector3D value)](VRageMath.PlaneD.DotNormal)

> Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD.

[void DotNormal(ref Vector3D value, out double result)](VRageMath.PlaneD.DotNormal)

> Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD.

[bool Equals(PlaneD other)](VRageMath.PlaneD.Equals)

> Determines whether the specified PlaneD is equal to the PlaneD.

[bool Equals(object obj)](VRageMath.PlaneD.Equals)

> Determines whether the specified Object is equal to the PlaneD.

[int GetHashCode()](VRageMath.PlaneD.GetHashCode)

> Gets the hash code for this object.

[Vector3D Intersection(ref Vector3D from, ref Vector3D direction)](VRageMath.PlaneD.Intersection)

> Gets intersection point in Plane.

[PlaneIntersectionType Intersects(BoundingBoxD box)](VRageMath.PlaneD.Intersects)

> Checks whether the current PlaneD intersects a specified BoundingBox.

[void Intersects(ref BoundingBoxD box, out PlaneIntersectionType result)](VRageMath.PlaneD.Intersects)

> Checks whether the current PlaneD intersects a BoundingBox.

[PlaneIntersectionType Intersects(BoundingFrustumD frustum)](VRageMath.PlaneD.Intersects)

> Checks whether the current PlaneD intersects a specified BoundingFrustum.

[PlaneIntersectionType Intersects(BoundingSphereD sphere)](VRageMath.PlaneD.Intersects)

> Checks whether the current PlaneD intersects a specified BoundingSphere.

[void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)](VRageMath.PlaneD.Intersects)

> Checks whether the current PlaneD intersects a BoundingSphere.

[void Normalize()](VRageMath.PlaneD.Normalize)

> Changes the coefficients of the Normal vector of this PlaneD to make it of unit length.

[Vector3D ProjectPoint(ref Vector3D point)](VRageMath.PlaneD.ProjectPoint)

> 

[Vector3D RandomPoint()](VRageMath.PlaneD.RandomPoint)

> 

[string ToString()](VRageMath.PlaneD.ToString)

> Returns a String that represents the current PlaneD.

