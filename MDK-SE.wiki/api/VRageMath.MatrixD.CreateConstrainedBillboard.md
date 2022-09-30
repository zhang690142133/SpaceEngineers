← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public static MatrixD CreateConstrainedBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D rotateAxis, Vector3D? cameraForwardVector, Vector3D? objectForwardVector)
```

Creates a cylindrical billboard that rotates around a specified axis.

### 返回

[MatrixD](VRageMath.MatrixD)

### 参数

* [Vector3D](VRageMath.Vector3D) objectPosition
* [Vector3D](VRageMath.Vector3D) cameraPosition
* [Vector3D](VRageMath.Vector3D) rotateAxis
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) objectForwardVector
### 概要

```csharp
public static void CreateConstrainedBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D rotateAxis, Vector3D? cameraForwardVector, Vector3D? objectForwardVector, out MatrixD result)
```

Creates a cylindrical billboard that rotates around a specified axis.

### 参数

* [Vector3D](VRageMath.Vector3D) objectPosition
* [Vector3D](VRageMath.Vector3D) cameraPosition
* [Vector3D](VRageMath.Vector3D) rotateAxis
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) objectForwardVector
* [MatrixD](VRageMath.MatrixD) result
