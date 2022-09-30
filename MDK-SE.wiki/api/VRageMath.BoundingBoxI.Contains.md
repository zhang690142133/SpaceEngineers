← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxI](VRageMath.BoundingBoxI)

### 概要

```csharp
public ContainmentType Contains(BoundingBoxI box)
```

Tests whether the BoundingBoxI contains another BoundingBoxI.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) box
### 概要

```csharp
public void Contains(ref BoundingBoxI box, out ContainmentType result)
```

Tests whether the BoundingBoxI contains a BoundingBoxI.

### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(Vector3I point)
```

Tests whether the BoundingBoxI contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector3I](VRageMath.Vector3I) point
### 概要

```csharp
public ContainmentType Contains(Vector3 point)
```



### 返回

[ContainmentType](VRageMath.ContainmentType)



### 参数

* [Vector3](VRageMath.Vector3) point
### 概要

```csharp
public void Contains(ref Vector3I point, out ContainmentType result)
```

Tests whether the BoundingBoxI contains a point.

### 参数

* [Vector3I](VRageMath.Vector3I) point
* [ContainmentType](VRageMath.ContainmentType) result
