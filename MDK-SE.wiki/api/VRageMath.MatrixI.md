← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MatrixI Struct

```csharp
public struct MatrixI
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[Direction Backward](VRageMath.MatrixI.Backward)

> 

[Direction Right](VRageMath.MatrixI.Right)

> 

[Vector3I Translation](VRageMath.MatrixI.Translation)

> 

[Direction Up](VRageMath.MatrixI.Up)

> 

#### Properties

[Vector3I BackwardVector { get; set; }](VRageMath.MatrixI.BackwardVector)

> 

[Direction Down { get; set; }](VRageMath.MatrixI.Down)

> 

[Vector3I DownVector { get; set; }](VRageMath.MatrixI.DownVector)

> 

[Direction Forward { get; set; }](VRageMath.MatrixI.Forward)

> 

[Vector3I ForwardVector { get; set; }](VRageMath.MatrixI.ForwardVector)

> 

[Direction Left { get; set; }](VRageMath.MatrixI.Left)

> 

[Vector3I LeftVector { get; set; }](VRageMath.MatrixI.LeftVector)

> 

[Vector3I RightVector { get; set; }](VRageMath.MatrixI.RightVector)

> 

[Vector3I UpVector { get; set; }](VRageMath.MatrixI.UpVector)

> 

#### Constructors

[MatrixI(ref Vector3I position, Direction forward, Direction up)](VRageMath.MatrixI..ctor)

> 

[MatrixI(Vector3I position, Direction forward, Direction up)](VRageMath.MatrixI..ctor)

> 

[MatrixI(Direction forward, Direction up)](VRageMath.MatrixI..ctor)

> 

[MatrixI(ref Vector3I position, ref Vector3I forward, ref Vector3I up)](VRageMath.MatrixI..ctor)

> 

[MatrixI(ref Vector3I position, ref Vector3 forward, ref Vector3 up)](VRageMath.MatrixI..ctor)

> 

[MatrixI(MyBlockOrientation orientation)](VRageMath.MatrixI..ctor)

> 

#### 方法

[static MatrixI CreateRotation(Direction oldA, Direction oldB, Direction newA, Direction newB)](VRageMath.MatrixI.CreateRotation)

> 

[static void Invert(ref MatrixI matrix, out MatrixI result)](VRageMath.MatrixI.Invert)

> 

[static void Multiply(ref MatrixI leftMatrix, ref MatrixI rightMatrix, out MatrixI result)](VRageMath.MatrixI.Multiply)

> 

[static MyBlockOrientation Transform(ref MyBlockOrientation orientation, ref MatrixI transform)](VRageMath.MatrixI.Transform)

> 

[MyBlockOrientation GetBlockOrientation()](VRageMath.MatrixI.GetBlockOrientation)

> 

[Direction GetDirection(Direction direction)](VRageMath.MatrixI.GetDirection)

> 

[Matrix GetFloatMatrix()](VRageMath.MatrixI.GetFloatMatrix)

> 

[void SetDirection(Direction dirToSet, Direction newDirection)](VRageMath.MatrixI.SetDirection)

> 

