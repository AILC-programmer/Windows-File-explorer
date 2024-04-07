#FileExplorer
The file explorer for Windows. You can have some plugins for this file explorer.

The application’s UI is implemented by metromodernui.1.4.0 package, which is available on the NuGet package.

If you want to create some plugins for this application, you can use the “Explorer.PluginManager” library:

– Interfaces:

  ICommand: You must implement the “ICommand” interface on one of the classes. This interface has one method called “run”, which can run a form or some queries from that library.

– Attributes:

  Command: You must use the “Command” attribute on the class that implements the ICommand interface. You can set the plugin name with this attribute.

  Icon: This attribute takes a string path of the icon file. The extension of icon file must be a PNG.

  ToolTipText: This attribute takes a string text and sets it as the tooltip.

  ShortcutKeys: This attribute takes a char shortcut. The character should be a capital letter.
