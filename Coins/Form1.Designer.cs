namespace Coins
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.User_name = new System.Windows.Forms.Label();
            this.User_lastname = new System.Windows.Forms.Label();
            this.User_title = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsBox = new System.Windows.Forms.Panel();
            this.CatList = new System.Windows.Forms.CheckedListBox();
            this.toPrintBox = new System.Windows.Forms.Panel();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.createDoc = new System.Windows.Forms.Button();
            this.addAll = new System.Windows.Forms.Button();
            this.Sort_date = new System.Windows.Forms.Label();
            this.Sort_name = new System.Windows.Forms.Label();
            this.rateInc = new System.Windows.Forms.RadioButton();
            this.rateDec = new System.Windows.Forms.RadioButton();
            this.PDFtoFile = new System.Windows.Forms.Button();
            this.savePDF = new System.Windows.Forms.SaveFileDialog();
            this.ClearToPrintBox = new System.Windows.Forms.Button();
            this.DownLoad = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Load_toPrint = new System.Windows.Forms.Button();
            this.ToPrint_lbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.Location = new System.Drawing.Point(3, 47);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(32, 13);
            this.User_name.TabIndex = 0;
            this.User_name.Text = "Имя:";
            // 
            // User_lastname
            // 
            this.User_lastname.AutoSize = true;
            this.User_lastname.Location = new System.Drawing.Point(3, 60);
            this.User_lastname.Name = "User_lastname";
            this.User_lastname.Size = new System.Drawing.Size(59, 13);
            this.User_lastname.TabIndex = 1;
            this.User_lastname.Text = "Фамилия:";
            // 
            // User_title
            // 
            this.User_title.AutoSize = true;
            this.User_title.Location = new System.Drawing.Point(3, 73);
            this.User_title.Name = "User_title";
            this.User_title.Size = new System.Drawing.Size(68, 13);
            this.User_title.TabIndex = 2;
            this.User_title.Text = "Должность:";
            this.User_title.Click += new System.EventHandler(this.label3_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(249, 32);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(353, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(168, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.Exit});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ItemsBox
            // 
            this.ItemsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsBox.AutoScroll = true;
            this.ItemsBox.BackColor = System.Drawing.Color.White;
            this.ItemsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsBox.Location = new System.Drawing.Point(129, 105);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(486, 334);
            this.ItemsBox.TabIndex = 6;
            this.ItemsBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ItemsBox_Scroll);
            this.ItemsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemsBox_Paint);
            this.ItemsBox.MouseHover += new System.EventHandler(this.ItemsBox_MouseHover);
            this.ItemsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemsBox_MouseMove);
            // 
            // CatList
            // 
            this.CatList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.CatList.CheckOnClick = true;
            this.CatList.FormattingEnabled = true;
            this.CatList.Location = new System.Drawing.Point(0, 105);
            this.CatList.Name = "CatList";
            this.CatList.Size = new System.Drawing.Size(123, 334);
            this.CatList.TabIndex = 13;
            this.CatList.Click += new System.EventHandler(this.CatList_Click);
            this.CatList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CatList_MouseClick);
            this.CatList.SelectedIndexChanged += new System.EventHandler(this.CatList_SelectedIndexChanged);
            this.CatList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CatList_KeyPress);
            // 
            // toPrintBox
            // 
            this.toPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toPrintBox.AutoScroll = true;
            this.toPrintBox.BackColor = System.Drawing.Color.White;
            this.toPrintBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toPrintBox.Location = new System.Drawing.Point(621, 105);
            this.toPrintBox.Name = "toPrintBox";
            this.toPrintBox.Size = new System.Drawing.Size(351, 334);
            this.toPrintBox.TabIndex = 8;
            this.toPrintBox.MouseHover += new System.EventHandler(this.toPrintBox_MouseHover);
            this.toPrintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toPrintBox_MouseMove);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(614, 32);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(3, 86);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(113, 13);
            this.Counter.TabIndex = 11;
            this.Counter.Text = "Количество Монет: 0";
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // createDoc
            // 
            this.createDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createDoc.Location = new System.Drawing.Point(470, 58);
            this.createDoc.Name = "createDoc";
            this.createDoc.Size = new System.Drawing.Size(145, 23);
            this.createDoc.TabIndex = 8;
            this.createDoc.Text = "Сформировать документ";
            this.createDoc.UseVisualStyleBackColor = true;
            this.createDoc.Click += new System.EventHandler(this.createDoc_Click);
            // 
            // addAll
            // 
            this.addAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAll.Location = new System.Drawing.Point(362, 58);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(103, 23);
            this.addAll.TabIndex = 7;
            this.addAll.Text = "Добавить все";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Visible = false;
            this.addAll.Click += new System.EventHandler(this.addAll_Click);
            // 
            // Sort_date
            // 
            this.Sort_date.AutoSize = true;
            this.Sort_date.Location = new System.Drawing.Point(168, 66);
            this.Sort_date.Name = "Sort_date";
            this.Sort_date.Size = new System.Drawing.Size(33, 13);
            this.Sort_date.TabIndex = 14;
            this.Sort_date.Text = "Дате";
            this.Sort_date.Click += new System.EventHandler(this.Sort_date_Click);
            // 
            // Sort_name
            // 
            this.Sort_name.AutoSize = true;
            this.Sort_name.Location = new System.Drawing.Point(207, 66);
            this.Sort_name.Name = "Sort_name";
            this.Sort_name.Size = new System.Drawing.Size(41, 13);
            this.Sort_name.TabIndex = 15;
            this.Sort_name.Text = "Имени";
            this.Sort_name.Click += new System.EventHandler(this.Sort_name_Click);
            // 
            // rateInc
            // 
            this.rateInc.AutoSize = true;
            this.rateInc.Location = new System.Drawing.Point(171, 82);
            this.rateInc.Name = "rateInc";
            this.rateInc.Size = new System.Drawing.Size(109, 17);
            this.rateInc.TabIndex = 5;
            this.rateInc.Text = "По возрастанию";
            this.rateInc.UseVisualStyleBackColor = true;
            this.rateInc.CheckedChanged += new System.EventHandler(this.rateInc_CheckedChanged);
            // 
            // rateDec
            // 
            this.rateDec.AutoSize = true;
            this.rateDec.Checked = true;
            this.rateDec.Location = new System.Drawing.Point(298, 81);
            this.rateDec.Name = "rateDec";
            this.rateDec.Size = new System.Drawing.Size(93, 17);
            this.rateDec.TabIndex = 6;
            this.rateDec.TabStop = true;
            this.rateDec.Text = "По убыванию";
            this.rateDec.UseVisualStyleBackColor = true;
            this.rateDec.CheckedChanged += new System.EventHandler(this.rateDec_CheckedChanged);
            // 
            // PDFtoFile
            // 
            this.PDFtoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFtoFile.Location = new System.Drawing.Point(621, 58);
            this.PDFtoFile.Name = "PDFtoFile";
            this.PDFtoFile.Size = new System.Drawing.Size(86, 23);
            this.PDFtoFile.TabIndex = 9;
            this.PDFtoFile.Text = "Создать  PDF";
            this.PDFtoFile.UseVisualStyleBackColor = true;
            this.PDFtoFile.Visible = false;
            this.PDFtoFile.Click += new System.EventHandler(this.PDFtoFile_Click);
            // 
            // ClearToPrintBox
            // 
            this.ClearToPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearToPrintBox.Location = new System.Drawing.Point(713, 58);
            this.ClearToPrintBox.Name = "ClearToPrintBox";
            this.ClearToPrintBox.Size = new System.Drawing.Size(106, 23);
            this.ClearToPrintBox.TabIndex = 10;
            this.ClearToPrintBox.Text = "Очистить корзину";
            this.ClearToPrintBox.UseVisualStyleBackColor = true;
            this.ClearToPrintBox.Visible = false;
            this.ClearToPrintBox.Click += new System.EventHandler(this.ClearToPrintBox_Click);
            // 
            // DownLoad
            // 
            this.DownLoad.Location = new System.Drawing.Point(695, 32);
            this.DownLoad.Name = "DownLoad";
            this.DownLoad.Size = new System.Drawing.Size(156, 23);
            this.DownLoad.TabIndex = 4;
            this.DownLoad.Text = "Загрузить базу";
            this.DownLoad.UseVisualStyleBackColor = true;
            this.DownLoad.Visible = false;
            this.DownLoad.Click += new System.EventHandler(this.DownLoad_Click);
            // 
            // Load_toPrint
            // 
            this.Load_toPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_toPrint.Location = new System.Drawing.Point(825, 58);
            this.Load_toPrint.Name = "Load_toPrint";
            this.Load_toPrint.Size = new System.Drawing.Size(120, 23);
            this.Load_toPrint.TabIndex = 12;
            this.Load_toPrint.Text = "Загрузить Корзину";
            this.Load_toPrint.UseVisualStyleBackColor = true;
            this.Load_toPrint.Visible = false;
            this.Load_toPrint.Click += new System.EventHandler(this.Load_toPrint_Click);
            // 
            // ToPrint_lbl
            // 
            this.ToPrint_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToPrint_lbl.AutoSize = true;
            this.ToPrint_lbl.Location = new System.Drawing.Point(618, 89);
            this.ToPrint_lbl.Name = "ToPrint_lbl";
            this.ToPrint_lbl.Size = new System.Drawing.Size(53, 13);
            this.ToPrint_lbl.TabIndex = 22;
            this.ToPrint_lbl.Text = "Корзина:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToPrint_lbl);
            this.Controls.Add(this.Load_toPrint);
            this.Controls.Add(this.DownLoad);
            this.Controls.Add(this.ClearToPrintBox);
            this.Controls.Add(this.PDFtoFile);
            this.Controls.Add(this.rateDec);
            this.Controls.Add(this.rateInc);
            this.Controls.Add(this.Sort_name);
            this.Controls.Add(this.Sort_date);
            this.Controls.Add(this.addAll);
            this.Controls.Add(this.createDoc);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.toPrintBox);
            this.Controls.Add(this.CatList);
            this.Controls.Add(this.ItemsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.User_title);
            this.Controls.Add(this.User_lastname);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 501);
            this.Name = "Form1";
            this.Text = "Монета";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Label User_lastname;
        private System.Windows.Forms.Label User_title;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        public System.Windows.Forms.Panel ItemsBox;
        private System.Windows.Forms.CheckedListBox CatList;
        private System.Windows.Forms.Panel toPrintBox;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button createDoc;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.Label Sort_date;
        private System.Windows.Forms.Label Sort_name;
        private System.Windows.Forms.RadioButton rateInc;
        private System.Windows.Forms.RadioButton rateDec;
        private System.Windows.Forms.Button PDFtoFile;
        private System.Windows.Forms.SaveFileDialog savePDF;
        private System.Windows.Forms.Button ClearToPrintBox;
        private System.Windows.Forms.Button DownLoad;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button Load_toPrint;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.Label ToPrint_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

