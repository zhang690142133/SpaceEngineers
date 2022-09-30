← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### CurveTangent Enum

```csharp
public enum CurveTangent
```

Specifies different tangent types to be calculated for CurveKey points in a Curve.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

CurveTangent Flat

> A Flat tangent always has a value equal to zero.

CurveTangent Linear

> A Linear tangent at a CurveKey is equal to the difference between its Value and the Value of the preceding or succeeding CurveKey. For example, in Curve MyCurve, where i is greater than zero and (i + 1) is less than the total number of CurveKeys in MyCurve, the linear TangentIn of MyCurve.Keys[i] is equal to: ( MyCurve.Keys[i].Value - MyCurve.Keys[i - 1].Value ) Similarly, the linear TangentOut is equal to: ( MyCurve.Keys[i + 1].Value - MyCurve.Keys[i].Value.)

CurveTangent Smooth

> A Smooth tangent smooths the inflection between a TangentIn and TangentOut by taking into account the values of both neighbors of the CurveKey. The smooth TangentIn of MyCurve.Keys[i] is equal to: ( ( MyCurve.Keys[i + 1].Value - MyCurve.Keys[i - 1].Value ) * ( ( MyCurve.Keys[i].Position - MyCurve.Keys[i - 1].Position ) / ( MyCurve.Keys[i + 1].Position - MyCurve.Keys[i-1].Position ) ) ) Similarly, the smooth TangentOut is equal to: ( ( MyCurve.Keys[i + 1].Value - MyCurve.Keys[i - 1].Value ) * ( ( MyCurve.Keys[i + 1].Position - MyCurve.Keys[i].Position ) / ( MyCurve.Keys[i + 1].Position - MyCurve.Keys[i - 1].Position ) ) )

