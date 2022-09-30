← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Matrix Struct

```csharp
public struct Matrix: IEquatable<Matrix>
```

Defines a matrix.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Matrix&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static Matrix Identity](VRageMath.Matrix.Identity)

> 

[static Matrix Zero](VRageMath.Matrix.Zero)

> 

[float M11](VRageMath.Matrix.M11)

> Value at row 1 column 1 of the matrix.

[float M12](VRageMath.Matrix.M12)

> Value at row 1 column 2 of the matrix.

[float M13](VRageMath.Matrix.M13)

> Value at row 1 column 3 of the matrix.

[float M14](VRageMath.Matrix.M14)

> Value at row 1 column 4 of the matrix.

[float M21](VRageMath.Matrix.M21)

> Value at row 2 column 1 of the matrix.

[float M22](VRageMath.Matrix.M22)

> Value at row 2 column 2 of the matrix.

[float M23](VRageMath.Matrix.M23)

> Value at row 2 column 3 of the matrix.

[float M24](VRageMath.Matrix.M24)

> Value at row 2 column 4 of the matrix.

[float M31](VRageMath.Matrix.M31)

> Value at row 3 column 1 of the matrix.

[float M32](VRageMath.Matrix.M32)

> Value at row 3 column 2 of the matrix.

[float M33](VRageMath.Matrix.M33)

> Value at row 3 column 3 of the matrix.

[float M34](VRageMath.Matrix.M34)

> Value at row 3 column 4 of the matrix.

[float M41](VRageMath.Matrix.M41)

> Value at row 4 column 1 of the matrix.

[float M42](VRageMath.Matrix.M42)

> Value at row 4 column 2 of the matrix.

[float M43](VRageMath.Matrix.M43)

> Value at row 4 column 3 of the matrix.

[float M44](VRageMath.Matrix.M44)

> Value at row 4 column 4 of the matrix.

#### Properties

[Vector3 Backward { get; set; }](VRageMath.Matrix.Backward)

> Gets and sets the backward vector of the Matrix.

[Vector3 Col0 { get; }](VRageMath.Matrix.Col0)

> 

[Vector3 Col1 { get; }](VRageMath.Matrix.Col1)

> 

[Vector3 Col2 { get; }](VRageMath.Matrix.Col2)

> 

[Vector3 Down { get; set; }](VRageMath.Matrix.Down)

> Gets and sets the down vector of the Matrix.

[Vector3 Forward { get; set; }](VRageMath.Matrix.Forward)

> Gets and sets the forward vector of the Matrix.

[float Item { get; set; }](VRageMath.Matrix.Item)

> 

[Vector3 Left { get; set; }](VRageMath.Matrix.Left)

> Gets and sets the left vector of the Matrix.

[Vector3 Right { get; set; }](VRageMath.Matrix.Right)

> Gets and sets the right vector of the Matrix.

[Vector3 Scale { get; }](VRageMath.Matrix.Scale)

> 

[Vector3 Translation { get; set; }](VRageMath.Matrix.Translation)

> Gets and sets the translation vector of the Matrix.

[Vector3 Up { get; set; }](VRageMath.Matrix.Up)

> Gets and sets the up vector of the Matrix.

#### Constructors

[Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)](VRageMath.Matrix..ctor)

> 

[Matrix(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)](VRageMath.Matrix..ctor)

> 

[Matrix(MatrixD other)](VRageMath.Matrix..ctor)

> 

#### 方法

[static Matrix Add(Matrix matrix1, Matrix matrix2)](VRageMath.Matrix.Add)

> Adds a matrix to another matrix.

[static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)](VRageMath.Matrix.Add)

> Adds a matrix to another matrix.

[static Matrix AlignRotationToAxes(ref Matrix toAlign, ref Matrix axisDefinitionMatrix)](VRageMath.Matrix.AlignRotationToAxes)

> 

[static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)](VRageMath.Matrix.CreateBillboard)

> Creates a spherical billboard that rotates around a specified object position.

[static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result)](VRageMath.Matrix.CreateBillboard)

> Creates a spherical billboard that rotates around a specified object position.

[static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)](VRageMath.Matrix.CreateConstrainedBillboard)

> Creates a cylindrical billboard that rotates around a specified axis.

[static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)](VRageMath.Matrix.CreateConstrainedBillboard)

> Creates a cylindrical billboard that rotates around a specified axis.

[static Matrix CreateFromAxisAngle(Vector3 axis, float angle)](VRageMath.Matrix.CreateFromAxisAngle)

> Creates a new Matrix that rotates around an arbitrary vector.

[static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)](VRageMath.Matrix.CreateFromAxisAngle)

> Creates a new Matrix that rotates around an arbitrary vector.

[static Matrix CreateFromDir(Vector3 dir)](VRageMath.Matrix.CreateFromDir)

> 

[static Matrix CreateFromDir(Vector3 dir, Vector3 suggestedUp)](VRageMath.Matrix.CreateFromDir)

> 

[static Matrix CreateFromPerspectiveFieldOfView(ref Matrix proj, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreateFromPerspectiveFieldOfView)

> 

[static Matrix CreateFromQuaternion(Quaternion quaternion)](VRageMath.Matrix.CreateFromQuaternion)

> Creates a rotation Matrix from a Quaternion.

[static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)](VRageMath.Matrix.CreateFromQuaternion)

> Creates a rotation Matrix from a Quaternion.

[static Matrix CreateFromTransformScale(Quaternion orientation, Vector3 position, Vector3 scale)](VRageMath.Matrix.CreateFromTransformScale)

> 

[static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)](VRageMath.Matrix.CreateFromYawPitchRoll)

> Creates a new rotation matrix from a specified yaw, pitch, and roll.

[static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result)](VRageMath.Matrix.CreateFromYawPitchRoll)

> Fills in a rotation matrix from a specified yaw, pitch, and roll.

[static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)](VRageMath.Matrix.CreateLookAt)

> Creates a view matrix.

[static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result)](VRageMath.Matrix.CreateLookAt)

> Creates a view matrix.

[static Matrix CreateLookAtInverse(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)](VRageMath.Matrix.CreateLookAtInverse)

> 

[static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)](VRageMath.Matrix.CreateOrthographic)

> Builds an orthogonal projection matrix.

[static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)](VRageMath.Matrix.CreateOrthographic)

> Builds an orthogonal projection matrix.

[static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)](VRageMath.Matrix.CreateOrthographicOffCenter)

> Builds a customized, orthogonal projection matrix.

[static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)](VRageMath.Matrix.CreateOrthographicOffCenter)

> Builds a customized, orthogonal projection matrix.

[static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreatePerspective)

> Builds a perspective projection matrix and returns the result by value.

[static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result)](VRageMath.Matrix.CreatePerspective)

> Builds a perspective projection matrix and returns the result by reference.

[static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFieldOfView)

> Builds a perspective projection matrix based on a field of view and returns by value.

[static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)](VRageMath.Matrix.CreatePerspectiveFieldOfView)

> Builds a perspective projection matrix based on a field of view and returns by reference.

[static Matrix CreatePerspectiveFovRhComplementary(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhComplementary)

> 

[static Matrix CreatePerspectiveFovRhInfinite(float fieldOfView, float aspectRatio, float nearPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhInfinite)

> 

[static Matrix CreatePerspectiveFovRhInfiniteComplementary(float fieldOfView, float aspectRatio, float nearPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhInfiniteComplementary)

> 

[static Matrix CreatePerspectiveFovRhInfiniteComplementaryInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhInfiniteComplementaryInverse)

> 

[static Matrix CreatePerspectiveFovRhInfiniteInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhInfiniteInverse)

> 

[static Matrix CreatePerspectiveFovRhInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreatePerspectiveFovRhInverse)

> 

[static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)](VRageMath.Matrix.CreatePerspectiveOffCenter)

> Builds a customized, perspective projection matrix.

[static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)](VRageMath.Matrix.CreatePerspectiveOffCenter)

> Builds a customized, perspective projection matrix.

[static Matrix CreateReflection(Plane value)](VRageMath.Matrix.CreateReflection)

> Creates a Matrix that reflects the coordinate system about a specified Plane.

[static void CreateReflection(ref Plane value, out Matrix result)](VRageMath.Matrix.CreateReflection)

> Fills in an existing Matrix so that it reflects the coordinate system about a specified Plane.

[static void CreateRotationFromTwoVectors(ref Vector3 fromVector, ref Vector3 toVector, out Matrix resultMatrix)](VRageMath.Matrix.CreateRotationFromTwoVectors)

> 

[static Matrix CreateRotationX(float radians)](VRageMath.Matrix.CreateRotationX)

> Returns a matrix that can be used to rotate a set of vertices around the x-axis.

[static void CreateRotationX(float radians, out Matrix result)](VRageMath.Matrix.CreateRotationX)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

[static Matrix CreateRotationY(float radians)](VRageMath.Matrix.CreateRotationY)

> Returns a matrix that can be used to rotate a set of vertices around the y-axis.

[static void CreateRotationY(float radians, out Matrix result)](VRageMath.Matrix.CreateRotationY)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

[static Matrix CreateRotationZ(float radians)](VRageMath.Matrix.CreateRotationZ)

> Returns a matrix that can be used to rotate a set of vertices around the z-axis.

[static void CreateRotationZ(float radians, out Matrix result)](VRageMath.Matrix.CreateRotationZ)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

[static Matrix CreateScale(float xScale, float yScale, float zScale)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static Matrix CreateScale(Vector3 scales)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(ref Vector3 scales, out Matrix result)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static Matrix CreateScale(float scale)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(float scale, out Matrix result)](VRageMath.Matrix.CreateScale)

> Creates a scaling Matrix.

[static Matrix CreateShadow(Vector3 lightDirection, Plane plane)](VRageMath.Matrix.CreateShadow)

> Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

[static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)](VRageMath.Matrix.CreateShadow)

> Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

[static Matrix CreateTranslation(Vector3 position)](VRageMath.Matrix.CreateTranslation)

> Creates a translation Matrix.

[static void CreateTranslation(ref Vector3 position, out Matrix result)](VRageMath.Matrix.CreateTranslation)

> Creates a translation Matrix.

[static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)](VRageMath.Matrix.CreateTranslation)

> Creates a translation Matrix.

[static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)](VRageMath.Matrix.CreateTranslation)

> Creates a translation Matrix.

[static Matrix CreateWorld(Vector3 position)](VRageMath.Matrix.CreateWorld)

> 

[static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)](VRageMath.Matrix.CreateWorld)

> Creates a world matrix with the specified parameters.

[static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)](VRageMath.Matrix.CreateWorld)

> Creates a world matrix with the specified parameters.

[static Matrix Divide(Matrix matrix1, Matrix matrix2)](VRageMath.Matrix.Divide)

> Divides the components of a matrix by the corresponding components of another matrix.

[static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)](VRageMath.Matrix.Divide)

> Divides the components of a matrix by the corresponding components of another matrix.

[static Matrix Divide(Matrix matrix1, float divider)](VRageMath.Matrix.Divide)

> Divides the components of a matrix by a scalar.

[static void Divide(ref Matrix matrix1, float divider, out Matrix result)](VRageMath.Matrix.Divide)

> Divides the components of a matrix by a scalar.

[static bool GetEulerAnglesXYZ(ref Matrix mat, out Vector3 xyz)](VRageMath.Matrix.GetEulerAnglesXYZ)

> 

[static Matrix Invert(Matrix matrix)](VRageMath.Matrix.Invert)

> Calculates the inverse of a matrix.

[static Matrix Invert(ref Matrix matrix)](VRageMath.Matrix.Invert)

> 

[static void Invert(ref Matrix matrix, out Matrix result)](VRageMath.Matrix.Invert)

> Calculates the inverse of a matrix.

[static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)](VRageMath.Matrix.Lerp)

> Linearly interpolates between the corresponding values of two matrices.

[static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)](VRageMath.Matrix.Lerp)

> Linearly interpolates between the corresponding values of two matrices.

[static Matrix Multiply(Matrix matrix1, Matrix matrix2)](VRageMath.Matrix.Multiply)

> Multiplies a matrix by another matrix.

[static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)](VRageMath.Matrix.Multiply)

> Multiplies a matrix by another matrix.

[static Matrix Multiply(Matrix matrix1, float scaleFactor)](VRageMath.Matrix.Multiply)

> Multiplies a matrix by a scalar value.

[static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result)](VRageMath.Matrix.Multiply)

> Multiplies a matrix by a scalar value.

[static void MultiplyRotation(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)](VRageMath.Matrix.MultiplyRotation)

> Multiplies a matrix by another matrix, only rotation parts.

[static Matrix Negate(Matrix matrix)](VRageMath.Matrix.Negate)

> Negates individual elements of a matrix.

[static void Negate(ref Matrix matrix, out Matrix result)](VRageMath.Matrix.Negate)

> Negates individual elements of a matrix.

[static Matrix Normalize(Matrix matrix)](VRageMath.Matrix.Normalize)

> 

[static Matrix Orthogonalize(Matrix rotationMatrix)](VRageMath.Matrix.Orthogonalize)

> 

[static void Rescale(ref Matrix matrix, float scale)](VRageMath.Matrix.Rescale)

> Same result as Matrix.CreateScale(scale) * matrix, but much faster

[static void Rescale(ref Matrix matrix, ref Vector3 scale)](VRageMath.Matrix.Rescale)

> Same result as Matrix.CreateScale(scale) * matrix, but much faster

[static Matrix Rescale(Matrix matrix, float scale)](VRageMath.Matrix.Rescale)

> 

[static Matrix Rescale(Matrix matrix, Vector3 scale)](VRageMath.Matrix.Rescale)

> 

[static Matrix Round(ref Matrix matrix)](VRageMath.Matrix.Round)

> 

[static void Slerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)](VRageMath.Matrix.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static void Slerp(Matrix matrix1, Matrix matrix2, float amount, out Matrix result)](VRageMath.Matrix.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static Matrix Slerp(Matrix matrix1, Matrix matrix2, float amount)](VRageMath.Matrix.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static void SlerpScale(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)](VRageMath.Matrix.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static void SlerpScale(Matrix matrix1, Matrix matrix2, float amount, out Matrix result)](VRageMath.Matrix.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static Matrix SlerpScale(Matrix matrix1, Matrix matrix2, float amount)](VRageMath.Matrix.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)](VRageMath.Matrix.Subtract)

> Subtracts matrices.

[static Matrix Subtract(Matrix matrix1, Matrix matrix2)](VRageMath.Matrix.Subtract)

> Subtracts matrices.

[static Matrix SwapYZCoordinates(Matrix m)](VRageMath.Matrix.SwapYZCoordinates)

> 

[static Matrix Transform(Matrix value, Quaternion rotation)](VRageMath.Matrix.Transform)

> Transforms a Matrix by applying a Quaternion rotation.

[static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)](VRageMath.Matrix.Transform)

> Transforms a Matrix by applying a Quaternion rotation.

[static Matrix Transpose(Matrix matrix)](VRageMath.Matrix.Transpose)

> Transposes the rows and columns of a matrix.

[static void Transpose(ref Matrix matrix, out Matrix result)](VRageMath.Matrix.Transpose)

> Transposes the rows and columns of a matrix.

[void AssertIsValid()](VRageMath.Matrix.AssertIsValid)

> 

[float Determinant()](VRageMath.Matrix.Determinant)

> Calculates the determinant of the matrix.

[bool Equals(Matrix other)](VRageMath.Matrix.Equals)

> Determines whether the specified Object is equal to the Matrix.

[bool Equals(object obj)](VRageMath.Matrix.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[bool EqualsFast(ref Matrix other, float epsilon = 0.0001)](VRageMath.Matrix.EqualsFast)

> Compares just position, forward and up

[Direction GetClosestDirection(Vector3 referenceVector)](VRageMath.Matrix.GetClosestDirection)

> 

[Direction GetClosestDirection(ref Vector3 referenceVector)](VRageMath.Matrix.GetClosestDirection)

> 

[Vector3 GetDirectionVector(Direction direction)](VRageMath.Matrix.GetDirectionVector)

> 

[int GetHashCode()](VRageMath.Matrix.GetHashCode)

> Gets the hash code of this object.

[Matrix GetOrientation()](VRageMath.Matrix.GetOrientation)

> Gets the orientation.

[Vector4 GetRow(int row)](VRageMath.Matrix.GetRow)

> 

[bool HasNoTranslationOrPerspective()](VRageMath.Matrix.HasNoTranslationOrPerspective)

> Returns true if this matrix represents invertible (you can call Invert on it) linear (it does not contain translation or perspective transformation) transformation. Such matrix consist solely of rotations, shearing, mirroring and scaling. It can be orthogonalized to create an orthogonal rotation matrix.

[bool IsMirrored()](VRageMath.Matrix.IsMirrored)

> 

[bool IsNan()](VRageMath.Matrix.IsNan)

> 

[bool IsOrthogonal()](VRageMath.Matrix.IsOrthogonal)

> 

[bool IsRotation()](VRageMath.Matrix.IsRotation)

> 

[bool IsValid()](VRageMath.Matrix.IsValid)

> 

[void SetDirectionVector(Direction direction, Vector3 newValue)](VRageMath.Matrix.SetDirectionVector)

> 

[void SetFrom(ref MatrixD m)](VRageMath.Matrix.SetFrom)

> Set this ma

[void SetRotationAndScale(ref MatrixD m)](VRageMath.Matrix.SetRotationAndScale)

> 

[void SetRow(int row, Vector4 value)](VRageMath.Matrix.SetRow)

> 

[string ToString()](VRageMath.Matrix.ToString)

> Retrieves a string representation of the current object.

[void TransposeRotationInPlace()](VRageMath.Matrix.TransposeRotationInPlace)

> Transposes the rows and columns of a matrix that is assumed to be rotation only in place.

