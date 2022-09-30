Visual Studio allows a new feature where the solution is loaded in an alternative way, giving access to the project faster by loading projects in the background. This has a distinct effect on MDK: It cannot detect the fact that your project is an MDK project before the solution is completely loaded. So either disable Lightweight Solution Load for your scripting solutions, or _wait_ until it is finished - which kinda makes lightweight solution load moot anyway.

![Still Loading...](https://github.com/malware-dev/MDK-SE/blob/master/images/lwsolutionload.jpg)
