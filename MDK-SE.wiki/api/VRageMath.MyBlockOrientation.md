← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyBlockOrientation Struct

```csharp
public struct MyBlockOrientation
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static MyBlockOrientation Identity](VRageMath.MyBlockOrientation.Identity)

> 

[Direction Forward](VRageMath.MyBlockOrientation.Forward)

> 

[Direction Up](VRageMath.MyBlockOrientation.Up)

> 

#### Properties

[bool IsValid { get; }](VRageMath.MyBlockOrientation.IsValid)

> 

[Direction Left { get; }](VRageMath.MyBlockOrientation.Left)

> 

#### Constructors

[MyBlockOrientation(Direction forward, Direction up)](VRageMath.MyBlockOrientation..ctor)

> 

[MyBlockOrientation(ref Quaternion q)](VRageMath.MyBlockOrientation..ctor)

> 

[MyBlockOrientation(ref Matrix m)](VRageMath.MyBlockOrientation..ctor)

> 

#### 方法

[bool Equals(object obj)](VRageMath.MyBlockOrientation.Equals)

> 

[int GetHashCode()](VRageMath.MyBlockOrientation.GetHashCode)

> 

[void GetMatrix(out Matrix result)](VRageMath.MyBlockOrientation.GetMatrix)

> 

[void GetQuaternion(out Quaternion result)](VRageMath.MyBlockOrientation.GetQuaternion)

> 

[string ToString()](VRageMath.MyBlockOrientation.ToString)

> 

[Direction TransformDirection(Direction baseDirection)](VRageMath.MyBlockOrientation.TransformDirection)

> 

[Direction TransformDirectionInverse(Direction baseDirection)](VRageMath.MyBlockOrientation.TransformDirectionInverse)

> 

