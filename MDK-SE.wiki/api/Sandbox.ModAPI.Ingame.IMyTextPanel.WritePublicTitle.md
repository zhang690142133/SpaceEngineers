← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyTextPanel](Sandbox.ModAPI.Ingame.IMyTextPanel)

### 概要

```csharp
public bool WritePublicTitle(string value, bool append = default)
```

Writes LCD popup dialog title If somebody opened LCD text in popup dialog, text can no longer be added.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

False is if somebody currently has opened LCD text in popup dialog, true in other cases

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) value
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) append
