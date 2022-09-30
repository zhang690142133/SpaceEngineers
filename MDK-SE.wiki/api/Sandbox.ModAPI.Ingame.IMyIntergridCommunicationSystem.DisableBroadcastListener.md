← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyIntergridCommunicationSystem](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem)

### 概要

```csharp
public void DisableBroadcastListener(IMyBroadcastListener broadcastListener)
```

Disables given broadcast listener. In case given broadcast listener is not active nothing happens. Instance of this broadcast listener remains valid and all pending messages may be accepted as normal. Disabling broadcast listener also disables it's message callback, if active. Consuming the last pending message will permanently disable the provided listener and it's never going to be activated again. ==> Registering new broadcast lister with the same tag will allocate new listener instance instead.

### 参数

* [IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener) broadcastListener
