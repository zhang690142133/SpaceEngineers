# Example 3 Simple Echo using wicoIGC Class
Source project is [available here](https://github.com/Wicorel/WicoSpaceEngineers/tree/master/Modular/IGC%20Modular%20Example)

Some comments have been removed to decrease line count in the explanations.

## Start
The main thing defined here is a reference to the WicoIGC class
```csharp
WicoIGC _wicoIGC;

UpdateType _utTriggers = UpdateType.Terminal | UpdateType.Trigger | UpdateType.Mod | UpdateType.Script;
UpdateType _utUpdates = UpdateType.Update1 | UpdateType.Update10 | UpdateType.Update100 | UpdateType.Once;
```

## Constructor

The constructor creates the WicoIGC class.

It then sets the script to be run once again.  This will allow the script to do initialization after the grid is fully created.

```csharp
public Program()
{
    _wicoIGC = new WicoIGC(this);

    // cause ourselves to run again so we can do the init
    Runtime.UpdateFrequency = UpdateFrequency.Once;
}
```

## Main

## Informational output
Here the script outputs some basic information so that it is clear why the script is being run.
```csharp
    // Echo some information about 'me' and why we were run
    Echo("Source=" + updateSource.ToString());
    Echo("Me=" + Me.EntityId.ToString("X"));
    Echo(Me.CubeGrid.CustomName);
```

## Initialization check and call
The script then checks to see if it has been initialized yet.  If not, it does the initialization and they sets the initialization flag.
```csharp
    if (!_areWeInited)
    {
        InitMessageHandlers();
        _areWeInited = true;
    }
```

## IGC Message Processing
The script then asks the IGC class to process any incoming IGC messages.  This replaced all the code in the previous examples for checking messages and also handles multiple channels.
```csharp
    // always check for IGC messages in case some aren't using callbacks
    _wicoIGC.ProcessIGCMessages();
```

## Sending a message
The next main thing the script does is process the argument if the update type is a trigger.  Just like the previous examples, it sends a message on the broadcast channel to any listeners.
```csharp
    else if((updateSource & _utTriggers) > 0)
    {
        // if we got a 'trigger' source, send out the received argument
        IGC.SendBroadcastMessage(_broadCastTag, argument);
        Echo("Sending Message:\n" + argument);
    }
```


## wicoIGC Message Handler
A message handler is registered and defined.

### Initialization
Interest in the broadcast channel is specified and the handler is provided.  The handler is called when a message is available.

```csharp
string _broadCastTag = "MDK IGC Example 3";

void InitMessageHandlers()
{
    // creates a broadcast channel with the specified tag and calls the handler when messages are processed
    _wicoIGC.AddPublicHandler(_broadCastTag, TestBroadcastHandler);
}
```
### Broadcast Message Handler

This is the handler for the broadcast messages.  Multiple handlers could be registered.  This handler is called by WicoIGC for all incoming broadcast messages.

The message processing code is very similar to the code from previous examples.
The code checks to make sure that the tag is one we recognize and returns if it is not.  It then checks the data type of the message to ensure it's a format we know.  It then does a simple Echo of the message data.

```csharp
// Handler for the test broadcast messages.
void TestBroadcastHandler(MyIGCMessage msg)
{
    // NOTE: called on ALL received messages; not just 'our' tag

    if (msg.Tag!= _broadCastTag)
        return; // not our message

    if (msg.Data is string)
    {
        Echo("Received Test Message");
        Echo(" Source=" + msg.Source.ToString("X"));
        Echo(" Data=\"" + msg.Data + "\"");
        Echo(" Tag=" + msg.Tag);
    }
}
```

# wicoIGC Class

This is a class for processing of incoming messages.  It works with handlers added by other parts of the script to actually do the handling of the contents of the messages.

It handles both broadcast and unicast messages. Broadcast channels can be added so that it's easy to handle multiple channels. 

Message handlers are added to make handling of messages simpler.  The handlers is called when a message is available.

## Class Variables
```csharp
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
```

## Class Constructor

The constructor requires MyGridProgram for access to functions and has an optional debug parameter.

The constructor saves the passed parameters and tries to find a debug text panel to use.

```csharp
    public WicoIGC(MyGridProgram myProgram, bool debug = false)
    {
        _gridProgram = myProgram;
        _debug = debug;
        _debugTextPanel = _gridProgram.GridTerminalSystem.GetBlockWithName("IGC Report") as IMyTextPanel;
        if (_debug) _debugTextPanel?.WriteText("");
    }

```

## AddPublicHandler
This routine creates a public channel and adds a handler to the list of handlers.

```csharp
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

```

## AddUnicastHandler

This routine will add a handler to the list of unicast messages.  Not that there is no need to register the tag with the system; all unicast messages sent to this script will be put into the unicast receive queue.

```cs
    public bool AddUnicastHandler(Action<MyIGCMessage> handler)
    {
        _unicastListener = _gridProgram.IGC.UnicastListener;
        _unicastListener.SetMessageCallback("UNICAST");
        _unicastMessageHandlers.Add(handler);
        return true;

    }
```

## ProcessIGCMessages()

This routine handles the processing of the IGC messages that have been received.  It will call the handlers with the messages as a parameter for each message received.

### Start

The start of the routine handles some debug messages if debug is turned on.

```csharp
    public void ProcessIGCMessages()
    {
        bool bFoundMessages = false;
        if (_debug) _gridProgram.Echo(_broadcastChannels.Count.ToString() + " broadcast channels");
        if (_debug) _gridProgram.Echo(_broadcastMessageHandlers.Count.ToString() + " broadcast message handlers");
        if (_debug) _gridProgram.Echo(_unicastMessageHandlers.Count.ToString() + " unicast message handlers");
```
### Receiving Broadcast Messages
This part of the routine handles processing the received messages.  The queues are checked until all broadcast messages are processed.

```csharp
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
```
### Receiving Unicast Messages
This part of the routine handles processing the unicast message queue.  Note that it is written to be very similiar to the broadcast message processing.

```csharp
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
```

# Entire code
```csharp
/*
 * Wico Modular IGC Example
 * 
 * November 28, 2019
 * Updated Feb 4, 2020 to be MDK IGC example 3
 * 
 * Steam workshop link: 
 * https://steamcommunity.com/sharedfiles/itemedittext/?id=1923270132
 * 
 * 
 * Source available at:
 * https://github.com/Wicorel/WicoSpaceEngineers/tree/master/Modular/IGC%20Modular%20Example
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
bool _areWeInited=false;

public void Main(string argument, UpdateType updateSource)
{
    // Echo some information about 'me' and why we were run
    Echo("Source=" + updateSource.ToString());
    Echo("Me=" + Me.EntityId.ToString("X"));
    Echo(Me.CubeGrid.CustomName);

    if (!_areWeInited)
    {
        InitMessageHandlers();
        _areWeInited = true;
    }

    // always check for IGC messages in case some aren't using callbacks
    _wicoIGC.ProcessIGCMessages();
    if ((updateSource & UpdateType.IGC) > 0)
    {
        // we got a callback for an IGC message.
        // but we already processed them.
    }
    else if((updateSource & _utTriggers) > 0)
    {
        // if we got a 'trigger' source, send out the received argument
        IGC.SendBroadcastMessage(_broadCastTag, argument);
        Echo("Sending Message:\n" + argument);
    }
    else if((updateSource & _utUpdates) > 0)
    {
        // it was an automatic update

        // this script doesn't have anything to do
    }
}

/// <summary>
        /// This is our unique ID for our message.  We've defined the format for the message data (it's just a string)
        /// </summary>
string _broadCastTag = "MDK IGC Example 3";

void InitMessageHandlers()
{
    // creates a broadcast channel with the specified tag and calls the handler when messages are processed
    _wicoIGC.AddPublicHandler(_broadCastTag, TestBroadcastHandler);
}

// Handler for the test broadcast messages.
void TestBroadcastHandler(MyIGCMessage msg)
{
    // NOTE: called on ALL received messages; not just 'our' tag

    if (msg.Tag!= _broadCastTag)
        return; // not our message

    if (msg.Data is string)
    {
        Echo("Received Test Message");
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
