← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector3D Struct

```csharp
public struct Vector3D: IEquatable<Vector3D>
```

Defines a vector with three components. Vector3 with double floating point precision

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Vector3D&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector3D Backward](VRageMath.Vector3D.Backward)

> 

[static Vector3D Down](VRageMath.Vector3D.Down)

> 

[static Vector3D Forward](VRageMath.Vector3D.Forward)

> 

[static Vector3D Half](VRageMath.Vector3D.Half)

> 

[static Vector3D Left](VRageMath.Vector3D.Left)

> 

[static Vector3D MaxValue](VRageMath.Vector3D.MaxValue)

> 

[static Vector3D MinValue](VRageMath.Vector3D.MinValue)

> 

[static Vector3D NegativeInfinity](VRageMath.Vector3D.NegativeInfinity)

> 

[static Vector3D One](VRageMath.Vector3D.One)

> 

[static Vector3D PositiveInfinity](VRageMath.Vector3D.PositiveInfinity)

> 

[static Vector3D Right](VRageMath.Vector3D.Right)

> 

[static Vector3D UnitX](VRageMath.Vector3D.UnitX)

> 

[static Vector3D UnitY](VRageMath.Vector3D.UnitY)

> 

[static Vector3D UnitZ](VRageMath.Vector3D.UnitZ)

> 

[static Vector3D Up](VRageMath.Vector3D.Up)

> 

[static Vector3D Zero](VRageMath.Vector3D.Zero)

> 

[double X](VRageMath.Vector3D.X)

> Gets or sets the x-component of the vector.

[double Y](VRageMath.Vector3D.Y)

> Gets or sets the y-component of the vector.

[double Z](VRageMath.Vector3D.Z)

> Gets or sets the z-component of the vector.

#### Properties

[double Sum { get; }](VRageMath.Vector3D.Sum)

> 

[double Volume { get; }](VRageMath.Vector3D.Volume)

> 

#### Constructors

[Vector3D(double x, double y, double z)](VRageMath.Vector3D..ctor)

> 

[Vector3D(double value)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector2 value, double z)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector2D value, double z)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector4 xyz)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector4D xyz)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector3 value)](VRageMath.Vector3D..ctor)

> 

[Vector3D(ref Vector3I value)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector3I value)](VRageMath.Vector3D..ctor)

> 

[Vector3D(Vector3D value)](VRageMath.Vector3D..ctor)

> 

#### 方法

[static void Abs(ref Vector3D vector3D, out Vector3D abs)](VRageMath.Vector3D.Abs)

> 

[static Vector3D Abs(Vector3D value)](VRageMath.Vector3D.Abs)

> 

[static Vector3D Add(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Add)

> Adds two vectors.

[static void Add(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Add)

> Adds two vectors.

[static bool ArePerpendicular(ref Vector3D a, ref Vector3D b)](VRageMath.Vector3D.ArePerpendicular)

> 

[static Vector3D Barycentric(Vector3D value1, Vector3D value2, Vector3D value3, double amount1, double amount2)](VRageMath.Vector3D.Barycentric)

> Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 3D triangle.

[static void Barycentric(ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, double amount1, double amount2, out Vector3D result)](VRageMath.Vector3D.Barycentric)

> Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 3D triangle.

[static void Barycentric(Vector3D p, Vector3D a, Vector3D b, Vector3D c, out double u, out double v, out double w)](VRageMath.Vector3D.Barycentric)

> Compute barycentric coordinates (u, v, w) for point p with respect to triangle (a, b, c) From : Real-Time Collision Detection, Christer Ericson, CRC Press 3.4 Barycentric Coordinates

[static Vector3D CalculatePerpendicularVector(Vector3D v)](VRageMath.Vector3D.CalculatePerpendicularVector)

> 

[static Vector3D CatmullRom(Vector3D value1, Vector3D value2, Vector3D value3, Vector3D value4, double amount)](VRageMath.Vector3D.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static void CatmullRom(ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, ref Vector3D value4, double amount, out Vector3D result)](VRageMath.Vector3D.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static Vector3D Clamp(Vector3D value1, Vector3D min, Vector3D max)](VRageMath.Vector3D.Clamp)

> Restricts a value to be within a specified range.

[static void Clamp(ref Vector3D value1, ref Vector3D min, ref Vector3D max, out Vector3D result)](VRageMath.Vector3D.Clamp)

> Restricts a value to be within a specified range.

[static Vector3D ClampToSphere(Vector3D vector, double radius)](VRageMath.Vector3D.ClampToSphere)

> 

[static void ClampToSphere(ref Vector3D vector, double radius)](VRageMath.Vector3D.ClampToSphere)

> 

[static void CreateFromAzimuthAndElevation(double azimuth, double elevation, out Vector3D direction)](VRageMath.Vector3D.CreateFromAzimuthAndElevation)

> 

[static Vector3D Cross(Vector3D vector1, Vector3D vector2)](VRageMath.Vector3D.Cross)

> Calculates the cross product of two vectors.

[static void Cross(ref Vector3D vector1, ref Vector3D vector2, out Vector3D result)](VRageMath.Vector3D.Cross)

> Calculates the cross product of two vectors.

[static double Distance(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Distance)

> Calculates the distance between two vectors.

[static double Distance(Vector3D value1, Vector3 value2)](VRageMath.Vector3D.Distance)

> 

[static double Distance(Vector3 value1, Vector3D value2)](VRageMath.Vector3D.Distance)

> 

[static void Distance(ref Vector3D value1, ref Vector3D value2, out double result)](VRageMath.Vector3D.Distance)

> Calculates the distance between two vectors.

[static double DistanceSquared(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.DistanceSquared)

> Calculates the distance between two vectors squared.

[static void DistanceSquared(ref Vector3D value1, ref Vector3D value2, out double result)](VRageMath.Vector3D.DistanceSquared)

> Calculates the distance between two vectors squared.

[static Vector3D Divide(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Divide)

> Divides the components of a vector by the components of another vector.

[static void Divide(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Divide)

> Divides the components of a vector by the components of another vector.

[static Vector3D Divide(Vector3D value1, double value2)](VRageMath.Vector3D.Divide)

> Divides a vector by a scalar value.

[static void Divide(ref Vector3D value1, double value2, out Vector3D result)](VRageMath.Vector3D.Divide)

> Divides a vector by a scalar value.

[static Vector3D DominantAxisProjection(Vector3D value1)](VRageMath.Vector3D.DominantAxisProjection)

> Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

[static void DominantAxisProjection(ref Vector3D value1, out Vector3D result)](VRageMath.Vector3D.DominantAxisProjection)

> Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved into a user-specified variable.

[static double Dot(Vector3D vector1, Vector3D vector2)](VRageMath.Vector3D.Dot)

> Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static double Dot(Vector3D vector1, Vector3 vector2)](VRageMath.Vector3D.Dot)

> 

[static void Dot(ref Vector3D vector1, ref Vector3D vector2, out double result)](VRageMath.Vector3D.Dot)

> Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static void Dot(ref Vector3D vector1, ref Vector3 vector2, out double result)](VRageMath.Vector3D.Dot)

> 

[static void Dot(ref Vector3 vector1, ref Vector3D vector2, out double result)](VRageMath.Vector3D.Dot)

> 

[static Vector3I Floor(Vector3D vect3d)](VRageMath.Vector3D.Floor)

> 

[static void Fract(ref Vector3D o, out Vector3D r)](VRageMath.Vector3D.Fract)

> 

[static void GetAzimuthAndElevation(Vector3D v, out double azimuth, out double elevation)](VRageMath.Vector3D.GetAzimuthAndElevation)

> 

[static Vector3D Hermite(Vector3D value1, Vector3D tangent1, Vector3D value2, Vector3D tangent2, double amount)](VRageMath.Vector3D.Hermite)

> Performs a Hermite spline interpolation.

[static void Hermite(ref Vector3D value1, ref Vector3D tangent1, ref Vector3D value2, ref Vector3D tangent2, double amount, out Vector3D result)](VRageMath.Vector3D.Hermite)

> Performs a Hermite spline interpolation.

[static bool IsUnit(ref Vector3D value)](VRageMath.Vector3D.IsUnit)

> 

[static bool IsZero(Vector3D value)](VRageMath.Vector3D.IsZero)

> 

[static bool IsZero(Vector3D value, double epsilon)](VRageMath.Vector3D.IsZero)

> 

[static Vector3D IsZeroVector(Vector3D value)](VRageMath.Vector3D.IsZeroVector)

> 

[static Vector3D IsZeroVector(Vector3D value, double epsilon)](VRageMath.Vector3D.IsZeroVector)

> 

[static Vector3D Lerp(Vector3D value1, Vector3D value2, double amount)](VRageMath.Vector3D.Lerp)

> Performs a linear interpolation between two vectors.

[static void Lerp(ref Vector3D value1, ref Vector3D value2, double amount, out Vector3D result)](VRageMath.Vector3D.Lerp)

> Performs a linear interpolation between two vectors.

[static Vector3D Max(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static void Max(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static Vector3D Min(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static void Min(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static void MinMax(ref Vector3D min, ref Vector3D max)](VRageMath.Vector3D.MinMax)

> Separates minimal and maximal values of any two input vectors

[static Vector3D Multiply(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Multiply)

> Multiplies the components of two vectors by each other.

[static void Multiply(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Multiply)

> Multiplies the components of two vectors by each other.

[static Vector3D Multiply(Vector3D value1, double scaleFactor)](VRageMath.Vector3D.Multiply)

> Multiplies a vector by a scalar value.

[static void Multiply(ref Vector3D value1, double scaleFactor, out Vector3D result)](VRageMath.Vector3D.Multiply)

> Multiplies a vector by a scalar value.

[static Vector3D Negate(Vector3D value)](VRageMath.Vector3D.Negate)

> Returns a vector pointing in the opposite direction.

[static void Negate(ref Vector3D value, out Vector3D result)](VRageMath.Vector3D.Negate)

> Returns a vector pointing in the opposite direction.

[static Vector3D Normalize(Vector3D value)](VRageMath.Vector3D.Normalize)

> Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[static void Normalize(ref Vector3D value, out Vector3D result)](VRageMath.Vector3D.Normalize)

> Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

[static Vector3D ProjectOnPlane(ref Vector3D vec, ref Vector3D planeNormal)](VRageMath.Vector3D.ProjectOnPlane)

> Projects given vector on plane specified by it's normal.

[static Vector3D ProjectOnVector(ref Vector3D vec, ref Vector3D guideVector)](VRageMath.Vector3D.ProjectOnVector)

> Projects vector on another vector resulting in new vector in guided vector's direction with different length.

[static double RectangularDistance(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.RectangularDistance)

> Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

[static double RectangularDistance(ref Vector3D value1, ref Vector3D value2)](VRageMath.Vector3D.RectangularDistance)

> Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

[static Vector3D Reflect(Vector3D vector, Vector3D normal)](VRageMath.Vector3D.Reflect)

> Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

[static void Reflect(ref Vector3D vector, ref Vector3D normal, out Vector3D result)](VRageMath.Vector3D.Reflect)

> Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

[static Vector3D Reject(Vector3D vector, Vector3D direction)](VRageMath.Vector3D.Reject)

> Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

[static void Reject(ref Vector3D vector, ref Vector3D direction, out Vector3D result)](VRageMath.Vector3D.Reject)

> Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

[static void Rotate(ref Vector3D vector, ref MatrixD rotationMatrix, out Vector3D result)](VRageMath.Vector3D.Rotate)

> 

[static Vector3D Rotate(Vector3D vector, MatrixD rotationMatrix)](VRageMath.Vector3D.Rotate)

> 

[static void RotateAndScale(ref Vector3D vector, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.RotateAndScale)

> 

[static Vector3I Round(Vector3D vect3d)](VRageMath.Vector3D.Round)

> 

[static Vector3D Round(Vector3D v, int numDecimals)](VRageMath.Vector3D.Round)

> 

[static Vector3D Sign(Vector3D value)](VRageMath.Vector3D.Sign)

> 

[static Vector3D SignNonZero(Vector3D value)](VRageMath.Vector3D.SignNonZero)

> Returns per component sign, never returns zero. For zero component returns sign 1. Faster than Sign.

[static Vector3D SmoothStep(Vector3D value1, Vector3D value2, double amount)](VRageMath.Vector3D.SmoothStep)

> Interpolates between two values using a cubic equation.

[static void SmoothStep(ref Vector3D value1, ref Vector3D value2, double amount, out Vector3D result)](VRageMath.Vector3D.SmoothStep)

> Interpolates between two values using a cubic equation.

[static Vector3D Step(Vector3D value)](VRageMath.Vector3D.Step)

> 

[static Vector3D Subtract(Vector3D value1, Vector3D value2)](VRageMath.Vector3D.Subtract)

> Subtracts a vector from a vector.

[static void Subtract(ref Vector3D value1, ref Vector3D value2, out Vector3D result)](VRageMath.Vector3D.Subtract)

> Subtracts a vector from a vector.

[static Vector3D SwapYZCoordinates(Vector3D v)](VRageMath.Vector3D.SwapYZCoordinates)

> 

[static Vector3D Transform(Vector3D value, Quaternion rotation)](VRageMath.Vector3D.Transform)

> Transforms a Vector3 by a specified Quaternion rotation.

[static void Transform(ref Vector3D value, ref Quaternion rotation, out Vector3D result)](VRageMath.Vector3D.Transform)

> Transforms a Vector3 by a specified Quaternion rotation.

[static void Transform(Vector3D&#91&#93; sourceArray, ref MatrixD matrix, Vector3D&#91&#93; destinationArray)](VRageMath.Vector3D.Transform)

> Transforms a source array of Vector3s by a specified Matrix and writes the results to an existing destination array.

[static void Transform(Vector3D&#91&#93; sourceArray, ref MatrixD matrix, *Vector3D destinationArray)](VRageMath.Vector3D.Transform)

> 

[static void Transform(Vector3D&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector3D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector3D.Transform)

> Applies a specified transform Matrix to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

[static void Transform(Vector3D&#91&#93; sourceArray, ref Quaternion rotation, Vector3D&#91&#93; destinationArray)](VRageMath.Vector3D.Transform)

> Transforms a source array of Vector3s by a specified Quaternion rotation and writes the results to an existing destination array.

[static void Transform(Vector3D&#91&#93; sourceArray, int sourceIndex, ref Quaternion rotation, Vector3D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector3D.Transform)

> Applies a specified Quaternion rotation to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

[static Vector3D Transform(Vector3D position, MatrixD matrix)](VRageMath.Vector3D.Transform)

> Transforms a 3D vector by the given matrix.

[static Vector3D Transform(Vector3 position, MatrixD matrix)](VRageMath.Vector3D.Transform)

> 

[static Vector3D Transform(Vector3D position, Matrix matrix)](VRageMath.Vector3D.Transform)

> Transforms a 3D vector by the given matrix.

[static Vector3D Transform(Vector3D position, ref MatrixD matrix)](VRageMath.Vector3D.Transform)

> 

[static void Transform(ref Vector3D position, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.Transform)

> Transforms a Vector3 by the given Matrix.

[static void Transform(ref Vector3 position, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.Transform)

> 

[static void Transform(ref Vector3D position, ref MatrixI matrix, out Vector3D result)](VRageMath.Vector3D.Transform)

> 

[static void TransformNoProjection(ref Vector3D vector, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.TransformNoProjection)

> 

[static void TransformNormal(ref Vector3D normal, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.TransformNormal)

> Transforms a vector normal by a matrix.

[static void TransformNormal(ref Vector3 normal, ref MatrixD matrix, out Vector3D result)](VRageMath.Vector3D.TransformNormal)

> 

[static void TransformNormal(ref Vector3D normal, ref MatrixI matrix, out Vector3D result)](VRageMath.Vector3D.TransformNormal)

> 

[static Vector3D TransformNormal(Vector3D normal, MyBlockOrientation orientation)](VRageMath.Vector3D.TransformNormal)

> 

[static void TransformNormal(ref Vector3D normal, MyBlockOrientation orientation, out Vector3D result)](VRageMath.Vector3D.TransformNormal)

> 

[static Vector3D TransformNormal(Vector3D normal, ref MatrixD matrix)](VRageMath.Vector3D.TransformNormal)

> 

[static void TransformNormal(Vector3D&#91&#93; sourceArray, ref Matrix matrix, Vector3D&#91&#93; destinationArray)](VRageMath.Vector3D.TransformNormal)

> Transforms an array of 3D vector normals by a specified Matrix.

[static void TransformNormal(Vector3D&#91&#93; sourceArray, ref Matrix matrix, *Vector3D destinationArray)](VRageMath.Vector3D.TransformNormal)

> 

[static void TransformNormal(Vector3D&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector3D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector3D.TransformNormal)

> Transforms a specified range in an array of 3D vector normals by a specified Matrix and writes the results to a specified range in a destination array.

[static Vector3D TransformNormal(Vector3D normal, Matrix matrix)](VRageMath.Vector3D.TransformNormal)

> Transforms a 3D vector normal by a matrix.

[static Vector3D TransformNormal(Vector3 normal, MatrixD matrix)](VRageMath.Vector3D.TransformNormal)

> Transforms a 3D vector normal by a matrix.

[static Vector3D TransformNormal(Vector3D normal, MatrixD matrix)](VRageMath.Vector3D.TransformNormal)

> Transforms a 3D vector normal by a matrix.

[static bool TryParse(string str, out Vector3D retval)](VRageMath.Vector3D.TryParse)

> 

[double AbsMax()](VRageMath.Vector3D.AbsMax)

> Returns the component of the vector, whose absolute value is largest of all the three components.

[int AbsMaxComponent()](VRageMath.Vector3D.AbsMaxComponent)

> 

[double AbsMin()](VRageMath.Vector3D.AbsMin)

> Returns the component of the vector, whose absolute value is smallest of all the three components.

[void AssertIsValid()](VRageMath.Vector3D.AssertIsValid)

> 

[void CalculatePerpendicularVector(out Vector3D result)](VRageMath.Vector3D.CalculatePerpendicularVector)

> 

[Vector3D Cross(Vector3D v)](VRageMath.Vector3D.Cross)

> 

[double Dot(Vector3D v)](VRageMath.Vector3D.Dot)

> 

[double Dot(Vector3 v)](VRageMath.Vector3D.Dot)

> 

[double Dot(ref Vector3D v)](VRageMath.Vector3D.Dot)

> 

[bool Equals(Vector3D other)](VRageMath.Vector3D.Equals)

> Determines whether the specified Object is equal to the Vector3.

[bool Equals(Vector3D other, double epsilon)](VRageMath.Vector3D.Equals)

> 

[bool Equals(object obj)](VRageMath.Vector3D.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[double GetDim(int i)](VRageMath.Vector3D.GetDim)

> 

[long GetHash()](VRageMath.Vector3D.GetHash)

> Gets the hash code of the vector object.

[int GetHashCode()](VRageMath.Vector3D.GetHashCode)

> 

[void Interpolate3(Vector3D v0, Vector3D v1, double rt)](VRageMath.Vector3D.Interpolate3)

> 

[bool IsInsideInclusive(ref Vector3D min, ref Vector3D max)](VRageMath.Vector3D.IsInsideInclusive)

> 

[bool IsValid()](VRageMath.Vector3D.IsValid)

> 

[bool IsZero()](VRageMath.Vector3D.IsZero)

> 

[double Length()](VRageMath.Vector3D.Length)

> Calculates the length of the vector.

[double LengthSquared()](VRageMath.Vector3D.LengthSquared)

> Calculates the length of the vector squared.

[double Max()](VRageMath.Vector3D.Max)

> Returns the component of the vector that is largest of all the three components.

[double Min()](VRageMath.Vector3D.Min)

> Returns the component of the vector that is smallest of all the three components.

[double Normalize()](VRageMath.Vector3D.Normalize)

> Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[void SetDim(int i, double value)](VRageMath.Vector3D.SetDim)

> 

[string ToString()](VRageMath.Vector3D.ToString)

> Retrieves a string representation of the current object.

[string ToString(string format)](VRageMath.Vector3D.ToString)

> 

[long VolumeInt(double multiplier)](VRageMath.Vector3D.VolumeInt)

> 

