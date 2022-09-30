← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyMessageProvider Interface

```csharp
public interface IMyMessageProvider
```

Base interface for all message providers.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Inheritors:**  
* [IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener)  
* [IMyUnicastListener](Sandbox.ModAPI.Ingame.IMyUnicastListener)

#### Properties

[bool HasPendingMessage { get; }](Sandbox.ModAPI.Ingame.IMyMessageProvider.HasPendingMessage)

> Determines whether there is a message pending to be accepted in this message provider or not. There may be multiple messages pending in single message provider. In such case the flag will stay raised until the last message is consumed.

[int MaxWaitingMessages { get; }](Sandbox.ModAPI.Ingame.IMyMessageProvider.MaxWaitingMessages)

> Indicates number of max messages waiting in queue before the oldest one will be dropped to make space for new one.

#### 方法

[MyIGCMessage AcceptMessage()](Sandbox.ModAPI.Ingame.IMyMessageProvider.AcceptMessage)

> Accepts first message from pending message queue for this message provider. Messages are guaranteed to be dequeued and returned by this method in order they arrived.

[void DisableMessageCallback()](Sandbox.ModAPI.Ingame.IMyMessageProvider.DisableMessageCallback)

> Disables registered message callback.

[void SetMessageCallback(string argument = "")](Sandbox.ModAPI.Ingame.IMyMessageProvider.SetMessageCallback)

> Whenever given message provider obtains new message respective programmable block gets called with provided argument. Each raised callback argument will be called only once per simulation tick no matter how many messages are there pending to be accepted. At most a single callback will be invoked each tick ==> If there are messages pending in multiple message providers with registered callback, one will be randomly picked and invoked. Rest will be deferred to the next tick and follow the same process. In case you don't consume all messages pending in given message provider, the callback will not be raise again in following tick unless new message arrives.

