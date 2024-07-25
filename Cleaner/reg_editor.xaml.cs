using Cleaner.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Cleaner
{
    /// <summary>
    /// Логика взаимодействия для reg_editor.xaml
    /// </summary>
    public partial class reg_editor : Window
    {
        public reg_editor()
        {
            InitializeComponent();
        }
        private void btn_offServ_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Disable_Unnecessary_Services.reg");
        }
        private void btn_offBack_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Disable_Background_Apps.reg");
        }
        private void btn_offPack_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Disable_Core_Parking.reg");
        }
        private void btn_offMaps_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Disable_Download_Maps.reg");
        }
        private void btn_offTrans_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Disable_Transparency.reg");
        }
        private void btn_offWin_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Win32PrioritySeperation.reg");
        }
        private void btn_onMaps_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Enable_Download_Maps_Manager.reg");
        }
        private void btn_onServ_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Enable_Extra_Unnecessary_Services.reg");
        }
        private void btn_onTrans_Click(object sender, RoutedEventArgs e)
        {
            WindowHelper.ProcessHelper.RunRegScript("Enable_Transparency.reg");
        }




    }
}
