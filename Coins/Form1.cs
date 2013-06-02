using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using FirebirdSql.Data.FirebirdClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace Coins
{ 
    public partial class Form1 : Form
    {
        int sorttype = 0;
    bool isPrint = false;
    Document myDocument = new Document(PageSize.A4);
    public  int ID = 2;
    public List <PicBox> All = new List<PicBox>();
    public List<PicBox> toPrintList = new List<PicBox>();
    public List<idToName> idtoname = new List<idToName>();
    public int ItemsBoxBorderUp = 10;
    int ItemsBoxBorderLeft = 10;
    int ItemsBoxBorderDown = 10;
    int ItemsBoxBorderRight = 10;
    int ItemsBoxShift = 10;
    public int ItemSizeX = 100;
    public int ItemSizeY = 100;

        public Form1()
    {
            
            InitializeComponent();
            LoadCoin();
           
            refreshCatList();
            refreshIdToName();
            refreshCoinIdtoName();
            sort();
            Sort_date.ForeColor = Color.OrangeRed;
            SetPerm();
            int y = (int)PageSize.A4.Width;
            int q = (int)PageSize.A4.Height;
            backgroundWorker1.DoWork += bw_DoWork;
            backgroundWorker1.ProgressChanged += bw_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += bw_RunWorkerCompleted;
            backgroundWorker2.DoWork += bw_DoWork_load;
            backgroundWorker2.ProgressChanged += bw_ProgressChanged_load;
            backgroundWorker2.RunWorkerCompleted += bw_RunWorkerCompleted_load;
            backgroundWorker3.DoWork += bw_DoWork_load_toprint;
            backgroundWorker3.ProgressChanged += bw_ProgressChanged_load_toprint;
            backgroundWorker3.RunWorkerCompleted += bw_RunWorkerCompleted_load_toprint;
            
            
           
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshItemsBox();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AddCoin form = new AddCoin();
             form.Show();
             Program.addcoinform = form;
         
        }
        public void SQL() {

            String Connect = "C:/Users/Alex/Documents/Visual Studio 2010/Projects/Coins/Coins/Database1.sdf; Password = lumo";
            SqlCeEngine engine = new SqlCeEngine("Data Source=" + Connect);
            SqlCeConnection cn = new SqlCeConnection(engine.LocalConnectionString);
            cn.Open();
            SqlCeCommand command = cn.CreateCommand();
            command.CommandText = "SELECT Name FROM coins";
            SqlCeDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //"INSERT INTO MyTable VALUES(@num)"
                SearchBox.Text = dataReader.GetValue(0).ToString();


            }
            cn.Close();
        }
        public void refreshCatList() {
            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");
            CatList.Items.Clear();
            CatList.Items.Add("Все");
            try
            {
                while (reader.Read())
                {
                    CatList.Items.Add(reader.GetString(1));
                    //.Text = CoinCat.Items[0].ToString();
                }
            }
            finally
            {
                sql.EndQuery();
            }

        
        
        
        }
        public void LoadCoin(){
            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM COINS");

            try
            {
                while (reader.Read())
                {
                    coin cn = new coin();
                    if (!reader.IsDBNull(4))
                        cn.JPGPath = reader.GetString(4);
                    if (reader.GetString(4) != "")
                    {
                        WebClient wc = new WebClient();
                        String name = reader.GetString(4).Substring(0, reader.GetString(4).Length - reader.GetString(8).Length);
                        wc.DownloadFile(Program.JPGserver + reader.GetString(4), Application.StartupPath +"\\"+ name);
                        System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath+"\\" + name, System.IO.FileMode.Open);
                        

                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        System.IO.File.Delete(Application.StartupPath + "\\" + name);

                        Bitmap bm = (Bitmap)img;
                        cn.image = bm;
                    }
                    if (!reader.IsDBNull(8))
                        cn.sec = reader.GetInt32(8);
                    if (!reader.IsDBNull(7))
                        cn.tag = reader.GetString(7);
                    if (!reader.IsDBNull(5))
                        cn.CDRPath = reader.GetString(5);
                    if (!reader.IsDBNull(3))
                    cn.cat = reader.GetInt32(3);
                    if (!reader.IsDBNull(1))
                    cn.name = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                    cn.number = reader.GetInt32(2);
                    cn.id = reader.GetInt32(0);
                    if (!reader.IsDBNull(6))
                    cn.date=reader.GetDateTime(6);
                    PicBox pb = new PicBox(cn,ItemSizeX, ItemSizeY);
                    pb.Click += new System.EventHandler(pictureBox1_Click);
                    All.Add(pb);
                }
            }
            finally
            {
                sql.EndQuery();
                SaveJPG();
            }        
            
        }
        public void RefreshItemsBox(){
            int x = ItemsBoxBorderLeft;
            int y = ItemsBoxBorderUp;
            CatList.Enabled = false;
            ItemsBox.Controls.Clear();
            int n = 0;
            int test = 0;
            while(n<  All.Count)
            {
                for (int i = x; i < ItemsBox.Width - ItemsBoxBorderRight-ItemSizeX; i += ItemsBoxShift + ItemSizeX)
                {
                    bool isok=false;
                    while (!isok && n < All.Count) { 
                        for(int r=1;r<CatList.Items.Count;r++){
                            if (CatList.GetItemChecked(r))
                            if (All[n].coin.catName == CatList.Items[r].ToString())
                            {
                                if (SearchBox.Text == "")
                                {
                                    isok = true;
                                    test++;

                                    All[n].Location = new System.Drawing.Point(i, y);
                                    //Номер монеты
                                    Label label = new Label();
                                    label.Height = 13;
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.BackColor = Color.Transparent;
                                    label.FlatStyle = FlatStyle.Standard;
                                    label.Text = All[n].coin.number.ToString();
                                    label.Location = new System.Drawing.Point(i, y + ItemSizeY);
                                    //-------------------------------------------------------
                                    //Название
                                    Label name = new Label();
                                    name.Height = 13;

                                    name.TextAlign = ContentAlignment.MiddleCenter;
                                    name.BackColor = Color.Transparent;
                                    name.FlatStyle = FlatStyle.Standard;
                                    name.Text = All[n].coin.name.ToString();
                                    name.Location = new System.Drawing.Point(i, y + ItemSizeY + 13);



                                    //-------------------------------------------------------
                                    ItemsBox.Controls.Add(All[n]);
                                    ItemsBox.Controls.Add(label);
                                    ItemsBox.Controls.Add(name);
                                    break;
                                }
                                else {

                                    if (All[n].coin.name.Contains(SearchBox.Text) || All[n].coin.id.ToString().Contains(SearchBox.Text)
                                        || All[n].coin.date.ToString().Contains(SearchBox.Text) || All[n].coin.number.ToString().Contains(SearchBox.Text)
                                        || All[n].coin.catName.ToString().Contains(SearchBox.Text) || All[n].coin.tag.Contains(SearchBox.Text))
                                    {
                                    isok = true;
                                    test++;

                                    All[n].Location = new System.Drawing.Point(i, y);
                                    //Номер монеты
                                    Label label = new Label();
                                    label.Height = 13;
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.BackColor = Color.Transparent;
                                    label.FlatStyle = FlatStyle.Standard;
                                    label.Text = All[n].coin.number.ToString();
                                    label.Location = new System.Drawing.Point(i, y + ItemSizeY);
                                    //-------------------------------------------------------
                                    //Название
                                    Label name = new Label();
                                    name.Height = 13;
                                    
                                    name.TextAlign = ContentAlignment.MiddleCenter;
                                    name.BackColor = Color.Transparent;
                                    name.FlatStyle = FlatStyle.Standard;
                                    name.Text = All[n].coin.name.ToString();
                                    name.Location = new System.Drawing.Point(i, y + ItemSizeY+13);



                                    //-------------------------------------------------------
                                    ItemsBox.Controls.Add(All[n]);
                                    ItemsBox.Controls.Add(label);
                                    ItemsBox.Controls.Add(name);
                                }
                                
                                }
                            }
                        }
                        n++;
                        if (isok) {
                            break;
                        }
                        
                    }
                    
                   
                }
              
                y = y + ItemSizeY + ItemsBoxShift+18; 

            }
            Counter.Text = "Количество Монет: " + test;
            CatList.Enabled = true;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            PicBox pic = (PicBox)sender;
            if (!isPrint)
            {
                Info frame = new Info();
                frame.Show();
                frame.Info_cat_txt.Text = pic.coin.catName;
                frame.Info_id.Text = "ID: " + pic.coin.id;
                frame.Info_jpg.Image = pic.coin.image;
                frame.Info_name_txt.Text = pic.coin.name;
                frame.Info_number_txt.Text = "" + pic.coin.number;
                frame.Info_date_txt.Text = "" + pic.coin.date.Day + "." + pic.coin.date.Month + "." + pic.coin.date.Year;
                if (pic.coin.CDRPath.Length>0)
                frame.Info_cdr_path_txt.Text = "" + pic.coin.CDRPath.Substring(0, (pic.coin.CDRPath.Length-pic.coin.number.ToString().Length));
                frame.SetFields();
                frame.picbox = pic;
                frame.Info_tags.Text = pic.coin.tag;
               
            }
            else
            {

                if (AddToPrintList(pic) == 1)
                {
                    pic.selected = true;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    RefreshToPrintBox();

                }
                else {

                    pic.selected = false;
                    pic.BorderStyle = BorderStyle.None;
                    for (int i = 0; i < toPrintList.Count;i++ )
                    {
                        if(pic.coin.Equals(toPrintList[i].coin)){
                            toPrintList.RemoveAt(i);
                            RefreshToPrintBox();
                            break;
                        }

                    }
                
                }
                
               
            
            }
        }
        public void toPrintBox_Click(object sender, EventArgs e)
        {
            PicBox pic = (PicBox)sender;
            toPrintList.Remove(pic);
            for (int i = 0; i < All.Count; i++) { 
                if(All[i].coin.Equals(pic.coin)){
                    All[i].selected = false;
                    All[i].BorderStyle = BorderStyle.None;
                    break;
                }
                
                
            }
                RefreshToPrintBox();
        
        }
        private void RefreshToPrintBox() {

            int x = ItemsBoxBorderLeft;
            int y = ItemsBoxBorderUp;
            int n = 0;
            toPrintBox.Controls.Clear();
            while (n < toPrintList.Count)
            {


                for (int i = x; i < toPrintBox.Width - ItemsBoxBorderRight - ItemSizeX; i += ItemsBoxShift + ItemSizeX)
                {



                    if (n < toPrintList.Count)
                    {
                        //coin coin;

                      //  coin = toPrintList[n].coin;
                            //PicBox pic = new PicBox(coin, ItemSizeX, ItemSizeY);// (PicBox)ItemsBox.Controls[n];

                            //ItemsBox.Controls[n].Location = new System.Drawing.Point(i, y);
                        toPrintList[n].Location = new System.Drawing.Point(i, y);
                       // toPrintList[n].Click += new System.EventHandler(toPrintBox_Click);
                        toPrintBox.Controls.Add(toPrintList[n]);
                       


                        n++;
                    }




                }

                y = y + ItemSizeY + ItemsBoxShift;
            }

        }
        private void ItemsBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
         //   pictureBox1.Location=new System.Drawing.Point(e.X, e.Y);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          //  SQL();
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
        public void refreshCoinIdtoName() {
            for (int i = 0; i < All.Count;i++ )
            {
                int id = All[i].coin.cat;
                for (int j = 0; j < idtoname.Count;j++ )
                {
                    if(id==idtoname[j].id){

                        All[i].coin.catName = idtoname[j].name;
                        break;
                    }
                }

            }

        
        
        }
        public void SaveJPG(){//\\\\MyServer\\MyShare
           // Uri uri = new Uri("http://109.123.181.232:8080/jpg/");
           // uri. = 3051;
           // ImageConverter converter = new ImageConverter();
            //Bitmap bm = new Bitmap(All[11].coin.image);
            
           // byte[] image = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            // WebClient wc = new WebClient();
            // String webAddress = @"http://109.123.181.232:8080/jpg/";
            
             // bm =  new Bitmap ("C:/indian.jpg");
            // String newPath = "C:\\";
           //  System.IO.Directory.CreateDirectory(newPath);
            // bm.Save(newPath + "qwer" + ".txt");
             //wc.UploadFileAsync(uri, "POST", "http://www.simpletutorials.ru/wp-content/uploads/2009/09/Google.jpg");//"C://indian.jpg");
            // uri = new Uri("ftp://coin:coin@109.123.181.232:3051/12312.jpg");
            // wc.UploadFile("ftp://coin:coin@109.123.181.232:3051/12312.jpg", "STOR", "C:/indian.jpg");
            //wc.UploadData(webAddress,"POST",  image);
           
            // wc.DownloadFile("http://109.123.181.232:3051/jpg/indian.jpg", @"c:\indian2.jpg");
           // System.IO.File.Copy("C:\\9.jpg", uri);
            //webAddress = @"http://myCompany/ShareDoc/";

            for (int i = 0; i < All.Count;i++ )
            {
                if(All[i].coin.image!=null){
                   // Bitmap bm =  new Bitmap (All[i].coin.image);
                    //String newPath = "C:\\jpg";
                    //System.IO.Directory.CreateDirectory(newPath);
                   //bm.Save(newPath +"\\"+ All[i].coin.id.ToString() + ".jpg");
                    //System.IO.File.Copy(fromPath, toPath);
                }
            }
        
        }
        public void refreshIdToName() {

            idtoname.Clear();
            
            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");

            try
            {
                while (reader.Read())
                {
                    idToName id = new idToName();
                    id.id = reader.GetInt32(0);
                    id.name = reader.GetString(1);
                    idtoname.Add(id);
                }
            }
            finally
            {
                sql.EndQuery();
            }
        
        }
        private String GetCatName(int cat)
        {

            SQL sql = new SQL();
            FbDataReader reader = sql.StartQuery("SELECT * FROM CAT");

            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == cat)
                    {
                        return reader.GetString(1);
                    }
                }
            }
            finally
            {
                sql.EndQuery();
            }

            return "";
        }
        private void CatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CatList.SelectedIndex>=0)
            {
            if (!CatList.GetItemChecked(CatList.SelectedIndex))
            {

                CatList.SetItemChecked(0, false);




            }
            if (CatList.GetItemChecked(0))
            {
                for (int i = 0; i < CatList.Items.Count;i++ )
                {
                    CatList.SetItemChecked(i, true);

                }
            
            
            }
            }
            RefreshItemsBox();
           

        }

        private void createDoc_Click(object sender, EventArgs e)
        {
            if (!isPrint)
            {
                createDoc.Text = "Просмотр";
                isPrint = true;
                addAll.Visible = true;
                PDFtoFile.Visible = true;
                ClearToPrintBox.Visible = true;
                Load_toPrint.Visible = true;
            }
            else {
                createDoc.Text = "Сформировать документ";
                isPrint = false;
                addAll.Visible = false;
                PDFtoFile.Visible = false;
                ClearToPrintBox.Visible = false;
                Load_toPrint.Visible = false;
            
            }
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemsBox.Controls.Count;i++ )
            { if ((ItemsBox.Controls[i]).GetType() == typeof(PicBox))
                        {
                            AddToPrintList((PicBox)ItemsBox.Controls[i]);
                            ((PicBox)ItemsBox.Controls[i]).BorderStyle = BorderStyle.Fixed3D;
                            ((PicBox)ItemsBox.Controls[i]).selected = true;
                }
                                                                                                                                                
            }
            RefreshToPrintBox();
            
            /*
            int x = ItemsBoxBorderLeft;
            int y = ItemsBoxBorderUp;           
            int n = 0;
            // ItemsBox.Controls[1].Location = new System.Drawing.Point(0, 0);
           // toPrintBox.Controls.Add(ItemsBox.Controls[n]);
           
         
            
            while (n < ItemsBox.Controls.Count)
            {
               
               
                for (int i = x; i < toPrintBox.Width - ItemsBoxBorderRight - ItemSizeX; i += ItemsBoxShift + ItemSizeX)
                {



                    if (n < ItemsBox.Controls.Count)
                    {   //PageSize.A4
                        coin coin;
                        if ((ItemsBox.Controls[n]).GetType() == typeof(PicBox))
                        {
                            coin = ((PicBox)ItemsBox.Controls[n]).coin;
                            PicBox pic = new PicBox(coin, ItemSizeX, ItemSizeY);// (PicBox)ItemsBox.Controls[n];

                            //ItemsBox.Controls[n].Location = new System.Drawing.Point(i, y);
                            pic.Location = new System.Drawing.Point(i, y);
                            pic.Click += new System.EventHandler(toPrintBox_Click);
                            if (AddToPrintList(pic) == 1)
                                toPrintBox.Controls.Add(pic);
                        }
                       
                        
                        n++;
                    }
                                            
                        
                    

                    }

                 y = y + ItemSizeY + ItemsBoxShift;
                }

         */
          
                      
        
        }
        public void createPDF(String filenpath) {
            if (toPrintList.Count > 0)
            {
                myDocument = new Document(PageSize.A4);
                int x = ItemsBoxBorderLeft;
                int y = (int)PageSize.A4.Height - ItemsBoxBorderUp - ItemSizeY;
                int n = 0;
                // ItemsBox.Controls[1].Location = new System.Drawing.Point(0, 0);
                // toPrintBox.Controls.Add(ItemsBox.Controls[n]);
                PdfWriter writer = PdfWriter.GetInstance(myDocument, new FileStream(filenpath, FileMode.Create));
                PdfWriterEvents writerEvent = new PdfWriterEvents("Монета");
                
                writer.PageEvent = writerEvent;
                myDocument.Open();
                System.Drawing.Image head = Coins.Properties.Resources.new_head;
                System.Drawing.Image bot = Coins.Properties.Resources.new_bottom;
                iTextSharp.text.Image head_pdf = iTextSharp.text.Image.GetInstance(head, new BaseColor(0, 0, 0));
                iTextSharp.text.Image bot_pdf = iTextSharp.text.Image.GetInstance(bot, new BaseColor(0, 0, 0));
                head_pdf.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                bot_pdf.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                head_pdf.SetAbsolutePosition(0, PageSize.A4.Height-head_pdf.PlainHeight);
                bot_pdf.SetAbsolutePosition(0, 0);
                myDocument.Add(head_pdf);
                myDocument.Add(bot_pdf);
                y -= (int)head_pdf.PlainHeight;
                //toPrintList[i]
                while (n < toPrintList.Count)
                {


                    for (int i = x; i < PageSize.A4.Width - ItemsBoxBorderRight - ItemSizeX; i += ItemsBoxShift + ItemSizeX)
                    {



                        if (n < toPrintList.Count)
                        {   //PageSize.A4



                            System.Drawing.Image img = toPrintList[n].coin.image;
                            if (img == null)
                            {
                                img = (System.Drawing.Image)(new Bitmap(@"C:\indian.jpg"));


                            }
                            //Paragraph pHeading = new Paragraph(new Chunk("" + toPrintList[n].coin.id, FontFactory.GetFont(FontFactory.HELVETICA, 13)));
                            // Chunk c1 = new Chunk("A chunk represents an isolated string. ");
                            PdfContentByte cb = writer.DirectContent;
                            PdfContentByte name_lbl = writer.DirectContent;
                            PdfContentByte name_lbl_2 = writer.DirectContent;
                            // we tell the ContentByte we're ready to draw text
                            cb.BeginText();


                            // we draw some text on a certain position
                            cb.SetTextMatrix(i + 140, y - 11);
                            cb.Rectangle(i + 140, y - 11, 100, 11); 
                            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);

                            cb.SetFontAndSize(baseFont, 10);
                          
                            /*
                            ColumnText ct = new ColumnText(cb);
                            ct.SetSimpleColumn(new Phrase(new Chunk("#" + toPrintList[n].coin.id, FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.NORMAL))),
                                               i, y, i+100, y-11, 25, Element.ALIGN_CENTER | Element.ALIGN_TOP);
                            ct.Go(); 
                            */
                            // cb.ShowText();
                            //cb.ShowText("#" + toPrintList[n].coin.id);
                            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "#" + toPrintList[n].coin.number, i + 50, y - 10, 0);
                            // we tell the contentByte, we've finished drawing text
                            cb.EndText();



                            name_lbl.BeginText();
                            
                            name_lbl.SetTextMatrix(i + 20, y - 22);
                             baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);

                             name_lbl.SetFontAndSize(baseFont, 10);
                            
                             name_lbl.ShowTextAligned(PdfContentByte.ALIGN_CENTER, toPrintList[n].coin.name, i + 50, y - 22,0);
                             
                            
                            cb.EndText();

                            

                           





                            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(img, new BaseColor(255, 255, 255));
                           
                            jpg.ScaleToFit(100, 100);
                            jpg.SetAbsolutePosition(i, y);
                            /*
                            using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                            {
                                
                                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance( System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                myDocument.Add(png);
                            }*/
                            // jpg.
                            myDocument.Add(jpg);

                            n++;
                        }




                    }

                    y = y - ItemSizeY - ItemsBoxShift-30;
                    if (y < ItemsBoxBorderDown + ItemSizeY + (int)head_pdf.PlainHeight)
                    {
                        y = (int)PageSize.A4.Height - ItemsBoxBorderUp - ItemSizeY;
                        y -= (int)head_pdf.PlainHeight;
                        using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                        {

                            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                            png.SetAbsolutePosition(0, (int)bot_pdf.PlainHeight);
                            myDocument.Add(png);
                        }
                        myDocument.NewPage();
                        myDocument.Add(head_pdf);
                        myDocument.Add(bot_pdf);
                    }
                }
                using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                {

                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    png.SetAbsolutePosition(0,  (int)bot_pdf.PlainHeight);
                    myDocument.Add(png);
                }
                myDocument.Close();

            }
            else {
                MessageBox.Show("Не выбраны монеты для создания документа");
            
            }
        
        }
        public void SortByDate() {
            int z=1;
            if (rateInc.Checked)
            {
                while (z > 0)
                {
                    z = 0;
                    for (int i = 1; i < All.Count; i++)
                    {
                        if (All[i - 1].coin.date.CompareTo(All[i].coin.date) >0)
                        {
                            PicBox p = All[i - 1];
                            All[i - 1] = All[i];
                            All[i] = p;
                            z++;
                        }
                    }
                }
            }
            else {
                while (z > 0)
                {
                    z = 0;
                    for (int i = 1; i < All.Count; i++)
                    {
                        if (All[i - 1].coin.date.CompareTo(All[i].coin.date) < 0)
                        {
                            PicBox p = All[i - 1];
                            All[i - 1] = All[i];
                            All[i] = p;
                            z++;
                        }
                    }
                }
            
            
            
            }
        }
        public int AddToPrintList(PicBox picbox) {
        
        for(int i=0;i<toPrintList.Count;i++){
            if (toPrintList[i].coin.cat == picbox.coin.cat && toPrintList[i].coin.image == picbox.coin.image && toPrintList[i].coin.number == picbox.coin.number)
            {
                
        return 0;
        
        }
        
        }

        coin coin =new coin();

        coin = picbox.coin;
        PicBox pic = new PicBox(coin, ItemSizeX, ItemSizeY);
        pic.Click += new System.EventHandler(toPrintBox_Click);
            toPrintList.Add(pic);
            return 1;
        }

        private void Sort_date_Click(object sender, EventArgs e)
        {
            sorttype = 0;
            Sort_date.ForeColor = Color.OrangeRed;
            Sort_name.ForeColor = Color.Black;
            SortByDate();
            RefreshItemsBox();
        }

        private void rateDec_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }
        public void sort() {


            switch (sorttype)
            {
                case 0:
                    SortByDate();
                    break;
                case 1:
                    SortByName();
                    break;
                /* case 2:
                     cost += 50;
                     goto case 1;*/
                default:
                   
                    goto case 1;
            }
            RefreshItemsBox();
        
        
        }

        private void rateInc_CheckedChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void Sort_name_Click(object sender, EventArgs e)
        {
            sorttype = 1;
            Sort_name.ForeColor = Color.OrangeRed;
            Sort_date.ForeColor = Color.Black;
            SortByName();
            RefreshItemsBox();
        }
        private void SortByName()
        {
            if (rateInc.Checked)
            {
                All.Sort((a, b) => a.coin.name.CompareTo(b.coin.name));
            }
            else {

                All.Sort((a, b) => b.coin.name.CompareTo(a.coin.name));
            
            
            }
        }

        private void PDFtoFile_Click(object sender, EventArgs e)
        {savePDF.FileName = "Монеты.pdf";
        String filename="";
        savePDF.Filter = "PDF|*.pdf";
           if (savePDF.ShowDialog() == DialogResult.OK)
           {
               filename = savePDF.FileName;
               
               string strFilExtn = filename.Remove(0, filename.Length - 3); 
               switch (strFilExtn) 
               {
                   case "pdf":
                       filename = savePDF.FileName;
                       break;
               
                   default:
                       filename = Application.StartupPath + @"\Монеты.pdf";
                       break;
               }
               if (!backgroundWorker1.IsBusy)
               {
                   
                   toolStripStatusLabel1.Text = "Создание PDF";
                   backgroundWorker1.RunWorkerAsync(filename);
                   //createPDF(filename);
               }
               else {

                   MessageBox.Show("Процесс создания PDF уже запущен");
               
               
               }
           }       
        
           
        }
        public void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            String filenpath = e.Argument.ToString() ;
            if (toPrintList.Count > 0)
            {
                myDocument = new Document(PageSize.A4);
                int x = ItemsBoxBorderLeft;
                int y = (int)PageSize.A4.Height - ItemsBoxBorderUp - ItemSizeY;
                int n = 0;
                // ItemsBox.Controls[1].Location = new System.Drawing.Point(0, 0);
                // toPrintBox.Controls.Add(ItemsBox.Controls[n]);
                PdfWriter writer = PdfWriter.GetInstance(myDocument, new FileStream(filenpath, FileMode.Create));
                PdfWriterEvents writerEvent = new PdfWriterEvents("Монета");

                writer.PageEvent = writerEvent;
                myDocument.Open();
                System.Drawing.Image head = Coins.Properties.Resources.new_head;
                System.Drawing.Image bot = Coins.Properties.Resources.new_bottom;
                iTextSharp.text.Image head_pdf = iTextSharp.text.Image.GetInstance(head, new BaseColor(0, 0, 0));
                iTextSharp.text.Image bot_pdf = iTextSharp.text.Image.GetInstance(bot, new BaseColor(0, 0, 0));
                head_pdf.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                bot_pdf.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                head_pdf.SetAbsolutePosition(0, PageSize.A4.Height - head_pdf.PlainHeight);
                bot_pdf.SetAbsolutePosition(0, 0);
                myDocument.Add(head_pdf);
                myDocument.Add(bot_pdf);
                y -= (int)head_pdf.PlainHeight;
                //toPrintList[i]
                while (n < toPrintList.Count)
                {
                   

                    for (int i = x; i < PageSize.A4.Width - ItemsBoxBorderRight - ItemSizeX; i += ItemsBoxShift + ItemSizeX)
                    {



                        if (n < toPrintList.Count)
                        {   //PageSize.A4
                            backgroundWorker1.ReportProgress(n);


                            System.Drawing.Image img = toPrintList[n].coin.image;
                            if (img == null)
                            {
                                img = (System.Drawing.Image)(new Bitmap(@"C:\indian.jpg"));


                            }
                            //Paragraph pHeading = new Paragraph(new Chunk("" + toPrintList[n].coin.id, FontFactory.GetFont(FontFactory.HELVETICA, 13)));
                            // Chunk c1 = new Chunk("A chunk represents an isolated string. ");
                            PdfContentByte cb = writer.DirectContent;
                            PdfContentByte name_lbl = writer.DirectContent;
                            PdfContentByte name_lbl_2 = writer.DirectContent;
                            // we tell the ContentByte we're ready to draw text
                            cb.BeginText();


                            // we draw some text on a certain position
                            cb.SetTextMatrix(i + 140, y - 11);
                            cb.Rectangle(i + 140, y - 11, 100, 11);
                            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);

                            cb.SetFontAndSize(baseFont, 10);

                            /*
                            ColumnText ct = new ColumnText(cb);
                            ct.SetSimpleColumn(new Phrase(new Chunk("#" + toPrintList[n].coin.id, FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.NORMAL))),
                                               i, y, i+100, y-11, 25, Element.ALIGN_CENTER | Element.ALIGN_TOP);
                            ct.Go(); 
                            */
                            // cb.ShowText();
                            //cb.ShowText("#" + toPrintList[n].coin.id);
                            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "#" + toPrintList[n].coin.number, i + 50, y - 10, 0);
                            // we tell the contentByte, we've finished drawing text
                            cb.EndText();



                            name_lbl.BeginText();

                            name_lbl.SetTextMatrix(i + 20, y - 22);
                            baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.EMBEDDED);

                            name_lbl.SetFontAndSize(baseFont, 10);

                            name_lbl.ShowTextAligned(PdfContentByte.ALIGN_CENTER, toPrintList[n].coin.name, i + 50, y - 22, 0);


                            cb.EndText();









                            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(img, new BaseColor(255, 255, 255));

                            jpg.ScaleToFit(100, 100);
                            jpg.SetAbsolutePosition(i, y);
                            /*
                            using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                            {
                                
                                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance( System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                myDocument.Add(png);
                            }*/
                            // jpg.
                            myDocument.Add(jpg);

                            n++;
                        }




                    }
                    if (n < toPrintList.Count)
                    y = y - ItemSizeY - ItemsBoxShift - 30;
                    if (y < ItemsBoxBorderDown + ItemSizeY + (int)head_pdf.PlainHeight)
                    {
                        y = (int)PageSize.A4.Height - ItemsBoxBorderUp - ItemSizeY;
                        y -= (int)head_pdf.PlainHeight;
                        using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                        {

                            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                            png.SetAbsolutePosition(0, (int)bot_pdf.PlainHeight);
                            myDocument.Add(png);
                        }
                        myDocument.NewPage();
                        myDocument.Add(head_pdf);
                        myDocument.Add(bot_pdf);
                    }
                }
                using (FileStream fs = new FileStream(Application.StartupPath + "/WaterMark.png", FileMode.Open))
                {

                    iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    png.SetAbsolutePosition(0, (int)bot_pdf.PlainHeight);
                    myDocument.Add(png);
                }
                myDocument.Close();

            }
            else
            {
                MessageBox.Show("Не выбраны монеты для создания документа");

            }
        }

        public void bw_RunWorkerCompleted(object sender,
                                           RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Создание PDF успешно завершено!";
        }

        public void bw_ProgressChanged(object sender,
                                        ProgressChangedEventArgs e)
        {
          
            toolStripProgressBar1.Value = (int)((e.ProgressPercentage+1) * 100 / toPrintList.Count);
            
        }
        private void ClearToPrintBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < All.Count;i++ )
            {
                All[i].selected = false;
                All[i].BorderStyle = BorderStyle.None;

            }

            toPrintList.Clear();
            RefreshToPrintBox();
        }
        public void SetPerm() {


            User_name.Text = "Имя: "+Program.user.Name;
            User_lastname.Text = "Фамилия: " + Program.user.scndName;
            User_title.Text = "Должность: " + Program.user.title;
            if (Program.Perm_CreatePDF)
            {
                createDoc.Visible = true;
            }
            else {
                createDoc.Visible = false;

            
            }
            if (Program.Perm_Ad)
            {
                ButtonAdd.Visible = true;

            }
            else
            {
                ButtonAdd.Visible = false;

            }
            if (Program.Perm_Download)
            {
                DownLoad.Visible = true;

            }
            else
            {
                DownLoad.Visible = false;

            }
            if (Program.user.admin)
            {
                управлениеToolStripMenuItem.Visible = true;

            }
            else {

                управлениеToolStripMenuItem.Visible = false;
            
            }
        
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Counter_Click(object sender, EventArgs e)
        {

        }

        private void DownLoad_Click(object sender, EventArgs e)
        {   
             if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowser.SelectedPath;
            if (!backgroundWorker2.IsBusy)
            {

                toolStripStatusLabel1.Text = "Загрузка Базы";
                backgroundWorker2.RunWorkerAsync(path);
                //createPDF(filename);
            }
            else
            {

                MessageBox.Show("Процесс загрузки базы уже запущен");


            }
             }
            /*
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowser.SelectedPath;
                try
                {
                    String Data = path + "//" + "База";
                    String jpg_data = Data + "//" + "jpg";
                    String cdr_data = Data + "//" + "cdr";
                    System.IO.Directory.CreateDirectory(Data);
                    System.IO.Directory.CreateDirectory(jpg_data);
                    System.IO.Directory.CreateDirectory(cdr_data);


                     for (int i = 0; i < All.Count;i++ )
                    {
                        if (All[i].coin.JPGPath != "")
                        {
                            WebClient wc = new WebClient();
                            String jpgName = All[i].coin.JPGPath;
                            String name = jpgName.Substring(0, jpgName.Length - All[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.JPGserver + jpgName, jpg_data + "\\" + All[i].coin.number + ext);



                        }
                        if (All[i].coin.CDRPath != "")
                        {
                            WebClient wc = new WebClient();
                            String cdrName = All[i].coin.CDRPath;
                            String name = cdrName.Substring(0, cdrName.Length - All[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.CDRserver + cdrName, cdr_data + "\\" + All[i].coin.number + ext);



                        }



                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                }
             
            }*/
        }
        //----------------------------------------------------

        public void bw_DoWork_load(object sender, DoWorkEventArgs e)
        {
           String path =e.Argument.ToString();
                try
                {
                    String Data = path + "//" + "База";
                    String jpg_data = Data + "//" + "jpg";
                    String cdr_data = Data + "//" + "cdr";
                    System.IO.Directory.CreateDirectory(Data);
                    System.IO.Directory.CreateDirectory(jpg_data);
                    System.IO.Directory.CreateDirectory(cdr_data);


                    for (int i = 0; i < All.Count; i++)
                    {
                        backgroundWorker2.ReportProgress(i);
                        if (All[i].coin.JPGPath != "")
                        {
                            WebClient wc = new WebClient();
                            String jpgName = All[i].coin.JPGPath;
                            String name = jpgName.Substring(0, jpgName.Length - All[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.JPGserver + jpgName, jpg_data + "\\" + All[i].coin.number + ext);



                        }
                        if (All[i].coin.CDRPath != "")
                        {
                            WebClient wc = new WebClient();
                            String cdrName = All[i].coin.CDRPath;
                            String name = cdrName.Substring(0, cdrName.Length - All[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.CDRserver + cdrName, cdr_data + "\\" + All[i].coin.number + ext);



                        }



                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            
        }

        public void bw_RunWorkerCompleted_load(object sender,
                                           RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Загрузка базы успешно завершена!";
        }

        public void bw_ProgressChanged_load(object sender,
                                        ProgressChangedEventArgs e)
        {

            toolStripProgressBar1.Value = (int)((e.ProgressPercentage + 1) * 100 / All.Count);

        }
        //----------------------------------------------------











        public void bw_DoWork_load_toprint(object sender, DoWorkEventArgs e)
        {
            String path = e.Argument.ToString();
            try
                {
                    String Data = path + "//" + "База";
                    String jpg_data = Data + "//" + "jpg";
                    String cdr_data = Data + "//" + "cdr";
                    System.IO.Directory.CreateDirectory(Data);
                    System.IO.Directory.CreateDirectory(jpg_data);
                    System.IO.Directory.CreateDirectory(cdr_data);



                    for (int i = 0; i < toPrintList.Count;i++ )
                    {
                        backgroundWorker3.ReportProgress(i);
                        if (toPrintList[i].coin.JPGPath != "")
                        {
                            WebClient wc = new WebClient();
                            String jpgName = toPrintList[i].coin.JPGPath;
                            String name = jpgName.Substring(0, jpgName.Length - toPrintList[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.JPGserver + jpgName, jpg_data + "\\" + toPrintList[i].coin.number + ext);



                        }
                        if (toPrintList[i].coin.CDRPath != "")
                        {
                            WebClient wc = new WebClient();
                            String cdrName = toPrintList[i].coin.CDRPath;
                            String name = cdrName.Substring(0, cdrName.Length - toPrintList[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.CDRserver + cdrName, cdr_data + "\\" + toPrintList[i].coin.number + ext);



                        }



                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }



          

        }

        public void bw_RunWorkerCompleted_load_toprint(object sender,
                                           RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Загрузка базы успешно завершена!";
        }

        public void bw_ProgressChanged_load_toprint(object sender,
                                        ProgressChangedEventArgs e)
        {

            toolStripProgressBar1.Value = (int)((e.ProgressPercentage + 1) * 100 / toPrintList.Count);

        }














        private void button1_Click(object sender, EventArgs e)
        {
            RefreshItemsBox();
        }

        private void Load_toPrint_Click(object sender, EventArgs e)
        {


            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowser.SelectedPath;
                if (!backgroundWorker3.IsBusy)
                {

                    toolStripStatusLabel1.Text = "Загрузка Базы";
                    backgroundWorker3.RunWorkerAsync(path);
                    //createPDF(filename);
                }
                else
                {

                    MessageBox.Show("Процесс загрузки базы уже запущен");


                }
                
                /*
                String path = folderBrowser.SelectedPath;
                try
                {
                    String Data = path + "//" + "База";
                    String jpg_data = Data + "//" + "jpg";
                    String cdr_data = Data + "//" + "cdr";
                    System.IO.Directory.CreateDirectory(Data);
                    System.IO.Directory.CreateDirectory(jpg_data);
                    System.IO.Directory.CreateDirectory(cdr_data);



                    for (int i = 0; i < toPrintList.Count;i++ )
                    {
                        if (toPrintList[i].coin.JPGPath != "")
                        {
                            WebClient wc = new WebClient();
                            String jpgName = toPrintList[i].coin.JPGPath;
                            String name = jpgName.Substring(0, jpgName.Length - toPrintList[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.JPGserver + jpgName, jpg_data + "\\" + toPrintList[i].coin.number + ext);



                        }
                        if (toPrintList[i].coin.CDRPath != "")
                        {
                            WebClient wc = new WebClient();
                            String cdrName = toPrintList[i].coin.CDRPath;
                            String name = cdrName.Substring(0, cdrName.Length - toPrintList[i].coin.sec.ToString().Length);
                            int indx = name.IndexOf('.');
                            String ext = name.Substring(indx, name.Length - indx);
                            wc.DownloadFile(Program.CDRserver + cdrName, cdr_data + "\\" + toPrintList[i].coin.number + ext);



                        }



                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }*/
            }
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager form = new Manager();
            form.Show();
        }

        private void CatList_Click(object sender, EventArgs e)
        {
           
        }

        private void CatList_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void CatList_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {

            }
            else
            {
                RefreshItemsBox();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void ItemsBox_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void ItemsBox_MouseHover(object sender, EventArgs e)
        {if(this.ContainsFocus)
            ItemsBox.Focus();
            
        }

        private void toPrintBox_MouseHover(object sender, EventArgs e)
        {
            if (this.ContainsFocus)
            toPrintBox.Focus();
        }

        private void toPrintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ContainsFocus)
            toPrintBox.Focus();
        }

        private void ItemsBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ContainsFocus)
            ItemsBox.Focus();
        }
        

    }
}
