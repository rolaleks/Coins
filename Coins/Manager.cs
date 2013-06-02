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
    public partial class Manager : Form
    {
        public List<Personal> pers = new List<Personal>();
        public List<Cat> cat = new List<Cat>();
        public Cat Selected_cat;
        public Personal personal;
        public bool del=false;
        public bool isadd = false;
        public Manager()
        {
            InitializeComponent();
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM PERSONAL");

            try
            {
                while (reader.Read())
                {
                    Personal p = new Personal();
                    p.login = reader.GetString(1);
                    p.pass = reader.GetString(2);
                    if (reader.GetInt32(3) == 1)
                    {
                        p.add = true;
                    }
                    else {
                        p.add = false;
                    
                    }
                    if (reader.GetInt32(4) == 1)
                    {
                        p.create_pdf = true;
                    }
                    else
                    {
                        p.create_pdf = false;

                    }
                    if (reader.GetInt32(5) == 1)
                    {
                        p.change = true;
                    }
                    else
                    {
                        p.change = false;

                    }

                    if (reader.GetInt32(6) == 1)
                    {
                        p.download = true;
                    }
                    else
                    {
                        p.download = false;

                    }
                    if (reader.GetInt32(7) == 1)
                    {
                        p.admin = true;
                    }
                    else
                    {
                        p.admin = false;

                    }
                    if (!reader.IsDBNull(8))
                    {
                        p.Name = reader.GetString(8);
                    }
                    if (!reader.IsDBNull(9))
                    {
                        p.scndName = reader.GetString(9);
                    }
                    if (!reader.IsDBNull(10))
                    {
                        p.title = reader.GetString(10);
                    }
                   
                    pers.Add(p);
                }
            }
            finally
            {
                sql.EndQuery();
                refreshPers();
                Manager_personal_list.SetSelected(0, true);
                select();
                
            }


             sql = new SQL();
             reader = sql.StartQuery("SELECT * FROM CAT");

            try
            {
                while (reader.Read())
                {
                   
                    Cat c = new Cat();
                    c.cat = reader.GetString(1);
                    c.id = reader.GetInt32(0);
                    cat.Add(c);
                }
            }
            finally
            {
                sql.EndQuery();
                refreshCat();
                

            }
        }




        private void refreshPers() {
            Manager_personal_list.Items.Clear();
            
            for (int i = 0; i < pers.Count;i++ )
            {   
                Manager_personal_list.Items.Add(pers[i].login);
                
               
               
            
            }
        
        }

        private void refreshCat()
        {
           
            Manager_cat_list.Items.Clear();
            for (int i = 0; i < cat.Count;i++ )
            {
                Manager_cat_list.Items.Add(cat[i].cat);
              
            }
        }


        private void select() {
            for (int i = 0; i < pers.Count; i++)
            {   if(Manager_personal_list.SelectedItem.ToString()==pers[i].login){
                personal = pers[i];
                Manager_login_txt.Text = pers[i].login;
                Manager_pass_txt.Text = pers[i].pass;
                Manager_name_txt.Text = pers[i].Name;
                Manage_lastname_txt.Text = pers[i].scndName;
                Manager_title_txt.Text = pers[i].title;
                if (pers[i].add)
                {
                    Manger_chk_add.Checked = true;

                }
                else {

                    Manger_chk_add.Checked = false;
                }
                if (pers[i].create_pdf)
                {
                    Manger_chk_createPDF.Checked = true;

                }
                else
                {

                    Manger_chk_createPDF.Checked = false;
                }
                if (pers[i].change)
                {
                    Manger_chk_change.Checked = true;

                }
                else
                {

                    Manger_chk_change.Checked = false;
                }
                if (pers[i].download)
                {
                    Manger_chk_download.Checked = true;

                }
                else
                {

                    Manger_chk_download.Checked = false;
                }
                if (pers[i].admin)
                {
                    Manger_chk_admin.Checked = true;

                }
                else
                {

                    Manger_chk_admin.Checked = false;
                }
            }
            }
        
        
        }

        private void selectCat()
        {   
            for (int i = 0; i < cat.Count; i++)
            {
                if (Manager_cat_list.SelectedItem!=null)
                    if (Manager_cat_list.SelectedItem.ToString() == cat[i].cat)
                {
                    Selected_cat = cat[i];
                  
                }
            }


        }


        private void Manager_login_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Manager_personal_list_SelectedIndexChanged(object sender, EventArgs e)
        {   if(!del)
            select();
        }

        private void Manager_change_Click(object sender, EventArgs e)
        {
            if (isLoginOk())
            {
                if (personal.login != Manager_login_txt.Text || personal.pass != Manager_pass_txt.Text
                    || personal.add != Manger_chk_add.Checked || personal.change != Manger_chk_change.Checked
                    || personal.download != Manger_chk_download.Checked || personal.create_pdf != Manger_chk_createPDF.Checked
                    || personal.admin != Manger_chk_admin.Checked || personal.Name != Manager_name_txt.Text
                    || personal.scndName != Manage_lastname_txt.Text || personal.title != Manager_title_txt.Text
                    )
                {
                    int add_int;
                    int change_int;
                    int dl_int;
                    int create_int;
                    int admin_int;
                    if (Manger_chk_add.Checked)
                    {
                        add_int = 1;
                    }
                    else
                    {
                        add_int = 0;
                    }
                    if (Manger_chk_change.Checked)
                    {
                        change_int = 1;
                    }
                    else
                    {
                        change_int = 0;
                    }
                    if (Manger_chk_download.Checked)
                    {
                        dl_int = 1;
                    }
                    else
                    {
                        dl_int = 0;
                    }
                    if (Manger_chk_createPDF.Checked)
                    {
                        create_int = 1;
                    }
                    else
                    {
                        create_int = 0;
                    }
                    if (Manger_chk_admin.Checked)
                    {
                        admin_int = 1;
                    }
                    else
                    {
                        admin_int = 0;
                    }




                    SQL sql = new SQL();
                    sql.ExecuteNonQuery("UPDATE PERSONAL SET USER_LOGIN = '" + Manager_login_txt.Text + "', PASS = '" + Manager_pass_txt.Text + "', ADD_COIN = " + add_int + ", CREATE_PDF = " + create_int + ", CHANGE = " + change_int + ", DOWNLOAD = " + dl_int + ", ADMIN_RULE = " + admin_int + ", NAME = '" + Manager_name_txt.Text + "'" + ", LAST_NAME = '" + Manage_lastname_txt.Text + "'" + ", TITLE = '" + Manager_title_txt.Text + "'" + " WHERE " + "USER_LOGIN = '" + personal.login.ToString() + "'");
                    personal.login = Manager_login_txt.Text;
                    personal.pass = Manager_pass_txt.Text;
                    personal.add = Manger_chk_add.Checked;
                    personal.change = Manger_chk_change.Checked;
                    personal.download = Manger_chk_download.Checked;
                    personal.create_pdf = Manger_chk_createPDF.Checked;
                    personal.admin = Manger_chk_admin.Checked;
                    personal.Name = Manager_name_txt.Text;
                    personal.scndName = Manage_lastname_txt.Text;
                    personal.title = Manager_title_txt.Text;


                }
            }
            else {

                MessageBox.Show("Два пользователя с одним логином");
            
            }
        }

        private void Manger_chk_admin_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Manger_chk_admin_Click(object sender, EventArgs e)
        {
            if (!Manger_chk_admin.Checked && personal.admin)
            {
                int count = 0;
                for (int i = 0; i < pers.Count; i++)
                {
                    if (pers[i].admin)
                    {
                        count++;
                        if (count > 1)
                        {
                            break;
                        }
                    }



                }
                if (count <2)
                {
                    MessageBox.Show("Должен быть хотя бы один пользователь с правами администратора");
                    Manger_chk_admin.Checked = true;
                }
            }
        }
        private bool isLoginOk() {

            for (int i = 0; i < pers.Count;i++ )
            {
                if (pers[i].login == Manager_login_txt.Text && personal.login != Manager_login_txt.Text)
                {
                    return false;
                
                }

            }
            return true;
        
        }
        private void Manager_addpersonal_Click(object sender, EventArgs e)
        {    Personal p = new Personal();
            if (isadd) {
                if (isLoginOk())
                {
                    isadd = false;
                    Manager_addpersonal.Text = "Добавить";
                    SQL sql = new SQL();
                    int add_int;
                    int change_int;
                    int dl_int;
                    int create_int;
                    int admin_int;
                    if (Manger_chk_add.Checked)
                    {
                        add_int = 1;
                    }
                    else
                    {
                        add_int = 0;
                    }
                    if (Manger_chk_change.Checked)
                    {
                        change_int = 1;
                    }
                    else
                    {
                        change_int = 0;
                    }
                    if (Manger_chk_download.Checked)
                    {
                        dl_int = 1;
                    }
                    else
                    {
                        dl_int = 0;
                    }
                    if (Manger_chk_createPDF.Checked)
                    {
                        create_int = 1;
                    }
                    else
                    {
                        create_int = 0;
                    }
                    if (Manger_chk_admin.Checked)
                    {
                        admin_int = 1;
                    }
                    else
                    {
                        admin_int = 0;
                    }

                    sql.ExecuteNonQuery("INSERT INTO PERSONAL (USER_LOGIN,PASS,ADD_COIN,CREATE_PDF,CHANGE,DOWNLOAD,ADMIN_RULE,NAME,LAST_NAME,TITLE) VALUES('" + Manager_login_txt.Text + "','" + Manager_pass_txt.Text + "'," + add_int + "," + create_int + "," + change_int + "," + dl_int + "," + admin_int + ",'" + Manager_name_txt.Text + "','" + Manage_lastname_txt.Text + "','" + Manager_title_txt.Text + "')");
                    p = pers[pers.Count - 1];
                    p.login = Manager_login_txt.Text;
                    p.pass = Manager_pass_txt.Text;
                    p.add = Manger_chk_add.Checked;
                    p.change = Manger_chk_change.Checked;
                    p.download = Manger_chk_download.Checked;
                    p.create_pdf = Manger_chk_createPDF.Checked;
                    p.admin = Manger_chk_admin.Checked;
                    p.Name = Manager_name_txt.Text;
                    p.scndName = Manage_lastname_txt.Text;
                    p.title = Manager_title_txt.Text;
                    refreshPers();
                    Manager_personal_list.SetSelected(Manager_personal_list.Items.Count - 1, true);
                    select();
                }
                else {
                    MessageBox.Show("Два пользователя с одним логином");
                
                
                }
            
            }else{
                  isadd=true;
                 
                  Manager_personal_list.Items.Add("Пользователь");
                  Manager_personal_list.SetSelected(Manager_personal_list.Items.Count-1,true);
                  p.login = "Пользователь";
                 // p.scndName = "Пользователь ";
                  pers.Add(p);
                  select();
                  Manager_addpersonal.Text = "Cохранить";
            
            }
           
        }
        public bool isLastAdmin() {

            if (personal.admin)
            {
                int count = 0;
                for (int i = 0; i < pers.Count; i++)
                {
                    if (pers[i].admin)
                    {
                        count++;
                        if (count > 1)
                        {
                            return false;
                            
                        }
                    }



                }
                if (count < 2)
                {
                    MessageBox.Show("Должен быть хотя бы один пользователь с правами администратора");
                    return true;
                }
            }
            return false;
        
        }
        private void Manager_del_Click(object sender, EventArgs e)
        {
            del = true;
            SQL sql = new SQL();
           if(!isLastAdmin()){
            sql.ExecuteNonQuery("DELETE FROM PERSONAL WHERE " + "USER_LOGIN = '" + personal.login.ToString() + "'");
            for (int i = 0; i < pers.Count; i++)
            {
                if (pers[i].login==personal.login)
                {
                    pers.RemoveAt(i);
                    Manager_personal_list.Items.RemoveAt(i);
                    refreshPers();
                    Manager_personal_list.SetSelected(0, true);
                    select();
                }



            }
           }
           del = false;
        }

        private void Manager_cat_del_Click(object sender, EventArgs e)
        {
            del = true;
            SQL sql = new SQL();
            if (Selected_cat!=null)
            {
                sql.ExecuteNonQuery("DELETE FROM CAT WHERE " + "ID = " + Selected_cat.id);
                sql.ExecuteNonQuery("DELETE FROM COINS WHERE " + "CAT = " + Selected_cat.id);
                for (int i = 0; i < cat.Count; i++)
                {
                    if (cat[i].id == Selected_cat.id)
                    {
                        cat.RemoveAt(i);
                       
                        refreshCat();
                       
                       // select();
                    }



                }
            }
            Program.mainform.refreshCatList();
            del = false;
        }

        private void Manager_cat_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCat();
        }
    }
}
