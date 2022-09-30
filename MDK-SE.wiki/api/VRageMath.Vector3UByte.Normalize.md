← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector3UByte](VRageMath.Vector3UByte)

### 概要

```csharp
public static Vector3UByte Normalize(Vector3 vec, float range)
```

Normalizes Vector3 into Vector4UByte, scales vector from (-range, range) to (0, 255). Unsafe for values "range >= any_vec_value / 257";

### 返回

[Vector3UByte](VRageMath.Vector3UByte)

### 参数

* [Vector3](VRageMath.Vector3) vec
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) range
