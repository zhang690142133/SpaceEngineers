← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyIni](VRage.Game.ModAPI.Ingame.Utilities.MyIni)

### 概要

```csharp
public bool TryParse(string content)
```

Attempts to parse the given content as a configuration file.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the parse succeeds,`false`otherwise

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) content
### 概要

```csharp
public bool TryParse(string content, out MyIniParseResult result)
```

Attempts to parse the given content as a configuration file.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the parse succeeds,`false`otherwise

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) content
* [MyIniParseResult](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult) result
### 概要

```csharp
public bool TryParse(string content, string section, out MyIniParseResult result)
```

Attempts to parse the given content as a configuration file. OBSERVE: Use only for read-only operations. If you parse a single section and run [ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIni.ToString) , you will only get the parsed section, the rest will be discarded.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the parse succeeds,`false`otherwise

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) content
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) section
* [MyIniParseResult](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult) result
### 概要

```csharp
public bool TryParse(string content, string section)
```

Attempts to parse the given content as a configuration file. OBSERVE: Use only for read-only operations. If you parse a single section and run [ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIni.ToString) , you will only get the parsed section, the rest will be discarded.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the parse succeeds,`false`otherwise

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) content
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) section
