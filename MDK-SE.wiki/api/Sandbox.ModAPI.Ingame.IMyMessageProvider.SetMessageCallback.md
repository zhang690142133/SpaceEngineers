← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyMessageProvider](Sandbox.ModAPI.Ingame.IMyMessageProvider)

### 概要

```csharp
public void SetMessageCallback(string argument = "")
```

Whenever given message provider obtains new message respective programmable block gets called with provided argument. Each raised callback argument will be called only once per simulation tick no matter how many messages are there pending to be accepted. At most a single callback will be invoked each tick ==> If there are messages pending in multiple message providers with registered callback, one will be randomly picked and invoked. Rest will be deferred to the next tick and follow the same process. In case you don't consume all messages pending in given message provider, the callback will not be raise again in following tick unless new message arrives.

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) argument
