using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nodepad.DAO
{
    static class CustomCommand
    {
        // Page Setup
        public static readonly RoutedUICommand PageSetup = new RoutedUICommand("PageSetup", "PageSetup", typeof(CustomCommand),
         new InputGestureCollection());

        // Exit
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(CustomCommand),
         new InputGestureCollection());

        //Find Next
        public static readonly RoutedUICommand FindNext = new RoutedUICommand("FindNext", "FindNext", typeof(CustomCommand), new InputGestureCollection() { new KeyGesture(Key.F3) });

        //Go to
        public static readonly RoutedUICommand Goto = new RoutedUICommand("Goto", "Goto", typeof(CustomCommand),
            new InputGestureCollection() { new KeyGesture(Key.G, ModifierKeys.Control) });

        //Time - Date
        public static readonly RoutedUICommand TimeDate = new RoutedUICommand("TimeDate", "TimeDate", typeof(CustomCommand), new InputGestureCollection());

        //Font
        public static readonly RoutedUICommand Font = new RoutedUICommand("Font", "Font", typeof(CustomCommand), new InputGestureCollection());

        //View Help
        public static readonly RoutedUICommand ViewHelp = new RoutedUICommand("ViewHelp", "ViewHelp", typeof(CustomCommand), new InputGestureCollection());

        //About Notepad
        public static readonly RoutedUICommand AboutNotepad = new RoutedUICommand("AboutNotepad", "Notepad", typeof(CustomCommand), new InputGestureCollection());
    }
}
