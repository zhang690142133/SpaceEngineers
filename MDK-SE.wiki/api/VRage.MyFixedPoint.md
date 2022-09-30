← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyFixedPoint Struct

```csharp
public struct MyFixedPoint: IXmlSerializable
```

Fixed point number represented as 64-bit integer with 6 decimal places (one millionts)

**命名空间:** [VRage](VRage)  
**Assembly:** VRage.Library.dll

**Implements:**  
* IXmlSerializable <sub>prohibited</sub>

#### Fields

[static MyFixedPoint MaxIntValue](VRage.MyFixedPoint.MaxIntValue)

> 

[static MyFixedPoint MaxValue](VRage.MyFixedPoint.MaxValue)

> 

[static MyFixedPoint MinIntValue](VRage.MyFixedPoint.MinIntValue)

> 

[static MyFixedPoint MinValue](VRage.MyFixedPoint.MinValue)

> 

[static MyFixedPoint SmallestPossibleValue](VRage.MyFixedPoint.SmallestPossibleValue)

> 

[static MyFixedPoint Zero](VRage.MyFixedPoint.Zero)

> 

[long RawValue](VRage.MyFixedPoint.RawValue)

> 

#### 方法

[static MyFixedPoint AddSafe(MyFixedPoint a, MyFixedPoint b)](VRage.MyFixedPoint.AddSafe)

> 

[static MyFixedPoint Ceiling(MyFixedPoint a)](VRage.MyFixedPoint.Ceiling)

> 

[static MyFixedPoint DeserializeString(string text)](VRage.MyFixedPoint.DeserializeString)

> 

[static MyFixedPoint DeserializeStringSafe(string text)](VRage.MyFixedPoint.DeserializeStringSafe)

> For XmlSerialization, format is 123.456789 Handles double and decimal formats too.

[static MyFixedPoint Floor(MyFixedPoint a)](VRage.MyFixedPoint.Floor)

> 

[static bool IsIntegral(MyFixedPoint fp)](VRage.MyFixedPoint.IsIntegral)

> 

[static MyFixedPoint Max(MyFixedPoint a, MyFixedPoint b)](VRage.MyFixedPoint.Max)

> 

[static MyFixedPoint Min(MyFixedPoint a, MyFixedPoint b)](VRage.MyFixedPoint.Min)

> 

[static MyFixedPoint MultiplySafe(MyFixedPoint a, float b)](VRage.MyFixedPoint.MultiplySafe)

> 

[static MyFixedPoint MultiplySafe(MyFixedPoint a, int b)](VRage.MyFixedPoint.MultiplySafe)

> 

[static MyFixedPoint MultiplySafe(float a, MyFixedPoint b)](VRage.MyFixedPoint.MultiplySafe)

> 

[static MyFixedPoint MultiplySafe(int a, MyFixedPoint b)](VRage.MyFixedPoint.MultiplySafe)

> 

[static MyFixedPoint MultiplySafe(MyFixedPoint a, MyFixedPoint b)](VRage.MyFixedPoint.MultiplySafe)

> 

[static MyFixedPoint Round(MyFixedPoint a)](VRage.MyFixedPoint.Round)

> 

[bool Equals(object obj)](VRage.MyFixedPoint.Equals)

> 

[int GetHashCode()](VRage.MyFixedPoint.GetHashCode)

> 

[string SerializeString()](VRage.MyFixedPoint.SerializeString)

> For XmlSerialization, format is 123.456789

[int ToIntSafe()](VRage.MyFixedPoint.ToIntSafe)

> 

[string ToString()](VRage.MyFixedPoint.ToString)

> 

