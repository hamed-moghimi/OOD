﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using OOD.EMS.UI.Users;
using OOD.EMS;

namespace OOD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DirectoryInfo mainDir = new DirectoryInfo(@Application.StartupPath);
            DirectoryInfo twoLevelsUp = mainDir.Parent.Parent;
            Storage.getInstance().init(twoLevelsUp.FullName + @"\data");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo culture = new GSD.Globalization.PersianCulture();
            culture.DateTimeFormat.ShortDatePattern = "yy/MM/dd";
            culture.DateTimeFormat.LongDatePattern = "yyyy/MM/dd";
            culture.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "";
            Application.CurrentCulture = culture;
            Application.Run(new LoginForm());
        }
    }
}