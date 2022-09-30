← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public static MatrixD CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance)
```

Builds a perspective projection matrix based on a field of view and returns by value.

### 返回

[MatrixD](VRageMath.MatrixD)

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) fieldOfView
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) aspectRatio
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
### 概要

```csharp
public static void CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

Builds a perspective projection matrix based on a field of view and returns by reference.

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) fieldOfView
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) aspectRatio
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
* [MatrixD](VRageMath.MatrixD) result
