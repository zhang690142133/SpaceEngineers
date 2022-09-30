← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector3](VRageMath.Vector3)

### 概要

```csharp
public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
```

Transforms a 3D vector normal by a matrix.

### 返回

[Vector3](VRageMath.Vector3)

### 参数

* [Vector3](VRageMath.Vector3) normal
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static Vector3 TransformNormal(Vector3 normal, MatrixD matrix)
```

Transforms a 3D vector normal by a matrix.

### 返回

[Vector3](VRageMath.Vector3)

### 参数

* [Vector3](VRageMath.Vector3) normal
* [MatrixD](VRageMath.MatrixD) matrix
### 概要

```csharp
public static Vector3 TransformNormal(Vector3D normal, Matrix matrix)
```

Transforms a 3D vector normal by a matrix.

### 返回

[Vector3](VRageMath.Vector3)

### 参数

* [Vector3D](VRageMath.Vector3D) normal
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result)
```

Transforms a vector normal by a matrix.

### 参数

* [Vector3](VRageMath.Vector3) normal
* [Matrix](VRageMath.Matrix) matrix
* [Vector3](VRageMath.Vector3) result
### 概要

```csharp
public static void TransformNormal(ref Vector3 normal, ref MatrixD matrix, out Vector3 result)
```

### 参数

* [Vector3](VRageMath.Vector3) normal
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector3](VRageMath.Vector3) result
### 概要

```csharp
public static void TransformNormal(ref Vector3 normal, ref MatrixI matrix, out Vector3 result)
```

### 参数

* [Vector3](VRageMath.Vector3) normal
* [MatrixI](VRageMath.MatrixI) matrix
* [Vector3](VRageMath.Vector3) result
### 概要

```csharp
public static Vector3 TransformNormal(Vector3 normal, MyBlockOrientation orientation)
```

### 返回

[Vector3](VRageMath.Vector3)

### 参数

* [Vector3](VRageMath.Vector3) normal
* [MyBlockOrientation](VRageMath.MyBlockOrientation) orientation
### 概要

```csharp
public static void TransformNormal(ref Vector3 normal, MyBlockOrientation orientation, out Vector3 result)
```

### 参数

* [Vector3](VRageMath.Vector3) normal
* [MyBlockOrientation](VRageMath.MyBlockOrientation) orientation
* [Vector3](VRageMath.Vector3) result
### 概要

```csharp
public static Vector3 TransformNormal(Vector3 normal, ref Matrix matrix)
```

### 返回

[Vector3](VRageMath.Vector3)

### 参数

* [Vector3](VRageMath.Vector3) normal
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
```

Transforms an array of 3D vector normals by a specified Matrix.

### 参数

* [Vector3&#91&#93;](VRageMath.Vector3&#91&#93;) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector3&#91&#93;](VRageMath.Vector3&#91&#93;) destinationArray
### 概要

```csharp
public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of 3D vector normals by a specified Matrix and writes the results to a specified range in a destination array.

### 参数

* [Vector3&#91&#93;](VRageMath.Vector3&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector3&#91&#93;](VRageMath.Vector3&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
