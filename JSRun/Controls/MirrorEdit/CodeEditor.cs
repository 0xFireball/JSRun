using Avalonia.Controls;
using Avalonia.Media;

namespace IridiumIon.MirrorEdit
{
    public class CodeEditor : TextBox
    {
        static CodeEditor()
        {
            AcceptsReturnProperty.OverrideDefaultValue(typeof(CodeEditor), true);
            //FontFamilyProperty.OverrideDefaultValue(typeof(CodeEditor), "Consolas");
            TextWrappingProperty.OverrideDefaultValue(typeof(CodeEditor), TextWrapping.Wrap);
        }

        public CodeEditor()
        {
            /*
            AcceptsReturn = true;
            FontFamily = "Consolas";
            TextWrapping = TextWrapping.Wrap;
            */
        }
    }
}