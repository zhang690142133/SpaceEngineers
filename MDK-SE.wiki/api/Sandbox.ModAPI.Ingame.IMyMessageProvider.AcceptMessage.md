← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyMessageProvider](Sandbox.ModAPI.Ingame.IMyMessageProvider)

### 概要

```csharp
public MyIGCMessage AcceptMessage()
```

Accepts first message from pending message queue for this message provider. Messages are guaranteed to be dequeued and returned by this method in order they arrived.

### 返回

[MyIGCMessage](Sandbox.ModAPI.Ingame.MyIGCMessage)

First message from pending message queue, default( [MyIGCMessage](Sandbox.ModAPI.Ingame.MyIGCMessage) ) if there are no messages pending to be accepted.

