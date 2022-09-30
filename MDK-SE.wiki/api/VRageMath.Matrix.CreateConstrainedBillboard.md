← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
```

Creates a cylindrical billboard that rotates around a specified axis.

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) rotateAxis
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) objectForwardVector
### 概要

```csharp
public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
```

Creates a cylindrical billboard that rotates around a specified axis.

### 参数

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) rotateAxis
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) objectForwardVector
* [Matrix](VRageMath.Matrix) result
