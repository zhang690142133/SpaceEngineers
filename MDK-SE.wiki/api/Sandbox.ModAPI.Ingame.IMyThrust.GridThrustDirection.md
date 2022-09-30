← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyThrust](Sandbox.ModAPI.Ingame.IMyThrust)

### 概要

```csharp
public Vector3I GridThrustDirection { get; }
```

Gets the direction of thrust, relative to ship controller (cockpit).

### 返回

[Vector3I](VRageMath.Vector3I)

### Remarks

For example, a value of [Forward](VRageMath.Vector3I.Forward) means the thruster will move the grid along the grid's forward direction. A value of Vector3D.Zero means direction is unknown (no cockpit available).

