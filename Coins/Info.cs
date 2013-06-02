using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Net;

namespace Coins
{
    public partial class Info : Form
    {
        Bitmap bm;
        String JPGPath;
        String CDRPath;
        String JPGName;
        String CDRName;
        String name;
        String number;
        String tag;
        Image jpg;
        String cdr;
        String catName;
        public PicBox picbox;

        public Info()
        {
            InitializeComponent();
            SetPerm();
            name = Info_name_txt.Text;
            number = Info_number_txt.Text;
            jpg = Info_jpg.Image;
            catName = Info_cat_txt.Text;
            cdr = Info_cdr_path_txt.Text;
            tag = Info_tags.Text;
            RefreshCat();

        }
        public void SetFields() {
            name = Info_name_txt.Text;
            number = Info_number_txt.Text;
            jpg = Info_jpg.Image;
            catName = Info_cat_txt.Text;
            cdr = Info_cdr_path_txt.Text;
            tag = Info_tags.Text;
            RefreshCat();
        
        }
        private void Info_Load(object sender, EventArgs e)
        {

        }
        public void SetPerm()
        {

            if (Program.Perm_Change)
            {
                Info_change.Visible = true;
                Info_load_cdr.Visible = true;
                Info_load_jpg.Visible = true;
            }
            else
            {
                Info_change.Visible = false;
                Info_load_cdr.Visible = false;
                Info_load_jpg.Visible = false;
            }
            if (Program.user.download)
            {
                Info_loadCoin.Visible = true;

            }
            else {
                Info_loadCoin.Visible = false;
            }

        }

        private void Info_load_jpg_Click(object sender, EventArgs e)
        {
            if (openJPG.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = new System.IO.FileStream(openJPG.FileName, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                JPGPath = openJPG.FileName;
                JPGName = openJPG.SafeFileName;
                bm = (Bitmap)img;
                Info_jpg.Image = bm;



            }
        }

        private void Info_load_cdr_Click(object sender, EventArgs e)
        {
            if (openCDR.ShowDialog() == DialogResult.OK)
            {
                CDRPath = openCDR.FileName;
                Info_cdr_path_txt.Text = CDRPath;
                CDRName = openCDR.SafeFileName;

            }
        }

        private void Info_cat_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void RefreshCat()
        {

            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");
            Info_cat_txt.Items.Clear();
            try
            {
                while (reader.Read())
                {
                    Info_cat_txt.Items.Add(reader.GetString(1));
                    Info_cat_txt.Text = Info_cat_txt.Items[0].ToString();
                }
            }
            finally
            {   
                sql.EndQuery();
                Info_cat_txt.Text = catName;
            }



        }
        public bool isLoginOk()
        {

            for (int i = 0; i < Program.mainform.All.Count; i++)
            {
                if (Program.mainform.All[i].coin.number == int.Parse(Info_number_txt.Text) && number != Info_number_txt.Text)
                {
                    MessageBox.Show("Монета с таким номером уже существует");
                    return false;

                }

            }
            return true;

        }
        private void Info_change_Click(object sender, EventArgs e)
        {
            if (isLoginOk())
            {
                if (name != Info_name_txt.Text || number != Info_number_txt.Text || catName != Info_cat_txt.Text || jpg != Info_jpg.Image || tag != Info_tags.Text
                    || (picbox.coin.date.Day+"."+picbox.coin.date.Month+"."+picbox.coin.date.Year)!=Info_date_txt.Text)
                {
                    int catid = GetCatID(Info_cat_txt.Text);
                    int catid_f = GetCatID(catName);
                    SQL sql = new SQL();
                    if (Info_number_txt.Text == "")
                    {
                        Info_number_txt.Text = "0";
                    }

                    String new_jpg_path = JPGName;
                    String new_cdr_path = CDRName;

                    if (bm != null)
                    {
                        bm = ResizeBitmap(bm);

                       

                    }






                    WebClient wc = new WebClient();

                   
                    int sec = picbox.coin.sec;
                    /*
                    if (picbox.coin.image != Info_jpg.Image)
                    {
                        wc.UploadFile(Program.JPGserver + JPGName + sec, "STOR", JPGPath);
                        JPGName += "" + sec;
                        
                    }
                    else
                    {
                        JPGName = picbox.coin.JPGPath;

                    }*/
                    if (JPGPath != null)
                    {
                        bm.Save(Application.StartupPath + "\\" + new_jpg_path);
                        wc.UploadFile(Program.JPGserver + new_jpg_path + sec, "STOR", Application.StartupPath + "\\" + new_jpg_path);
                        System.IO.File.Delete(Application.StartupPath + "\\" + new_jpg_path);
                        new_jpg_path += "" + sec;
                        picbox.coin.JPGPath = new_jpg_path;
                        picbox.coin.image = (Bitmap)bm;
                        picbox.Image = picbox.coin.image;

                    }
                    else
                    {
                        new_jpg_path = picbox.coin.JPGPath;

                    }
                    if (CDRPath != null)
                    {
                        wc.UploadFile(Program.CDRserver + new_cdr_path + sec, "STOR", CDRPath);
                        new_cdr_path += "" + sec;
                        picbox.coin.CDRPath = new_cdr_path;
                    }
                    else
                    {

                        new_cdr_path = picbox.coin.CDRPath;
                    }
                    String day = "";
                    String month = "";
                    String year = "";
                    String date="";
                    if ((picbox.coin.date.Day + "." + picbox.coin.date.Month + "." + picbox.coin.date.Year) != Info_date_txt.Text)
                    {
                        try
                        {
                       
                            String tmp;
                             day = Info_date_txt.Text.Substring(0, Info_date_txt.Text.IndexOf("."));
                            tmp = Info_date_txt.Text.Substring(Info_date_txt.Text.IndexOf(".") + 1, Info_date_txt.Text.Length - Info_date_txt.Text.IndexOf(".") - 1);
                             month = tmp.Substring(0, tmp.IndexOf("."));
                            tmp = tmp.Substring(tmp.IndexOf(".") + 1, tmp.Length - tmp.IndexOf(".") - 1);
                             year = tmp;
                             date = int.Parse(month) + "/" + int.Parse(day) + "/" + int.Parse(year);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                           
                        }
                    }
                    else {
                         date = picbox.coin.date.Month + "/" + picbox.coin.date.Day + "/" + picbox.coin.date.Year;
                    
                    }
                    String test11 = "";
                     test11 = "UPDATE COINS SET NAME = '" + Info_name_txt.Text + "'" + ", \"DATE\" = '" + date + ", TAG = '" + Info_tags.Text + "', NUMBER = " + int.Parse(Info_number_txt.Text) + ", CAT = " + catid + ", IMAGE_JPG = '" + new_jpg_path + "'" + ", IMAGE_CDR = '" + new_cdr_path + "'" + " WHERE " + "NAME = '" + name + "'AND NUMBER = " + int.Parse(number) + "AND CAT = " + catid_f;
                    sql.ExecuteNonQuery("UPDATE COINS SET NAME = '" + Info_name_txt.Text + "'"+", \"DATE\" = '" + date +"', TAG = '" + Info_tags.Text + "', NUMBER = " + int.Parse(Info_number_txt.Text) + ", CAT = " + catid + ", IMAGE_JPG = '" + new_jpg_path + "'" + ", IMAGE_CDR = '" + new_cdr_path + "'" + " WHERE " + "NAME = '" + name + "'AND NUMBER = " + int.Parse(number) + "AND CAT = " + catid_f);

                    picbox.coin.name = Info_name_txt.Text;
                    picbox.coin.number = int.Parse(Info_number_txt.Text);
                    picbox.coin.tag = Info_tags.Text;
                    if ((picbox.coin.date.Day + "." + picbox.coin.date.Month + "." + picbox.coin.date.Year) != Info_date_txt.Text)
                    {
                        picbox.coin.date.AddDays(int.Parse(day));
                        picbox.coin.date.AddMonths(int.Parse(month));
                        picbox.coin.date.AddYears(int.Parse(year));
                    }
                    Program.mainform.refreshCoinIdtoName();
                    Program.mainform.sort();
                }
            }
        }
        private static Bitmap ResizeBitmap(Bitmap sourceBMP)
        {
            int width = 100;
            int height = 100;
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(sourceBMP, 0, 0, width, height);
            return result;
        }
        private int GetCatID(String cat)
        {

            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");

            try
            {
                while (reader.Read())
                {
                    if (reader.GetString(1).ToString() == cat)
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            finally
            {
                sql.EndQuery();
            }

            return -1;
        }

        private void Info_loadCoin_Click(object sender, EventArgs e)
        {

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowser.SelectedPath;
                try
                {
                   
                   



                        if (picbox.coin.JPGPath != "")
                        {
                            WebClient wc = new WebClient();
                            String jpgName = picbox.coin.JPGPath;
                            String name = jpgName.Substring(0, jpgName.Length - picbox.coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.JPGserver + jpgName, path + "\\" + picbox.coin.number + ext);



                        }
                        if (picbox.coin.CDRPath != "")
                        {
                            WebClient wc = new WebClient();
                            String cdrName = picbox.coin.CDRPath;
                            String name = cdrName.Substring(0, cdrName.Length - picbox.coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.CDRserver + cdrName, path + "\\" + picbox.coin.number + ext);



                        }



                    


                }
                finally
                {

                }
            }
        }

        private void Info_number_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Info_number_txt.Text.Length > 7 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
