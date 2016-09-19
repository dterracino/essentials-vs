# Yann's Essentials for VS
## Features
This Extension Installed's features can be accessed via one or more of the following methods:

- clicking on a button on the *Yann's Essentials* toolbar
- selecting a command from the *Yann's Essentials* menu
- selecting a command from the *Yann's Essentials* menu in the context menu of any code window

Some features are available via all three methods, whereas as others may not be able to be
accessed via all of the methods.

---

#### Insert Guid(s)
Insert a guid directly into your code without the use of any **external** tool
by placing the cursor where you want the guid and invoking the command.

Insert **multiple unique guids** at the same time by making a multi-line selection before invoking the command
using one of the methods listed below.

Replace a section of **existing text** with a guid by selecting it before invoking the command.
Replace **multiple lines of text** by making a multi-line selection before invoking the command.

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- select *Create GUID*
- click the *Copy* button, or the *New GUID* button
- move your cursor to where you want the guid
- right-click and select *Paste*
- (repeat steps for multiple guids)

##### With This Extension Installed

* **Menu**
    - click on the *Yann's Essentials* menu in *Visual Studio*'s main menu bar
    - select *Insert Guid*
    - ![Insert Guid (from menu)][insert-guid-menu]
* **Code Window**
    - right-click in the code file where you want to insert the guid,
    or select some text, or multi-select some text
    - select *Yann's Essentials*
    - select *Insert Guid(s)*
    - ![Insert Guid (from code)][insert-guid-code]
* **Shortcut**
    - press *Ctrl-Alt-I*, *Ctrl-Alt-G*

---

#### Rebuild Solution
Quickly rebuild the whole solution.

##### Without This Extension Installed

- move your mouse to the solution node in *Solution Explorer*
- right-click it
- select *Rebuild Solution*
- **or**
- move your mouse up to the *Build* menu
- click it
- select *Rebuild Solution*

##### With This Extension Installed

This feature is only enabled if a build/rebuild is **not** currently in progress.

* **Toolbar**
    - click the *Rebuild Solution* button on the *Yann's Essentials* toolbar
    - ![Rebuild Solution (from toolbar)][rebuild-solution-toolbar]
* **Menu**
    - click on the *Yann's Essentials* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Solution*
    - ![Rebuild Solution (from menu)][rebuild-solution-menu]
* **Code Window**
    - right-click in any code window
    - click on *Yann's Essentials* in the context menu
    - click on *Rebuild Solution*
    - ![Rebuild Solution (from code)][rebuild-solution-code]
* **Shortcut**
    - press *Ctrl-Alt-0*

Once Visual Studio starts rebuilding the solution,
the *Rebuild Solution* and *Rebuild Project* buttons are **disabled**,
and the *Cancel Build* button is **enabled**.

---

#### Rebuild Project
Quickly rebuild the current project.

##### Without This Extension Installed

- move your mouse to the currently selected project's node in *Solution Explorer*
- right-click it
- select *Rebuild Project*
- **or**
- move your mouse up to the *Build* menu
- click it
- select *Rebuild Project*

##### With This Extension Installed

This feature is only enabled if a build/rebuild is **not** currently in progress.

* **Toolbar**
    - click the *Rebuild Project* button on the *Yann's Essentials* toolbar
    - ![Rebuild Project (from toolbar)][rebuild-project-toolbar]
* **Menu**
    - click on the *Yann's Essentials* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Rebuild Project (from menu)][rebuild-project-menu]
* **Code Window**
    - right-click in any code window
    - click on *Yann's Essentials* in the context menu
    - click on *Rebuild Project*
    - ![Rebuild Project (from code)][rebuild-project-code]
* **Shortcut**
    - press *Ctrl-Alt-0*

Once Visual Studio starts rebuilding the selected project,
the *Rebuild Project* and *Rebuild Solution* buttons are **disabled**,
and the *Cancel Build* button is **enabled**.

---

#### Cancel Build

Quickly cancel a running build/rebuild.

##### Without This Extension Installed

- move your mouse up to the *Build* menu
- click it
- select *Cancel*

##### With This Extension Installed

This feature is only enabled if a build/rebuild **is** currently in progress.

* **Toolbar**
    - click the *Cancel Build* button on the *Yann's Essentials* toolbar
    - ![Cancel Build (from toolbar)][cancel-build-toolbar]
* **Menu**
    - click on the *Yann's Essentials* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Cancel Build (from menu)][cancel-build-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* in the context menu
    - select *Cancel Build*
    - ![Cancel Build (from code)][cancel-build-code]

Once the build/rebuild has been cancelled,
the *Rebuild Project* and *Rebuild Solution* buttons are **enabled**,
and the *Cancel Build* button is **disabled**.

---

#### Extensions and Updates

Open the *Extensions and Updates* dialog.

This one's about pure convenience.
I often find myself needing to open dialog this multiple times a day.

I've lost count of how many times I've **accidentally** ended up clicking on *Options*
instead of *Extensions and Updates*.
Or found myself looking up and down the menu trying to find it in the *Tools* menu.

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- click it
- find and select *Extensions and Options*

##### With This Extension Installed

* **Toolbar**
    - click the *Extensions and Updates* button on the *Yann's Essentials* toolbar
    - ![Extensions and Updates][extensions-updates-toolbar]
* **Menu**
    - click on the *Yann's Essentials* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Extensions and Updates (from menu)][extensions-updates-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* in the context menu
    - select *Extensions and Updates*
    - ![Extensions and Updates][extensions-updates-code]

---

#### Restart Visual Studio
Instantly restart Visual Studio.

Have you ever wished there was an **easy** way to restart Visual Studio,
just like the *Extensions and Updates* dialog does
after installing/uninstalling an extension?

##### Without This Extension Installed

- close *Visual Studio*
- reopen *Visual Studio*
- wait for Visual Studio to load
- move your cursor to the *File Menu*
- click it
- select *Recent Projects and Solutions*
- select the project that you were working on before the restart

##### With This Extension Installed

* **Toolbar**
    - click the *Restart Visual Studio* button on the toolbar
    - ![Restart Visual Studio (from toolbar)][restart-vs-toolbar]
* **Menu**
    - click on the *Essentials* menu in *Visual Studio*'s main menu bar
    - select *Restart Visual Studio*
    - ![Restart Visual Studio (from menu)][restart-vs-menu]
* **Code Window**
    - right-click in any code window
    - click on *Yann's Essentials* in the context menu
    - click on *Cancel Build*
    - ![Restart Visual Studio (from code)][restart-vs-code]

Visual Studio restarts and automatically re-opens the solution that you were working on.

---

#### Restart Visual Studio as Administrator

Instantly restart Visual Studio as administrator (elevated session).

##### Without This Extension Installed

- close *Visual Studio*
- right-click *Visual Studio* (on the Start menu, or on the Taskbar etc)
- select *Run as administrator*
- accept the User Control prompt
- wait for Visual Studio to load
- move your cursor to the *File Menu*
- click it
- select *Recent Projects and Solutions*
- select the project that you were working on before the restart

##### With This Extension Installed

* **Toolbar**
    - click the *Restart Visual Studio as Administrator* button on the toolbar
    - ![Restart Visual Studio as Administrator (from toolbar)][restart-vs-admin-toolbar]
* **Menu**
    - click on the *Yann's Essentials* menu
    - select *Restart Visual Studio as Administrator*
    - ![Restart Visual Studio as Administrator (from menu)][restart-vs-admin-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* in the context menu
    - select *Restart Visual Studio as Administrator*
    - ![Restart Visual Studio as Administrator (from code)][restart-vs-admin-code]

Visual Studio restarts an elevated session 
and automatically re-opens the solution that you were previously working on.

---

#### Edit Solution

Open the solution file in an xml editor.

##### Without This Extension Installed

- move your mouse up to the *Solution* node
- click it
- move your mouse up to the *File* menu
- select *Close Solution*
- (explorer window)
- (text editor)
- (reopen solution)

##### With This Extension Installed

* **Solution Node**
    - right-click on the *Solution Name* node
    - click on *Edit Solution*
    - ![Edit Solution (from solution node)][edit-solution-node]
* **Menu**
    - click on the *Yann's Essentials* menu
    - select *Edit Solution*
    - ![Edit Solution (from menu)][edit-solution-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* from the context menu
    - select *Edit Solution*
    - ![Edit Solution (from code)][edit-solution-code]

The solution file opens in an XML window, ready for editing.

---

#### Close Solution

Close the current solution.

##### Without This Extension Installed

- move your mouse up to the *Solution* node
- click it
- move your mouse up to the *File* menu
- select *Close Solution*

##### With This Extension Installed

* **Solution Node**
    - right-click on the *Solution Name* node
    - select *Close Solution*
    - ![Close Solution (from solution node)][close-solution-node]
* **Menu**
    - click on the *Yann's Essentials* menu
    - select *Close Solution*
    - ![Close Solution (from menu)][close-solution-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* in the context menu
    - select *Close Solution*
    - ![Close Solution (from code)][close-solution-code]

---

#### Edit Project command

Open a project's *csproj* file in an xml editor.

##### Without This Extension Installed

- move your mouse up to the *Project* node
- click it
- move your mouse up to the *Project* menu
- select *Unload Project*
- move cursor back to the *Project* mode
- right-click it
- select *Edit [ProjectName].csproj*

##### With This Extension Installed

* **Project Node**
    - right-click on the *Project* node
    - click on *Edit Project*
    - ![Edit Project (from project node)][edit-project-node]
* **Menu**
    - click on the *Yann's Essentials* menu
    - select *Edit Project*
    - ![Edit Project (from menu)][edit-project-menu]
* **Code Window**
    - right-click in any code window
    - select *Yann's Essentials* in the context menu
    - select *Edit Project*
    - ![Edit Project (from code)][edit-project-code]

The project file opens in an XML window.

---

<div style="text-align:center">
  <img src="art/lss-vsip.png" />
</div>

[insert-guid-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/insert-guid-menu.png
[insert-guid-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/insert-guid-menu.png
[insert-guid-code]: https://github.com/yannduran/essentials-vs/raw/master/art/insert-guid-code.png

[rebuild-solution-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-solution-toolbar.png
[rebuild-solution-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-solution-menu.png
[rebuild-solution-code]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-solution-code.png

[rebuild-project-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-project-toolbar.png
[rebuild-project-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-project-menu.png
[rebuild-project-code]: https://github.com/yannduran/essentials-vs/raw/master/art/rebuild-project-code.png

[cancel-build-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/cancel-build-toolbar.png
[cancel-build-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/cancel-build-menu.png
[cancel-build-code]: https://github.com/yannduran/essentials-vs/raw/master/art/cancel-build-code.png

[extensions-updates-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/extensions-toolbar.png
[extensions-updates-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/extensions-menu.png
[extensions-updates-code]: https://github.com/yannduran/essentials-vs/raw/master/art/extensions-code.png

[restart-vs-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-toolbar.png
[restart-vs-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-menu.png
[restart-vs-code]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-code.png

[restart-vs-admin-toolbar]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-admin-toolbar.png
[restart-vs-admin-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-admin-menu.png
[restart-vs-admin-code]: https://github.com/yannduran/essentials-vs/raw/master/art/restart-vs-admin-code.png

[edit-solution-node]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-solution-node.png
[edit-solution-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-solution-menu.png
[edit-solution-code]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-solution-code.png

[close-solution-node]: https://github.com/yannduran/essentials-vs/raw/master/art/close-solution-node.png
[close-solution-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/close-solution-menu.png
[close-solution-code]: https://github.com/yannduran/essentials-vs/raw/master/art/close-solution-code.png

[edit-project-node]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-project-node.png
[edit-project-menu]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-project-menu.png
[edit-project-code]: https://github.com/yannduran/essentials-vs/raw/master/art/edit-project-code.png
