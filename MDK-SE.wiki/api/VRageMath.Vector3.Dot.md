← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector3](VRageMath.Vector3)

### 概要

```csharp
public static float Dot(Vector3 vector1, Vector3 vector2)
```

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

### 返回

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

### 参数

* [Vector3](VRageMath.Vector3) vector1
* [Vector3](VRageMath.Vector3) vector2
### 概要

```csharp
public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
```

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

### 参数

* [Vector3](VRageMath.Vector3) vector1
* [Vector3](VRageMath.Vector3) vector2
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) result
### 概要

```csharp
public float Dot(Vector3 v)
```

### 返回

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

### 参数

* [Vector3](VRageMath.Vector3) v
### 概要

```csharp
public float Dot(ref Vector3 v)
```

### 返回

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

### 参数

* [Vector3](VRageMath.Vector3) v
