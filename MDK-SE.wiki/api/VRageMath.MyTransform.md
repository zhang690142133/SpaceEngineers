← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyTransform Struct

```csharp
public struct MyTransform
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[Vector3 Position](VRageMath.MyTransform.Position)

> 

[Quaternion Rotation](VRageMath.MyTransform.Rotation)

> 

#### Properties

[Matrix TransformMatrix { get; }](VRageMath.MyTransform.TransformMatrix)

> 

#### Constructors

[MyTransform(Vector3 position)](VRageMath.MyTransform..ctor)

> 

[MyTransform(Matrix matrix)](VRageMath.MyTransform..ctor)

> 

[MyTransform(ref Vector3 position)](VRageMath.MyTransform..ctor)

> 

[MyTransform(ref Matrix matrix)](VRageMath.MyTransform..ctor)

> 

#### 方法

[static MyTransform Transform(ref MyTransform t1, ref MyTransform t2)](VRageMath.MyTransform.Transform)

> 

[static void Transform(ref MyTransform t1, ref MyTransform t2, out MyTransform result)](VRageMath.MyTransform.Transform)

> 

[static Vector3 Transform(ref Vector3 v, ref MyTransform t2)](VRageMath.MyTransform.Transform)

> 

[static void Transform(ref Vector3 v, ref MyTransform t2, out Vector3 result)](VRageMath.MyTransform.Transform)

> 

