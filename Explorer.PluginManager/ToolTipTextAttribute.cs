using System;

namespace Explorer.PluginManager
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ToolTipTextAttribute : Attribute
    {
        public string Text { get; set; }
        public ToolTipTextAttribute(string Text)
        {
            this.Text = Text;
        }
    }
}
