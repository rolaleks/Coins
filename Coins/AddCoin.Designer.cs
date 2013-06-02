namespace Coins
{
    partial class AddCoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCoin));
            this.CoinNameTxt = new System.Windows.Forms.TextBox();
            this.CoinNumberTxt = new System.Windows.Forms.TextBox();
            this.AddMore = new System.Windows.Forms.Button();
            this.JPGpreview = new System.Windows.Forms.PictureBox();
            this.AddJPG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CoinName = new System.Windows.Forms.Label();
            this.CoinNumber = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.CoinCat = new System.Windows.Forms.ComboBox();
            this.addCDR = new System.Windows.Forms.Button();
            this.openCDR = new System.Windows.Forms.OpenFileDialog();
            this.CDRPathTxt = new System.Windows.Forms.TextBox();
            this.addCat = new System.Windows.Forms.Button();
            this.Add_cat_lable = new System.Windows.Forms.Label();
            this.Info_tags = new System.Windows.Forms.TextBox();
            this.Info_tags_lable = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.JPGpreview)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinNameTxt
            // 
            this.CoinNameTxt.Location = new System.Drawing.Point(79, 11);
            this.CoinNameTxt.Name = "CoinNameTxt";
            this.CoinNameTxt.Size = new System.Drawing.Size(100, 20);
            this.CoinNameTxt.TabIndex = 0;
            // 
            // CoinNumberTxt
            // 
            this.CoinNumberTxt.Location = new System.Drawing.Point(79, 36);
            this.CoinNumberTxt.Name = "CoinNumberTxt";
            this.CoinNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.CoinNumberTxt.TabIndex = 1;
            this.CoinNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoinNumberTxt_KeyPress);
            // 
            // AddMore
            // 
            this.AddMore.Location = new System.Drawing.Point(16, 353);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(118, 23);
            this.AddMore.TabIndex = 2;
            this.AddMore.Text = "Добавить еще...";
            this.AddMore.UseVisualStyleBackColor = true;
            this.AddMore.Click += new System.EventHandler(this.button1_Click);
            // 
            // JPGpreview
            // 
            this.JPGpreview.Location = new System.Drawing.Point(336, 176);
            this.JPGpreview.Name = "JPGpreview";
            this.JPGpreview.Size = new System.Drawing.Size(200, 200);
            this.JPGpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JPGpreview.TabIndex = 3;
            this.JPGpreview.TabStop = false;
            this.JPGpreview.Click += new System.EventHandler(this.JPGpreview_Click);
            // 
            // AddJPG
            // 
            this.AddJPG.Location = new System.Drawing.Point(336, 141);
            this.AddJPG.Name = "AddJPG";
            this.AddJPG.Size = new System.Drawing.Size(149, 23);
            this.AddJPG.TabIndex = 4;
            this.AddJPG.Text = "Добавить картинку";
            this.AddJPG.UseVisualStyleBackColor = true;
            this.AddJPG.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CoinName
            // 
            this.CoinName.AutoSize = true;
            this.CoinName.BackColor = System.Drawing.Color.Transparent;
            this.CoinName.Location = new System.Drawing.Point(13, 17);
            this.CoinName.Name = "CoinName";
            this.CoinName.Size = new System.Drawing.Size(57, 13);
            this.CoinName.TabIndex = 5;
            this.CoinName.Text = "Название";
            // 
            // CoinNumber
            // 
            this.CoinNumber.AutoSize = true;
            this.CoinNumber.Location = new System.Drawing.Point(14, 43);
            this.CoinNumber.Name = "CoinNumber";
            this.CoinNumber.Size = new System.Drawing.Size(41, 13);
            this.CoinNumber.TabIndex = 6;
            this.CoinNumber.Text = "Номер";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(140, 353);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // CoinCat
            // 
            this.CoinCat.FormattingEnabled = true;
            this.CoinCat.Location = new System.Drawing.Point(79, 76);
            this.CoinCat.Name = "CoinCat";
            this.CoinCat.Size = new System.Drawing.Size(121, 21);
            this.CoinCat.TabIndex = 8;
            this.CoinCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoinCat_KeyPress);
            // 
            // addCDR
            // 
            this.addCDR.Location = new System.Drawing.Point(16, 141);
            this.addCDR.Name = "addCDR";
            this.addCDR.Size = new System.Drawing.Size(149, 23);
            this.addCDR.TabIndex = 10;
            this.addCDR.Text = "Прикрепить файл";
            this.addCDR.UseVisualStyleBackColor = true;
            this.addCDR.Click += new System.EventHandler(this.addCDR_Click);
            // 
            // openCDR
            // 
            this.openCDR.FileName = "openCDR";
            // 
            // CDRPathTxt
            // 
            this.CDRPathTxt.Enabled = false;
            this.CDRPathTxt.Location = new System.Drawing.Point(16, 176);
            this.CDRPathTxt.Name = "CDRPathTxt";
            this.CDRPathTxt.Size = new System.Drawing.Size(292, 20);
            this.CDRPathTxt.TabIndex = 11;
            // 
            // addCat
            // 
            this.addCat.Location = new System.Drawing.Point(214, 74);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(128, 23);
            this.addCat.TabIndex = 12;
            this.addCat.Text = "Добавить категорию";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // Add_cat_lable
            // 
            this.Add_cat_lable.AutoSize = true;
            this.Add_cat_lable.Location = new System.Drawing.Point(13, 79);
            this.Add_cat_lable.Name = "Add_cat_lable";
            this.Add_cat_lable.Size = new System.Drawing.Size(60, 13);
            this.Add_cat_lable.TabIndex = 13;
            this.Add_cat_lable.Text = "Категория";
            // 
            // Info_tags
            // 
            this.Info_tags.Location = new System.Drawing.Point(16, 219);
            this.Info_tags.MaximumSize = new System.Drawing.Size(289, 128);
            this.Info_tags.MinimumSize = new System.Drawing.Size(289, 128);
            this.Info_tags.Multiline = true;
            this.Info_tags.Name = "Info_tags";
            this.Info_tags.Size = new System.Drawing.Size(289, 128);
            this.Info_tags.TabIndex = 14;
            // 
            // Info_tags_lable
            // 
            this.Info_tags_lable.AutoSize = true;
            this.Info_tags_lable.Location = new System.Drawing.Point(14, 203);
            this.Info_tags_lable.Name = "Info_tags_lable";
            this.Info_tags_lable.Size = new System.Drawing.Size(60, 13);
            this.Info_tags_lable.TabIndex = 15;
            this.Info_tags_lable.Text = "Описание:";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(17, 115);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(200, 20);
            this.Calendar.TabIndex = 16;
            // 
            // AddCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 401);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Info_tags_lable);
            this.Controls.Add(this.Info_tags);
            this.Controls.Add(this.Add_cat_lable);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.CDRPathTxt);
            this.Controls.Add(this.addCDR);
            this.Controls.Add(this.CoinCat);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CoinNumber);
            this.Controls.Add(this.CoinName);
            this.Controls.Add(this.AddJPG);
            this.Controls.Add(this.JPGpreview);
            this.Controls.Add(this.AddMore);
            this.Controls.Add(this.CoinNumberTxt);
            this.Controls.Add(this.CoinNameTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCoin";
            this.Text = "AddCoin";
            ((System.ComponentModel.ISupportInitialize)(this.JPGpreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoinNameTxt;
        private System.Windows.Forms.TextBox CoinNumberTxt;
        private System.Windows.Forms.Button AddMore;
        private System.Windows.Forms.PictureBox JPGpreview;
        private System.Windows.Forms.Button AddJPG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label CoinName;
        private System.Windows.Forms.Label CoinNumber;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox CoinCat;
        private System.Windows.Forms.Button addCDR;
        private System.Windows.Forms.OpenFileDialog openCDR;
        private System.Windows.Forms.TextBox CDRPathTxt;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Label Add_cat_lable;
        private System.Windows.Forms.TextBox Info_tags;
        private System.Windows.Forms.Label Info_tags_lable;
        private System.Windows.Forms.DateTimePicker Calendar;
    }
}