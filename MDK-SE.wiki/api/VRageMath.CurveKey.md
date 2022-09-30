← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### CurveKey Class

```csharp
public class CurveKey: IEquatable<CurveKey>, IComparable<CurveKey>
```

Represents a point in a multi-point curve.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IComparable&lt;CurveKey&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable&lt;CurveKey&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Properties

[CurveContinuity Continuity { get; set; }](VRageMath.CurveKey.Continuity)

> Describes whether the segment between this point and the next point in the curve is discrete or continuous.

[float Position { get; }](VRageMath.CurveKey.Position)

> Position of the CurveKey in the curve.

[float TangentIn { get; set; }](VRageMath.CurveKey.TangentIn)

> Describes the tangent when approaching this point from the previous point in the curve.

[float TangentOut { get; set; }](VRageMath.CurveKey.TangentOut)

> Describes the tangent when leaving this point to the next point in the curve.

[float Value { get; set; }](VRageMath.CurveKey.Value)

> Describes the value of this point.

#### Constructors

[CurveKey()](VRageMath.CurveKey..ctor)

> 

[CurveKey(float position, float value)](VRageMath.CurveKey..ctor)

> 

[CurveKey(float position, float value, float tangentIn, float tangentOut)](VRageMath.CurveKey..ctor)

> 

[CurveKey(float position, float value, float tangentIn, float tangentOut, CurveContinuity continuity)](VRageMath.CurveKey..ctor)

> 

#### 方法

[CurveKey Clone()](VRageMath.CurveKey.Clone)

> Creates a copy of the CurveKey.

[int CompareTo(CurveKey other)](VRageMath.CurveKey.CompareTo)

> Compares this instance to another CurveKey and returns an indication of their relative values.

[bool Equals(CurveKey other)](VRageMath.CurveKey.Equals)

> Determines whether the specified Object is equal to the CurveKey.

[bool Equals(object obj)](VRageMath.CurveKey.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int GetHashCode()](VRageMath.CurveKey.GetHashCode)

> Returns the hash code for this instance.

