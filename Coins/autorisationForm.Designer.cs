namespace Coins
{
    partial class autorisationForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Auth_name = new System.Windows.Forms.TextBox();
            this.Auth_pass = new System.Windows.Forms.TextBox();
            this.Auth_log_lable = new System.Windows.Forms.Label();
            this.Auth_pass_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(16, 90);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(311, 90);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(91, 34);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Auth_name
            // 
            this.Auth_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Auth_name.Location = new System.Drawing.Point(195, 12);
            this.Auth_name.Name = "Auth_name";
            this.Auth_name.Size = new System.Drawing.Size(207, 29);
            this.Auth_name.TabIndex = 2;
            this.Auth_name.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Auth_name_ControlAdded);
            this.Auth_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Auth_name_KeyPress);
            // 
            // Auth_pass
            // 
            this.Auth_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_pass.Location = new System.Drawing.Point(195, 55);
            this.Auth_pass.Name = "Auth_pass";
            this.Auth_pass.PasswordChar = '*';
            this.Auth_pass.Size = new System.Drawing.Size(207, 29);
            this.Auth_pass.TabIndex = 3;
            this.Auth_pass.Text = "Пароль";
            this.Auth_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Auth_pass_KeyPress);
            // 
            // Auth_log_lable
            // 
            this.Auth_log_lable.AutoSize = true;
            this.Auth_log_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Auth_log_lable.Location = new System.Drawing.Point(12, 12);
            this.Auth_log_lable.Name = "Auth_log_lable";
            this.Auth_log_lable.Size = new System.Drawing.Size(150, 24);
            this.Auth_log_lable.TabIndex = 4;
            this.Auth_log_lable.Text = "Введите логин:";
            this.Auth_log_lable.Click += new System.EventHandler(this.Auth_log_lable_Click);
            // 
            // Auth_pass_lable
            // 
            this.Auth_pass_lable.AutoSize = true;
            this.Auth_pass_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Auth_pass_lable.Location = new System.Drawing.Point(12, 55);
            this.Auth_pass_lable.Name = "Auth_pass_lable";
            this.Auth_pass_lable.Size = new System.Drawing.Size(162, 24);
            this.Auth_pass_lable.TabIndex = 5;
            this.Auth_pass_lable.Text = "Введите пароль:";
            // 
            // autorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 136);
            this.Controls.Add(this.Auth_pass_lable);
            this.Controls.Add(this.Auth_log_lable);
            this.Controls.Add(this.Auth_pass);
            this.Controls.Add(this.Auth_name);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(414, 136);
            this.MinimumSize = new System.Drawing.Size(414, 136);
            this.Name = "autorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autorisationForm";
            this.Load += new System.EventHandler(this.autorisationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox Auth_name;
        private System.Windows.Forms.TextBox Auth_pass;
        private System.Windows.Forms.Label Auth_log_lable;
        private System.Windows.Forms.Label Auth_pass_lable;
    }
}