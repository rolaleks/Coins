namespace Coins
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.Manager_tab = new System.Windows.Forms.TabControl();
            this.Manger_personal = new System.Windows.Forms.TabPage();
            this.Manager_del = new System.Windows.Forms.Button();
            this.Manager_addpersonal = new System.Windows.Forms.Button();
            this.Manager_title_lbl = new System.Windows.Forms.Label();
            this.Manager_Lastname_lbl = new System.Windows.Forms.Label();
            this.Manager_title_txt = new System.Windows.Forms.TextBox();
            this.Manage_lastname_txt = new System.Windows.Forms.TextBox();
            this.Manager_name_lbl = new System.Windows.Forms.Label();
            this.Manager_name_txt = new System.Windows.Forms.TextBox();
            this.Manager_change = new System.Windows.Forms.Button();
            this.Manger_chk_admin = new System.Windows.Forms.CheckBox();
            this.Manger_chk_download = new System.Windows.Forms.CheckBox();
            this.Manger_chk_change = new System.Windows.Forms.CheckBox();
            this.Manger_chk_createPDF = new System.Windows.Forms.CheckBox();
            this.Manger_chk_add = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Manager_pass_lbl = new System.Windows.Forms.Label();
            this.Manager_login_lbl = new System.Windows.Forms.Label();
            this.Manager_pass_txt = new System.Windows.Forms.TextBox();
            this.Manager_login_txt = new System.Windows.Forms.TextBox();
            this.Manager_personal_list = new System.Windows.Forms.ListBox();
            this.Manager_cat = new System.Windows.Forms.TabPage();
            this.Manager_cat_del = new System.Windows.Forms.Button();
            this.Manager_cat_list = new System.Windows.Forms.ListBox();
            this.Manager_tab.SuspendLayout();
            this.Manger_personal.SuspendLayout();
            this.Manager_cat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manager_tab
            // 
            this.Manager_tab.Controls.Add(this.Manger_personal);
            this.Manager_tab.Controls.Add(this.Manager_cat);
            this.Manager_tab.Location = new System.Drawing.Point(12, 12);
            this.Manager_tab.Name = "Manager_tab";
            this.Manager_tab.SelectedIndex = 0;
            this.Manager_tab.Size = new System.Drawing.Size(608, 335);
            this.Manager_tab.TabIndex = 0;
            // 
            // Manger_personal
            // 
            this.Manger_personal.BackColor = System.Drawing.Color.White;
            this.Manger_personal.Controls.Add(this.Manager_del);
            this.Manger_personal.Controls.Add(this.Manager_addpersonal);
            this.Manger_personal.Controls.Add(this.Manager_title_lbl);
            this.Manger_personal.Controls.Add(this.Manager_Lastname_lbl);
            this.Manger_personal.Controls.Add(this.Manager_title_txt);
            this.Manger_personal.Controls.Add(this.Manage_lastname_txt);
            this.Manger_personal.Controls.Add(this.Manager_name_lbl);
            this.Manger_personal.Controls.Add(this.Manager_name_txt);
            this.Manger_personal.Controls.Add(this.Manager_change);
            this.Manger_personal.Controls.Add(this.Manger_chk_admin);
            this.Manger_personal.Controls.Add(this.Manger_chk_download);
            this.Manger_personal.Controls.Add(this.Manger_chk_change);
            this.Manger_personal.Controls.Add(this.Manger_chk_createPDF);
            this.Manger_personal.Controls.Add(this.Manger_chk_add);
            this.Manger_personal.Controls.Add(this.label1);
            this.Manger_personal.Controls.Add(this.Manager_pass_lbl);
            this.Manger_personal.Controls.Add(this.Manager_login_lbl);
            this.Manger_personal.Controls.Add(this.Manager_pass_txt);
            this.Manger_personal.Controls.Add(this.Manager_login_txt);
            this.Manger_personal.Controls.Add(this.Manager_personal_list);
            this.Manger_personal.Location = new System.Drawing.Point(4, 22);
            this.Manger_personal.Name = "Manger_personal";
            this.Manger_personal.Padding = new System.Windows.Forms.Padding(3);
            this.Manger_personal.Size = new System.Drawing.Size(600, 309);
            this.Manger_personal.TabIndex = 0;
            this.Manger_personal.Text = "Сотрудники";
            // 
            // Manager_del
            // 
            this.Manager_del.Location = new System.Drawing.Point(230, 280);
            this.Manager_del.Name = "Manager_del";
            this.Manager_del.Size = new System.Drawing.Size(75, 23);
            this.Manager_del.TabIndex = 19;
            this.Manager_del.Text = "Удалить";
            this.Manager_del.UseVisualStyleBackColor = true;
            this.Manager_del.Click += new System.EventHandler(this.Manager_del_Click);
            // 
            // Manager_addpersonal
            // 
            this.Manager_addpersonal.Location = new System.Drawing.Point(139, 280);
            this.Manager_addpersonal.Name = "Manager_addpersonal";
            this.Manager_addpersonal.Size = new System.Drawing.Size(75, 23);
            this.Manager_addpersonal.TabIndex = 18;
            this.Manager_addpersonal.Text = "Добавить";
            this.Manager_addpersonal.UseVisualStyleBackColor = true;
            this.Manager_addpersonal.Click += new System.EventHandler(this.Manager_addpersonal_Click);
            // 
            // Manager_title_lbl
            // 
            this.Manager_title_lbl.AutoSize = true;
            this.Manager_title_lbl.Location = new System.Drawing.Point(136, 156);
            this.Manager_title_lbl.Name = "Manager_title_lbl";
            this.Manager_title_lbl.Size = new System.Drawing.Size(68, 13);
            this.Manager_title_lbl.TabIndex = 17;
            this.Manager_title_lbl.Text = "Должность:";
            // 
            // Manager_Lastname_lbl
            // 
            this.Manager_Lastname_lbl.AutoSize = true;
            this.Manager_Lastname_lbl.Location = new System.Drawing.Point(136, 129);
            this.Manager_Lastname_lbl.Name = "Manager_Lastname_lbl";
            this.Manager_Lastname_lbl.Size = new System.Drawing.Size(59, 13);
            this.Manager_Lastname_lbl.TabIndex = 16;
            this.Manager_Lastname_lbl.Text = "Фамилия:";
            // 
            // Manager_title_txt
            // 
            this.Manager_title_txt.Location = new System.Drawing.Point(205, 153);
            this.Manager_title_txt.Name = "Manager_title_txt";
            this.Manager_title_txt.Size = new System.Drawing.Size(100, 20);
            this.Manager_title_txt.TabIndex = 15;
            // 
            // Manage_lastname_txt
            // 
            this.Manage_lastname_txt.Location = new System.Drawing.Point(205, 126);
            this.Manage_lastname_txt.Name = "Manage_lastname_txt";
            this.Manage_lastname_txt.Size = new System.Drawing.Size(100, 20);
            this.Manage_lastname_txt.TabIndex = 14;
            // 
            // Manager_name_lbl
            // 
            this.Manager_name_lbl.AutoSize = true;
            this.Manager_name_lbl.Location = new System.Drawing.Point(136, 102);
            this.Manager_name_lbl.Name = "Manager_name_lbl";
            this.Manager_name_lbl.Size = new System.Drawing.Size(32, 13);
            this.Manager_name_lbl.TabIndex = 13;
            this.Manager_name_lbl.Text = "Имя:";
            // 
            // Manager_name_txt
            // 
            this.Manager_name_txt.Location = new System.Drawing.Point(205, 99);
            this.Manager_name_txt.Name = "Manager_name_txt";
            this.Manager_name_txt.Size = new System.Drawing.Size(100, 20);
            this.Manager_name_txt.TabIndex = 12;
            // 
            // Manager_change
            // 
            this.Manager_change.Location = new System.Drawing.Point(519, 280);
            this.Manager_change.Name = "Manager_change";
            this.Manager_change.Size = new System.Drawing.Size(75, 23);
            this.Manager_change.TabIndex = 11;
            this.Manager_change.Text = "Изменить";
            this.Manager_change.UseVisualStyleBackColor = true;
            this.Manager_change.Click += new System.EventHandler(this.Manager_change_Click);
            // 
            // Manger_chk_admin
            // 
            this.Manger_chk_admin.AutoSize = true;
            this.Manger_chk_admin.Location = new System.Drawing.Point(340, 134);
            this.Manger_chk_admin.Name = "Manger_chk_admin";
            this.Manger_chk_admin.Size = new System.Drawing.Size(59, 17);
            this.Manger_chk_admin.TabIndex = 10;
            this.Manger_chk_admin.Text = "Админ";
            this.Manger_chk_admin.UseVisualStyleBackColor = true;
            this.Manger_chk_admin.CheckedChanged += new System.EventHandler(this.Manger_chk_admin_CheckedChanged);
            this.Manger_chk_admin.Click += new System.EventHandler(this.Manger_chk_admin_Click);
            // 
            // Manger_chk_download
            // 
            this.Manger_chk_download.AutoSize = true;
            this.Manger_chk_download.Location = new System.Drawing.Point(340, 110);
            this.Manger_chk_download.Name = "Manger_chk_download";
            this.Manger_chk_download.Size = new System.Drawing.Size(106, 17);
            this.Manger_chk_download.TabIndex = 9;
            this.Manger_chk_download.Text = "Скачивать Базу";
            this.Manger_chk_download.UseVisualStyleBackColor = true;
            // 
            // Manger_chk_change
            // 
            this.Manger_chk_change.AutoSize = true;
            this.Manger_chk_change.Location = new System.Drawing.Point(340, 86);
            this.Manger_chk_change.Name = "Manger_chk_change";
            this.Manger_chk_change.Size = new System.Drawing.Size(146, 17);
            this.Manger_chk_change.TabIndex = 8;
            this.Manger_chk_change.Text = "Редактировать Монеты";
            this.Manger_chk_change.UseVisualStyleBackColor = true;
            // 
            // Manger_chk_createPDF
            // 
            this.Manger_chk_createPDF.AutoSize = true;
            this.Manger_chk_createPDF.Location = new System.Drawing.Point(340, 62);
            this.Manger_chk_createPDF.Name = "Manger_chk_createPDF";
            this.Manger_chk_createPDF.Size = new System.Drawing.Size(104, 17);
            this.Manger_chk_createPDF.TabIndex = 7;
            this.Manger_chk_createPDF.Text = "Создавать PDF";
            this.Manger_chk_createPDF.UseVisualStyleBackColor = true;
            // 
            // Manger_chk_add
            // 
            this.Manger_chk_add.AutoSize = true;
            this.Manger_chk_add.Location = new System.Drawing.Point(340, 38);
            this.Manger_chk_add.Name = "Manger_chk_add";
            this.Manger_chk_add.Size = new System.Drawing.Size(125, 17);
            this.Manger_chk_add.TabIndex = 6;
            this.Manger_chk_add.Text = "Добавлять Монеты";
            this.Manger_chk_add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Возможности:";
            // 
            // Manager_pass_lbl
            // 
            this.Manager_pass_lbl.AutoSize = true;
            this.Manager_pass_lbl.Location = new System.Drawing.Point(136, 48);
            this.Manager_pass_lbl.Name = "Manager_pass_lbl";
            this.Manager_pass_lbl.Size = new System.Drawing.Size(48, 13);
            this.Manager_pass_lbl.TabIndex = 4;
            this.Manager_pass_lbl.Text = "Пароль:";
            // 
            // Manager_login_lbl
            // 
            this.Manager_login_lbl.AutoSize = true;
            this.Manager_login_lbl.Location = new System.Drawing.Point(136, 22);
            this.Manager_login_lbl.Name = "Manager_login_lbl";
            this.Manager_login_lbl.Size = new System.Drawing.Size(41, 13);
            this.Manager_login_lbl.TabIndex = 3;
            this.Manager_login_lbl.Text = "Логин:";
            this.Manager_login_lbl.Click += new System.EventHandler(this.Manager_login_lbl_Click);
            // 
            // Manager_pass_txt
            // 
            this.Manager_pass_txt.Location = new System.Drawing.Point(205, 45);
            this.Manager_pass_txt.Name = "Manager_pass_txt";
            this.Manager_pass_txt.Size = new System.Drawing.Size(100, 20);
            this.Manager_pass_txt.TabIndex = 2;
            // 
            // Manager_login_txt
            // 
            this.Manager_login_txt.Location = new System.Drawing.Point(205, 19);
            this.Manager_login_txt.Name = "Manager_login_txt";
            this.Manager_login_txt.Size = new System.Drawing.Size(100, 20);
            this.Manager_login_txt.TabIndex = 1;
            // 
            // Manager_personal_list
            // 
            this.Manager_personal_list.FormattingEnabled = true;
            this.Manager_personal_list.Location = new System.Drawing.Point(6, 6);
            this.Manager_personal_list.Name = "Manager_personal_list";
            this.Manager_personal_list.Size = new System.Drawing.Size(120, 303);
            this.Manager_personal_list.TabIndex = 0;
            this.Manager_personal_list.SelectedIndexChanged += new System.EventHandler(this.Manager_personal_list_SelectedIndexChanged);
            // 
            // Manager_cat
            // 
            this.Manager_cat.Controls.Add(this.Manager_cat_del);
            this.Manager_cat.Controls.Add(this.Manager_cat_list);
            this.Manager_cat.Location = new System.Drawing.Point(4, 22);
            this.Manager_cat.Name = "Manager_cat";
            this.Manager_cat.Padding = new System.Windows.Forms.Padding(3);
            this.Manager_cat.Size = new System.Drawing.Size(600, 309);
            this.Manager_cat.TabIndex = 1;
            this.Manager_cat.Text = "Категории";
            this.Manager_cat.UseVisualStyleBackColor = true;
            // 
            // Manager_cat_del
            // 
            this.Manager_cat_del.Location = new System.Drawing.Point(136, 7);
            this.Manager_cat_del.Name = "Manager_cat_del";
            this.Manager_cat_del.Size = new System.Drawing.Size(75, 23);
            this.Manager_cat_del.TabIndex = 1;
            this.Manager_cat_del.Text = "Удалить";
            this.Manager_cat_del.UseVisualStyleBackColor = true;
            this.Manager_cat_del.Click += new System.EventHandler(this.Manager_cat_del_Click);
            // 
            // Manager_cat_list
            // 
            this.Manager_cat_list.FormattingEnabled = true;
            this.Manager_cat_list.Location = new System.Drawing.Point(7, 7);
            this.Manager_cat_list.Name = "Manager_cat_list";
            this.Manager_cat_list.Size = new System.Drawing.Size(122, 290);
            this.Manager_cat_list.TabIndex = 0;
            this.Manager_cat_list.SelectedIndexChanged += new System.EventHandler(this.Manager_cat_list_SelectedIndexChanged);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 359);
            this.Controls.Add(this.Manager_tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(648, 397);
            this.MinimumSize = new System.Drawing.Size(648, 397);
            this.Name = "Manager";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.Manager_tab.ResumeLayout(false);
            this.Manger_personal.ResumeLayout(false);
            this.Manger_personal.PerformLayout();
            this.Manager_cat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Manager_tab;
        private System.Windows.Forms.TabPage Manger_personal;
        private System.Windows.Forms.TabPage Manager_cat;
        private System.Windows.Forms.ListBox Manager_personal_list;
        private System.Windows.Forms.Label Manager_pass_lbl;
        private System.Windows.Forms.Label Manager_login_lbl;
        private System.Windows.Forms.TextBox Manager_pass_txt;
        private System.Windows.Forms.TextBox Manager_login_txt;
        private System.Windows.Forms.CheckBox Manger_chk_admin;
        private System.Windows.Forms.CheckBox Manger_chk_download;
        private System.Windows.Forms.CheckBox Manger_chk_change;
        private System.Windows.Forms.CheckBox Manger_chk_createPDF;
        private System.Windows.Forms.CheckBox Manger_chk_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Manager_change;
        private System.Windows.Forms.Label Manager_title_lbl;
        private System.Windows.Forms.Label Manager_Lastname_lbl;
        private System.Windows.Forms.TextBox Manager_title_txt;
        private System.Windows.Forms.TextBox Manage_lastname_txt;
        private System.Windows.Forms.Label Manager_name_lbl;
        private System.Windows.Forms.TextBox Manager_name_txt;
        private System.Windows.Forms.Button Manager_addpersonal;
        private System.Windows.Forms.Button Manager_del;
        private System.Windows.Forms.ListBox Manager_cat_list;
        private System.Windows.Forms.Button Manager_cat_del;

    }
}