← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Plane](VRageMath.Plane)

### 概要

```csharp
public float D
```

The distance of the Plane along its normal from the origin. Note: Be careful! The distance is signed and is the opposite of what people usually expect. If you look closely at the plane equation: (n dot P) - D = 0, you'll realize that D = - (n dot P) (that is, negative instead of positive)

### 返回

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

