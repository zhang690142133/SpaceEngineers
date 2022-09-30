← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static void Rescale(ref Matrix matrix, float scale)
```

Same result as Matrix.CreateScale(scale) * matrix, but much faster

### 参数

* [Matrix](VRageMath.Matrix) matrix
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) scale
### 概要

```csharp
public static void Rescale(ref Matrix matrix, ref Vector3 scale)
```

Same result as Matrix.CreateScale(scale) * matrix, but much faster

### 参数

* [Matrix](VRageMath.Matrix) matrix
* [Vector3](VRageMath.Vector3) scale
### 概要

```csharp
public static Matrix Rescale(Matrix matrix, float scale)
```

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Matrix](VRageMath.Matrix) matrix
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) scale
### 概要

```csharp
public static Matrix Rescale(Matrix matrix, Vector3 scale)
```

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Matrix](VRageMath.Matrix) matrix
* [Vector3](VRageMath.Vector3) scale
