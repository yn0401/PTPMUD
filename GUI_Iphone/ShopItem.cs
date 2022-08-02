using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Iphone
{
    public partial class ShopItem : Bunifu.UI.WinForms.BunifuUserControl
    {
        public ShopItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return img_box2.Image;
            }
            set
            {
                img_box2.Image = value;
            }
        }

        public string ItemLabel
        {
            get
            {
                return bu_lbl_2.Text;
            }
            set
            {
                bu_lbl_2.Text= value;
            }
        }

        public string ItemPrice
        {
            get
            {
                return bu_lbl_1.Text;
            }
            set
            {
                bu_lbl_1.Text = value;
            }
        }

        private void bunifuRating1_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
