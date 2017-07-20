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
        public static readonly RoutedUICommand Save = new RoutedUICommand("Save", "Save", typeof(CustomCommand),
            new InputGestureCollection() { new KeyGesture(Key.S, ModifierKeys.Control) });
        public static readonly RoutedUICommand New = new RoutedUICommand("New", "New", typeof(CustomCommand),
           new InputGestureCollection() { new KeyGesture(Key.N, ModifierKeys.Control) });
        public static readonly RoutedUICommand Open = new RoutedUICommand("Open", "Open", typeof(CustomCommand),
           new InputGestureCollection() { new KeyGesture(Key.O, ModifierKeys.Control) });
        public static readonly RoutedUICommand Print = new RoutedUICommand("Print", "Print", typeof(CustomCommand),
         new InputGestureCollection() { new KeyGesture(Key.P, ModifierKeys.Control) });
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(CustomCommand),
         new InputGestureCollection());
    }
}
