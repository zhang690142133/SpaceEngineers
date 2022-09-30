# Example 4 Add Unicast reply and receive

The beginning part of the code is exactly the same as in Example 3 (and that's one of the points of using the class).
* [Start](https://github.com/malware-dev/MDK-SE/wiki/Advanced:-IGC:-Example-3-Simple-Echo-using-wicoIGC-Class#start)
* [Constructor](https://github.com/malware-dev/MDK-SE/wiki/Advanced:-IGC:-Example-3-Simple-Echo-using-wicoIGC-Class#constructor)
* [Main](https://github.com/malware-dev/MDK-SE/wiki/Advanced:-IGC:-Example-3-Simple-Echo-using-wicoIGC-Class#main)

# Message handler

## Initialization
Initialization is almost the same as in example 3.  A unicast handler is added to process those messages.

```csharp
string _broadCastTag = "MDK IGC Example 4";
string _unicastTag   = "MDK IGC Example 4 Ack";

void InitMessageHandlers()
{
    // creates a BROADCAST channel with the specified tag and calls the handler when messages are processed
    _wicoIGC.AddPublicHandler(_broadCastTag, TestBroadcastHandler);

    // calls the handler when UNICAST messages are processed
    _wicoIGC.AddUnicastHandler(TestUnicastHandler);
}
```
## Broadcast Message Handler

The broadcast handler is almost the same as in Example 3.  We add sending a unicast message back to the source acknowledging that we received the message.

For more reasonable use cases, the message back could contain information about our grid or other information that was 'requested' in the broadcast message.  Also note that the scripts could continue to send unicast messages back and forth for the rest of the 'conversation' and just use the broadcast message to get 'introduced'.

```csharp
        // Now reply to the sender and let them know we received the message
        IGC.SendUnicastMessage(msg.Source, _unicastTag, "Acknowledge by:"+Me.CustomName);
        Echo(" Reply Sent");

```
## Unicast Message Handler

The unicast message handler is very close to the broadcast message handler processing since we are just outputting the information from the message.

Note that the handler will be called for ALL unicast messages sent to this script.
```csharp
void TestUnicastHandler(MyIGCMessage msg)
{
    // NOTE: Called for ALL received unicast messages
    if (msg.Tag != _unicastTag)
        return; // not our message

    if (msg.Data is string)
    {
        Echo("Received Acknowledge Message");
        Echo(" Source=" + msg.Source.ToString("X"));
        Echo(" Data=\"" + msg.Data + "\"");
        Echo(" Tag=" + msg.Tag);
    }
}
```

# Wico IGC Class
See the [explanation from Example 3 here](https://github.com/malware-dev/MDK-SE/wiki/Advanced:-IGC:-Example-3-Simple-Echo-using-wicoIGC-Class#wicoigc-class)

# Complete Code

```csharp
/*
 * This is MDK IGC Example 4 by wicorel
 * 
 * This does a simple echo of a received BROADCAST message. 
 * It sends out any arguments received on the broadcast channel.
 * 
 * It then responds with a UNICAST message back to the sending script.
 * 
 * Go to:
 *  https://github.com/malware-dev/MDK-SE/wiki/Quick-Introduction-to-Space-Engineers-Ingame-Scripts
 *  to learn more about ingame scripts.
 * 
 * This Example source: 
 *  https://github.com/Wicorel/WicoSpaceEngineers/tree/master/Modular/MDK%20IGC%20Example%204
 */

WicoIGC _wicoIGC;

/// <summary>
        /// The combined set of UpdateTypes that count as a 'trigger'
        /// </summary>
UpdateType _utTriggers = UpdateType.Terminal | UpdateType.Trigger | UpdateType.Mod | UpdateType.Script;

/// <summary>
        /// the combined set of UpdateTypes and count as an 'Update'
        /// </summary>
UpdateType _utUpdates = UpdateType.Update1 | UpdateType.Update10 | UpdateType.Update100 | UpdateType.Once;

public Program()
{
    _wicoIGC = new WicoIGC(this);

    // cause ourselves to run again so we can do the init
    Runtime.UpdateFrequency = UpdateFrequency.Once;
}

public void Save()
{
}

/// <summary>
        /// Has everything been initialized?
        /// </summary>
bool _areWeInited = false;

public void Main(string argument, UpdateType updateSource)
{
    // Echo some information aboue 'me' and why we were run
    Echo("Source=" + updateSource.ToString());
    Echo("Me=" + Me.EntityId.ToString("X"));
    Echo(Me.CubeGrid.CustomName);

    if (!_areWeInited)
    {
        InitMessageHandlers();
        _areWeInited = true;
    }

    // use if not setting callbacks for any of the desired channels
    //            if (bInit) wicoIGC.ProcessIGCMessages();

    // always check for IGC messages in case some aren't using callbacks
    _wicoIGC.ProcessIGCMessages();
    if ((updateSource & UpdateType.IGC) > 0)
    {
        // we got a callback for an IGC message.
        // but we already processed them.
    }
    else if ((updateSource & _utTriggers) > 0)
    {
        // if we got a 'trigger' source, send out the received argument
        IGC.SendBroadcastMessage(_broadCastTag, argument);
        Echo("Sending Message:\n" + argument);
    }
    else if ((updateSource & _utUpdates) > 0)
    {
        // it was an automatic update

        // this script doens't have anything to do
    }
}

/// <summary>
        /// This is our unique ID for our message.  We've defined the format for the message data (it's just a string)
        /// </summary>
string _broadCastTag = "MDK IGC Example 4";
string _unicastTag   = "MDK IGC Example 4 Ack";

void InitMessageHandlers()
{
    // creates a BROADCAST channel with the specified tag and calls the handler when messages are processed
    _wicoIGC.AddPublicHandler(_broadCastTag, TestBroadcastHandler);

    // calls the handler when UNICAST messages are processed
    _wicoIGC.AddUnicastHandler(TestUnicastHandler);
}

// Handler for the test broadcast messages.
void TestBroadcastHandler(MyIGCMessage msg)
{
    // NOTE: called on ALL received messages; not just 'our' tag

    if (msg.Tag != _broadCastTag)
        return; // not our message

    if (msg.Data is string)
    {
        Echo("Received Test Message");
        Echo(" Source=" + msg.Source.ToString("X"));
        Echo(" Data=\"" + msg.Data + "\"");
        Echo(" Tag=" + msg.Tag);

        // Now reply to the sender and let them know we received the message
        IGC.SendUnicastMessage(msg.Source, _unicastTag, "Acknowledge by:"+Me.CustomName);
        Echo(" Reply Sent");
    }
}

void TestUnicastHandler(MyIGCMessage msg)
{
    // NOTE: Called for ALL received unicast messages
    if (msg.Tag != _unicastTag)
        return; // not our message

    if (msg.Data is string)
    {
        Echo("Received Acknowledge Message");
        Echo(" Source=" + msg.Source.ToString("X"));
        Echo(" Data=\"" + msg.Data + "\"");
        Echo(" Tag=" + msg.Tag);
    }

}

// Source is available from: https://github.com/Wicorel/WicoSpaceEngineers/tree/master/Modular/IGC
class WicoIGC
{
    // the one and only unicast listener.  Must be shared amoung all interested parties
    IMyUnicastListener _unicastListener;

    /// <summary>
            /// the list of unicast message handlers. All handlers will be called on pending messages
            /// </summary>
    List<Action<MyIGCMessage>> _unicastMessageHandlers = new List<Action<MyIGCMessage>>();

    /// <summary>
            /// List of 'registered' broadcst message handlers.  All handlers will be called on each message received
            /// </summary>
    List<Action<MyIGCMessage>> _broadcastMessageHandlers = new List<Action<MyIGCMessage>>();
    /// <summary>
            /// List of broadcast channels.  All channels will be checked for incoming messages
            /// </summary>
    List<IMyBroadcastListener> _broadcastChannels = new List<IMyBroadcastListener>();

    MyGridProgram _gridProgram;
    bool _debug = false;
    IMyTextPanel _debugTextPanel;

    /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="myProgram"></param>
            /// <param name="debug"></param>
    public WicoIGC(MyGridProgram myProgram, bool debug = false)
    {
        _gridProgram = myProgram;
        _debug = debug;
        _debugTextPanel = _gridProgram.GridTerminalSystem.GetBlockWithName("IGC Report") as IMyTextPanel;
        if (_debug) _debugTextPanel?.WriteText("");
    }

    /// <summary>
            /// Call to add a handler for public messages.  Also registers the tag with IGC for reception.
            /// </summary>
            /// <param name="channelTag">The tag for the channel.  This should be unique to the use of the channel.</param>
            /// <param name="handler">The handler for messages when received. Note that this handler will be called with ALL broadcast messages; not just the one from ChannelTag</param>
            /// <param name="setCallback">Should a callback be set on the channel. The system will call Main() when the IGC message is received.</param>
            /// <returns></returns>
    public bool AddPublicHandler(string channelTag, Action<MyIGCMessage> handler, bool setCallback = true)
    {
        IMyBroadcastListener publicChannel;
        // IGC Init
        publicChannel = _gridProgram.IGC.RegisterBroadcastListener(channelTag); // What it listens for
        if (setCallback) publicChannel.SetMessageCallback(channelTag); // What it will run the PB with once it has a message

        // add broadcast message handlers
        _broadcastMessageHandlers.Add(handler);

        // add to list of channels to check
        _broadcastChannels.Add(publicChannel);
        return true;
    }

    /// <summary>
            /// Add a unicast handler.
            /// </summary>
            /// <param name="handler">The handler for messages when received. Note that this handler will be called with ALL Unicast messages. Always sets a callback handler</param>
            /// <returns></returns>
    public bool AddUnicastHandler(Action<MyIGCMessage> handler)
    {
        _unicastListener = _gridProgram.IGC.UnicastListener;
        _unicastListener.SetMessageCallback("UNICAST");
        _unicastMessageHandlers.Add(handler);
        return true;

    }
    /// <summary>
            /// Process all pending IGC messages.
            /// </summary>
    public void ProcessIGCMessages()
    {
        bool bFoundMessages = false;
        if (_debug) _gridProgram.Echo(_broadcastChannels.Count.ToString() + " broadcast channels");
        if (_debug) _gridProgram.Echo(_broadcastMessageHandlers.Count.ToString() + " broadcast message handlers");
        if (_debug) _gridProgram.Echo(_unicastMessageHandlers.Count.ToString() + " unicast message handlers");
        // TODO: make this a yield return thing if processing takes too long
        do
        {
            bFoundMessages = false;
            foreach (var channel in _broadcastChannels)
            {
                if (channel.HasPendingMessage)
                {
                    bFoundMessages = true;
                    var msg = channel.AcceptMessage();
                    if (_debug)
                    {
                        _gridProgram.Echo("Broadcast received. TAG:" + msg.Tag);
                        _debugTextPanel?.WriteText("IGC:" +msg.Tag+" SRC:"+msg.Source.ToString("X")+"\n",true);
                    }
                    foreach (var handler in _broadcastMessageHandlers)
                    {
                        handler(msg);
                    }
                }
            }
        } while (bFoundMessages); // Process all pending messages

        if (_unicastListener != null)
        {
            // TODO: make this a yield return thing if processing takes too long
            do
            {
                // since there's only one channel, we could just use .HasPendingMessages directly.. but this keeps the code loops the same
                bFoundMessages = false;

                if (_unicastListener.HasPendingMessage)
                {
                    bFoundMessages = true;
                    var msg = _unicastListener.AcceptMessage();
                    if (_debug) _gridProgram.Echo("Unicast received. TAG:" + msg.Tag);
                    foreach (var handler in _unicastMessageHandlers)
                    {
                        // Call each handler
                        handler(msg);
                    }
                }
            } while (bFoundMessages); // Process all pending messages
        }

    }
}
```

