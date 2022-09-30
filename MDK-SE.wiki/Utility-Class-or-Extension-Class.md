### Utility classes (normal classes)

Now you have created your project, you can either write your script in the Program.cs file as you're used to, or you can utilize the extra little tricks MDK has in store for you. You can use separate .cs files for your classes, making for a project that's a lot easier to manage.

You must realize, however, that you can't just add any old class and have it work as expected. [As explained here](https://github.com/malware-dev/MDK-SE/wiki/The-Anatomy-of-a-Script), programmable block scripts are wrapped into a container class by the game. Visual Studio obviously does not have this wrapping built-in, so you're gonna have to add something to simulate that yourself.

You do this by wrapping your class like this:
```csharp
Namespace IngameScript
{
    partial class Program
    {
        public class ThisIsMyClass
        {
        }
    }
}
```

This is highly recommended in order to have your script work as you expect when writing the code. MDK provides you with a class template to help you create this wrapper. Right click on your project, select **Add**, then **New Item**.

![Add New item](https://github.com/malware-dev/MDK-SE/blob/master/images/addnewitem-1.jpg)
![Select Utility Template](https://github.com/malware-dev/MDK-SE/blob/master/images/utilityclass.jpg)

### Extension Classes
There is a significant difference between an [extension class](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) and a utility class. For the absolute majority of your uses, you're not going to need this - however, if you _do_ want it, you _can_. Extension classes are a special construct which actually uses an officially sanctioned exploit to function. The "exploit" is left open because it's perfectly harmless. This is how to use extension classes directly in the programmable block:

```csharp
public void Main()
{
    // Some cool code...
}

} // Forcefully close the wrapper Program class that SE uses around your script

public static class ExtensionClass
{
    // Extension code...
// } Deliberately remove the closing brace of the last extension class, because Space Engineers will add it back in
```

Of course, MDK does all that work for you. Any class not having the `partial class Program` signature explained above will be designated an extension class and added in the manner above automatically. No hacking around needed.