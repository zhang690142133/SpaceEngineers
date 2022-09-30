← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox2I](VRageMath.BoundingBox2I)

### 概要

```csharp
public ContainmentType Contains(BoundingBox2I box)
```

Tests whether the BoundingBox2I contains another BoundingBox2I.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBox2I](VRageMath.BoundingBox2I) box
### 概要

```csharp
public void Contains(ref BoundingBox2I box, out ContainmentType result)
```

Tests whether the BoundingBox2I contains a BoundingBox2I.

### 参数

* [BoundingBox2I](VRageMath.BoundingBox2I) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(Vector2I point)
```

Tests whether the BoundingBox2I contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector2I](VRageMath.Vector2I) point
### 概要

```csharp
public void Contains(ref Vector2I point, out ContainmentType result)
```

Tests whether the BoundingBox2I contains a point.

### 参数

* [Vector2I](VRageMath.Vector2I) point
* [ContainmentType](VRageMath.ContainmentType) result
