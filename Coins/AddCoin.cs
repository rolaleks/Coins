using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.OleDb;
using FirebirdSql.Data.FirebirdClient;
using System.Net;

namespace Coins
{
    public partial class AddCoin : Form
    {
       
        byte[] jpg;
        Bitmap bm;
        String JPGPath;
        String CDRPath;
        String JPGName;
        String CDRName;
        public AddCoin()
        {
            InitializeComponent();
           
               RefreshCat();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLoginOk())
            {
            int catid = GetCatID(CoinCat.Text);
            SQL sql = new SQL();
            if (CoinNumberTxt.Text == "")
            {
                CoinNumberTxt.Text = "0";
            }
            Random rnd = new Random();
            int sec = rnd.Next(1000000);
            coin cn = new coin();
            if (bm != null)
            {
                bm = ResizeBitmap(bm);
                cn.image = bm;
               
                
            }
            cn.name = CoinNameTxt.Text;
            cn.cat = catid;
            cn.number = int.Parse(CoinNumberTxt.Text);
            cn.date = Calendar.Value;
            cn.sec = sec;
            cn.tag = Info_tags.Text;
            //cn.date.AddDays(Calendar.SelectionStart.Day);
            //cn.date.AddMonths(Calendar.SelectionStart.Month);
           // cn.date.AddYears(Calendar.SelectionStart.Year);

            String date = Calendar.Value.Month + "/" + Calendar.Value.Day + "/" + Calendar.Value.Year;

            WebClient wc = new WebClient();
            String new_jpg_path = JPGName;
            String new_cdr_path = CDRName;
            if (JPGPath != null)
            {
                bm.Save(Application.StartupPath + "\\" + new_jpg_path);
                wc.UploadFile(Program.JPGserver + new_jpg_path + sec, "STOR", Application.StartupPath + "\\" + new_jpg_path);
                System.IO.File.Delete(Application.StartupPath + "\\" + new_jpg_path);
                new_jpg_path += "" + sec;
                cn.JPGPath = new_jpg_path;
                
            }
            else
            {
                new_jpg_path = "";
                cn.JPGPath = new_jpg_path;

            }
            if (CDRPath != null)
            {
                wc.UploadFile(Program.CDRserver + new_cdr_path + sec, "STOR", CDRPath);
                new_cdr_path += "" + sec;
                cn.CDRPath = new_cdr_path;
            }
            else
            {

                new_cdr_path = "";
                cn.CDRPath = new_cdr_path;
            }




            PicBox pb = new PicBox(cn, Program.mainform.ItemSizeX, Program.mainform.ItemSizeY);
            pb.Click += new System.EventHandler(Program.mainform.pictureBox1_Click);





            sql.ExecuteNonQuery("INSERT INTO COINS (NAME,NUMBER,CAT,IMAGE_JPG,IMAGE_CDR,\"DATE\",SECURE,TAG) VALUES('" + CoinNameTxt.Text + "'," + int.Parse(CoinNumberTxt.Text) + "," + catid + ",'" + new_jpg_path + "','" + new_cdr_path + "','" + date + "'," + sec + ",'" + Info_tags.Text + "')");
            Program.mainform.All.Add(pb);
            Program.mainform.refreshIdToName();
            Program.mainform.refreshCoinIdtoName();
            Program.mainform.refreshCatList();
            Program.mainform.sort();
             //INSERT INTO COINS (ID, NAME, NUMBER, CAT, IMAGE_JPG, IMAGE_CDR, "DATE") VALUES (14, 'le;flsd', 34234, 4, 'C:\Users\Public\Pictures\Sample Pictures\Desert.jpg', 'None', '2-MAR-2012');
        }

        }
        public bool isLoginOk()
        {

            for (int i = 0; i < Program.mainform.All.Count; i++)
            {
                if (Program.mainform.All[i].coin.number == int.Parse(CoinNumberTxt.Text))
                {
                    MessageBox.Show("Монета с таким номером уже существует");
                    return false;

                }

            }
            return true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                JPGPath = openFileDialog1.FileName;
                JPGName = openFileDialog1.SafeFileName;
                
                bm = (Bitmap)img;
                JPGpreview.Image = bm;
                


            }
        }
        private Bitmap resize(Bitmap pic) {
            Bitmap new_pic = new Bitmap(100,100);
            double k1 = pic.Height / new_pic.Height;
            double k2 = pic.Width / new_pic.Width;
            for (int i = 0; i < new_pic.Width;i++ )
            {
                for (int j = 0; j < new_pic.Height; j++)
                {
                    int x = (int)k2 * i;
                    int y= (int)k1 * j;
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    int count=0;
                    for (int q = x - 1; q <= x + 1;q++ )
                    {
                        for (int w = y - 1; w <= y + 1; w++)
                        {
                            if (q < pic.Width && w < pic.Height && q>0 && w>0) {
                                count++;
                                Color c = pic.GetPixel(q,w);

                                r += c.R;
                                g += c.G;
                                b += c.B;
                            
                            
                            }
                        }
                       


                    }
                    r /= count;
                    b /= count;
                    g /= count;
                    Color col = Color.FromArgb(r,g,b);

                    new_pic.SetPixel(i,j,col);

                }   

            }




            return new_pic;
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.AddMore.PerformClick();
            this.Close();
        }
        private int GetCatID(String cat) {

            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");

            try
            {
                while (reader.Read())
                {
                    if (reader.GetString(1).ToString()==cat)
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
        public void RefreshCat()
        {

            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");
            CoinCat.Items.Clear();
            try
            {
                while (reader.Read()) 
                {
                    CoinCat.Items.Add(reader.GetString(1));
                    CoinCat.Text = CoinCat.Items[0].ToString();
                }
            }
            finally
            {
                sql.EndQuery();
            }



        }

        private void CoinNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CoinNumberTxt.Text.Length > 7 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void addCDR_Click(object sender, EventArgs e)
        {
            if (openCDR.ShowDialog() == DialogResult.OK)
            {
                CDRPath = openCDR.FileName;
                CDRPathTxt.Text = CDRPath;
                CDRName = openCDR.SafeFileName;

            }
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            AddCat form = new AddCat();
            form.Show();
            
        }

        private void CoinCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void JPGpreview_Click(object sender, EventArgs e)
        {

        }
        
    }
}
