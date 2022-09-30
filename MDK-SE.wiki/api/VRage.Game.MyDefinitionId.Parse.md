← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyDefinitionId](VRage.Game.MyDefinitionId)

### 概要

```csharp
public static MyDefinitionId Parse(string id)
```

Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type. If it does not, an exception will be thrown. The second (the subtype) is not enforced. See TryParse for a parsing method that does not throw an exception.

### 返回

[MyDefinitionId](VRage.Game.MyDefinitionId)



### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) id
