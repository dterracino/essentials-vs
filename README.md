# Yann's Essentials for VS

[![Build status](https://ci.appveyor.com/api/projects/status/la50f40vw7qys7b3?svg=true)](https://ci.appveyor.com/project/YannDuran/essentials-vs)

Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd)
or get the [CI build](http://vsixgallery.com/extension/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd/).

See the [changelog](https://github.com/yannduran/essentials-vs/blob/master/CHANGELOG.md) for changes and the roadmap for the future.

---

- *If you **like** this extension, please come back and add add a **rating**, so people will know what users think of it.*

- *If for some reason you **didn't like** it, or have any **suggestions** for improving it, just let me know via the **Q&A** section.*

---

### *Yann's Essentials* Toolbar
This extension adds a new toolbar.
Because it's usually far easier to click a toolbar button than to have to go hunting for
the command you want in a menu somewhere,
the most convenient commands have been added to the toolbar.

To make the toolbar visible, right-click in a blank spot on the toolbar area, 
and select *Yann's Essentials*.

Like all other Visual Studio toolbars, you can remove any commands that you feel you don't need,
or even add new commands to it.

### *Yann's Essentials* Menu
For those people who prefer a menu to a toolbar this extension also adds a new menu to 
Visual Studio's main menu bar. All commands are available via this menu.

### Code Window Context Menu
For the ultimate in coding convenience, most features are also available via the 
another *Yann's Essentials* menu that's been added to the right-click context menu of any code window.
This allows you to access nearly all of the *Yann's Essentials* features
without moving your mouse from the code you're working on.

The commands have been grouped into their own menu because the code window context menu
is already pretty clogged up. And it's growing all the time,
as Microsoft or 3rd-party extensions add more and more commands to it.

It means that there is one more click than I'd prefer,
but I've found it much easier to find the commands in a dedicated menu
than having to search through one gigantic menu of different commands.

### Keyboard Shortcuts
Some of the features that tend to be used frequently have also been assigned a keyboard shortcut.
And of course you can add your own keyboard shortcut to any of the *Yann's Essentials* commands.

### Feature Descriptions
A more in-depth description of the features listed below
[can be found here](https://yannduran.github.io/essentials-vs/),
including a comparison of the steps required both with and without the extension installed,
as well as images of the features in action.

---

## Features

#### Insert Guid(s)
Instantly insert/replace guid(s) directly in your code without the use of any **external** tool.

toolbar | main menu | context menu | shortcut
:---:   | :---:     | :---:        | :---:
no      | yes       | yes          | Shift-Alt-I, Shift-Alt-G

#### Rebuild Solution
Instantly rebuild the whole solution.

toolbar | main menu | context menu | shortcut
:---:   | :---:     | :---:        | :---:
yes     | yes       | yes          | Ctrl-Alt-0 

#### Rebuild Project
Instantly rebuild the current project.

toolbar | main menu | context menu | shortcut
:---:   | :---:     | :---:        | :---:
yes     | yes       | yes          | Ctrl-Alt-9 

#### Cancel Build
Quickly cancel a running build/rebuild.

toolbar | main menu | context menu
:---:   | :---:     | :---:
yes     | yes       | yes

#### Extensions and Updates
Open the *Extensions and Updates* dialog.

toolbar | main menu | context menu
:---:   | :---:     | :---:
yes     | yes       | yes

#### Restart Visual Studio
Instantly restart Visual Studio.

toolbar | main menu | context menu
:---:   | :---:     | :---:
yes     | yes       | yes

#### Restart Visual Studio as Administrator
Instantly restart Visual Studio as administrator (elevated).

toolbar | main menu | context menu
:---:   | :---:     | :---:
yes     | yes       | yes

#### Edit Solution
Open the solution file in an xml editor.

toolbar | main menu | context menu
:---:   | :---:     | :---:
yes     | yes       | yes

#### Close Solution
Close the solution.
This command is missing from the solution node in Visual Studio for some unknown reason.

toolbar | main menu | context menu | solution node
:---:   | :---:     | :---:        | :---:
yes     | yes       | yes          | yes

#### Edit Project
Open a project's *csproj* file in an xml editor.

toolbar | main menu | context menu | project node
:---:   | :---:     | :---:        | :---:
yes     | yes       | yes          | yes

## Contribute
Check out the [contribution guidelines](https://github.com/yannduran/essentials-vs/blob/master/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features used by this project.

## License
[Apache 2.0](LICENSE)

<div style="text-align:center">
  <img src="art/lss-vsip.png" />
</div>
