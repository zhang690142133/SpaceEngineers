When you want to test your script, you will need to deploy it to Space Engineers. This process will combine all your [utility and extension classes](https://github.com/malware-dev/MDK-SE/wiki/Utility-Class-or-Extension-Class) together and create one complete script ready for Space Engineers to use.

There are a couple of ways to deploy your script, depending on your requirements. Usually you'll want to deploy just one single script project. In fact, most of you will probably _have_ just a single script project in your solution. To deploy a single project, you right-click the project in question in the **Solution Explorer**, then select **Deploy MDK Script**.

![Deploy Single Project](https://github.com/malware-dev/MDK-SE/blob/master/images/deploy-single.jpg)

If you have a solution with many projects, you may want to deploy all of them at once. You can do that by right-clicking on the topmost solution node instead of the individual project node.

![Deploy All Projects](https://github.com/malware-dev/MDK-SE/blob/master/images/deploy-all.jpg)


You can put deployment time information into your script automatically using certain macros. In order to both try to save a little time and to make sure these macros don't mess up any code, they only work inside special code regions.

# Deployment Time Macros

You can put deployment time information into your script automatically using certain macros. In order to both try to save a little time and to make sure these macros don't mess up any code, they only work inside special code regions.
```cs
#region mdk macros
// This script was deployed at $MDK_DATETIME$
const string Deployment = "$MDK_DATE$, $MDK_TIME$"
#endregion
```

# File Sorting Order

MDK deployment works by taking all your .cs files and packing them into a single file that Space Engineers understands.
You can control where each individual .cs files are placed in relation to each other by adding
```cs
// <mdk sortorder="100" />
```
at the _very top_ of the code files you wish to control, even above the `using` statements. The sortorder number will be used to determine the orders of the files. You can also use negative sortorders to force files above the Program class. Of course, certain rules will be above even the sortorder: The `readme.cs` file will always be on top no matter what, and classes that is not inside a `partial class Program` will by necessity have to be at the bottom simply due to how such classes work.

## The Minifier

The Programmable Block only allows for 100'000 characters. if your script goes above this, the [Minifier](https://github.com/malware-dev/MDK-SE/wiki/The-Minifier) will reduce your character count for you without impeding the development of your script.
