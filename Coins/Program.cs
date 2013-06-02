using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coins
{
    static class Program
    {
        public static Form1 mainform;
        public static AddCoin addcoinform;
        public static autorisationForm Auth_form;
        public static bool Perm_Ad = false;
        public static bool Perm_Change = false;
        public static bool Perm_CreatePDF = false;
        public static bool Perm_Download = false;
        public static bool Perm_Admin = false;
        public static String JPGserver="";
        public static String CDRserver = "";
        public static String DATAserver = "";
        public static String DATALogin = "";
        public static String DATAPass = "";
        public static String DATASource = "";
        public static String DATAPort = "";
        public static Personal user;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            readserver();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Auth_form = new autorisationForm();
            Auth_form.Show();
            Application.Run();
            
         
        }
        private static void readserver()
        {
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(Application.StartupPath + "\\server.server");
            int i = 1;

            while ((line = file.ReadLine()) != null)
            {
                if (i == 1)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.JPGserver = line.Substring(dd, line.Length - dd);
                }
                if (i == 2)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.CDRserver = line.Substring(dd, line.Length - dd);
                }
                if (i == 3)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.DATAserver = line.Substring(dd, line.Length - dd);
                }
                if (i == 4)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.DATALogin = line.Substring(dd, line.Length - dd);
                }
                if (i == 5)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.DATAPass = line.Substring(dd, line.Length - dd);
                }
                if (i == 6)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.DATASource = line.Substring(dd, line.Length - dd);
                }
                if (i == 7)
                {
                    int dd = line.IndexOf("::") + 2;
                    Program.DATAPort = line.Substring(dd, line.Length - dd);
                }


                i++;
            }

            file.Close();

        }
    }
}
