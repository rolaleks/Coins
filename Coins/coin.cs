using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms; 
namespace Coins
{
    public class coin
    {
        public Bitmap image;
        public String CDRPath;
        public String JPGPath;
        public int number;
        public String name;
        public int cat;
        public String catName;
        public int id;
        public DateTime date = new DateTime();
        public String tag;
        public int sec;
        public coin(){
        
        try
        {
            CDRPath = "";
            JPGPath = "";
            tag = "";
            image = Coins.Properties.Resources.Question_Coin;
       

       
      
    }
    catch(ArgumentException)
    {
        MessageBox.Show("There was an error." +
            "Check the path to the image file.");
    }
        
    }
}
}
