using System;
using System.Windows.Forms;

namespace Explorer.PluginManager
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ShortcutKeysAttribute : Attribute
    {
        private Keys keys { get; set; }

        public ShortcutKeysAttribute(char ShortcutKey)
        {
            this.keys = (Keys)ShortcutKey;
        }

        public ShortcutKeysAttribute(Keys keys)
        {
            this.keys = keys;
        }

        public Keys getShourtCut()
        {
            Keys s = (Keys)keys;
            return Keys.Control | Keys.Shift | Keys.Alt | s;
        }
    }
}
