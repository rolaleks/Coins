using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Coins
{
    public partial class autorisationForm : Form
    {
        bool log = false;
        public autorisationForm()
        {
            InitializeComponent();
        }

        private void Auth_log_lable_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            try
            {
                
                FbDataReader reader = sql.StartQuery("SELECT * FROM PERSONAL");
                Program.user = new Personal();
                if(sql.error==0)
                while (true)
                {
                    if (reader.Read())
                    {

                    }
                    else {
                        break;
                    }
                    int a;
                    if (reader.GetString(1) == Auth_name.Text  && (!reader.IsDBNull(2) & reader.GetString(2) == Auth_pass.Text))
                    {
                        log = true;
                        if(!reader.IsDBNull(3) & reader.GetString(3)=="1"){
                            Program.Perm_Ad = true;
                            Program.user.add = true;

                        }
                        if (!reader.IsDBNull(4) & reader.GetString(4) == "1")
                        {
                            Program.Perm_CreatePDF = true;
                            Program.user.create_pdf = true;

                        }
                        if (!reader.IsDBNull(5) & reader.GetString(5) == "1")
                        {
                            Program.Perm_Change = true;
                            Program.user.change = true;

                        }
                        if (!reader.IsDBNull(6) & reader.GetString(6) == "1")
                        {
                            Program.Perm_Download = true;
                            Program.user.download = true;

                        }
                        if (!reader.IsDBNull(7) & reader.GetString(7) == "1")
                        {
                            Program.Perm_Admin = true;
                            Program.user.admin = true;

                        }
                        if (!reader.IsDBNull(8) )
                        {

                            Program.user.Name = reader.GetString(8);

                        }
                        if (!reader.IsDBNull(9) )
                        {

                            Program.user.scndName = reader.GetString(9);

                        }
                        if (!reader.IsDBNull(10))
                        {

                            Program.user.title = reader.GetString(10);

                        }
                        break;
                    }
                  
                }
            }
            finally
            {
                sql.EndQuery();
            }
            if (log)
            {


                Program.mainform = new Form1();
                Program.mainform.Show();
                Program.Auth_form.Close();

            }
            else {
               

                    MessageBox.Show("Неверный логин или пароль");

            
            
            }
            }

        private void autorisationForm_Load(object sender, EventArgs e)
        {

           /*
                Program.Perm_Ad = true;

           
                Program.Perm_CreatePDF = true;

           
                Program.Perm_Change = true;

         
                Program.Perm_Download = true;

            
            Program.mainform = new Form1();
            Program.mainform.Show();
            Program.Auth_form.Close();*/
        }

        private void Auth_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter){
                Enter.PerformClick();
            }
        }

        private void Auth_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Enter.PerformClick();
            }
        }
    }
}
