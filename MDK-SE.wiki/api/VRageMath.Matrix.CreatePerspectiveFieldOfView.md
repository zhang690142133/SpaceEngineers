← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Matrix](VRageMath.Matrix)

### 概要

```csharp
public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```

Builds a perspective projection matrix based on a field of view and returns by value.

### 返回

[Matrix](VRageMath.Matrix)

### 参数

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) fieldOfView
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) aspectRatio
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
### 概要

```csharp
public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

Builds a perspective projection matrix based on a field of view and returns by reference.

### 参数

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) fieldOfView
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) aspectRatio
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
* [Matrix](VRageMath.Matrix) result
