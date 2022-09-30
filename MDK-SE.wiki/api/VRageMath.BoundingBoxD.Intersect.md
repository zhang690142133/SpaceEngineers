← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxD](VRageMath.BoundingBoxD)

### 概要

```csharp
public BoundingBoxD Intersect(BoundingBoxD box)
```

Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

### 返回

[BoundingBoxD](VRageMath.BoundingBoxD)

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
### 概要

```csharp
public bool Intersect(ref LineD line, out LineD intersectedLine)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [LineD](VRageMath.LineD) line
* [LineD](VRageMath.LineD) intersectedLine
### 概要

```csharp
public bool Intersect(ref LineD line, out double t1, out double t2)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [LineD](VRageMath.LineD) line
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) t1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) t2
### 概要

```csharp
public bool Intersect(ref RayD ray, out double tmin, out double tmax)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [RayD](VRageMath.RayD) ray
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) tmin
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) tmax
