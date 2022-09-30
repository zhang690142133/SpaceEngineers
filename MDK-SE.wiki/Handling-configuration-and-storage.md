## Overview
[Configuration](#configuration)  
[The Basics](#the-basics)  
[Type Conversions](#type-conversions)  
[Find Blocks With Sections](#find-blocks-with-sections)  
[Saving to Storage](#saving-to-storage)  
[Saving to CustomData](#saving-to-customdata)  
[The Multiline Construct](#the-multiline-construct)  
[The Terminator Token](#the-terminator-token)  


## Configuration

The simplest way to configure blocks and behavior in scripts is simply to hard-code the behavior. However some times - especially if you're planning to release your script for public use - there's a need to allow for user configuration of behavior. Keen introduced the Custom Data field specifically for this reason. This is a field available in the terminal of most (if not all) terminal blocks, where users can enter any text. Scripters can use this to their advantage by having their users enter configuration there instead of having to open the script and editing code.

This field is accessed as a simple `String CustomData` property. For example, as you know, the currently running programmable block is accessed by the script property `Me`. So, to get to the custom data of the programmable block, you do this:

```csharp
public void Program() 
{
    var customData = Me.CustomData;
}
``` 

However just a string is not very useful. In order to help dealing with configuration information more easily, we introduce the `MyIni` class. This class helps you parse and read strings in [the old fashioned INI format](https://en.wikipedia.org/wiki/INI_file).

>**Note**: If you are using an IDE like Visual Studio and want to use this class in an existing script, you might need to add `using VRage.Game.ModAPI.Ingame.Utilities;` to the top of your code file(s).  

```ini
[FirstDataSection]
;This is a comment. It is not parsed by the class.
SomeKey=The value of this key
AnotherKey=Another value

[AnotherSection]
SomeKey=15
```

This is a very simple format, and it's easy to learn even for those without any coding skills. Only the simple INI format is supported. There are none of the escapes or other advanced features as described being supported by the more complicated use cases - all to maintain high performance. `MyIni` does add a little extra to this format though, as explained below.

#### The Multiline Construct
The multiline construct allows you to include text with newlines in it in a relatively easy way.
```ini
[Section]
;The following line is a special format which allows for multiline text in a single key:
MultiLine=
|The first line of the value
|The second line of the value
|And so on
```
Note that there should be nothing after the `=`, the whole value is defined in the section with `|`.

#### The Terminator Token
Three hyphens on a separate line will tell the parser to stop parsing, and just store the rest of the content in the MyIni's `EndContent` property. This will allow for at least _some_ support for other data alongside the ini.
```
---
```

### The Basics

To read this data you first need to instantiate an instance of the `MyIni` class. As always it's recommended to make a single instance, and reuse this instance throughout your script's lifetime.

Place down a programmable block. Open the Custom Data editor and add the following configuration:
```ini
[demo]
outputNow=true
output=LCD Panel
textToOutput=This text will be copied onto the target LCD.
```
Now add an LCD panel too, make sure it's called "LCD Panel" - or change the name in the programmable block's custom data to match. Remember to configure it to show "Text and Images".

Open the code editor of the programmable block and enter the following piece of code. Don't forget to read the explaining
comments in the code.

```cs
// Instantiate a shared instance of the parser
MyIni _ini = new MyIni();

bool _outputNow;
string _textToOutput;
string _outputName;
IMyTextPanel _outputPanel;

public Program()
{
    // Call the TryParse method on the custom data. This method will
    // return false if the source wasn't compatible with the parser.
    MyIniParseResult result;
    if (!_ini.TryParse(Me.CustomData, out result)) 
        throw new Exception(result.ToString());

    // Get the value of the "outputNow" key under the "demo" section.
    // Then, by calling ToBoolean(), we try to convert it into a
    // bool value.
    _outputNow = _ini.Get("demo", "outputNow").ToBoolean();
    
    // Get the value of the "output" key. This time we just want the
    // string.
    _outputName = _ini.Get("demo", "output").ToString();

    // Then the final value
    _textToOutput = _ini.Get("demo", "textToOutput").ToString();

    // If the configuration says that the text should be added immediately, so we
    // tell the programmable block to run itself once automatically.
    if (_outputNow) 
    {
        Runtime.UpdateFrequency = UpdateFrequency.Once;
    }
}

public void Main() 
{
    // Output the configured text every time the script is run
    // If the output text panel has not yet been retrieved, retrieve it now.
    if (_outputPanel == null) 
    {
        // Get the output panel as configured by the CustomData
        _outputPanel = GridTerminalSystem.GetBlockWithName(_outputName) as IMyTextPanel;
    }
    if (_outputPanel == null) {
        // No output panel could be found, so we'll just have to exit.
        Echo("No output panel");
        return;
    }

    // Append the configured text to the text panel
    _outputPanel.WriteText(_textToOutput, true);
    // And then add a newline
    _outputPanel.WriteText("\n", true);
}

```
Feel free to change the values of the CustomData configuration (leave the section and key names alone, just change the values) and see the results. For an explanation of `UpdateFrequency.Once`, see [Continuous Running No Timers Needed](https://github.com/malware-dev/MDK-SE/wiki/Continuous-Running-No-Timers-Needed).

### Type Conversions

In the example above we see the use of `.ToBoolean();` and `.ToString();` in relation to the `_ini.Get` calls. There are several type conversion methods are available for the configuration values. Each type has two variants: The To* and the TryGet*. The former will attempt to convert the value, and if it fails, it will simply fall back to the default value. The second will return a boolean which tells you if the conversion was successful or not. Use whichever suits your script best.

* `bool ToBoolean(bool defaultValue = default(bool))`
* `bool TryGetBoolean(out bool value)`

* `char ToChar(char defaultValue = default(char))`
* `bool TryGetChar(out char value)`

* `sbyte ToSByte(sbyte defaultValue = default(sbyte))`
* `bool TryGetSByte(out sbyte value)`

* `byte ToByte(byte defaultValue = default(byte))`
* `bool TryGetByte(out byte value)`

* `ushort ToUInt16(ushort defaultValue = default(ushort))`
* `bool TryGetUInt16(out ushort value)`

* `short ToInt16(short defaultValue = default(short))`
* `bool TryGetInt16(out short value)`

* `uint ToUInt32(uint defaultValue = default(uint))`
* `bool TryGetUInt32(out uint value)`

* `int ToInt32(int defaultValue = default(int))`
* `bool TryGetInt32(out int value)`

* `ulong ToUInt64(ulong defaultValue = default(ulong))`
* `bool TryGetUInt64(out ulong value)`

* `long ToInt64(long defaultValue = default(long))`
* `bool TryGetInt64(out long value)`

* `float ToSingle(float defaultValue = default(float))`
* `bool TryGetSingle(out float value)`

* `double ToDouble(double defaultValue = default(double))`
* `bool TryGetDouble(out double value)`

* `decimal ToDecimal(decimal defaultValue = 0)`
* `bool TryGetDecimal(out decimal value)`

* `string ToString(string defaultValue = default(string))`
* `bool TryGetString(out string value)`

There's also the `void GetLines(List<string> lines)` method, which fills the given list with the individual lines of the configuration value.

### Find Blocks With Sections

My favorite way of using CustomData configuration now is to use _it_ to retrieve blocks for my scripts rather than using hard coded custom names. What I do is use the ini sections to indicate if a certain block is to be included in a certain script module. For example, my airlock script looks for an `[airlock]` configuration in blocks like for example doors and air vents, which configures how those blocks should behave in relation to a given air lock. It allows for the adding and removal of new air locks without the need to manually add code to the script, I simply press a "reset" button and the script finds any new airlocks and discards old ones. Easy - and requires no coding knowledge for the end user.

To support this use case there's a fast search method in `MyIni` which searches a string quickly to see if it has the desired section. This allows you to quickly reject blocks which are not relevant for the current model. The method is designed to be performance- and memory friendly.

```csharp
GridTerminalSystem.GetBlocksOfType<IMyDoor>(doors, door => MyIni.HasSection(door.CustomData, "airlock"));
```


## Saving to Storage

So far I've only been talking about the _reading_ of configuration. But `MyIni` can also be used to help you with persistant storage in the `Storage` property. Obviously reading is just a matter of adapting the examples above to work with this property instead.

Changing values in a configuration is - unsurprisingly - done via the `Set` method. Consider the following example:

```csharp
// Instantiate a shared instance of the parser
MyIni _ini = new MyIni();

// Define the default of the _intValue. You don't have to do it this way, it's just defined
// like this here for the sake of readability.
const int DefaultIntValue = 5;

// An integer value
int _intValue;

// The default of _boolValue
const bool DefaultBoolValue = true;

// A boolean value
bool _boolValue;

public void Program()
{
    // For the sake of Storage the initialization code is simpler. We can make a lot more assumptions 
    // because players don't have access to change this value. For this reason we just parse, we don't
    // care whether it's actually successful or not. Obviously this is your choice.
    _ini.TryParse(Storage);

    // Read the integer value. If it does not exist, return the default for this value.
    _intValue = _ini.Get("demo", "intValue").ToInt32(DefaultIntValue);

    // Then we do the same for the boolean value.
    _boolValue = _ini.Get("demo", "boolValue").ToBoolean(DefaultBoolValue);
}

public void Save()
{
    // Assume that the script has been running and potentially changing these values.
    // We don't want to continually update the _ini during runtime, that's going to be
    // too slow compared to using the variables directly.

    // First, clear out any old data, we're gonna recreate it in its entirety.
    _ini.Clear();

    // Then we set the integer value
    _ini.Set("demo", "intValue", _intValue);

    // and finally the boolean value.
    _ini.Set("demo", "boolValue", _boolValue);

    // Now we finally commit our configuration to storage, which the game will save to disk.
    // Next time the script is created, it will be able to recreate this information in the
    // code we added to the constructor.
    Storage = _ini.ToString();
}

public void Main()
{
    // Your logic here. Don't use the _ini directly as backing storage, use the loaded fields. The _ini
    // is too slow for general runtime.
}
```


## Saving to CustomData

First things first. It would be remiss of me if I didn't tell you that you really shouldn't do that. Depending on how you make your changes to CustomData, it's a bit unpredictable since it's _not_ designed to be used this way. For example:

* There is no guarantee that the CustomData of a block has not _already_ been captured for the save file by the time the programmable block Save is called, meaning that the changes you do won't actually be saved until _next_ time. Also, while changes to CustomData runs well in single player, it's synchronized to every player in multiplayer so be very careful. 

* When you recompile a script, the old script will have its Save method called. So, if a user are updating a script and making changes in their CustomData setup _before_ replacing the script, the changes might be overwritten by the old script's save when compiling the _new_ script, wasting their time.

However - there may be situations were you _really_ need this. In this case you should change the example above a little to take into account that CustomData is user editable. Not only may it contain invalid data, it may change during the runtime of your script.

```csharp
// Instantiate a shared instance of the parser
MyIni _ini = new MyIni();

// Define the default of the _intValue. You don't have to do it this way, it's just defined
// like this here for the sake of readability.
const int DefaultIntValue = 5;

// An integer value
int _intValue;

// The default of _boolValue
const bool DefaultBoolValue = true;

// A boolean value
bool _boolValue;

public void Program()
{
    // This time we _must_ check for failure since the user may have written invalid ini.
    MyIniParseResult result;    
    if (!_ini.TryParse(Me.CustomData, out result))
        throw new Exception(result.ToString());
 
    // Read the integer value. If it does not exist, return the default for this value.
    _intValue = _ini.Get("demo", "intValue").ToInt32(DefaultIntValue);

    // Then we do the same for the boolean value.
    _boolValue = _ini.Get("demo", "boolValue").ToBoolean(DefaultBoolValue);
}

public void Save()
{
    // Assume that the script has been running and potentially changing these values.
    // We don't want to continually update the _ini during runtime, that's going to be
    // too slow compared to using the variables directly.

    // This time we do _not_ clear out the ini. We parse it all over again, because a
    // user might have made changes to it manually and we'll want to retain those
    // changes. Once again we fail if we cannot understand the configuration.
    MyIniParseResult result;
    if (!_ini.TryParse(Me.CustomData, out result))
        throw new Exception(result.ToString());

    // Then we set the integer value
    _ini.Set("demo", "intValue", _intValue);

    // and finally the boolean value.
    _ini.Set("demo", "boolValue", _boolValue);

    // Now we finally commit our configuration to the CustomData. Again, be careful.
    // CustomData is unpredictable for use as storage like this, because it simply
    // isn't designed for it, and it's slow in multiplayer.
    Me.CustomData = _ini.ToString();
}

public void Main()
{
    // Your logic here. Don't use the _ini directly as backing storage, use the loaded fields. The _ini
    // is too slow for general runtime.
}
```
