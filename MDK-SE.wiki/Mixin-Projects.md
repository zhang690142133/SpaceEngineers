It is very common to write a set of utility methods and/or classes that you reuse with multiple scripts. MDK needs access to the actual source code in order to build the final script, so you can't use ordinary class libraries for this. However, Visual Studio has another project type that works just perfect for this: The Shared Project.

To create a shared project, right click on your solution node and select **Add** then **New Project**.

![Add New Project](https://github.com/malware-dev/MDK-SE/blob/master/images/addnewproject.jpg)

Then click the search box and type in "Shared". 

![Shared Projects](https://github.com/malware-dev/MDK-SE/blob/master/images/sharedproject.jpg)

Make sure you select the **C#** variant, name your project. When selecting _where_ to store your new project, consider the fact that you are going to want to add this same project to multiple script solutions. I myself choose to use this folder structure:

```
Programmable Block\
    Mixins\
    Scripts\
```
where the Mixins folder contains my Shared Projects, and the Scripts folder contains the individual script solutions. This, of course, is entirely up to you.

In order to use a Shared Project with a script you need to correctly reference it from your script project. The shared project needs to be added to your solution first. If you just created the project as described above, your project is already in your solution. If you want to reference a shared project you've made _earlier_, you need to add it to your solution by once more right clicking your solution, click **Add** and then **Existing Project**, then select your previously created project.

Once your Shared Project is successfully added to the solution, you need to reference it from each and every script project in your solution. You do this by expanding your project node, then right clicking the **References** node and selecting **Add Reference**.

![Add Reference](https://github.com/malware-dev/MDK-SE/blob/master/images/addreference.jpg)

Click the **Shared Projects** node

![Shared Project](https://github.com/malware-dev/MDK-SE/blob/master/images/sharedprojects.jpg)

then check the Shared Projects you wish to have access to in this project, then click **OK**. 

![Shared Projects](https://github.com/malware-dev/MDK-SE/blob/master/images/sharedprojectlist.jpg)

The code in your Shared Project is now available in your script project, and will be automatically added to your final script by MDK.