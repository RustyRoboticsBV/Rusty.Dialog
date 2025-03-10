using Godot;

namespace Rusty.Dialog
{
    /// <summary>
    /// An utility that provides global dialog-related methods.
    /// </summary>
    [GlobalClass]
    public partial class DialogManager : Node
    {
        public static void SelectWindow(string text, string targetLabel)
        {}
        
        public static void SetWindowState(string text, string targetLabel)
        {}
        
        public static void ClearText(string text, string targetLabel)
        {}
        
        public static void SetText(string speaker, string mood, string body)
        {}
        
        public static void AddChoice(string text, string targetLabel)
        {}
        
        public static void ExtendText(string text)
        {}
    }
}