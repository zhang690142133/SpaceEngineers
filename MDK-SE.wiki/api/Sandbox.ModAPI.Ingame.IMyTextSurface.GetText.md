← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)

### 概要

```csharp
public string GetText()
```

Gets current text that is written on surface. Allocates memory (StringBuilder.ToString())! This method doesn't allocate memory [ReadText(StringBuilder, bool = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.ReadText) 

### 返回

[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6)

Current text

