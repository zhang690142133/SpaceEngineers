← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector4D](VRageMath.Vector4D)

### 概要

```csharp
public static Vector4D CatmullRom(Vector4D value1, Vector4D value2, Vector4D value3, Vector4D value4, double amount)
```

Performs a Catmull-Rom interpolation using the specified positions.

### 返回

[Vector4D](VRageMath.Vector4D)

### 参数

* [Vector4D](VRageMath.Vector4D) value1
* [Vector4D](VRageMath.Vector4D) value2
* [Vector4D](VRageMath.Vector4D) value3
* [Vector4D](VRageMath.Vector4D) value4
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount
### 概要

```csharp
public static void CatmullRom(ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, ref Vector4D value4, double amount, out Vector4D result)
```

Performs a Catmull-Rom interpolation using the specified positions.

### 参数

* [Vector4D](VRageMath.Vector4D) value1
* [Vector4D](VRageMath.Vector4D) value2
* [Vector4D](VRageMath.Vector4D) value3
* [Vector4D](VRageMath.Vector4D) value4
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount
* [Vector4D](VRageMath.Vector4D) result
