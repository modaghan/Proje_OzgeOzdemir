using Proje.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckFiles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GirisFormu girisFormu = new GirisFormu();
            if (girisFormu.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());
        }

        private static void CheckFiles()
        {
            string[] Dirs = new string[]
            {
              Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + $"\\{Settings.Default.DBFolder}\\"
            };
            foreach (string dir in Dirs)
                    Directory.CreateDirectory(dir);
            string[] Files = new string[]
            {
                Dirs[0] + "\\Companies.json",
                Dirs[0] + "\\Logs.json"
            };
            foreach (string fname in Files)
            {
                if (!File.Exists(fname))
                {
                    File.Create(fname).Close();
                    File.WriteAllText(fname, "[]");
                }
            }

        }
    }
}
