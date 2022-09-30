### Malware's Development Kit for Space Engineers

A toolkit to help with ingame script (programmable block) development for Keen Software House's space sandbox Space Engineers. It helps you create a ready-to-code project for writing ingame scripts, and provides an analyzer which warns you if you're trying to use something that is not allowed in Space Engineers. It also provides a code minifier to make your deployed script as small as possible - albeit somewhat unreadable.

### General features
* Helps you create a fully connected script project in Visual Studio, with all references in place
* Requires that you have the game installed, but does _not_ require you to have it running
* Class templates for normal utility classes and extension classes
* Tells you if you're using code that's not allowed in Space Engineers (whitelist checker)
* Deploys multiple classes into a single PB script, which then is placed in the local Workshop space for easy access in-game - no copy/paste needed
* Supports optional code minifying: Fit more code within the limits of the programmable block
* Allows real reusable code libraries through the use of Visual Studio's Shared Project
* Out-of-game script blueprint manager allows you to rename and delete script blueprints without starting the game

### Frequently Asked Questions
* Can I use this in VSCode?
  - No. VSCode has nothing in common with Visual Studio but the name.
* Can I use this in Visual Studio 2022?
  - Sadly, no. Microsoft made some _major_ changes to Visual Studio this time which means I'd have to maintain two MDK versions. Not an option. I am currently working on MDK2 to remedy this, but I'm currently not really playing SE and as such not scripting much, so my personal motivation isn't great.

Space Engineers is trademarked to Keen Software House. This toolkit is fan-made, and its developer has no relation to Keen Software House.

## Important Note
This is a project I pretty much made for _myself_. I'm publishing it in case someone else might have a use for it. Fair warning: Make requests, by all means, but if your request is not something I myself have any use for, someone else is gonna have to do the work. I'm fully employed, and this is a spare-time project. I'll be working on it on and off.

## Contribution
Yeah, sure. Absolutely. I will gladly accept contribution to the project. I'll be grateful for any assistance, especially for any features requested that I myself may not have any use for. I have only limited time for this project, and I am forced - for the most part - to stick to features that I myself will be using. This means that any extra features, like for instance mod support, relies on the community contributing. However: I can't merge contributions willy nilly. I will expect a certain minimum standard, and I reserve the right to deny features I don't like. Another fair warning :D

[See here for more info](https://github.com/malware-dev/MDK-SE/blob/master/CONTRIBUTING.md).

## About Me
Ok, so who is this Malware guy anyway, and why the heck does a software engineer use a nickname based on malicious software? Can I even trust this person?

Well, yes, I promise you can. The nickname is chosen deliberately, both as a sarcastic reference to said malicious software that I hate as much as anyone, and a play on words. You see, my real name initials are MAL, and I am a software engineer through and through, both by vocation and hobby. Mal + [soft]ware = Malware. Cheesy? Oh, yes, absolutely, but I like it.

Like I said, a software engineer through and through. I have been programming since my very early teens (or maybe before, I can't remember exactly). I wrote my first piece of software somewhere between 25 and 30 years ago alongside my father, with a then brand-new 80286 computer. We used [GW-BASIC](https://en.wikipedia.org/wiki/GW-BASIC). Well, technically, he actually wrote it, I suggested and watched with big eyes. That sparked my unending love for programming, and I never looked back. I am now a professional business software programmer, and I've been in my current job for over a decade. I love this job.

Oh, I guess I should also mention that I'm the author of the current version of Space Engineer's programmable block. To be exact, it's compiler. That is my main contribution, but I have also contributed smaller things here and there.

I hope this is enough information to help you trust me despite my chosen nickname!