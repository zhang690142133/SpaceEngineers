← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### CurveContinuity Enum

```csharp
public enum CurveContinuity
```

Defines the continuity of CurveKeys on a Curve.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

CurveContinuity Smooth

> Interpolation can be used between this CurveKey and the next.

CurveContinuity Step

> Interpolation cannot be used between this CurveKey and the next. Specifying a position between the two points returns this point.

