← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector4 Struct

```csharp
public struct Vector4: IEquatable<Vector4>
```

Defines a vector with four components.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Vector4&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Vector4 One](VRageMath.Vector4.One)

> 

[static Vector4 UnitW](VRageMath.Vector4.UnitW)

> 

[static Vector4 UnitX](VRageMath.Vector4.UnitX)

> 

[static Vector4 UnitY](VRageMath.Vector4.UnitY)

> 

[static Vector4 UnitZ](VRageMath.Vector4.UnitZ)

> 

[static Vector4 Zero](VRageMath.Vector4.Zero)

> 

[float W](VRageMath.Vector4.W)

> Gets or sets the w-component of the vector.

[float X](VRageMath.Vector4.X)

> Gets or sets the x-component of the vector.

[float Y](VRageMath.Vector4.Y)

> Gets or sets the y-component of the vector.

[float Z](VRageMath.Vector4.Z)

> Gets or sets the z-component of the vector.

#### Properties

[float Item { get; set; }](VRageMath.Vector4.Item)

> 

#### Constructors

[Vector4(float x, float y, float z, float w)](VRageMath.Vector4..ctor)

> 

[Vector4(Vector2 value, float z, float w)](VRageMath.Vector4..ctor)

> 

[Vector4(Vector3 value, float w)](VRageMath.Vector4..ctor)

> 

[Vector4(float value)](VRageMath.Vector4..ctor)

> 

#### 方法

[static Vector4 Add(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Add)

> Adds two vectors.

[static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Add)

> Adds two vectors.

[static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)](VRageMath.Vector4.Barycentric)

> Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 4D triangle.

[static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)](VRageMath.Vector4.Barycentric)

> Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric (areal) coordinates relative to a 4D triangle.

[static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)](VRageMath.Vector4.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)](VRageMath.Vector4.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)](VRageMath.Vector4.Clamp)

> Restricts a value to be within a specified range.

[static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)](VRageMath.Vector4.Clamp)

> Restricts a value to be within a specified range.

[static float Distance(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Distance)

> Calculates the distance between two vectors.

[static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)](VRageMath.Vector4.Distance)

> Calculates the distance between two vectors.

[static float DistanceSquared(Vector4 value1, Vector4 value2)](VRageMath.Vector4.DistanceSquared)

> Calculates the distance between two vectors squared.

[static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)](VRageMath.Vector4.DistanceSquared)

> Calculates the distance between two vectors squared.

[static Vector4 Divide(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Divide)

> Divides the components of a vector by the components of another vector.

[static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Divide)

> Divides the components of a vector by the components of another vector.

[static Vector4 Divide(Vector4 value1, float divider)](VRageMath.Vector4.Divide)

> Divides a vector by a scalar value.

[static void Divide(ref Vector4 value1, float divider, out Vector4 result)](VRageMath.Vector4.Divide)

> Divides a vector by a scalar value.

[static float Dot(Vector4 vector1, Vector4 vector2)](VRageMath.Vector4.Dot)

> Calculates the dot product of two vectors.

[static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result)](VRageMath.Vector4.Dot)

> Calculates the dot product of two vectors.

[static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)](VRageMath.Vector4.Hermite)

> Performs a Hermite spline interpolation.

[static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)](VRageMath.Vector4.Hermite)

> Performs a Hermite spline interpolation.

[static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)](VRageMath.Vector4.Lerp)

> Performs a linear interpolation between two vectors.

[static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)](VRageMath.Vector4.Lerp)

> Performs a linear interpolation between two vectors.

[static Vector4 Max(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Max)

> Returns a vector that contains the highest value from each matching pair of components.

[static Vector4 Min(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Min)

> Returns a vector that contains the lowest value from each matching pair of components.

[static Vector4 Multiply(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Multiply)

> Multiplies the components of two vectors by each other.

[static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Multiply)

> Multiplies the components of two vectors by each other.

[static Vector4 Multiply(Vector4 value1, float scaleFactor)](VRageMath.Vector4.Multiply)

> Multiplies a vector by a scalar.

[static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)](VRageMath.Vector4.Multiply)

> Multiplies a vector by a scalar value.

[static Vector4 Negate(Vector4 value)](VRageMath.Vector4.Negate)

> Returns a vector pointing in the opposite direction.

[static void Negate(ref Vector4 value, out Vector4 result)](VRageMath.Vector4.Negate)

> Returns a vector pointing in the opposite direction.

[static Vector4 Normalize(Vector4 vector)](VRageMath.Vector4.Normalize)

> Creates a unit vector from the specified vector.

[static void Normalize(ref Vector4 vector, out Vector4 result)](VRageMath.Vector4.Normalize)

> Returns a normalized version of the specified vector.

[static Vector4 PackOrthoMatrix(Vector3 position, Vector3 forward, Vector3 up)](VRageMath.Vector4.PackOrthoMatrix)

> 

[static Vector4 PackOrthoMatrix(ref Matrix matrix)](VRageMath.Vector4.PackOrthoMatrix)

> 

[static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)](VRageMath.Vector4.SmoothStep)

> Interpolates between two values using a cubic equation.

[static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)](VRageMath.Vector4.SmoothStep)

> Interpolates between two values using a cubic equation.

[static Vector4 Subtract(Vector4 value1, Vector4 value2)](VRageMath.Vector4.Subtract)

> Subtracts a vector from a vector.

[static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)](VRageMath.Vector4.Subtract)

> Subtracts a vector from a vector.

[static Vector4 Transform(Vector2 position, Matrix matrix)](VRageMath.Vector4.Transform)

> Transforms a Vector2 by the given Matrix.

[static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector2 by the given Matrix.

[static Vector4 Transform(Vector3 position, Matrix matrix)](VRageMath.Vector4.Transform)

> Transforms a Vector3 by the given Matrix.

[static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector3 by the given Matrix.

[static Vector4 Transform(Vector4 vector, Matrix matrix)](VRageMath.Vector4.Transform)

> Transforms a Vector4 by the specified Matrix.

[static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector4 by the given Matrix.

[static Vector4 Transform(Vector2 value, Quaternion rotation)](VRageMath.Vector4.Transform)

> Transforms a Vector2 by a specified Quaternion into a Vector4.

[static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector2 by a specified Quaternion into a Vector4.

[static Vector4 Transform(Vector3 value, Quaternion rotation)](VRageMath.Vector4.Transform)

> Transforms a Vector3 by a specified Quaternion into a Vector4.

[static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector3 by a specified Quaternion into a Vector4.

[static Vector4 Transform(Vector4 value, Quaternion rotation)](VRageMath.Vector4.Transform)

> Transforms a Vector4 by a specified Quaternion.

[static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)](VRageMath.Vector4.Transform)

> Transforms a Vector4 by a specified Quaternion.

[static void Transform(Vector4&#91&#93; sourceArray, ref Matrix matrix, Vector4&#91&#93; destinationArray)](VRageMath.Vector4.Transform)

> Transforms an array of Vector4s by a specified Matrix.

[static void Transform(Vector4&#91&#93; sourceArray, int sourceIndex, ref Matrix matrix, Vector4&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector4.Transform)

> Transforms a specified range in an array of Vector4s by a specified Matrix into a specified range in a destination array.

[static void Transform(Vector4&#91&#93; sourceArray, ref Quaternion rotation, Vector4&#91&#93; destinationArray)](VRageMath.Vector4.Transform)

> Transforms an array of Vector4s by a specified Quaternion.

[static void Transform(Vector4&#91&#93; sourceArray, int sourceIndex, ref Quaternion rotation, Vector4&#91&#93; destinationArray, int destinationIndex, int length)](VRageMath.Vector4.Transform)

> Transforms a specified range in an array of Vector4s by a specified Quaternion into a specified range in a destination array.

[static Matrix UnpackOrthoMatrix(ref Vector4 packed)](VRageMath.Vector4.UnpackOrthoMatrix)

> 

[static void UnpackOrthoMatrix(ref Vector4 packed, out Matrix matrix)](VRageMath.Vector4.UnpackOrthoMatrix)

> 

[bool Equals(Vector4 other)](VRageMath.Vector4.Equals)

> Determines whether the specified Object is equal to the Vector4.

[bool Equals(object obj)](VRageMath.Vector4.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int GetHashCode()](VRageMath.Vector4.GetHashCode)

> Gets the hash code of this object.

[float Length()](VRageMath.Vector4.Length)

> Calculates the length of the vector.

[float LengthSquared()](VRageMath.Vector4.LengthSquared)

> Calculates the length of the vector squared.

[void Normalize()](VRageMath.Vector4.Normalize)

> Turns the current vector into a unit vector.

[string ToString()](VRageMath.Vector4.ToString)

> Retrieves a string representation of the current object.

