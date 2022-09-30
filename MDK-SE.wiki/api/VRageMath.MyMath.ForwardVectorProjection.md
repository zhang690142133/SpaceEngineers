← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyMath](VRageMath.MyMath)

### 概要

```csharp
public static Vector3 ForwardVectorProjection(Vector3 forwardVector, Vector3 projectedVector)
```

This projection results to initial velocity of non-engine objects, which parents move in some velocity We want to add only forward speed of the parent to the forward direction of the object, and if parent is going backward, no speed is added.

### 返回

[Vector3](VRageMath.Vector3)



### 参数

* [Vector3](VRageMath.Vector3) forwardVector
* [Vector3](VRageMath.Vector3) projectedVector
