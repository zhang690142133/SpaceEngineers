← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Curve Class

```csharp
public class Curve
```

Stores an arbitrary collection of 2D CurveKey points, and provides methods for evaluating features of the curve they define.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Properties

[bool IsConstant { get; }](VRageMath.Curve.IsConstant)

> Gets a value indicating whether the curve is constant.

[CurveKeyCollection Keys { get; }](VRageMath.Curve.Keys)

> The points that make up the curve.

[CurveLoopType PostLoop { get; set; }](VRageMath.Curve.PostLoop)

> Specifies how to handle weighting values that are greater than the last control point in the curve.

[CurveLoopType PreLoop { get; set; }](VRageMath.Curve.PreLoop)

> Specifies how to handle weighting values that are less than the first control point in the curve.

#### Constructors

[Curve()](VRageMath.Curve..ctor)

> 

#### 方法

[Curve Clone()](VRageMath.Curve.Clone)

> Creates a copy of the Curve.

[void ComputeTangent(int keyIndex, CurveTangent tangentType)](VRageMath.Curve.ComputeTangent)

> Computes both the TangentIn and the TangentOut for a CurveKey specified by its index.

[void ComputeTangent(int keyIndex, CurveTangent tangentInType, CurveTangent tangentOutType)](VRageMath.Curve.ComputeTangent)

> Computes a specified type of TangentIn and a specified type of TangentOut for a given CurveKey.

[void ComputeTangents(CurveTangent tangentType)](VRageMath.Curve.ComputeTangents)

> Computes all tangents for all CurveKeys in this Curve, using a specified tangent type for both TangentIn and TangentOut.

[void ComputeTangents(CurveTangent tangentInType, CurveTangent tangentOutType)](VRageMath.Curve.ComputeTangents)

> Computes all tangents for all CurveKeys in this Curve, using different tangent types for TangentOut and TangentIn.

[float Evaluate(float position)](VRageMath.Curve.Evaluate)

> Finds the value at a position on the Curve.

