using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coins
{
    public partial class AddCat : Form
    {
        SQL sql = new SQL();
        public AddCat()
        {
            InitializeComponent();
        }

        private void ConfirmAddCat_Click(object sender, EventArgs e)
        {
            sql.ExecuteNonQuery("INSERT INTO CAT (CAT) VALUES('"+AddCatTxt.Text+"')");
            Program.addcoinform.RefreshCat();
            this.Close();
        }
    }

}
