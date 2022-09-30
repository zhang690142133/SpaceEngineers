← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Quaternion Struct

```csharp
public struct Quaternion: IEquatable<Quaternion>
```

Defines a four-dimensional vector (x,y,z,w), which is used to efficiently rotate an object about the (x, y, z) vector by the angle theta, where w = cos(theta/2).

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Quaternion&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Quaternion Identity](VRageMath.Quaternion.Identity)

> 

[static Quaternion Zero](VRageMath.Quaternion.Zero)

> 

[float W](VRageMath.Quaternion.W)

> Specifies the rotation component of the quaternion.

[float X](VRageMath.Quaternion.X)

> Specifies the x-value of the vector component of the quaternion.

[float Y](VRageMath.Quaternion.Y)

> Specifies the y-value of the vector component of the quaternion.

[float Z](VRageMath.Quaternion.Z)

> Specifies the z-value of the vector component of the quaternion.

#### Properties

[Vector3 Forward { get; }](VRageMath.Quaternion.Forward)

> 

[Vector3 Right { get; }](VRageMath.Quaternion.Right)

> 

[Vector3 Up { get; }](VRageMath.Quaternion.Up)

> 

#### Constructors

[Quaternion(float x, float y, float z, float w)](VRageMath.Quaternion..ctor)

> 

[Quaternion(Vector3 vectorPart, float scalarPart)](VRageMath.Quaternion..ctor)

> 

#### 方法

[static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)](VRageMath.Quaternion.Add)

> Adds two Quaternions.

[static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)](VRageMath.Quaternion.Add)

> Adds two Quaternions.

[static Quaternion Concatenate(Quaternion value1, Quaternion value2)](VRageMath.Quaternion.Concatenate)

> Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

[static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)](VRageMath.Quaternion.Concatenate)

> Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

[static Quaternion Conjugate(Quaternion value)](VRageMath.Quaternion.Conjugate)

> Returns the conjugate of a specified Quaternion.

[static void Conjugate(ref Quaternion value, out Quaternion result)](VRageMath.Quaternion.Conjugate)

> Returns the conjugate of a specified Quaternion.

[static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)](VRageMath.Quaternion.CreateFromAxisAngle)

> Creates a Quaternion from a vector and an angle to rotate about the vector.

[static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)](VRageMath.Quaternion.CreateFromAxisAngle)

> Creates a Quaternion from a vector and an angle to rotate about the vector.

[static Quaternion CreateFromForwardUp(Vector3 forward, Vector3 up)](VRageMath.Quaternion.CreateFromForwardUp)

> Works for normalized vectors only

[static Quaternion CreateFromRotationMatrix(ref MatrixD matrix)](VRageMath.Quaternion.CreateFromRotationMatrix)

> 

[static Quaternion CreateFromRotationMatrix(Matrix matrix)](VRageMath.Quaternion.CreateFromRotationMatrix)

> Creates a Quaternion from a rotation Matrix.

[static void CreateFromRotationMatrix(ref MatrixD matrix, out Quaternion result)](VRageMath.Quaternion.CreateFromRotationMatrix)

> 

[static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)](VRageMath.Quaternion.CreateFromRotationMatrix)

> Creates a Quaternion from a rotation Matrix.

[static void CreateFromRotationMatrix(ref Matrix3x3 matrix, out Quaternion result)](VRageMath.Quaternion.CreateFromRotationMatrix)

> Creates a Quaternion from a rotation Matrix.

[static void CreateFromTwoVectors(ref Vector3 firstVector, ref Vector3 secondVector, out Quaternion result)](VRageMath.Quaternion.CreateFromTwoVectors)

> 

[static Quaternion CreateFromTwoVectors(Vector3 firstVector, Vector3 secondVector)](VRageMath.Quaternion.CreateFromTwoVectors)

> 

[static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)](VRageMath.Quaternion.CreateFromYawPitchRoll)

> Creates a new Quaternion from specified yaw, pitch, and roll angles.

[static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)](VRageMath.Quaternion.CreateFromYawPitchRoll)

> Creates a new Quaternion from specified yaw, pitch, and roll angles.

[static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)](VRageMath.Quaternion.Divide)

> Divides a Quaternion by another Quaternion.

[static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)](VRageMath.Quaternion.Divide)

> Divides a Quaternion by another Quaternion.

[static float Dot(Quaternion quaternion1, Quaternion quaternion2)](VRageMath.Quaternion.Dot)

> Calculates the dot product of two Quaternions.

[static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)](VRageMath.Quaternion.Dot)

> Calculates the dot product of two Quaternions.

[static Quaternion FromVector4(Vector4 v)](VRageMath.Quaternion.FromVector4)

> 

[static void GetForward(ref Quaternion q, out Vector3 result)](VRageMath.Quaternion.GetForward)

> Gets forward vector (0,0,-1) transformed by quaternion.

[static void GetRight(ref Quaternion q, out Vector3 result)](VRageMath.Quaternion.GetRight)

> Gets right vector (1,0,0) transformed by quaternion.

[static void GetUp(ref Quaternion q, out Vector3 result)](VRageMath.Quaternion.GetUp)

> Gets up vector (0,1,0) transformed by quaternion.

[static Quaternion Inverse(Quaternion quaternion)](VRageMath.Quaternion.Inverse)

> Returns the inverse of a Quaternion.

[static void Inverse(ref Quaternion quaternion, out Quaternion result)](VRageMath.Quaternion.Inverse)

> Returns the inverse of a Quaternion.

[static bool IsZero(Quaternion value)](VRageMath.Quaternion.IsZero)

> 

[static bool IsZero(Quaternion value, float epsilon)](VRageMath.Quaternion.IsZero)

> 

[static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)](VRageMath.Quaternion.Lerp)

> Linearly interpolates between two quaternions.

[static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)](VRageMath.Quaternion.Lerp)

> Linearly interpolates between two quaternions.

[static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)](VRageMath.Quaternion.Multiply)

> Multiplies two quaternions.

[static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)](VRageMath.Quaternion.Multiply)

> Multiplies two quaternions.

[static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)](VRageMath.Quaternion.Multiply)

> Multiplies a quaternion by a scalar value.

[static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)](VRageMath.Quaternion.Multiply)

> Multiplies a quaternion by a scalar value.

[static Quaternion Negate(Quaternion quaternion)](VRageMath.Quaternion.Negate)

> Flips the sign of each component of the quaternion.

[static void Negate(ref Quaternion quaternion, out Quaternion result)](VRageMath.Quaternion.Negate)

> Flips the sign of each component of the quaternion.

[static Quaternion Normalize(Quaternion quaternion)](VRageMath.Quaternion.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[static void Normalize(ref Quaternion quaternion, out Quaternion result)](VRageMath.Quaternion.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)](VRageMath.Quaternion.Slerp)

> Interpolates between two quaternions, using spherical linear interpolation.

[static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)](VRageMath.Quaternion.Slerp)

> Interpolates between two quaternions, using spherical linear interpolation.

[static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)](VRageMath.Quaternion.Subtract)

> Subtracts a quaternion from another quaternion.

[static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)](VRageMath.Quaternion.Subtract)

> Subtracts a quaternion from another quaternion.

[void Conjugate()](VRageMath.Quaternion.Conjugate)

> Transforms this Quaternion into its conjugate.

[bool Equals(Quaternion other)](VRageMath.Quaternion.Equals)

> Determines whether the specified Object is equal to the Quaternion.

[bool Equals(Quaternion value, float epsilon)](VRageMath.Quaternion.Equals)

> 

[bool Equals(object obj)](VRageMath.Quaternion.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int FindLargestIndex()](VRageMath.Quaternion.FindLargestIndex)

> 

[void GetAxisAngle(out Vector3 axis, out float angle)](VRageMath.Quaternion.GetAxisAngle)

> 

[float GetComponent(int index)](VRageMath.Quaternion.GetComponent)

> 

[int GetHashCode()](VRageMath.Quaternion.GetHashCode)

> Get the hash code of this object.

[float Length()](VRageMath.Quaternion.Length)

> Calculates the length of a Quaternion.

[float LengthSquared()](VRageMath.Quaternion.LengthSquared)

> Calculates the length squared of a Quaternion.

[void Normalize()](VRageMath.Quaternion.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[void SetComponent(int index, float value)](VRageMath.Quaternion.SetComponent)

> 

[string ToString()](VRageMath.Quaternion.ToString)

> Retireves a string representation of the current object.

[string ToString(string format)](VRageMath.Quaternion.ToString)

> 

[string ToStringAxisAngle(string format = "G")](VRageMath.Quaternion.ToStringAxisAngle)

> 

[Vector4 ToVector4()](VRageMath.Quaternion.ToVector4)

> 

