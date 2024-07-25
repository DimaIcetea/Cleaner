using Cleaner.Services;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cleaner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_tempFiles_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunScript("Clean_Temporary_Files.cmd");
        }
        private void btn_logFiles_Click(Object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunScript("Clean_Log_Files.cmd");
        }
        private void btn_dnsCache_Click(Object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunScript("Clean_DNS_Cache.cmd");
        }
        private void btn_openReg_Click(Object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.OpenApplication("regedit.exe");
        }
        private void btn_openConfig_Click(Object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.OpenApplication("msconfig.exe");
        }
        private void btn_openWindow_Click(Object sender, RoutedEventArgs e)
        {
            reg_editor Reg_editor = new reg_editor();
            Reg_editor.Show();
        }


    }
}