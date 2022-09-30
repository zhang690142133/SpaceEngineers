← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxI](VRageMath.BoundingBoxI)

### 概要

```csharp
public static IEnumerable<Vector3I> IterateDifference(BoundingBoxI left, BoundingBoxI right)
```

Iterate every cell contained in {left} - {right}, where we interpret {box} as the set of all distinct Vector3I points inside a 'box'. Containment is taken in a typical inclusive start, exclusive end fashion.

### 返回

[IEnumerable&lt;Vector3I&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)



### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) left
* [BoundingBoxI](VRageMath.BoundingBoxI) right
