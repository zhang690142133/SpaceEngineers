← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector2 Struct

```csharp
public struct Vector2: IEquatable<Vector2>
```

Defines a vector with two components.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Vector2&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector2 One](VRageMath.Vector2.One)

> 

[static Vector2 PositiveInfinity](VRageMath.Vector2.PositiveInfinity)

> 

[static Vector2 UnitX](VRageMath.Vector2.UnitX)

> 

[static Vector2 UnitY](VRageMath.Vector2.UnitY)

> 

[static Vector2 Zero](VRageMath.Vector2.Zero)

> 

[float X](VRageMath.Vector2.X)

> Gets or sets the x-component of the vector.

[float Y](VRageMath.Vector2.Y)

> Gets or sets the y-component of the vector.

#### Properties

[float Item { get; set; }](VRageMath.Vector2.Item)

> 

#### Constructors

[Vector2(float x, float y)](VRageMath.Vector2..ctor)

> 

[Vector2(float value)](VRageMath.Vector2..ctor)

> 

#### 方法

[static Vector2 Add(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Add)

> Adds two vectors.

[static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Add)

> Adds two vectors.

[static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)](VRageMath.Vector2.Barycentric)

> Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

[static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)](VRageMath.Vector2.Barycentric)

> Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

[static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)](VRageMath.Vector2.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result)](VRageMath.Vector2.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)](VRageMath.Vector2.Clamp)

> Restricts a value to be within a specified range.

[static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result)](VRageMath.Vector2.Clamp)

> Restricts a value to be within a specified range.

[static Vector2 ClampToSphere(Vector2 vector, float radius)](VRageMath.Vector2.ClampToSphere)

> 

[static void ClampToSphere(ref Vector2 vector, float radius)](VRageMath.Vector2.ClampToSphere)

> 

[static float Distance(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Distance)

> Calculates the distance between two vectors.

[static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)](VRageMath.Vector2.Distance)

> Calculates the distance between two vectors.

[static float DistanceSquared(Vector2 value1, Vector2 value2)](VRageMath.Vector2.DistanceSquared)

> Calculates the distance between two vectors squared.

[static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)](VRageMath.Vector2.DistanceSquared)

> Calculates the distance between two vectors squared.

[static Vector2 Divide(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Divide)

> Divides the components of a vector by the components of another vector.

[static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Divide)

> Divides the components of a vector by the components of another vector.

[static Vector2 Divide(Vector2 value1, float divider)](VRageMath.Vector2.Divide)

> Divides a vector by a scalar value.

[static void Divide(ref Vector2 value1, float divider, out Vector2 result)](VRageMath.Vector2.Divide)

> Divides a vector by a scalar value.

[static float Dot(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Dot)

> Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)](VRageMath.Vector2.Dot)

> Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

[static Vector2 Floor(Vector2 position)](VRageMath.Vector2.Floor)

> 

[static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)](VRageMath.Vector2.Hermite)

> Performs a Hermite spline interpolation.

[static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result)](VRageMath.Vector2.Hermite)

> Performs a Hermite spline interpolation.

[static bool IsZero(ref Vector2 value)](VRageMath.Vector2.IsZero)

> 

[static bool IsZero(ref Vector2 value, float epsilon)](VRageMath.Vector2.IsZero)

> 

[static bool IsZero(Vector2 value, float epsilon)](VRageMath.Vector2.IsZero)

> 

[static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)](VRageMath.Vector2.Lerp)

> Performs a linear interpolation between two vectors.

[static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)](VRageMath.Vector2.Lerp)

> Performs a linear interpolation between two vectors.

[static Vector2 Max(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static Vector2 Min(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static Vector2 Multiply(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Multiply)

> Multiplies the components of two vectors by each other.

[static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Multiply)

> Multiplies the components of two vectors by each other.

[static Vector2 Multiply(Vector2 value1, float scaleFactor)](VRageMath.Vector2.Multiply)

> Multiplies a vector by a scalar value.

[static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result)](VRageMath.Vector2.Multiply)

> Multiplies a vector by a scalar value.

[static Vector2 Negate(Vector2 value)](VRageMath.Vector2.Negate)

> Returns a vector pointing in the opposite direction.

[static void Negate(ref Vector2 value, out Vector2 result)](VRageMath.Vector2.Negate)

> Returns a vector pointing in the opposite direction.

[static Vector2 Normalize(Vector2 value)](VRageMath.Vector2.Normalize)

> Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[static void Normalize(ref Vector2 value, out Vector2 result)](VRageMath.Vector2.Normalize)

> Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

[static Vector2 Reflect(Vector2 vector, Vector2 normal)](VRageMath.Vector2.Reflect)

> Determines the reflect vector of the given vector and normal.

[static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)](VRageMath.Vector2.Reflect)

> Determines the reflect vector of the given vector and normal.

[static Vector2 SignNonZero(Vector2 value)](VRageMath.Vector2.SignNonZero)

> 

[static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)](VRageMath.Vector2.SmoothStep)

> Interpolates between two values using a cubic equation.

[static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)](VRageMath.Vector2.SmoothStep)

> Interpolates between two values using a cubic equation.

[static Vector2 Subtract(Vector2 value1, Vector2 value2)](VRageMath.Vector2.Subtract)

> Subtracts a vector from a vector.

[static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)](VRageMath.Vector2.Subtract)

> Subtracts a vector from a vector.

[static Vector2 Transform(Vector2 position, Matrix matrix)](VRageMath.Vector2.Transform)

> Transforms the vector (x, y, 0, 1) by the specified matrix.

[static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)](VRageMath.Vector2.Transform)

> Transforms a Vector2 by the given Matrix.

[static Vector2 Transform(Vector2 value, Quaternion rotation)](VRageMath.Vector2.Transform)

> Transforms a single Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

[static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)](VRageMath.Vector2.Transform)

> Transforms a Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

[static void Transform(Vector2&#91&#93; sourceArray, ref Matrix matrix, Vector2&#91&#93; destinationArray)](VRageMath.Vector2.Transform)

> Transforms an array of Vector2s by a specified Matrix.

[static void Transform(Vector2&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector2&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2.Transform)

> Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

[static void Transform(Vector2&#91&#93; sourceArray, ref Quaternion rotation, Vector2&#91&#93; destinationArray)](VRageMath.Vector2.Transform)

> Transforms an array of Vector2s by a specified Quaternion.

[static void Transform(Vector2&#91&#93; sourceArray, int sourceIndex, ref Quaternion rotation, Vector2&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2.Transform)

> Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

[static Vector2 TransformNormal(Vector2 normal, Matrix matrix)](VRageMath.Vector2.TransformNormal)

> Transforms a 2D vector normal by a matrix.

[static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)](VRageMath.Vector2.TransformNormal)

> Transforms a vector normal by a matrix.

[static void TransformNormal(Vector2&#91&#93; sourceArray, ref Matrix matrix, Vector2&#91&#93; destinationArray)](VRageMath.Vector2.TransformNormal)

> Transforms an array of Vector2 vector normals by a specified Matrix.

[static void TransformNormal(Vector2&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector2&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector2.TransformNormal)

> Transforms a specified range in an array of Vector2 vector normals by a specified Matrix and places the results in a specified range in a destination array.

[void AssertIsValid()](VRageMath.Vector2.AssertIsValid)

> 

[bool Between(ref Vector2 start, ref Vector2 end)](VRageMath.Vector2.Between)

> 

[bool Equals(Vector2 other)](VRageMath.Vector2.Equals)

> Determines whether the specified Object is equal to the Vector2.

[bool Equals(object obj)](VRageMath.Vector2.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int GetHashCode()](VRageMath.Vector2.GetHashCode)

> Gets the hash code of the vector object.

[bool IsValid()](VRageMath.Vector2.IsValid)

> 

[float Length()](VRageMath.Vector2.Length)

> Calculates the length of the vector.

[float LengthSquared()](VRageMath.Vector2.LengthSquared)

> Calculates the length of the vector squared.

[void Normalize()](VRageMath.Vector2.Normalize)

> Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

[void Rotate(double angle)](VRageMath.Vector2.Rotate)

> 

[string ToString()](VRageMath.Vector2.ToString)

> Retrieves a string representation of the current object.

