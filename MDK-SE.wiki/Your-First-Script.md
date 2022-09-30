Let's start simple. Let's say you have a light, and you want to turn it off and on. Yes, I know, you can just add that to any old toolbar. But it's one of the easiest things you can script, so I say we start there. In fact, let me provide you with [a finished blueprint with the script in place and ready to go](http://steamcommunity.com/sharedfiles/filedetails/?id=1094911307).

Since it's somewhat... cumbersome... to read scripts in the game's internal editor, let me provide the script here. Again I have removed the comments for brevity.

```cs
public void Main() 
{
    IMyInteriorLight light;

    light = GridTerminalSystem.GetBlockWithName("That Important Light") as IMyInteriorLight;
    if (light == null) 
    {
        Echo("Oh my! I couldn't find that block...");
        return;
    }

    light.Enabled = !light.Enabled;
    Echo("I have toggled the button!");
}
```

So let's explain what is happening here. 

First I need to define a variable to contain a reference to the light I want to change.
```csharp
IMyInteriorLight light;
```

Then I must query the [grid terminal system](https://github.com/malware-dev/MDK-SE/wiki/The-Grid-Terminal-System) for the specific block I'm after. I do this by requesting it by name. Be aware that this name must be _exact_. Even if your query differs by a space, the system will not find your block.
```csharp
light = GridTerminalSystem.GetBlockWithName("That Important Light") as IMyInteriorLight;
```
The first part, `GridTerminalSystem.GetBlockWithName("That Important Light")` will find the first block on the build that has the name That Important Light. It does not care what type of block that is. If you rename the light to something else, and rename, let's say the reactor, to That Important Light, the method will return _that_ block instead. So to remedy that, we add a conditional cast `as IMyInteriorLight` which will test if the block is of that particular type, and return it only if it is. If the type does not match, it will return `null`. So in practice that means that there are two scenarios where the query above will _not_ return a block: Either because there is no block with that name on your build, or because the block with that name does not have this particular type. This means that we should check if the block has been retrieved:
```csharp
if (light == null) 
{
    // Output some text to the programmable block's details section:
    Echo("Oh my! I couldn't find that block...");
    // Just quit, we can't do anything else here.
    return;
}
```
You can read [more about Echo here](https://github.com/malware-dev/MDK-SE/wiki/Debugging-Your-Scripts).

Ok, so we have a block, and we know it's a light. So all we have to do now, is to toggle it.   
```csharp
light.Enabled = !light.Enabled;
Echo("I have toggled the button!");
```

What we are doing here is to set the light's Enabled state (its on/off button, essentially) to _the opposite_ (as defined by the !) as its current value. This will effectively toggle the button on and off. We're done! Press Check code, then Remember & Exit, and then the Run button, to see what happens (you may need to wait a second or so for the light to catch up to the change).

That will conclude the first introduction. I have hopes that I - or some contributors - will be able to add further tutorials to help you along the way. In the mean time, again, I point towards [Keen's official Discord](https://discordapp.com/invite/KeenSWH) and the **#programming-in-game** channel.