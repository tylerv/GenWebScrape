using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenWebScrape
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}


//TODO: Create Search Definitions (DataTables and Form - Need to have a datagridview that lists the parameters in reado-only and lets users type in the search values. Allow multiple defined searches per site and SHOW the search ID for use in CLI runs.)
//TODO: Add in CLI parameters that include which dataset.xml to load