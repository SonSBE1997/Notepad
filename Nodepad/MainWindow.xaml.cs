using Microsoft.Win32;
using Nodepad.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nodepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string fileLocation;

        public MainWindow()
        {
            InitializeComponent();
            fileLocation = "";
        }
        #region event-Windows-Loaded
        //If u using file open with 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.FileName != null)
            {
                fileLocation = App.FileName;
                txbData.Text = OpenFileDocument.Instance.OpenFile(App.FileName, Encoding.UTF8);
                this.Title = GetFileName(fileLocation);
            }
            txbData.Focus();
        }
        #endregion

        #region event-windows-closing
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CheckSaveUntitiled())
            {
                MessageBoxResult result = MessageBox.Show("Do you want to save changes to Untitled?", "Notepad", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
                if (result == MessageBoxResult.Yes)
                {
                    if (SaveFile() == false) e.Cancel = true;
                }
            }
            if (CheckSaveWithName())
            {
                MessageBoxResult result = MessageBox.Show("Do you want to save changes to " + fileLocation + "?", "Notepad", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
                if (result == MessageBoxResult.Yes)
                {
                    SaveFileDocument.Instance.SaveFile(fileLocation, Encoding.UTF8, txbData.Text);
                }
            }
        }
        #endregion

        #region Methods

        private bool? SaveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|(*.*)";
            saveFile.AddExtension = false;
            saveFile.InitialDirectory = @"C:\Users\My PC\Documents";
            saveFile.FileName = "*.txt";
            bool? result = saveFile.ShowDialog();
            if (result == true && saveFile.FileName != "*.txt")
            {
                SaveFileDocument.Instance.SaveFile(saveFile.FileName, Encoding.UTF8, txbData.Text);
            }
            return result;
        }

        string GetFileName(string path)
        {
            string[] split = path.Split('\\');
            return split.Last() + " -  Notepad";
        }

        bool CheckSaveUntitiled()
        {
            return (txbData.Text.Equals("") == false && this.Title == "Untitled - Notepad");
        }

        bool CheckSaveWithName()
        {
            if (this.Title != "Untitled - Notepad")
            {
                string data = OpenFileDocument.Instance.OpenFile(fileLocation, Encoding.UTF8);
                return txbData.Text != data;
            }
            return false;
        }
        #endregion


        //Can Execute - true
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        #region Menu - File
        private void PrintCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (CheckSaveUntitiled())
            {
                MessageBoxResult result = MessageBox.Show("Do you want to save changes to Untitled?", "Notepad", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    if (SaveFile() == true)
                    {
                        txbData.Text = "";
                        return;
                    }

                }

                if (result == MessageBoxResult.No)
                {
                    txbData.Text = "";
                    return;
                }
            }

            if (CheckSaveWithName())
            {
                MessageBoxResult result = MessageBox.Show("Do you want to save changes to " + fileLocation + "?", "Notepad", MessageBoxButton.YesNoCancel);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        SaveFileDocument.Instance.SaveFile(fileLocation, Encoding.UTF8, txbData.Text);
                        txbData.Text = "";
                        this.Title = "Untitled - Notepad";
                        return;
                    case MessageBoxResult.No:
                        txbData.Text = "";
                        this.Title = "Untitled - Notepad";
                        return;
                }
            }
        }

        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            openFile.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|(*.*)";
            openFile.Multiselect = false;
            openFile.AddExtension = false;
            if (openFile.FileName != "")
            {
                txbData.Text = OpenFileDocument.Instance.OpenFile(openFile.FileName, Encoding.UTF8);
                fileLocation = openFile.FileName;
                this.Title = GetFileName(fileLocation);
            }
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.Title == "Untitled - Notepad") SaveFile();
            else
            {
                SaveFileDocument.Instance.SaveFile(fileLocation, Encoding.UTF8, txbData.Text);
            }
        }

        private void SaveAsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFile();
        }

        private void PageSetupCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ExitCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            Environment.Exit(0);
        }
        #endregion

        #region Menu - Edit

        //Delete can excute
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txbData.SelectionLength > 0) e.CanExecute = true;
        }

        //Delete excuted
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txbData.SelectedText.Remove(txbData.SelectionStart, txbData.SelectionLength);

        }

        //Find and Find Next can excute
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txbData.Text.Length > 0) e.CanExecute = true;
        }

        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void FindNextCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }


        private void ReplaceCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void GotoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void TimeDateCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txbData.Text += DateTime.Now.ToString("h:mm tt M/d/yyyy");
        }
        #endregion

        #region Menu - Format
        private void FontCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        #endregion

        #region Menu - Help
        private void ViewHelpCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://answers.microsoft.com/en-us/windows/forum/apps_windows_10?auth=1");
        }

        private void AboutNotepadCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        #endregion
    }
}