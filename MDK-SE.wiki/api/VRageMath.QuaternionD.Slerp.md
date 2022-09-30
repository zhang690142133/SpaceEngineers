← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [QuaternionD](VRageMath.QuaternionD)

### 概要

```csharp
public static QuaternionD Slerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount)
```

Interpolates between two quaternions, using spherical linear interpolation.

### 返回

[QuaternionD](VRageMath.QuaternionD)

### 参数

* [QuaternionD](VRageMath.QuaternionD) quaternion1
* [QuaternionD](VRageMath.QuaternionD) quaternion2
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount
### 概要

```csharp
public static void Slerp(ref QuaternionD quaternion1, ref QuaternionD quaternion2, double amount, out QuaternionD result)
```

Interpolates between two quaternions, using spherical linear interpolation.

### 参数

* [QuaternionD](VRageMath.QuaternionD) quaternion1
* [QuaternionD](VRageMath.QuaternionD) quaternion2
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount
* [QuaternionD](VRageMath.QuaternionD) result
