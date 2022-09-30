← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Matrix3x3 Struct

```csharp
public struct Matrix3x3: IEquatable<Matrix3x3>
```

Defines a matrix.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Matrix3x3&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Matrix3x3 Identity](VRageMath.Matrix3x3.Identity)

> 

[static Matrix3x3 Zero](VRageMath.Matrix3x3.Zero)

> 

[float M11](VRageMath.Matrix3x3.M11)

> Value at row 1 column 1 of the matrix.

[float M12](VRageMath.Matrix3x3.M12)

> Value at row 1 column 2 of the matrix.

[float M13](VRageMath.Matrix3x3.M13)

> Value at row 1 column 3 of the matrix.

[float M21](VRageMath.Matrix3x3.M21)

> Value at row 2 column 1 of the matrix.

[float M22](VRageMath.Matrix3x3.M22)

> Value at row 2 column 2 of the matrix.

[float M23](VRageMath.Matrix3x3.M23)

> Value at row 2 column 3 of the matrix.

[float M31](VRageMath.Matrix3x3.M31)

> Value at row 3 column 1 of the matrix.

[float M32](VRageMath.Matrix3x3.M32)

> Value at row 3 column 2 of the matrix.

[float M33](VRageMath.Matrix3x3.M33)

> Value at row 3 column 3 of the matrix.

#### Properties

[Vector3 Backward { get; set; }](VRageMath.Matrix3x3.Backward)

> Gets and sets the backward vector of the Matrix3x3.

[Vector3 Col0 { get; }](VRageMath.Matrix3x3.Col0)

> 

[Vector3 Col1 { get; }](VRageMath.Matrix3x3.Col1)

> 

[Vector3 Col2 { get; }](VRageMath.Matrix3x3.Col2)

> 

[Vector3 Down { get; set; }](VRageMath.Matrix3x3.Down)

> Gets and sets the down vector of the Matrix3x3.

[Vector3 Forward { get; set; }](VRageMath.Matrix3x3.Forward)

> Gets and sets the forward vector of the Matrix3x3.

[float Item { get; set; }](VRageMath.Matrix3x3.Item)

> 

[Vector3 Left { get; set; }](VRageMath.Matrix3x3.Left)

> Gets and sets the left vector of the Matrix3x3.

[Vector3 Right { get; set; }](VRageMath.Matrix3x3.Right)

> Gets and sets the right vector of the Matrix3x3.

[Vector3 Scale { get; }](VRageMath.Matrix3x3.Scale)

> 

[Vector3 Up { get; set; }](VRageMath.Matrix3x3.Up)

> Gets and sets the up vector of the Matrix3x3.

#### Constructors

[Matrix3x3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)](VRageMath.Matrix3x3..ctor)

> 

[Matrix3x3(Matrix3x3 other)](VRageMath.Matrix3x3..ctor)

> 

[Matrix3x3(MatrixD other)](VRageMath.Matrix3x3..ctor)

> 

#### 方法

[static void Add(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)](VRageMath.Matrix3x3.Add)

> Adds a matrix to another matrix.

[static Matrix3x3 AlignRotationToAxes(ref Matrix3x3 toAlign, ref Matrix3x3 axisDefinitionMatrix)](VRageMath.Matrix3x3.AlignRotationToAxes)

> 

[static Matrix3x3 CreateFromAxisAngle(Vector3 axis, float angle)](VRageMath.Matrix3x3.CreateFromAxisAngle)

> Creates a new Matrix3x3 that rotates around an arbitrary vector.

[static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateFromAxisAngle)

> Creates a new Matrix3x3 that rotates around an arbitrary vector.

[static Matrix3x3 CreateFromDir(Vector3 dir)](VRageMath.Matrix3x3.CreateFromDir)

> 

[static Matrix3x3 CreateFromDir(Vector3 dir, Vector3 suggestedUp)](VRageMath.Matrix3x3.CreateFromDir)

> 

[static Matrix3x3 CreateFromQuaternion(Quaternion quaternion)](VRageMath.Matrix3x3.CreateFromQuaternion)

> Creates a rotation Matrix3x3 from a Quaternion.

[static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateFromQuaternion)

> Creates a rotation Matrix3x3 from a Quaternion.

[static Matrix3x3 CreateFromYawPitchRoll(float yaw, float pitch, float roll)](VRageMath.Matrix3x3.CreateFromYawPitchRoll)

> Creates a new rotation matrix from a specified yaw, pitch, and roll.

[static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateFromYawPitchRoll)

> Fills in a rotation matrix from a specified yaw, pitch, and roll.

[static void CreateRotationFromTwoVectors(ref Vector3 fromVector, ref Vector3 toVector, out Matrix3x3 resultMatrix)](VRageMath.Matrix3x3.CreateRotationFromTwoVectors)

> 

[static Matrix3x3 CreateRotationX(float radians)](VRageMath.Matrix3x3.CreateRotationX)

> Returns a matrix that can be used to rotate a set of vertices around the x-axis.

[static void CreateRotationX(float radians, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateRotationX)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

[static Matrix3x3 CreateRotationY(float radians)](VRageMath.Matrix3x3.CreateRotationY)

> Returns a matrix that can be used to rotate a set of vertices around the y-axis.

[static void CreateRotationY(float radians, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateRotationY)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

[static Matrix3x3 CreateRotationZ(float radians)](VRageMath.Matrix3x3.CreateRotationZ)

> Returns a matrix that can be used to rotate a set of vertices around the z-axis.

[static void CreateRotationZ(float radians, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateRotationZ)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

[static Matrix3x3 CreateScale(float xScale, float yScale, float zScale)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static void CreateScale(float xScale, float yScale, float zScale, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static Matrix3x3 CreateScale(Vector3 scales)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static void CreateScale(ref Vector3 scales, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static Matrix3x3 CreateScale(float scale)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static void CreateScale(float scale, out Matrix3x3 result)](VRageMath.Matrix3x3.CreateScale)

> Creates a scaling Matrix3x3.

[static Matrix3x3 CreateWorld(ref Vector3 forward, ref Vector3 up)](VRageMath.Matrix3x3.CreateWorld)

> Creates a world matrix with the specified parameters.

[static void Divide(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)](VRageMath.Matrix3x3.Divide)

> Divides the components of a matrix by the corresponding components of another matrix.

[static void Divide(ref Matrix3x3 matrix1, float divider, out Matrix3x3 result)](VRageMath.Matrix3x3.Divide)

> Divides the components of a matrix by a scalar.

[static bool GetEulerAnglesXYZ(ref Matrix3x3 mat, out Vector3 xyz)](VRageMath.Matrix3x3.GetEulerAnglesXYZ)

> 

[static void Invert(ref Matrix3x3 matrix, out Matrix3x3 result)](VRageMath.Matrix3x3.Invert)

> Calculates the inverse of a matrix.

[static void Lerp(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)](VRageMath.Matrix3x3.Lerp)

> Linearly interpolates between the corresponding values of two matrices.

[static void Multiply(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)](VRageMath.Matrix3x3.Multiply)

> Multiplies a matrix by another matrix.

[static void Multiply(ref Matrix3x3 matrix1, float scaleFactor, out Matrix3x3 result)](VRageMath.Matrix3x3.Multiply)

> Multiplies a matrix by a scalar value.

[static void Negate(ref Matrix3x3 matrix, out Matrix3x3 result)](VRageMath.Matrix3x3.Negate)

> Negates individual elements of a matrix.

[static Matrix3x3 Normalize(Matrix3x3 matrix)](VRageMath.Matrix3x3.Normalize)

> 

[static Matrix3x3 Orthogonalize(Matrix3x3 rotationMatrix)](VRageMath.Matrix3x3.Orthogonalize)

> 

[static void Rescale(ref Matrix3x3 matrix, float scale)](VRageMath.Matrix3x3.Rescale)

> Same result as Matrix3x3.CreateScale(scale) * matrix, but much faster

[static void Rescale(ref Matrix3x3 matrix, ref Vector3 scale)](VRageMath.Matrix3x3.Rescale)

> Same result as Matrix3x3.CreateScale(scale) * matrix, but much faster

[static Matrix3x3 Rescale(Matrix3x3 matrix, float scale)](VRageMath.Matrix3x3.Rescale)

> 

[static Matrix3x3 Rescale(Matrix3x3 matrix, Vector3 scale)](VRageMath.Matrix3x3.Rescale)

> 

[static Matrix3x3 Round(ref Matrix3x3 matrix)](VRageMath.Matrix3x3.Round)

> 

[static void Slerp(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)](VRageMath.Matrix3x3.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static void SlerpScale(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)](VRageMath.Matrix3x3.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static void Subtract(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)](VRageMath.Matrix3x3.Subtract)

> Subtracts matrices.

[static void Transform(ref Matrix3x3 value, ref Quaternion rotation, out Matrix3x3 result)](VRageMath.Matrix3x3.Transform)

> Transforms a Matrix3x3 by applying a Quaternion rotation.

[static void Transpose(ref Matrix3x3 matrix, out Matrix3x3 result)](VRageMath.Matrix3x3.Transpose)

> Transposes the rows and columns of a matrix.

[void AssertIsValid()](VRageMath.Matrix3x3.AssertIsValid)

> 

[float Determinant()](VRageMath.Matrix3x3.Determinant)

> 

[bool Equals(Matrix3x3 other)](VRageMath.Matrix3x3.Equals)

> Determines whether the specified Object is equal to the Matrix3x3.

[bool Equals(object obj)](VRageMath.Matrix3x3.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[bool EqualsFast(ref Matrix3x3 other, float epsilon = 0.0001)](VRageMath.Matrix3x3.EqualsFast)

> Compares just position, forward and up

[Direction GetClosestDirection(Vector3 referenceVector)](VRageMath.Matrix3x3.GetClosestDirection)

> 

[Direction GetClosestDirection(ref Vector3 referenceVector)](VRageMath.Matrix3x3.GetClosestDirection)

> 

[Vector3 GetDirectionVector(Direction direction)](VRageMath.Matrix3x3.GetDirectionVector)

> 

[int GetHashCode()](VRageMath.Matrix3x3.GetHashCode)

> Gets the hash code of this object.

[Matrix3x3 GetOrientation()](VRageMath.Matrix3x3.GetOrientation)

> Gets the orientation.

[Vector3 GetRow(int row)](VRageMath.Matrix3x3.GetRow)

> 

[bool IsMirrored()](VRageMath.Matrix3x3.IsMirrored)

> 

[bool IsNan()](VRageMath.Matrix3x3.IsNan)

> 

[bool IsOrthogonal()](VRageMath.Matrix3x3.IsOrthogonal)

> 

[bool IsRotation()](VRageMath.Matrix3x3.IsRotation)

> 

[bool IsValid()](VRageMath.Matrix3x3.IsValid)

> 

[void SetDirectionVector(Direction direction, Vector3 newValue)](VRageMath.Matrix3x3.SetDirectionVector)

> 

[void SetRow(int row, Vector3 value)](VRageMath.Matrix3x3.SetRow)

> 

[string ToString()](VRageMath.Matrix3x3.ToString)

> Retrieves a string representation of the current object.

[void Transpose()](VRageMath.Matrix3x3.Transpose)

> 

