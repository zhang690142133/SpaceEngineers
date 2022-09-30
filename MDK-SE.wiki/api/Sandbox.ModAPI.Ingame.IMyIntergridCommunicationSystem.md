← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyIntergridCommunicationSystem Interface

```csharp
public interface IMyIntergridCommunicationSystem
```

This is the entry point for all communication operations.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Properties

[long Me { get; }](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.Me)

> Gets communication address for current programmable block.

[IMyUnicastListener UnicastListener { get; }](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.UnicastListener)

> Gets unicast listener for current programmable block.

#### 方法

[void DisableBroadcastListener(IMyBroadcastListener broadcastListener)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.DisableBroadcastListener)

> Disables given broadcast listener. In case given broadcast listener is not active nothing happens. Instance of this broadcast listener remains valid and all pending messages may be accepted as normal. Disabling broadcast listener also disables it's message callback, if active. Consuming the last pending message will permanently disable the provided listener and it's never going to be activated again. ==> Registering new broadcast lister with the same tag will allocate new listener instance instead.

[void GetBroadcastListeners(List&lt;IMyBroadcastListener&gt; broadcastListeners, Func&lt;IMyBroadcastListener, bool&gt; collect = null)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.GetBroadcastListeners)

> Retrieves list of all active broadcast listeners and listeners with pending messages, registered by current programmable block. Returned list is snapshot of current state and is not updated by future operations.

[bool IsEndpointReachable(long address, TransmissionDistance transmissionDistance = TransmissionDistance.AntennaRelay)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.IsEndpointReachable)

> Determines if given endpoint is currently reachable. Similar to sending ICMP message.

[IMyBroadcastListener RegisterBroadcastListener(string tag)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.RegisterBroadcastListener)

> Registers broadcast listener with given tag for current programmable block. In case there is already another active broadcast lister with given tag new listener is NOT registered and the already active one is returned instead.

[void SendBroadcastMessage&lt;TData&gt;(string tag, TData data, TransmissionDistance transmissionDistance = TransmissionDistance.AntennaRelay)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.SendBroadcastMessage)

> 

[bool SendUnicastMessage&lt;TData&gt;(long addressee, string tag, TData data)](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.SendUnicastMessage)

> 

