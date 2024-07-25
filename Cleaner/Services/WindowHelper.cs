using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cleaner.Services
{
    class WindowHelper
    {
        public static class ProcessHelper
        {
            public static void RunScript(string scriptName)
            {
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, scriptName);
                    if (!File.Exists(path))
                    {
                        MessageBox.Show($"Файл не найден: {path}");
                        return;
                    }

                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    Process process = Process.Start(processInfo);
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Операция отменена пользователем.");
                }
            }
            public static void RunRegScript(string scriptName)
            {
                try 
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, scriptName);
                    if (!File.Exists(path))
                    {
                        MessageBox.Show($"Файл не найден: {path}");
                        return;
                    }
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "regedit.exe",
                        Arguments = $"/s \"{scriptName}\"",
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    Process process = Process.Start(processInfo);
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Операция отменена пользователем.");
                }
            }

            public static void OpenApplication(string applicationName)
            {
                try
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = applicationName,
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    Process process = Process.Start(processInfo);
                }
                catch
                {
                    MessageBox.Show("Не получилось.");
                }
            }
        }
    }
}
