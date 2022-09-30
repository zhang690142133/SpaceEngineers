← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox2](VRageMath.BoundingBox2)

### 概要

```csharp
public ContainmentType Contains(BoundingBox2 box)
```

Tests whether the BoundingBox2 contains another BoundingBox2.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBox2](VRageMath.BoundingBox2) box
### 概要

```csharp
public void Contains(ref BoundingBox2 box, out ContainmentType result)
```

Tests whether the BoundingBox2 contains a BoundingBox2.

### 参数

* [BoundingBox2](VRageMath.BoundingBox2) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(Vector2 point)
```

Tests whether the BoundingBox2 contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector2](VRageMath.Vector2) point
### 概要

```csharp
public void Contains(ref Vector2 point, out ContainmentType result)
```

Tests whether the BoundingBox2 contains a point.

### 参数

* [Vector2](VRageMath.Vector2) point
* [ContainmentType](VRageMath.ContainmentType) result
