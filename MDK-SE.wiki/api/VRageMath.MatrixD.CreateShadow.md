← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public static MatrixD CreateShadow(Vector3D lightDirection, Plane plane)
```

Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

### 返回

[MatrixD](VRageMath.MatrixD)

### 参数

* [Vector3D](VRageMath.Vector3D) lightDirection
* [Plane](VRageMath.Plane) plane
### 概要

```csharp
public static void CreateShadow(ref Vector3D lightDirection, ref Plane plane, out MatrixD result)
```

Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

### 参数

* [Vector3D](VRageMath.Vector3D) lightDirection
* [Plane](VRageMath.Plane) plane
* [MatrixD](VRageMath.MatrixD) result
