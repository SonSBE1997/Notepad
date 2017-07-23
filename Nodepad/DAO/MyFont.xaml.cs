using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nodepad.DAO
{
    /// <summary>
    /// Interaction logic for MyFont.xaml
    /// </summary>
    public partial class MyFont : Window
    {
        #region properties
        private string myFontSize;
        private string myFontFamily;
        private string myFontStyle;

        public string MyFontFamily
        {
            get
            {
                return myFontFamily;
            }

            private set
            {
                myFontFamily = value;
            }
        }

        public string MyFontStyle
        {
            get
            {
                return myFontStyle;
            }

            private set
            {
                myFontStyle = value;
            }
        }

        public string MyFontSize
        {
            get
            {
                return myFontSize;
            }

            private set
            {
                myFontSize = value;
            }
        }

        #endregion

        public MyFont()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(System.IO.Path.Combine(Environment.SystemDirectory, "control.exe"), "/name Microsoft.Fonts");
            //System.Diagnostics.Process.Start("control", "powercfg.cpl"); // open power 
            //System.Diagnostics.Process.Start(System.Environment.SystemDirectory + @"\appwiz.cpl");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            libFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            libFontSize.SelectedIndex = 4;

            libFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(_ => _.Source); ;
            libFontFamily.SelectedIndex = 0;

            libFontStyle.ItemsSource = new List<string>() { FontStyles.Italic.ToString(), FontStyles.Normal.ToString(), FontStyles.Oblique.ToString() };
            libFontStyle.SelectedIndex = 1;

            cbScript.ItemsSource = new List<string>() { "Western" };
            cbScript.SelectedIndex = 0;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckFont()) return;
            this.DialogResult = true;
        }

        bool CheckFont()
        {
            var temp = Fonts.SystemFontFamilies.OrderBy(_ => _.Source);
            if (temp.Any(_ => _.Source.Equals(txbFontFamily.Text)) == false)
            {
                MessageBox.Show("There is no font with that name.\r\nChoose a font from the list of fonts.", "Font", MessageBoxButton.OK, MessageBoxImage.Information);
                txbFontFamily.Focus();
                txbFontFamily.SelectAll();
                return false;
            }

            double size;
            if (Double.TryParse(txbFontSize.Text, out size) == false)
            {
                MessageBox.Show("Size must be a number.", "Font", MessageBoxButton.OK, MessageBoxImage.Information);
                txbFontSize.Focus();
                txbFontSize.SelectAll();
                return false;
            }

            if (txbFontStyle.Text.Equals("Italic") == false && txbFontStyle.Text.Equals("Oblique") == false && txbFontStyle.Text.Equals("Normal") == false)
            {
                MessageBox.Show("This font is not availabel in that style.\r\nChoose a style from the list of styles.", "Font", MessageBoxButton.OK, MessageBoxImage.Information);
                txbFontStyle.Focus();
                txbFontStyle.SelectAll();
                return false;
            }

            MyFontFamily = libFontFamily.SelectedItem.ToString();
            MyFontStyle = libFontStyle.SelectedItem.ToString();
            MyFontSize = libFontSize.SelectedItem.ToString();
            return true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txbFontFamily.SelectAll();
            txbFontFamily.Focus();
        }
    }
}
