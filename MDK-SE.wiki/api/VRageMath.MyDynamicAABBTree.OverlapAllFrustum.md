← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyDynamicAABBTree](VRageMath.MyDynamicAABBTree)

### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, bool clear = default)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [List&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) elementsList
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) clear
### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, uint requiredFlags, bool clear = default)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [List&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) elementsList
* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) requiredFlags
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) clear
### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, List<bool> isInsideList, bool clear = default)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [List&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) elementsList
* [List&lt;bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) isInsideList
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) clear
### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, Action<T, bool> add)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [Action&lt;T, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6) add
### 概要

```csharp
public void OverlapAllFrustum<T, Op>(ref BoundingFrustum frustum, ref Op add)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [Op]() add
### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, List<bool> isInsideList, float tSqr, bool clear = default)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [List&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) elementsList
* [List&lt;bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) isInsideList
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) tSqr
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) clear
### 概要

```csharp
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, Action<T, bool> add, float tSqr)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [Action&lt;T, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6) add
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) tSqr
### 概要

```csharp
public void OverlapAllFrustum<T, Op>(ref BoundingFrustum frustum, float tSqr, ref Op add)
```

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) tSqr
* [Op]() add
