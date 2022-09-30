If there's one thing that is certain about being a programmer, it is that you will make mistakes. Bugs are just part of the job. Usually in IDEs like Visual Studio you can enable a "Debug Mode" though, which will give you file names and line numbers, and even breakpoints which enables you to stop at selected points and step-by-step the code to see what went wrong.

_None_ of which is available for Space Engineers ingame scripts.

The reasoning for this is simple: Debuggable scripts run _a lot_ slower than optimized scripts. Because of this the compiled scripts in SE contains no debug information at all. 

So... We're still going to have bugs, how can we trace them?

### Echo
Let's start simple, with the `Echo`. This is a method belonging to the scripts base class, `MyGridProgram` (it's a delegate property actually, but [I'll get back to that](#echo-performance-and-tricks)). This method can be used to output text to the programmable block's detail area. For instance, this:

```csharp
public void Main() 
{
    Echo("Hello World");
}
```

results in this:

![Hello World](https://github.com/malware-dev/MDK-SE/blob/master/images/pb-echo.jpg)

By placing outputs like this at strategic locations in your code, you can figure out how far it goes before your error occurs - and in that way narrow down your search range.

However to provide full coverage you'd need Echo _all over the place_. It'd be nice to be able to narrow down a little more first.

### Stack Trace
A **stack trace** is a description showing you the route a call has made at the error point. There is actually a way to get at least a limited stack trace out of Space Engineers, this should help you narrow down at least what code member was running when the error occurred. You can do this by adding a `try/catch` to the main callback points of your script - those being `Program()`, `Save()`, and most importantly `Main()`.

For our example, let's start with a simple example _without_ any stack tracing.
```csharp
public void Main()  
{ 
    var block = GridTerminalSystem.GetBlockWithName("I Don't Exist");
    ShowBlockInfo(block);
}

public void ShowBlockInfo(IMyTerminalBlock block)
{
    // Let's say this method shows various information about the given
    // block.
    // We'll just print it's name in this example for simplicity's sake.
    Echo(block.CustomName);
}
```
Provided you _do not_ add a block named `I Don't Exist`, this program will obviously fail, since it wouldn't be able to retrieve said block. This means that the following will be the result:

![No Stack Trace](https://github.com/malware-dev/MDK-SE/blob/master/images/pb-nostacktrace.jpg)

That's less than helpful. We know that some object was null somewhere, but that's it. To combat this, we need to add a little bit of code to our example:

```csharp
public void Main()  
{ 
    try
    {
        // This is the old Main content.
        var block = GridTerminalSystem.GetBlockWithName("I Don't Exist");
        ShowBlockInfo(block);
    }
    catch (Exception e)
    {
        // Dump the exception content to the 
        Echo("An error occurred during script execution.");
        Echo($"Exception: {e}\n---");

        // Rethrow the exception to make the programmable block halt execution properly
        throw;
    }
}

public void ShowBlockInfo(IMyTerminalBlock block)
{
    // Let's say this method shows various information about the given
    // block.
    // We'll just print it's name in this example for simplicity's sake.
    Echo(block.CustomName);
}
```
As mentioned in the comment, the `throw` statement rethrows the same exception to force the PB to shut down as it normally would. I recommend doing this because it's highly likely your script is in an undefined state at this point, even if you've tried to take errors into account.

When running this script, this is what will be shown in the programmable block's Details view:

![Stacktrace](https://github.com/malware-dev/MDK-SE/blob/master/images/pb-stacktrace.jpg)

Yeah. Sorry. Seems like there's a bug with the word wrapper at the time of writing this tutorial. Let me unjumble that for you:
```
An error occurred during script execution.
Exception: System.NullReferenceException: Object reference not set to an instance of an object.
   at Program.ShowBlockInfo(IMyTerminalBlock block)
   at Program.Main()
---
Caught exception during execution of script:Object reference not set to an instance of an object.
```
The last line, after '---', is obviously the same as was shown earlier so we'll simply ignore that. The rest of the output comes from our changes in the script, and this provides more information. It tells us:

* What exception type occurred (`System.NullReferenceException`)
* The specific error message (`Object reference not set to an instance of an object.`) 
* The first line `at Program.ShowBlockInfo(IMyTerminalBlock block)` tells you which _method_ the error happened in.
* The second line `at Program.Main()` tells us where the method in the previous line was called from.
* If the call chain was deeper, we'd be getting more of these lines.

Now we know which method(s) we need to decorate with Echo's, we don't need to fill our application up completely.

Unfortunately even this method is inexact. The compiler optimizer is rather clever. Sometimes it takes some of your smaller methods and bakes them into larger methods, because it deems that to be faster. This means that you'll not see that particular method in the stack trace, because as far as the _compiled_ code goes, it doesn't exist. This _will_ give you a relatively decent idea where to start looking though.

### Echo, performance, and tricks
Unfortunately there's a slight caveat to using `Echo` a lot. In solo play there's little to no issue, but in multiplayer the text needs to be synchronized from the server where the script is running and to your client. This takes time. If a lot of scripts are echoing a lot of text every frame, it's going to have an impact. For this reason you shouldn't Echo everything always. This is where the thing I mentioned earlier comes into play: `Echo` is actually a property containing a [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/), specifically one of the type [`Action<string>`](https://msdn.microsoft.com/en-us/library/018hxwa8(v=vs.110).aspx). The method called can be replaced with whatever you want. For instance, if you have lots of diagnostic echoes in your script and want to keep it around for later, you can do this:

```csharp
public Program() 
{
    Echo = text => {};
}
```

The part `text => {}` is called a [lambda](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator). This one creates a method with a single string argument named `text`, and which does nothing on execution. This will effectively make _Echo_ do nothing. Voila, any performance hit by your echoes are now gone - but you can switch it back on simply by removing the line above!

Another neat trick you can do because of this, is to reroute your echo.

```csharp
IMyTextPanel _logOutput;

public Program()
{
    // Replace the Echo
    Echo = EchoToLCD;

    // Fetch a log text panel
    _logOutput = GridTerminalSystem.GetBlockWithName("Log LCD") as IMyTextPanel;
}

public void EchoToLCD(string text)
{
    // Append the text and a newline to the logging LCD
    // A nice little C# trick here:
    // - The ?. after _logOutput means "call only if _logOutput is not null".
    _logOutput?.WritePublicText($"{text}\n", true);
}
```
Putting a $ in front of the string literal makes it a [string interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interpolated-strings).
