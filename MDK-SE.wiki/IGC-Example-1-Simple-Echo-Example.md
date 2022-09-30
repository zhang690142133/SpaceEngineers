# Example 1 Echo
You should already be familiar with basic scripts in SE.  (https://github.com/malware-dev/MDK-SE/wiki/Your-First-Script) 

Let’s start with a simple IGC example.  This is a script to send a message and receive a message and Echo it.

Source for this example is here: https://github.com/Wicorel/WicoSpaceEngineers/tree/master/Modular/IGC%20Echo

Here’s the deployed script with comments removed to make it shorter.

```csharp
int _runcount = 0;
string _broadCastTag = "MDK IGC EXAMPLE 1";
IMyBroadcastListener _myBroadcastListener;

public Program()
{
    Echo("Creator");
    _myBroadcastListener=IGC.RegisterBroadcastListener(_broadCastTag);
    _myBroadcastListener.SetMessageCallback(_broadCastTag); 
}

public void Main(string argument, UpdateType updateSource)
{
    _runcount++;
    Echo(_runcount.ToString()+ ":"+updateSource.ToString());

    if (
        (updateSource & (UpdateType.Trigger | UpdateType.Terminal)) > 0
        || (updateSource & (UpdateType.Mod)) > 0 
        || (updateSource & (UpdateType.Script)) > 0
        )
    { 
        if (argument != "")
        {
            IGC.SendBroadcastMessage(_broadCastTag, argument);
            Echo("Sending message:\n" + argument);
        }
    }

    if( (updateSource & UpdateType.IGC) >0)
    { 
        while (_myBroadcastListener.HasPendingMessage)
        {
            MyIGCMessage myIGCMessage = _myBroadcastListener.AcceptMessage();
            if(myIGCMessage.Tag ==_broadCastTag)
            { // This is our tag
                if(myIGCMessage.Data is string)
                {
                    string str = myIGCMessage.Data.ToString();
                    Echo("Received IGC Public Message");
                    Echo("Tag=" + myIGCMessage.Tag);
                    Echo("Data=" + myIGCMessage.Data.ToString());
                    Echo("Source=" + myIGCMessage.Source.ToString("X"));
                }
                else // if(msg.Data is XXX)
                {
                }
            }
            else
            {
            }
        }
    }
}
```

So let’s go through this section by section.

## Definitions
```csharp
int _runcount = 0;
string _broadCastTag = "MDK IGC EXAMPLE 1";
IMyBroadcastListener _myBroadcastListener;
```

This is creating three variables to hold information for the script. The first is used as a counter for runs so that when multiple executions of the script happen quickly, that can be noticed.

The second is the tag for the broadcast channel we will be using.  This tag should be chosen to be unique so that messages from unexpected sources are not received.

The third is the broadcast channel we will be using for receiving messages.  Note that this listener is only needed to RECEIVE messages; you can SEND messages without a registered listener.

## Constructor

```csharp
public Program()
{
    Echo("Creator");
    _myBroadcastListener=IGC.RegisterBroadcastListener(_broadCastTag);
    _myBroadcastListener.SetMessageCallback(_broadCastTag); 
}
```

This is the script constructor.  (if you don’t know what that means, read https://github.com/malware-dev/MDK-SE/wiki/The-Anatomy-of-a-Script)

We start by doing a simple Echo so that the player can tell that the script has compiled.

The next line creates a broadcast channel with the broadcast tag.  

The next line sets the channel to have a callback to the script when a message is received by the IGC system.


## Main start
```csharp
public void Main(string argument, UpdateType updateSource)
{
    _runcount++;
    Echo(_runcount.ToString()+ ":"+updateSource.ToString());
```
Note that we are using Main with the string and UpdateType because we need to check them.

In the beginning here we are just incrementing the runcount and then outputting the value and the current updateSource for informational purposes.

## Checking Update Triggers
```csharp
    if (
        (updateSource & (UpdateType.Trigger | UpdateType.Terminal)) > 0
        || (updateSource & (UpdateType.Mod)) > 0 
        || (updateSource & (UpdateType.Script)) > 0
        )
    { 
        if (argument != "")
        {
            IGC.SendBroadcastMessage(_broadCastTag, argument);
            Echo("Sending message:\n" + argument);
        }
    }
```
Here we are checking to see if the updatesource is one of the trigger types where we want to check the argument.

If it is one of those types and the argument is not empty, then we will broadcast the message on our channel.
```csharp
   IGC.SendBroadcastMessage(_broadCastTag, argument);
```

This sends the message to the channel specified.  In this case, the channel is our _broadCastTag and the message is a string in argument.

We also Echo what we are sending for informational purposes.

## Message Processing
This is where the work happens on processing a message that is received.

```csharp
    if( (updateSource & UpdateType.IGC) >0)
    { 
        while (_myBroadcastListener.HasPendingMessage)
        {
            MyIGCMessage myIGCMessage = _myBroadcastListener.AcceptMessage();
            if(myIGCMessage.Tag ==_broadCastTag)
            { // This is our tag
                if(myIGCMessage.Data is string)
                {
                    string str = myIGCMessage.Data.ToString();
                    Echo("Received IGC Public Message");
                    Echo("Tag=" + myIGCMessage.Tag);
                    Echo("Data=" + myIGCMessage.Data.ToString());
                    Echo("Source=" + myIGCMessage.Source.ToString("X"));
                }
```                

First we check to see if we were run because of an incoming IGC message.
```csharp
if( (updateSource& UpdateType.IGC) >0)
```

Then it checks if our broadcast channel has any pending incoming messages. Although this example only has one channel that it is listening to, it is a good habit to not assume which channel has the messages.
```csharp
while (_myBroadcastListener.HasPendingMessage)
```

If there is, then we get the message that was sent using AcceptMessage().  This will remove the message from the incoming queue.
```csharp
	MyIGCMessage myIGCMessage = _myBroadcastListener.AcceptMessage();
```
We then check the message to verify that it has our broadcasttag. For broadcast channel, it should always be our tag because that is what the channel was set up to receive.  However, for unicast messages they can be for many different tags.  So it is a good idea to get in the habit of checking the tag in your code.
```csharp
	if(myIGCMessage.Tag ==_broadCastTag)
```

We also check to verify that the data is a string like we expect.
```csharp
if(myIGCMessage.Data is string)
```

Then we Echo the data to show that we received the message.
```csharp
string str = myIGCMessage.Data.ToString();
Echo("Received IGC Public Message");
Echo("Tag=" + myIGCMessage.Tag);
Echo("Data=" + myIGCMessage.Data.ToString());
Echo("Source=" + myIGCMessage.Source.ToString("X"));
```

## Unexpected data processing

Here we are processing if the data is not in the format we expected or not the tag we expect.  We could check other expected formats for the data, or Echo a message about it being unexpected, or just ignore it.
```csharp
               else // if(msg.Data is XXX)
               {
               }
            }
            else
            {
            }
```

