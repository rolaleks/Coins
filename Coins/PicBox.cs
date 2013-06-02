using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Coins
{
    public class PicBox : PictureBox
    {
        public coin coin;
        public int x;
        public int y;
        public bool selected;
        public PicBox(coin c, int X, int Y)
        {
            coin = c;
            x = X;
            y = Y;

            selected = false;
            Location = new System.Drawing.Point(47, 23);
            Image = c.image;
            Size = new System.Drawing.Size(x, y);
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            TabIndex = 0;
            TabStop = false;




        }
    }
}
