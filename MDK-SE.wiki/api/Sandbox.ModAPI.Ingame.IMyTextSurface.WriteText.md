← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)

### 概要

```csharp
public bool WriteText(string value, bool append = default)
```

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if text was added, or replaced. False if somebody was looking at lcd

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) value
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) append
### 概要

```csharp
public bool WriteText(StringBuilder value, bool append = default)
```

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if text was added, or replaced. False if somebody was looking at lcd

### 参数

* [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/System.Text.StringBuilder?view=netframework-4.6) value
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) append
