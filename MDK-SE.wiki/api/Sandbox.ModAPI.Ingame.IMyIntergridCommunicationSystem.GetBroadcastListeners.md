← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyIntergridCommunicationSystem](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem)

### 概要

```csharp
public void GetBroadcastListeners(List<IMyBroadcastListener> broadcastListeners, Func<IMyBroadcastListener, bool> collect = null)
```

Retrieves list of all active broadcast listeners and listeners with pending messages, registered by current programmable block. Returned list is snapshot of current state and is not updated by future operations.

### 参数

* [List&lt;IMyBroadcastListener&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) broadcastListeners
* [Func&lt;IMyBroadcastListener, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) collect
