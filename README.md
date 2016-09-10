# Essentials for VS

[![Build status](https://ci.appveyor.com/api/projects/status/la50f40vw7qys7b3?svg=true)](https://ci.appveyor.com/project/YannDuran/essentials-vs)

Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd)
or get the [CI build](http://vsixgallery.com/extension/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd/).

---


- *If you **like** this extension, please come back and add add a **review** (either with or without text), so people will know what users think of it.*

- *If for some reason you **didn't like** it, or have any **suggestions** for improving it, just let me know via the **Q&A** section.*

See the [changelog](https://github.com/yannduran/essentials-vs/blob/master/CHANGELOG.md) for changes and the roadmap for the future.

## Features
Most features are available on the *Yann's Essentials* toolbar 
(don't forget to right-click in a blank spot on the toolbar to make the new toolbar visible). 
It's much easier to click a toolbar button than to have to go hunting for
the command you want in a menu somewhere.

For convenience, most features are also available via the *Yann's Essentials* menu, 
found in the right-click context menu of any code window.
This allows you to access nearly all of the features 
without moving your mouse from the code you're working on.

The commands are all grouped in the *Yann's Essentials* menu because the code window's context menu
is already pretty clogged up, and it's growing all the time as Microsoft, 
or 3rd-party extensions, add more and more commands to it. 
It's one more click than I'd like, 
but I've found it much easier to find the commands in a dedicated menu 
than having to search through one gigantic menu.

**A more in-depth description of these features can be found 
[here](https://yannduran.github.io/essentials-vs/), 
including a comparison of the steps required both with and without the extension installed, 
as well as images of the extension in action.**

#### Rebuild Project
- rebuilds the currently selected project with a single click of a button on the *Yann's Essentials* toolbar
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window
- only enabled when a build/rebuild *is not running*

#### Rebuild Solution
- rebuilds the solution with a single click of a button on the *Yann Essentials* toolbar
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window
- only enabled when a build/rebuild *is not running*

#### Cancel Build
- cancels a currently running build/rebuild with a single click of a button on the *Yann's Essentials* toolbar
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window
- only enabled when a build/rebuild *is running*

#### Extensions and Updates
- opens the *Extensions and Updates* dialog with a single click of a button on the *Yann's Essentials* toolbar
- the command is also available from the right-click context menu in any code window

#### Restart Visual Studio
- restarts Visual Studio with a single click of a button on the *Yann's Essentials* toolbar
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window

#### Edit Solution command
- edits the Solution file with a single right-click on a solution node in the *Solution Explorer* window
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window

#### Close Solution command
- edits the Solution file with a single right-click on a solution node in the *Solution Explorer* window
- the command is also available from:
  -  the *Yann's Essentials* menu in the main menu bar
  -  the right-click context menu in any code window

## Contribute
Check out the [contribution guidelines](https://github.com/yannduran/essentials-vs/blob/master/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features used by this project.

## License
[Apache 2.0](LICENSE)

![Vsp](art/lss-vsip.png)