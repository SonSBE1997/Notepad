using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nodepad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string _FileName;

        public static string FileName
        {
            get
            {
                return _FileName;
            }

            set
            {
                _FileName = value;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            if (e.Args.Length > 0) FileName = e.Args[0];

            //u can get Args using Environment.GetCommandLineArgs()
        }
    }
}
