← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector2D Struct

```csharp
public struct Vector2D: IEquatable<Vector2D>
```

Defines a vector with two components.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Vector2D&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector2D One](VRageMath.Vector2D.One)

> 

[static Vector2D PositiveInfinity](VRageMath.Vector2D.PositiveInfinity)

> 

[static Vector2D UnitX](VRageMath.Vector2D.UnitX)

> 

[static Vector2D UnitY](VRageMath.Vector2D.UnitY)

> 

[static Vector2D Zero](VRageMath.Vector2D.Zero)

> 

[double X](VRageMath.Vector2D.X)

> Gets or sets the x-component of the vector.

[double Y](VRageMath.Vector2D.Y)

> Gets or sets the y-component of the vector.

#### Properties

[double Item { get; set; }](VRageMath.Vector2D.Item)

> 

#### Constructors

[Vector2D(double x, double y)](VRageMath.Vector2D..ctor)

> 

[Vector2D(double value)](VRageMath.Vector2D..ctor)

> 

#### 方法

[static Vector2D Add(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Add)

> Adds two vectors.

[static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Add)

> Adds two vectors.

[static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)](VRageMath.Vector2D.Barycentric)

> Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

[static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)](VRageMath.Vector2D.Barycentric)

> Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

[static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)](VRageMath.Vector2D.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)](VRageMath.Vector2D.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)](VRageMath.Vector2D.Clamp)

> Restricts a value to be within a specified range.

[static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)](VRageMath.Vector2D.Clamp)

> Restricts a value to be within a specified range.

[static Vector2D ClampToSphere(Vector2D vector, double radius)](VRageMath.Vector2D.ClampToSphere)

> 

[static void ClampToSphere(ref Vector2D vector, double radius)](VRageMath.Vector2D.ClampToSphere)

> 

[static double Distance(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Distance)

> Calculates the distance between two vectors.

[static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)](VRageMath.Vector2D.Distance)

> Calculates the distance between two vectors.

[static double DistanceSquared(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.DistanceSquared)

> Calculates the distance between two vectors squared.

[static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)](VRageMath.Vector2D.DistanceSquared)

> Calculates the distance between two vectors squared.

[static Vector2D Divide(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Divide)

> Divides the components of a vector by the components of another vector.

[static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Divide)

> Divides the components of a vector by the components of another vector.

[static Vector2D Divide(Vector2D value1, double divider)](VRageMath.Vector2D.Divide)

> Divides a vector by a scalar value.

[static void Divide(ref Vector2D value1, double divider, out Vector2D result)](VRageMath.Vector2D.Divide)

> Divides a vector by a scalar value.

[static double Dot(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Dot)

> Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)](VRageMath.Vector2D.Dot)

> Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static Vector2D Floor(Vector2D position)](VRageMath.Vector2D.Floor)

> 

[static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)](VRageMath.Vector2D.Hermite)

> Performs a Hermite spline interpolation.

[static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)](VRageMath.Vector2D.Hermite)

> Performs a Hermite spline interpolation.

[static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)](VRageMath.Vector2D.Lerp)

> Performs a linear interpolation between two vectors.

[static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)](VRageMath.Vector2D.Lerp)

> Performs a linear interpolation between two vectors.

[static Vector2D Max(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static void Max(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static Vector2D Min(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static void Min(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static Vector2D Multiply(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Multiply)

> Multiplies the components of two vectors by each other.

[static void Multiply(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Multiply)

> Multiplies the components of two vectors by each other.

[static Vector2D Multiply(Vector2D value1, double scaleFactor)](VRageMath.Vector2D.Multiply)

> Multiplies a vector by a scalar value.

[static void Multiply(ref Vector2D value1, double scaleFactor, out Vector2D result)](VRageMath.Vector2D.Multiply)

> Multiplies a vector by a scalar value.

[static Vector2D Negate(Vector2D value)](VRageMath.Vector2D.Negate)

> Returns a vector pointing in the opposite direction.

[static void Negate(ref Vector2D value, out Vector2D result)](VRageMath.Vector2D.Negate)

> Returns a vector pointing in the opposite direction.

[static Vector2D Normalize(Vector2D value)](VRageMath.Vector2D.Normalize)

> Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[static void Normalize(ref Vector2D value, out Vector2D result)](VRageMath.Vector2D.Normalize)

> Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

[static Vector2D Reflect(Vector2D vector, Vector2D normal)](VRageMath.Vector2D.Reflect)

> Determines the reflect vector of the given vector and normal.

[static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)](VRageMath.Vector2D.Reflect)

> Determines the reflect vector of the given vector and normal.

[static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)](VRageMath.Vector2D.SmoothStep)

> Interpolates between two values using a cubic equation.

[static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)](VRageMath.Vector2D.SmoothStep)

> Interpolates between two values using a cubic equation.

[static Vector2D Subtract(Vector2D value1, Vector2D value2)](VRageMath.Vector2D.Subtract)

> Subtracts a vector from a vector.

[static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)](VRageMath.Vector2D.Subtract)

> Subtracts a vector from a vector.

[static Vector2D Transform(Vector2D position, Matrix matrix)](VRageMath.Vector2D.Transform)

> Transforms the vector (x, y, 0, 1) by the specified matrix.

[static void Transform(ref Vector2D position, ref Matrix matrix, out Vector2D result)](VRageMath.Vector2D.Transform)

> Transforms a Vector2D by the given Matrix.

[static Vector2D Transform(Vector2D value, Quaternion rotation)](VRageMath.Vector2D.Transform)

> Transforms a single Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

[static void Transform(ref Vector2D value, ref Quaternion rotation, out Vector2D result)](VRageMath.Vector2D.Transform)

> Transforms a Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

[static void Transform(Vector2D&#91&#93; sourceArray, ref Matrix matrix, Vector2D&#91&#93; destinationArray)](VRageMath.Vector2D.Transform)

> Transforms an array of Vector2s by a specified Matrix.

[static void Transform(Vector2D&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector2D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2D.Transform)

> Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

[static void Transform(Vector2D&#91&#93; sourceArray, ref Quaternion rotation, Vector2D&#91&#93; destinationArray)](VRageMath.Vector2D.Transform)

> Transforms an array of Vector2s by a specified Quaternion.

[static void Transform(Vector2D&#91&#93; sourceArray, int sourceIndex, ref Quaternion rotation, Vector2D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2D.Transform)

> Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

[static Vector2D TransformNormal(Vector2D normal, Matrix matrix)](VRageMath.Vector2D.TransformNormal)

> Transforms a 2D vector normal by a matrix.

[static void TransformNormal(ref Vector2D normal, ref Matrix matrix, out Vector2D result)](VRageMath.Vector2D.TransformNormal)

> Transforms a vector normal by a matrix.

[static void TransformNormal(Vector2D&#91&#93; sourceArray, ref Matrix matrix, Vector2D&#91&#93; destinationArray)](VRageMath.Vector2D.TransformNormal)

> Transforms an array of Vector2D vector normals by a specified Matrix.

[static void TransformNormal(Vector2D&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector2D&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2D.TransformNormal)

> Transforms a specified range in an array of Vector2D vector normals by a specified Matrix and places the results in a specified range in a destination array.

[void AssertIsValid()](VRageMath.Vector2D.AssertIsValid)

> 

[bool Between(ref Vector2D start, ref Vector2D end)](VRageMath.Vector2D.Between)

> 

[bool Equals(Vector2D other)](VRageMath.Vector2D.Equals)

> Determines whether the specified Object is equal to the Vector2D.

[bool Equals(object obj)](VRageMath.Vector2D.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int GetHashCode()](VRageMath.Vector2D.GetHashCode)

> Gets the hash code of the vector object.

[bool IsValid()](VRageMath.Vector2D.IsValid)

> 

[double Length()](VRageMath.Vector2D.Length)

> Calculates the length of the vector.

[double LengthSquared()](VRageMath.Vector2D.LengthSquared)

> Calculates the length of the vector squared.

[void Normalize()](VRageMath.Vector2D.Normalize)

> Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[void Rotate(double angle)](VRageMath.Vector2D.Rotate)

> 

[string ToString()](VRageMath.Vector2D.ToString)

> Retrieves a string representation of the current object.

