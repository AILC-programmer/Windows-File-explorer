using System;

namespace Explorer.PluginManager
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class CommandAttribute : Attribute
    {
        public string pluginName { get; set; }

        public CommandAttribute(string pluginName)
        {
            this.pluginName = pluginName;
        }
    }
}
