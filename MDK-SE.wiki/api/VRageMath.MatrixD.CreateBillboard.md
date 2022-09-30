← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public static MatrixD CreateBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D cameraUpVector, Vector3D? cameraForwardVector)
```

Creates a spherical billboard that rotates around a specified object position.

### 返回

[MatrixD](VRageMath.MatrixD)

### 参数

* [Vector3D](VRageMath.Vector3D) objectPosition
* [Vector3D](VRageMath.Vector3D) cameraPosition
* [Vector3D](VRageMath.Vector3D) cameraUpVector
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
### 概要

```csharp
public static void CreateBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D cameraUpVector, Vector3D? cameraForwardVector, out MatrixD result)
```

Creates a spherical billboard that rotates around a specified object position.

### 参数

* [Vector3D](VRageMath.Vector3D) objectPosition
* [Vector3D](VRageMath.Vector3D) cameraPosition
* [Vector3D](VRageMath.Vector3D) cameraUpVector
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [MatrixD](VRageMath.MatrixD) result
