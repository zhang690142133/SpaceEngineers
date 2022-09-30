← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
```

Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Vector3](VRageMath.Vector3) lightDirection
* [Plane](VRageMath.Plane) plane
### 概要

```csharp
public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
```

Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

### 参数

* [Vector3](VRageMath.Vector3) lightDirection
* [Plane](VRageMath.Plane) plane
* [Matrix](VRageMath.Matrix) result
