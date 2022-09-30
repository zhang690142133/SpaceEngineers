← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### QuaternionD Struct

```csharp
public struct QuaternionD
```

Defines a four-dimensional vector (x,y,z,w), which is used to efficiently rotate an object about the (x, y, z) vector by the angle theta, where w = cos(theta/2). Uses double precision floating point numbers for calculation and storage

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static QuaternionD Identity](VRageMath.QuaternionD.Identity)

> 

[double W](VRageMath.QuaternionD.W)

> Specifies the rotation component of the quaternion.

[double X](VRageMath.QuaternionD.X)

> Specifies the x-value of the vector component of the quaternion.

[double Y](VRageMath.QuaternionD.Y)

> Specifies the y-value of the vector component of the quaternion.

[double Z](VRageMath.QuaternionD.Z)

> Specifies the z-value of the vector component of the quaternion.

#### Constructors

[QuaternionD(double x, double y, double z, double w)](VRageMath.QuaternionD..ctor)

> 

[QuaternionD(Vector3D vectorPart, double scalarPart)](VRageMath.QuaternionD..ctor)

> 

#### 方法

[static QuaternionD Add(QuaternionD quaternion1, QuaternionD quaternion2)](VRageMath.QuaternionD.Add)

> Adds two Quaternions.

[static void Add(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)](VRageMath.QuaternionD.Add)

> Adds two Quaternions.

[static QuaternionD Concatenate(QuaternionD value1, QuaternionD value2)](VRageMath.QuaternionD.Concatenate)

> Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

[static void Concatenate(ref QuaternionD value1, ref QuaternionD value2, out QuaternionD result)](VRageMath.QuaternionD.Concatenate)

> Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

[static QuaternionD Conjugate(QuaternionD value)](VRageMath.QuaternionD.Conjugate)

> Returns the conjugate of a specified QuaternionD.

[static void Conjugate(ref QuaternionD value, out QuaternionD result)](VRageMath.QuaternionD.Conjugate)

> Returns the conjugate of a specified QuaternionD.

[static QuaternionD CreateFromAxisAngle(Vector3D axis, double angle)](VRageMath.QuaternionD.CreateFromAxisAngle)

> Creates a QuaternionD from a vector and an angle to rotate about the vector.

[static void CreateFromAxisAngle(ref Vector3D axis, double angle, out QuaternionD result)](VRageMath.QuaternionD.CreateFromAxisAngle)

> Creates a QuaternionD from a vector and an angle to rotate about the vector.

[static QuaternionD CreateFromForwardUp(Vector3D forward, Vector3D up)](VRageMath.QuaternionD.CreateFromForwardUp)

> Works for normalized vectors only

[static QuaternionD CreateFromRotationMatrix(MatrixD matrix)](VRageMath.QuaternionD.CreateFromRotationMatrix)

> Creates a QuaternionD from a rotation MatrixD.

[static void CreateFromRotationMatrix(ref MatrixD matrix, out QuaternionD result)](VRageMath.QuaternionD.CreateFromRotationMatrix)

> Creates a QuaternionD from a rotation MatrixD.

[static void CreateFromTwoVectors(ref Vector3D firstVector, ref Vector3D secondVector, out QuaternionD result)](VRageMath.QuaternionD.CreateFromTwoVectors)

> 

[static QuaternionD CreateFromTwoVectors(Vector3D firstVector, Vector3D secondVector)](VRageMath.QuaternionD.CreateFromTwoVectors)

> 

[static QuaternionD CreateFromYawPitchRoll(double yaw, double pitch, double roll)](VRageMath.QuaternionD.CreateFromYawPitchRoll)

> Creates a new QuaternionD from specified yaw, pitch, and roll angles.

[static void CreateFromYawPitchRoll(double yaw, double pitch, double roll, out QuaternionD result)](VRageMath.QuaternionD.CreateFromYawPitchRoll)

> Creates a new QuaternionD from specified yaw, pitch, and roll angles.

[static QuaternionD Divide(QuaternionD quaternion1, QuaternionD quaternion2)](VRageMath.QuaternionD.Divide)

> Divides a QuaternionD by another QuaternionD.

[static void Divide(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)](VRageMath.QuaternionD.Divide)

> Divides a QuaternionD by another QuaternionD.

[static double Dot(QuaternionD quaternion1, QuaternionD quaternion2)](VRageMath.QuaternionD.Dot)

> Calculates the dot product of two Quaternions.

[static void Dot(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out double result)](VRageMath.QuaternionD.Dot)

> Calculates the dot product of two Quaternions.

[static QuaternionD FromVector4(Vector4D v)](VRageMath.QuaternionD.FromVector4)

> 

[static QuaternionD Inverse(QuaternionD quaternion)](VRageMath.QuaternionD.Inverse)

> Returns the inverse of a QuaternionD.

[static void Inverse(ref QuaternionD quaternion, out QuaternionD result)](VRageMath.QuaternionD.Inverse)

> Returns the inverse of a QuaternionD.

[static bool IsZero(QuaternionD value)](VRageMath.QuaternionD.IsZero)

> 

[static bool IsZero(QuaternionD value, double epsilon)](VRageMath.QuaternionD.IsZero)

> 

[static QuaternionD Lerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount)](VRageMath.QuaternionD.Lerp)

> Linearly interpolates between two quaternions.

[static void Lerp(ref QuaternionD quaternion1, ref QuaternionD quaternion2, double amount, out QuaternionD result)](VRageMath.QuaternionD.Lerp)

> Linearly interpolates between two quaternions.

[static QuaternionD Multiply(QuaternionD quaternion1, QuaternionD quaternion2)](VRageMath.QuaternionD.Multiply)

> Multiplies two quaternions.

[static void Multiply(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)](VRageMath.QuaternionD.Multiply)

> Multiplies two quaternions.

[static QuaternionD Multiply(QuaternionD quaternion1, double scaleFactor)](VRageMath.QuaternionD.Multiply)

> Multiplies a quaternion by a scalar value.

[static void Multiply(ref QuaternionD quaternion1, double scaleFactor, out QuaternionD result)](VRageMath.QuaternionD.Multiply)

> Multiplies a quaternion by a scalar value.

[static QuaternionD Negate(QuaternionD quaternion)](VRageMath.QuaternionD.Negate)

> Flips the sign of each component of the quaternion.

[static void Negate(ref QuaternionD quaternion, out QuaternionD result)](VRageMath.QuaternionD.Negate)

> Flips the sign of each component of the quaternion.

[static QuaternionD Normalize(QuaternionD quaternion)](VRageMath.QuaternionD.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[static void Normalize(ref QuaternionD quaternion, out QuaternionD result)](VRageMath.QuaternionD.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[static QuaternionD Slerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount)](VRageMath.QuaternionD.Slerp)

> Interpolates between two quaternions, using spherical linear interpolation.

[static void Slerp(ref QuaternionD quaternion1, ref QuaternionD quaternion2, double amount, out QuaternionD result)](VRageMath.QuaternionD.Slerp)

> Interpolates between two quaternions, using spherical linear interpolation.

[static QuaternionD Subtract(QuaternionD quaternion1, QuaternionD quaternion2)](VRageMath.QuaternionD.Subtract)

> Subtracts a quaternion from another quaternion.

[static void Subtract(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)](VRageMath.QuaternionD.Subtract)

> Subtracts a quaternion from another quaternion.

[void Conjugate()](VRageMath.QuaternionD.Conjugate)

> Transforms this QuaternionD into its conjugate.

[bool Equals(QuaternionD other)](VRageMath.QuaternionD.Equals)

> Determines whether the specified Object is equal to the QuaternionD.

[bool Equals(object obj)](VRageMath.QuaternionD.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[void GetAxisAngle(out Vector3D axis, out double angle)](VRageMath.QuaternionD.GetAxisAngle)

> 

[int GetHashCode()](VRageMath.QuaternionD.GetHashCode)

> Get the hash code of this object.

[double Length()](VRageMath.QuaternionD.Length)

> Calculates the length of a QuaternionD.

[double LengthSquared()](VRageMath.QuaternionD.LengthSquared)

> Calculates the length squared of a QuaternionD.

[void Normalize()](VRageMath.QuaternionD.Normalize)

> Divides each component of the quaternion by the length of the quaternion.

[string ToString()](VRageMath.QuaternionD.ToString)

> Retireves a string representation of the current object.

[Vector4D ToVector4()](VRageMath.QuaternionD.ToVector4)

> 

