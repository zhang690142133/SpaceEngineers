← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyCommandLine](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine)

### 概要

```csharp
public bool Switch(string name)
```

Determines whether the given switch is set. Switches are specified without their prefixed hyphen.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
### 概要

```csharp
public string Switch(string name, int relativeArgument)
```

Gets an argument of a switch. For example, using`Switch("key", 0)`on the command line`someOtherArgument -key value`will return`value`.

### 返回

[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6)



### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) relativeArgument
