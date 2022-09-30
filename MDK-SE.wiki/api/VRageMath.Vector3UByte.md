← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Vector3UByte Struct

```csharp
public struct Vector3UByte
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static EqualityComparer Comparer](VRageMath.Vector3UByte.Comparer)

> 

[static Vector3UByte Zero](VRageMath.Vector3UByte.Zero)

> 

[byte X](VRageMath.Vector3UByte.X)

> 

[byte Y](VRageMath.Vector3UByte.Y)

> 

[byte Z](VRageMath.Vector3UByte.Z)

> 

#### Constructors

[Vector3UByte(byte x, byte y, byte z)](VRageMath.Vector3UByte..ctor)

> 

[Vector3UByte(Vector3I vec)](VRageMath.Vector3UByte..ctor)

> 

#### 方法

[static Vector3 Denormalize(Vector3UByte vec, float range)](VRageMath.Vector3UByte.Denormalize)

> Unpacks Vector3 from Vector3UByte, scales vector from (0, 255) to (-range, range)

[static Vector3UByte Floor(Vector3 vec)](VRageMath.Vector3UByte.Floor)

> 

[static bool IsMiddle(Vector3UByte vec)](VRageMath.Vector3UByte.IsMiddle)

> Returns true when all components are 127

[static Vector3UByte Normalize(Vector3 vec, float range)](VRageMath.Vector3UByte.Normalize)

> Normalizes Vector3 into Vector4UByte, scales vector from (-range, range) to (0, 255). Unsafe for values "range >= any_vec_value / 257";

[static Vector3UByte Round(Vector3 vec)](VRageMath.Vector3UByte.Round)

> 

[bool Equals(object obj)](VRageMath.Vector3UByte.Equals)

> 

[int GetHashCode()](VRageMath.Vector3UByte.GetHashCode)

> 

[int LengthSquared()](VRageMath.Vector3UByte.LengthSquared)

> 

[string ToString()](VRageMath.Vector3UByte.ToString)

> 

