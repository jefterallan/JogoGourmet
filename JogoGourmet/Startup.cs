﻿using JogoGourmet.Views;
using System;
using System.Windows.Forms;

namespace JogoGourmet
{
    static class Startup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmJogoGourmet());
        }
    }
}
