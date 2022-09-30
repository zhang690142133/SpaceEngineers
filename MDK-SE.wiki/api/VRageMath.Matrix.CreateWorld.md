← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static Matrix CreateWorld(Vector3 position)
```

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Vector3](VRageMath.Vector3) position
### 概要

```csharp
public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
```

Creates a world matrix with the specified parameters.

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [Vector3](VRageMath.Vector3) position
* [Vector3](VRageMath.Vector3) forward
* [Vector3](VRageMath.Vector3) up
### 概要

```csharp
public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)
```

Creates a world matrix with the specified parameters.

### 参数

* [Vector3](VRageMath.Vector3) position
* [Vector3](VRageMath.Vector3) forward
* [Vector3](VRageMath.Vector3) up
* [Matrix](VRageMath.Matrix) result
