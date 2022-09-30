← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MatrixD](VRageMath.MatrixD)

### 概要

```csharp
public bool HasNoTranslationOrPerspective()
```

Returns true if this matrix represents invertible (you can call Invert on it) linear (it does not contain translation or perspective transformation) transformation. Such matrix consist solely of rotations, shearing, mirroring and scaling. It can be orthogonalized to create an orthogonal rotation matrix.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

