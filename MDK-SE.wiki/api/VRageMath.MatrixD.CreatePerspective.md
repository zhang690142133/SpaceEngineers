← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public static MatrixD CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance)
```

Builds a perspective projection matrix and returns the result by value.

### 返回

[MatrixD](VRageMath.MatrixD)

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) width
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) height
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
### 概要

```csharp
public static void CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

Builds a perspective projection matrix and returns the result by reference.

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) width
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) height
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
* [MatrixD](VRageMath.MatrixD) result
