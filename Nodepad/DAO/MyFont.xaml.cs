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

            set
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

            set
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

            set
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
            //cbFontSize.ItemsSource = new List<float>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            //cbFontSize.SelectedIndex = 4;

            //// Custom Font
            ////CustomFont customFont = new CustomFont();
            //cbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(_ => _.Source);
            //cbFontFamily.SelectedIndex = 0;
            //cbFontStyle.ItemsSource = new List<string>() { FontStyles.Italic.ToString(), FontStyles.Normal.ToString(), FontStyles.Oblique.ToString() };
            //cbFontStyle.SelectedIndex = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            //MyFontFamily = cbFontFamily.SelectedItem.ToString();
            //MyFontStyle = cbFontStyle.SelectedItem.ToString();
            //MyFontSize = cbFontSize.SelectedItem.ToString();
        }
    }

    /////<summary>
    ///// Class MyFont has font family and font style
    ///// </summary>
    //public class CustomFont
    //{
    //    public List<string> MyFontFamily;
    //    public List<string> MyFontStyle;
    //    public CustomFont()
    //    {
    //        MyFontFamily = new List<string>();
    //        MyFontStyle = new List<string>();
    //    }
    //}
}
