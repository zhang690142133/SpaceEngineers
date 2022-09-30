← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MathHelper](VRageMath.MathHelper)

### 概要

```csharp
public static float MonotonicCosine(float radians)
```

Calculate the monotonic cosine of a value. Monotonic cosine is an alternative cosine encoding that is monotonic in the [-pi, pi] interval. We use this when some parameter of an onject in a planet is constrained by latitude. The 'monotonicity' is guaranteed by subtracting the cosine value from 2 if the angle is positive. So for instance MonotonicCos(pi/2) = 2. This only works in the above interval of course.

### 返回

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

The cosine of the angle if it is > 0, 2 - that value otherwise.

### 参数

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) radians
