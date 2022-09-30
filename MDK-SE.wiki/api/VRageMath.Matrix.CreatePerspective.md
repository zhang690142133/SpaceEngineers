← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
```

Builds a perspective projection matrix and returns the result by value.

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) width
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) height
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
### 概要

```csharp
public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

Builds a perspective projection matrix and returns the result by reference.

### 参数

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) width
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) height
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
* [Matrix](VRageMath.Matrix) result
