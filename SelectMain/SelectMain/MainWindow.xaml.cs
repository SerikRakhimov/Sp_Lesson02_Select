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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelectMain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butLoadfile_Click(object sender, RoutedEventArgs e)
        {
            var loadileDomain = AppDomain.CreateDomain("Loadfile domain");
            loadileDomain.ExecuteAssembly(loadileDomain.BaseDirectory + "SelectLoadfile.exe", new string[] { "https://cloud.mail.ru/public/27re/3Vxxsf5iG"});
            AppDomain.Unload(loadileDomain);
        }

        private void butRuncalc_Click(object sender, RoutedEventArgs e)
        {
            var runcalcDomain = AppDomain.CreateDomain("Loadfile domain");
            runcalcDomain.ExecuteAssembly(runcalcDomain.BaseDirectory + "SelectCalc.exe", new string[] { "5" });
            AppDomain.Unload(runcalcDomain);
        }
    }
}
