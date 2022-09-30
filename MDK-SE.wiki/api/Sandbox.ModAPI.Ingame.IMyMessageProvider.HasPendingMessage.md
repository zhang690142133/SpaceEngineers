← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyMessageProvider](Sandbox.ModAPI.Ingame.IMyMessageProvider)

### 概要

```csharp
public bool HasPendingMessage { get; }
```

Determines whether there is a message pending to be accepted in this message provider or not. There may be multiple messages pending in single message provider. In such case the flag will stay raised until the last message is consumed.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

