← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyDefinitionId](VRage.Game.MyDefinitionId)

### 概要

```csharp
public static bool TryParse(string id, out MyDefinitionId definitionId)
```

Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type, while the second (the subtype) is not enforced.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) id
* [MyDefinitionId](VRage.Game.MyDefinitionId) definitionId
### 概要

```csharp
public static bool TryParse(string type, string subtype, out MyDefinitionId definitionId)
```

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) type
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) subtype
* [MyDefinitionId](VRage.Game.MyDefinitionId) definitionId
