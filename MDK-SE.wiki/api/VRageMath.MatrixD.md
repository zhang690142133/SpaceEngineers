← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MatrixD Struct

```csharp
public struct MatrixD: IEquatable<MatrixD>
```

Defines a matrix.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;MatrixD&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static MatrixD Identity](VRageMath.MatrixD.Identity)

> 

[static MatrixD Zero](VRageMath.MatrixD.Zero)

> 

[double M11](VRageMath.MatrixD.M11)

> Value at row 1 column 1 of the matrix.

[double M12](VRageMath.MatrixD.M12)

> Value at row 1 column 2 of the matrix.

[double M13](VRageMath.MatrixD.M13)

> Value at row 1 column 3 of the matrix.

[double M14](VRageMath.MatrixD.M14)

> Value at row 1 column 4 of the matrix.

[double M21](VRageMath.MatrixD.M21)

> Value at row 2 column 1 of the matrix.

[double M22](VRageMath.MatrixD.M22)

> Value at row 2 column 2 of the matrix.

[double M23](VRageMath.MatrixD.M23)

> Value at row 2 column 3 of the matrix.

[double M24](VRageMath.MatrixD.M24)

> Value at row 2 column 4 of the matrix.

[double M31](VRageMath.MatrixD.M31)

> Value at row 3 column 1 of the matrix.

[double M32](VRageMath.MatrixD.M32)

> Value at row 3 column 2 of the matrix.

[double M33](VRageMath.MatrixD.M33)

> Value at row 3 column 3 of the matrix.

[double M34](VRageMath.MatrixD.M34)

> Value at row 3 column 4 of the matrix.

[double M41](VRageMath.MatrixD.M41)

> Value at row 4 column 1 of the matrix.

[double M42](VRageMath.MatrixD.M42)

> Value at row 4 column 2 of the matrix.

[double M43](VRageMath.MatrixD.M43)

> Value at row 4 column 3 of the matrix.

[double M44](VRageMath.MatrixD.M44)

> Value at row 4 column 4 of the matrix.

#### Properties

[Vector3D Backward { get; set; }](VRageMath.MatrixD.Backward)

> Gets and sets the backward vector of the Matrix.

[Vector3D Col0 { get; }](VRageMath.MatrixD.Col0)

> 

[Vector3D Col1 { get; }](VRageMath.MatrixD.Col1)

> 

[Vector3D Col2 { get; }](VRageMath.MatrixD.Col2)

> 

[Vector3D Down { get; set; }](VRageMath.MatrixD.Down)

> Gets and sets the down vector of the Matrix.

[Vector3D Forward { get; set; }](VRageMath.MatrixD.Forward)

> Gets and sets the forward vector of the Matrix.

[double Item { get; set; }](VRageMath.MatrixD.Item)

> 

[Vector3D Left { get; set; }](VRageMath.MatrixD.Left)

> Gets and sets the left vector of the Matrix.

[Vector3D Right { get; set; }](VRageMath.MatrixD.Right)

> Gets and sets the right vector of the Matrix.

[Matrix3x3 Rotation { get; }](VRageMath.MatrixD.Rotation)

> 

[Vector3D Scale { get; }](VRageMath.MatrixD.Scale)

> 

[Vector3D Translation { get; set; }](VRageMath.MatrixD.Translation)

> Gets and sets the translation vector of the Matrix.

[Vector3D Up { get; set; }](VRageMath.MatrixD.Up)

> Gets and sets the up vector of the Matrix.

#### Constructors

[MatrixD(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)](VRageMath.MatrixD..ctor)

> 

[MatrixD(double m11, double m12, double m13, double m21, double m22, double m23, double m31, double m32, double m33)](VRageMath.MatrixD..ctor)

> 

[MatrixD(Matrix m)](VRageMath.MatrixD..ctor)

> 

#### 方法

[static MatrixD Add(MatrixD matrix1, MatrixD matrix2)](VRageMath.MatrixD.Add)

> Adds a matrix to another matrix.

[static void Add(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)](VRageMath.MatrixD.Add)

> Adds a matrix to another matrix.

[static MatrixD AlignRotationToAxes(ref MatrixD toAlign, ref MatrixD axisDefinitionMatrix)](VRageMath.MatrixD.AlignRotationToAxes)

> 

[static MatrixD CreateBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D cameraUpVector, Vector3D? cameraForwardVector)](VRageMath.MatrixD.CreateBillboard)

> Creates a spherical billboard that rotates around a specified object position.

[static void CreateBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D cameraUpVector, Vector3D? cameraForwardVector, out MatrixD result)](VRageMath.MatrixD.CreateBillboard)

> Creates a spherical billboard that rotates around a specified object position.

[static MatrixD CreateConstrainedBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D rotateAxis, Vector3D? cameraForwardVector, Vector3D? objectForwardVector)](VRageMath.MatrixD.CreateConstrainedBillboard)

> Creates a cylindrical billboard that rotates around a specified axis.

[static void CreateConstrainedBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D rotateAxis, Vector3D? cameraForwardVector, Vector3D? objectForwardVector, out MatrixD result)](VRageMath.MatrixD.CreateConstrainedBillboard)

> Creates a cylindrical billboard that rotates around a specified axis.

[static MatrixD CreateFromAxisAngle(Vector3D axis, double angle)](VRageMath.MatrixD.CreateFromAxisAngle)

> Creates a new Matrix that rotates around an arbitrary vector.

[static void CreateFromAxisAngle(ref Vector3D axis, double angle, out MatrixD result)](VRageMath.MatrixD.CreateFromAxisAngle)

> Creates a new Matrix that rotates around an arbitrary vector.

[static MatrixD CreateFromDir(Vector3D dir)](VRageMath.MatrixD.CreateFromDir)

> 

[static MatrixD CreateFromDir(Vector3D dir, Vector3D suggestedUp)](VRageMath.MatrixD.CreateFromDir)

> 

[static MatrixD CreateFromQuaternion(Quaternion quaternion)](VRageMath.MatrixD.CreateFromQuaternion)

> Creates a rotation Matrix from a Quaternion.

[static MatrixD CreateFromQuaternion(QuaternionD quaternion)](VRageMath.MatrixD.CreateFromQuaternion)

> 

[static void CreateFromQuaternion(ref Quaternion quaternion, out MatrixD result)](VRageMath.MatrixD.CreateFromQuaternion)

> Creates a rotation Matrix from a Quaternion.

[static MatrixD CreateFromTransformScale(Quaternion orientation, Vector3D position, Vector3D scale)](VRageMath.MatrixD.CreateFromTransformScale)

> 

[static MatrixD CreateFromYawPitchRoll(double yaw, double pitch, double roll)](VRageMath.MatrixD.CreateFromYawPitchRoll)

> Creates a new rotation matrix from a specified yaw, pitch, and roll.

[static void CreateFromYawPitchRoll(double yaw, double pitch, double roll, out MatrixD result)](VRageMath.MatrixD.CreateFromYawPitchRoll)

> Fills in a rotation matrix from a specified yaw, pitch, and roll.

[static MatrixD CreateLookAt(Vector3D cameraPosition, Vector3D cameraTarget, Vector3 cameraUpVector)](VRageMath.MatrixD.CreateLookAt)

> 

[static MatrixD CreateLookAt(Vector3D cameraPosition, Vector3D cameraTarget, Vector3D cameraUpVector)](VRageMath.MatrixD.CreateLookAt)

> Creates a view matrix.

[static void CreateLookAt(ref Vector3D cameraPosition, ref Vector3D cameraTarget, ref Vector3D cameraUpVector, out MatrixD result)](VRageMath.MatrixD.CreateLookAt)

> Creates a view matrix.

[static MatrixD CreateLookAtInverse(Vector3D cameraPosition, Vector3D cameraTarget, Vector3D cameraUpVector)](VRageMath.MatrixD.CreateLookAtInverse)

> 

[static MatrixD CreateOrthographic(double width, double height, double zNearPlane, double zFarPlane)](VRageMath.MatrixD.CreateOrthographic)

> Builds an orthogonal projection matrix.

[static void CreateOrthographic(double width, double height, double zNearPlane, double zFarPlane, out MatrixD result)](VRageMath.MatrixD.CreateOrthographic)

> Builds an orthogonal projection matrix.

[static MatrixD CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNearPlane, double zFarPlane)](VRageMath.MatrixD.CreateOrthographicOffCenter)

> Builds a customized, orthogonal projection matrix.

[static void CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNearPlane, double zFarPlane, out MatrixD result)](VRageMath.MatrixD.CreateOrthographicOffCenter)

> Builds a customized, orthogonal projection matrix.

[static MatrixD CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance)](VRageMath.MatrixD.CreatePerspective)

> Builds a perspective projection matrix and returns the result by value.

[static void CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)](VRageMath.MatrixD.CreatePerspective)

> Builds a perspective projection matrix and returns the result by reference.

[static MatrixD CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance)](VRageMath.MatrixD.CreatePerspectiveFieldOfView)

> Builds a perspective projection matrix based on a field of view and returns by value.

[static void CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)](VRageMath.MatrixD.CreatePerspectiveFieldOfView)

> Builds a perspective projection matrix based on a field of view and returns by reference.

[static MatrixD CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double nearPlaneDistance, double farPlaneDistance)](VRageMath.MatrixD.CreatePerspectiveOffCenter)

> Builds a customized, perspective projection matrix.

[static void CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)](VRageMath.MatrixD.CreatePerspectiveOffCenter)

> Builds a customized, perspective projection matrix.

[static MatrixD CreateReflection(Plane value)](VRageMath.MatrixD.CreateReflection)

> Creates a Matrix that reflects the coordinate system about a specified Plane.

[static void CreateReflection(ref Plane value, out MatrixD result)](VRageMath.MatrixD.CreateReflection)

> Fills in an existing Matrix so that it reflects the coordinate system about a specified Plane.

[static MatrixD CreateRotationX(double radians)](VRageMath.MatrixD.CreateRotationX)

> Returns a matrix that can be used to rotate a set of vertices around the x-axis.

[static void CreateRotationX(double radians, out MatrixD result)](VRageMath.MatrixD.CreateRotationX)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

[static MatrixD CreateRotationY(double radians)](VRageMath.MatrixD.CreateRotationY)

> Returns a matrix that can be used to rotate a set of vertices around the y-axis.

[static void CreateRotationY(double radians, out MatrixD result)](VRageMath.MatrixD.CreateRotationY)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

[static MatrixD CreateRotationZ(double radians)](VRageMath.MatrixD.CreateRotationZ)

> Returns a matrix that can be used to rotate a set of vertices around the z-axis.

[static void CreateRotationZ(double radians, out MatrixD result)](VRageMath.MatrixD.CreateRotationZ)

> Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

[static MatrixD CreateScale(double xScale, double yScale, double zScale)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(double xScale, double yScale, double zScale, out MatrixD result)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static MatrixD CreateScale(Vector3D scales)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(ref Vector3D scales, out MatrixD result)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static MatrixD CreateScale(double scale)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static void CreateScale(double scale, out MatrixD result)](VRageMath.MatrixD.CreateScale)

> Creates a scaling Matrix.

[static MatrixD CreateShadow(Vector3D lightDirection, Plane plane)](VRageMath.MatrixD.CreateShadow)

> Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

[static void CreateShadow(ref Vector3D lightDirection, ref Plane plane, out MatrixD result)](VRageMath.MatrixD.CreateShadow)

> Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

[static MatrixD CreateTranslation(Vector3D position)](VRageMath.MatrixD.CreateTranslation)

> Creates a translation Matrix.

[static MatrixD CreateTranslation(Vector3 position)](VRageMath.MatrixD.CreateTranslation)

> 

[static void CreateTranslation(ref Vector3D position, out MatrixD result)](VRageMath.MatrixD.CreateTranslation)

> Creates a translation Matrix.

[static MatrixD CreateTranslation(double xPosition, double yPosition, double zPosition)](VRageMath.MatrixD.CreateTranslation)

> Creates a translation Matrix.

[static void CreateTranslation(double xPosition, double yPosition, double zPosition, out MatrixD result)](VRageMath.MatrixD.CreateTranslation)

> Creates a translation Matrix.

[static MatrixD CreateWorld(Vector3D position, Vector3 forward, Vector3 up)](VRageMath.MatrixD.CreateWorld)

> 

[static MatrixD CreateWorld(Vector3D position)](VRageMath.MatrixD.CreateWorld)

> 

[static MatrixD CreateWorld(Vector3D position, Vector3D forward, Vector3D up)](VRageMath.MatrixD.CreateWorld)

> Creates a world matrix with the specified parameters.

[static void CreateWorld(ref Vector3D position, ref Vector3D forward, ref Vector3D up, out MatrixD result)](VRageMath.MatrixD.CreateWorld)

> Creates a world matrix with the specified parameters.

[static MatrixD Divide(MatrixD matrix1, MatrixD matrix2)](VRageMath.MatrixD.Divide)

> Divides the components of a matrix by the corresponding components of another matrix.

[static void Divide(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)](VRageMath.MatrixD.Divide)

> Divides the components of a matrix by the corresponding components of another matrix.

[static MatrixD Divide(MatrixD matrix1, double divider)](VRageMath.MatrixD.Divide)

> Divides the components of a matrix by a scalar.

[static void Divide(ref MatrixD matrix1, double divider, out MatrixD result)](VRageMath.MatrixD.Divide)

> Divides the components of a matrix by a scalar.

[static bool GetEulerAnglesXYZ(ref MatrixD mat, out Vector3D xyz)](VRageMath.MatrixD.GetEulerAnglesXYZ)

> 

[static MatrixD Invert(MatrixD matrix)](VRageMath.MatrixD.Invert)

> Calculates the inverse of a matrix.

[static MatrixD Invert(ref MatrixD matrix)](VRageMath.MatrixD.Invert)

> 

[static void Invert(ref MatrixD matrix, out MatrixD result)](VRageMath.MatrixD.Invert)

> Calculates the inverse of a matrix.

[static MatrixD Lerp(MatrixD matrix1, MatrixD matrix2, double amount)](VRageMath.MatrixD.Lerp)

> Linearly interpolates between the corresponding values of two matrices.

[static void Lerp(ref MatrixD matrix1, ref MatrixD matrix2, double amount, out MatrixD result)](VRageMath.MatrixD.Lerp)

> Linearly interpolates between the corresponding values of two matrices.

[static MatrixD Multiply(MatrixD matrix1, MatrixD matrix2)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by another matrix.

[static MatrixD Multiply(MatrixD matrix1, Matrix matrix2)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by another matrix.

[static void Multiply(ref MatrixD matrix1, ref Matrix matrix2, out MatrixD result)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by another matrix.

[static void Multiply(ref Matrix matrix1, ref MatrixD matrix2, out MatrixD result)](VRageMath.MatrixD.Multiply)

> 

[static void Multiply(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by another matrix.

[static MatrixD Multiply(MatrixD matrix1, double scaleFactor)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by a scalar value.

[static void Multiply(ref MatrixD matrix1, double scaleFactor, out MatrixD result)](VRageMath.MatrixD.Multiply)

> Multiplies a matrix by a scalar value.

[static MatrixD Negate(MatrixD matrix)](VRageMath.MatrixD.Negate)

> Negates individual elements of a matrix.

[static void Negate(ref MatrixD matrix, out MatrixD result)](VRageMath.MatrixD.Negate)

> Negates individual elements of a matrix.

[static MatrixD Normalize(MatrixD matrix)](VRageMath.MatrixD.Normalize)

> 

[static MatrixD Orthogonalize(MatrixD rotationMatrix)](VRageMath.MatrixD.Orthogonalize)

> 

[static void Rescale(ref MatrixD matrix, double scale)](VRageMath.MatrixD.Rescale)

> Same result as Matrix.CreateScale(scale) * matrix, but much faster

[static void Rescale(ref MatrixD matrix, float scale)](VRageMath.MatrixD.Rescale)

> Same result as Matrix.CreateScale(scale) * matrix, but much faster

[static void Rescale(ref MatrixD matrix, ref Vector3D scale)](VRageMath.MatrixD.Rescale)

> Same result as Matrix.CreateScale(scale) * matrix, but much faster

[static MatrixD Rescale(MatrixD matrix, double scale)](VRageMath.MatrixD.Rescale)

> 

[static MatrixD Rescale(MatrixD matrix, Vector3D scale)](VRageMath.MatrixD.Rescale)

> 

[static void Slerp(ref MatrixD matrix1, ref MatrixD matrix2, double amount, out MatrixD result)](VRageMath.MatrixD.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static MatrixD Slerp(MatrixD matrix1, MatrixD matrix2, double amount)](VRageMath.MatrixD.Slerp)

> Performs spherical linear interpolation of position and rotation.

[static void SlerpScale(ref MatrixD matrix1, ref MatrixD matrix2, double amount, out MatrixD result)](VRageMath.MatrixD.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static void SlerpScale(MatrixD matrix1, MatrixD matrix2, double amount, out MatrixD result)](VRageMath.MatrixD.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static MatrixD SlerpScale(MatrixD matrix1, MatrixD matrix2, double amount)](VRageMath.MatrixD.SlerpScale)

> Performs spherical linear interpolation of position and rotation and scale.

[static void Subtract(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)](VRageMath.MatrixD.Subtract)

> Subtracts matrices.

[static Matrix Subtract(Matrix matrix1, Matrix matrix2)](VRageMath.MatrixD.Subtract)

> Subtracts matrices.

[static MatrixD SwapYZCoordinates(MatrixD m)](VRageMath.MatrixD.SwapYZCoordinates)

> 

[static MatrixD Transform(MatrixD value, Quaternion rotation)](VRageMath.MatrixD.Transform)

> Transforms a Matrix by applying a Quaternion rotation.

[static void Transform(ref MatrixD value, ref Quaternion rotation, out MatrixD result)](VRageMath.MatrixD.Transform)

> Transforms a Matrix by applying a Quaternion rotation.

[static MatrixD Transpose(MatrixD matrix)](VRageMath.MatrixD.Transpose)

> Transposes the rows and columns of a matrix.

[static void Transpose(ref MatrixD matrix, out MatrixD result)](VRageMath.MatrixD.Transpose)

> Transposes the rows and columns of a matrix.

[void AssertIsValid(string message = null)](VRageMath.MatrixD.AssertIsValid)

> 

[double Determinant()](VRageMath.MatrixD.Determinant)

> Calculates the determinant of the matrix.

[bool Equals(MatrixD other)](VRageMath.MatrixD.Equals)

> Determines whether the specified Object is equal to the Matrix.

[bool Equals(object obj)](VRageMath.MatrixD.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[bool EqualsFast(ref MatrixD other, double epsilon = 0.0001)](VRageMath.MatrixD.EqualsFast)

> Compares just position, forward and up

[Direction GetClosestDirection(Vector3D referenceVector)](VRageMath.MatrixD.GetClosestDirection)

> 

[Direction GetClosestDirection(ref Vector3D referenceVector)](VRageMath.MatrixD.GetClosestDirection)

> 

[Vector3D GetDirectionVector(Direction direction)](VRageMath.MatrixD.GetDirectionVector)

> 

[int GetHashCode()](VRageMath.MatrixD.GetHashCode)

> Gets the hash code of this object.

[MatrixD GetOrientation()](VRageMath.MatrixD.GetOrientation)

> Gets the orientation.

[Vector4D GetRow(int row)](VRageMath.MatrixD.GetRow)

> 

[bool HasNoTranslationOrPerspective()](VRageMath.MatrixD.HasNoTranslationOrPerspective)

> Returns true if this matrix represents invertible (you can call Invert on it) linear (it does not contain translation or perspective transformation) transformation. Such matrix consist solely of rotations, shearing, mirroring and scaling. It can be orthogonalized to create an orthogonal rotation matrix.

[bool IsMirrored()](VRageMath.MatrixD.IsMirrored)

> 

[bool IsNan()](VRageMath.MatrixD.IsNan)

> 

[bool IsOrthogonal()](VRageMath.MatrixD.IsOrthogonal)

> 

[bool IsOrthogonal(double epsilon)](VRageMath.MatrixD.IsOrthogonal)

> 

[bool IsRotation()](VRageMath.MatrixD.IsRotation)

> 

[bool IsValid()](VRageMath.MatrixD.IsValid)

> 

[void Orthogonalize()](VRageMath.MatrixD.Orthogonalize)

> 

[void SetDirectionVector(Direction direction, Vector3D newValue)](VRageMath.MatrixD.SetDirectionVector)

> 

[void SetFrom(ref Matrix m)](VRageMath.MatrixD.SetFrom)

> 

[void SetRotationAndScale(ref Matrix m)](VRageMath.MatrixD.SetRotationAndScale)

> 

[void SetRow(int row, Vector4 value)](VRageMath.MatrixD.SetRow)

> 

[string ToString()](VRageMath.MatrixD.ToString)

> Retrieves a string representation of the current object.

