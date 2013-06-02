namespace Coins
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.Info_name = new System.Windows.Forms.Label();
            this.Info_number = new System.Windows.Forms.Label();
            this.Info_cat = new System.Windows.Forms.Label();
            this.Info_id = new System.Windows.Forms.Label();
            this.Info_jpg = new System.Windows.Forms.PictureBox();
            this.Info_Image_jpg = new System.Windows.Forms.Label();
            this.Info_name_txt = new System.Windows.Forms.TextBox();
            this.Info_number_txt = new System.Windows.Forms.TextBox();
            this.Info_cat_txt = new System.Windows.Forms.ComboBox();
            this.Info_date_lable = new System.Windows.Forms.Label();
            this.Info_date_txt = new System.Windows.Forms.TextBox();
            this.Info_change = new System.Windows.Forms.Button();
            this.Info_cdr_path_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Info_load_cdr = new System.Windows.Forms.Button();
            this.Info_load_jpg = new System.Windows.Forms.Button();
            this.openCDR = new System.Windows.Forms.OpenFileDialog();
            this.openJPG = new System.Windows.Forms.OpenFileDialog();
            this.Info_tags = new System.Windows.Forms.TextBox();
            this.Info_loadCoin = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Info_jpg)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_name
            // 
            this.Info_name.AutoSize = true;
            this.Info_name.Location = new System.Drawing.Point(13, 16);
            this.Info_name.Name = "Info_name";
            this.Info_name.Size = new System.Drawing.Size(60, 13);
            this.Info_name.TabIndex = 0;
            this.Info_name.Text = "Название:";
            // 
            // Info_number
            // 
            this.Info_number.AutoSize = true;
            this.Info_number.Location = new System.Drawing.Point(13, 43);
            this.Info_number.Name = "Info_number";
            this.Info_number.Size = new System.Drawing.Size(44, 13);
            this.Info_number.TabIndex = 1;
            this.Info_number.Text = "Номер:";
            // 
            // Info_cat
            // 
            this.Info_cat.AutoSize = true;
            this.Info_cat.Location = new System.Drawing.Point(13, 70);
            this.Info_cat.Name = "Info_cat";
            this.Info_cat.Size = new System.Drawing.Size(63, 13);
            this.Info_cat.TabIndex = 2;
            this.Info_cat.Text = "Категория:";
            // 
            // Info_id
            // 
            this.Info_id.AutoSize = true;
            this.Info_id.Location = new System.Drawing.Point(13, 128);
            this.Info_id.Name = "Info_id";
            this.Info_id.Size = new System.Drawing.Size(21, 13);
            this.Info_id.TabIndex = 3;
            this.Info_id.Text = "ID:";
            // 
            // Info_jpg
            // 
            this.Info_jpg.Location = new System.Drawing.Point(264, 147);
            this.Info_jpg.Name = "Info_jpg";
            this.Info_jpg.Size = new System.Drawing.Size(200, 200);
            this.Info_jpg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Info_jpg.TabIndex = 4;
            this.Info_jpg.TabStop = false;
            // 
            // Info_Image_jpg
            // 
            this.Info_Image_jpg.AutoSize = true;
            this.Info_Image_jpg.Location = new System.Drawing.Point(261, 128);
            this.Info_Image_jpg.Name = "Info_Image_jpg";
            this.Info_Image_jpg.Size = new System.Drawing.Size(80, 13);
            this.Info_Image_jpg.TabIndex = 5;
            this.Info_Image_jpg.Text = "Изоброжение:";
            // 
            // Info_name_txt
            // 
            this.Info_name_txt.Location = new System.Drawing.Point(80, 13);
            this.Info_name_txt.Name = "Info_name_txt";
            this.Info_name_txt.Size = new System.Drawing.Size(85, 20);
            this.Info_name_txt.TabIndex = 6;
            // 
            // Info_number_txt
            // 
            this.Info_number_txt.Location = new System.Drawing.Point(80, 40);
            this.Info_number_txt.Name = "Info_number_txt";
            this.Info_number_txt.Size = new System.Drawing.Size(85, 20);
            this.Info_number_txt.TabIndex = 7;
            this.Info_number_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Info_number_txt_KeyPress);
            // 
            // Info_cat_txt
            // 
            this.Info_cat_txt.FormattingEnabled = true;
            this.Info_cat_txt.Location = new System.Drawing.Point(80, 67);
            this.Info_cat_txt.Name = "Info_cat_txt";
            this.Info_cat_txt.Size = new System.Drawing.Size(85, 21);
            this.Info_cat_txt.TabIndex = 8;
            this.Info_cat_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Info_cat_txt_KeyPress);
            // 
            // Info_date_lable
            // 
            this.Info_date_lable.AutoSize = true;
            this.Info_date_lable.Location = new System.Drawing.Point(13, 97);
            this.Info_date_lable.Name = "Info_date_lable";
            this.Info_date_lable.Size = new System.Drawing.Size(33, 13);
            this.Info_date_lable.TabIndex = 9;
            this.Info_date_lable.Text = "Дата";
            // 
            // Info_date_txt
            // 
            this.Info_date_txt.Location = new System.Drawing.Point(80, 94);
            this.Info_date_txt.Name = "Info_date_txt";
            this.Info_date_txt.Size = new System.Drawing.Size(85, 20);
            this.Info_date_txt.TabIndex = 10;
            // 
            // Info_change
            // 
            this.Info_change.Location = new System.Drawing.Point(13, 324);
            this.Info_change.Name = "Info_change";
            this.Info_change.Size = new System.Drawing.Size(75, 23);
            this.Info_change.TabIndex = 11;
            this.Info_change.Text = "Изменить";
            this.Info_change.UseVisualStyleBackColor = true;
            this.Info_change.Click += new System.EventHandler(this.Info_change_Click);
            // 
            // Info_cdr_path_txt
            // 
            this.Info_cdr_path_txt.Enabled = false;
            this.Info_cdr_path_txt.Location = new System.Drawing.Point(186, 40);
            this.Info_cdr_path_txt.Name = "Info_cdr_path_txt";
            this.Info_cdr_path_txt.Size = new System.Drawing.Size(278, 20);
            this.Info_cdr_path_txt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "cdr файл:";
            // 
            // Info_load_cdr
            // 
            this.Info_load_cdr.Location = new System.Drawing.Point(186, 67);
            this.Info_load_cdr.Name = "Info_load_cdr";
            this.Info_load_cdr.Size = new System.Drawing.Size(111, 23);
            this.Info_load_cdr.TabIndex = 14;
            this.Info_load_cdr.Text = "Выбрать cdr";
            this.Info_load_cdr.UseVisualStyleBackColor = true;
            this.Info_load_cdr.Click += new System.EventHandler(this.Info_load_cdr_Click);
            // 
            // Info_load_jpg
            // 
            this.Info_load_jpg.Location = new System.Drawing.Point(186, 102);
            this.Info_load_jpg.Name = "Info_load_jpg";
            this.Info_load_jpg.Size = new System.Drawing.Size(148, 23);
            this.Info_load_jpg.TabIndex = 15;
            this.Info_load_jpg.Text = "Загрузить изоброжение";
            this.Info_load_jpg.UseVisualStyleBackColor = true;
            this.Info_load_jpg.Click += new System.EventHandler(this.Info_load_jpg_Click);
            // 
            // openCDR
            // 
            this.openCDR.FileName = "openFileDialog1";
            // 
            // openJPG
            // 
            this.openJPG.FileName = "openFileDialog2";
            // 
            // Info_tags
            // 
            this.Info_tags.Location = new System.Drawing.Point(16, 180);
            this.Info_tags.Multiline = true;
            this.Info_tags.Name = "Info_tags";
            this.Info_tags.Size = new System.Drawing.Size(221, 138);
            this.Info_tags.TabIndex = 16;
            // 
            // Info_loadCoin
            // 
            this.Info_loadCoin.Location = new System.Drawing.Point(94, 324);
            this.Info_loadCoin.Name = "Info_loadCoin";
            this.Info_loadCoin.Size = new System.Drawing.Size(75, 23);
            this.Info_loadCoin.TabIndex = 17;
            this.Info_loadCoin.Text = "Загрузить";
            this.Info_loadCoin.UseVisualStyleBackColor = true;
            this.Info_loadCoin.Click += new System.EventHandler(this.Info_loadCoin_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 357);
            this.Controls.Add(this.Info_loadCoin);
            this.Controls.Add(this.Info_tags);
            this.Controls.Add(this.Info_load_jpg);
            this.Controls.Add(this.Info_load_cdr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info_cdr_path_txt);
            this.Controls.Add(this.Info_change);
            this.Controls.Add(this.Info_date_txt);
            this.Controls.Add(this.Info_date_lable);
            this.Controls.Add(this.Info_cat_txt);
            this.Controls.Add(this.Info_number_txt);
            this.Controls.Add(this.Info_name_txt);
            this.Controls.Add(this.Info_Image_jpg);
            this.Controls.Add(this.Info_jpg);
            this.Controls.Add(this.Info_id);
            this.Controls.Add(this.Info_cat);
            this.Controls.Add(this.Info_number);
            this.Controls.Add(this.Info_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(492, 395);
            this.MinimumSize = new System.Drawing.Size(492, 395);
            this.Name = "Info";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Info_jpg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Info_name;
        public System.Windows.Forms.Label Info_number;
        public System.Windows.Forms.Label Info_cat;
        public System.Windows.Forms.Label Info_id;
        public System.Windows.Forms.PictureBox Info_jpg;
        public System.Windows.Forms.Label Info_Image_jpg;
        public System.Windows.Forms.TextBox Info_name_txt;
        public System.Windows.Forms.TextBox Info_number_txt;
        public System.Windows.Forms.ComboBox Info_cat_txt;
        public System.Windows.Forms.Label Info_date_lable;
        public System.Windows.Forms.TextBox Info_date_txt;
        public System.Windows.Forms.Button Info_change;
        public System.Windows.Forms.TextBox Info_cdr_path_txt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Info_load_cdr;
        public System.Windows.Forms.Button Info_load_jpg;
        public System.Windows.Forms.OpenFileDialog openCDR;
        public System.Windows.Forms.OpenFileDialog openJPG;
        public System.Windows.Forms.TextBox Info_tags;
        private System.Windows.Forms.Button Info_loadCoin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}