← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxD](VRageMath.BoundingBoxD)

### 概要

```csharp
public BoundingBoxD TransformFast(MatrixD m)
```

Transform this AABB by matrix. Matrix has to be only rotation and translation.

### 返回

[BoundingBoxD](VRageMath.BoundingBoxD)

transformed aabb

### 参数

* [MatrixD](VRageMath.MatrixD) m
### 概要

```csharp
public BoundingBoxD TransformFast(ref MatrixD m)
```

Transform this AABB by matrix. Matrix has to be only rotation and translation.

### 返回

[BoundingBoxD](VRageMath.BoundingBoxD)

transformed aabb

### 参数

* [MatrixD](VRageMath.MatrixD) m
### 概要

```csharp
public void TransformFast(ref MatrixD m, ref BoundingBoxD bb)
```

Transform this AABB by matrix. Matrix has to be only rotation and translation.

### 参数

* [MatrixD](VRageMath.MatrixD) m
* [BoundingBoxD](VRageMath.BoundingBoxD) bb
