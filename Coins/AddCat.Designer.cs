namespace Coins
{
    partial class AddCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCat));
            this.ConfirmAddCat = new System.Windows.Forms.Button();
            this.AddCatTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConfirmAddCat
            // 
            this.ConfirmAddCat.Location = new System.Drawing.Point(193, 12);
            this.ConfirmAddCat.Name = "ConfirmAddCat";
            this.ConfirmAddCat.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAddCat.TabIndex = 0;
            this.ConfirmAddCat.Text = "Добавить";
            this.ConfirmAddCat.UseVisualStyleBackColor = true;
            this.ConfirmAddCat.Click += new System.EventHandler(this.ConfirmAddCat_Click);
            // 
            // AddCatTxt
            // 
            this.AddCatTxt.Location = new System.Drawing.Point(13, 13);
            this.AddCatTxt.Name = "AddCatTxt";
            this.AddCatTxt.Size = new System.Drawing.Size(174, 20);
            this.AddCatTxt.TabIndex = 1;
            // 
            // AddCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 50);
            this.Controls.Add(this.AddCatTxt);
            this.Controls.Add(this.ConfirmAddCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(296, 88);
            this.MinimumSize = new System.Drawing.Size(296, 88);
            this.Name = "AddCat";
            this.Text = "Добавить Категорию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmAddCat;
        private System.Windows.Forms.TextBox AddCatTxt;
    }
}