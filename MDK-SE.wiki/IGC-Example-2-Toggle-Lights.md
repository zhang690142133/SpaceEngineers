# Example 2: Toggling a light using IGC

This code will toggle a light; just like “[Your First Script](https://github.com/Wicorel/WicoSpaceEngineers/tree/master/MDK%20IGC%20Example%202)” example 

The difference is that the code will receive a message to toggle the light from a remote script.

To shorten the explanations, only the differences from Example 1 are explained.

## Entire code:
```csharp
/*
 * This is MDK IGC Example 2 by wicorel
 * 
 * Takes the first example script of toggling a light and makes it work via IGC.
 * 
 * Go to:
 *  https://github.com/malware-dev/MDK-SE/wiki/Quick-Introduction-to-Space-Engineers-Ingame-Scripts
 *  to learn more about ingame scripts.
 * 
 * This Example source: 
 *  https://github.com/Wicorel/WicoSpaceEngineers/tree/master/MDK%20IGC%20Example%202
 */

/// <summary>
        /// This is our unique ID for our message.  We've defined the format for the message data (it's just a string)
        /// </summary>
string _broadCastTag = "MDK IGC EXAMPLE 2";

/// <summary>
        /// The broadcast listener for the channel we are interested in.
        /// </summary>
IMyBroadcastListener _myBroadcastListener;

public Program()
{
    // let them know we are alive
    Echo("Creator");

    // register a broadcast channel for our tag
    _myBroadcastListener = IGC.RegisterBroadcastListener(_broadCastTag);

    // Ask to be called back --to Main()-- when a message is received
    _myBroadcastListener.SetMessageCallback(_broadCastTag); // the callback agrument does NOT need to be the same as the tag

}


public void Main(string argument, UpdateType updateSource)
{
    if (
        (updateSource & (UpdateType.Trigger | UpdateType.Terminal)) > 0 // run by a terminal action
        || (updateSource & (UpdateType.Mod)) > 0 // script run by a mod
        || (updateSource & (UpdateType.Script)) > 0 // this pb run by another script (PB)
        )
    { // script was run because of an action
        if (argument != "")
        {
            // if we are given an argument, send it out over our broadcast channel
            IGC.SendBroadcastMessage(_broadCastTag, argument);
            Echo("Sending message:\n" + argument);
        }
    }

    if ((updateSource & UpdateType.IGC) > 0)
    { // script was run because of incoming IGC message
        while (_myBroadcastListener.HasPendingMessage)
        {
            var myIGCMessage = _myBroadcastListener.AcceptMessage();
            if (myIGCMessage.Tag == _broadCastTag)
            { // This is our tag
                if (myIGCMessage.Data is string)
                {
                    string lightName = myIGCMessage.Data.ToString();

                    IMyInteriorLight light;

                    light = GridTerminalSystem.GetBlockWithName(lightName) as IMyInteriorLight;
                    if (light == null)
                    {
                        Echo("Oh my! I couldn't find that block...");
                        Echo(lightName);
                        return;
                    }

                    light.Enabled = !light.Enabled;
                    Echo("I have toggled the light!");
                }
                else // if(msg.Data is XXX)
                {
                    // handle other data types here...
                }
            }
            else
            {
                // handle other tags here
            }
        }
    }
}
```

Note that we choose a different channel tag for this example.
```csharp
string _broadCastTag = "MDK IGC EXAMPLE 2";
```

Most of the code is exactly the same as Example 1.  If we are given an argument, then we send that string out to the channel.

The difference is what we do when we receive a message.  The processing code is almost the same as the code from the “Your First Script” example, except the name of the light is taken from the string in the received message.
```csharp

               if (myIGCMessage.Data is string)
               {
                    string lightName = myIGCMessage.Data.ToString();

                    IMyInteriorLight light;

                    light = GridTerminalSystem.GetBlockWithName(lightName) as IMyInteriorLight;
                    if (light == null)
                    {
                        Echo("Oh my! I couldn't find that block...");
                        Echo(lightName);
                        return;
                    }

                    light.Enabled = !light.Enabled;
                    Echo("I have toggled the light!");
                }
```

Here we get the name of the light from the message data.
```csharp
	string lightName = myIGCMessage.Data.ToString();
```



