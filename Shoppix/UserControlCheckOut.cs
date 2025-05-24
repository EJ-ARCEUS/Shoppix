using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shoppix.UserControlCart;

namespace Shoppix
{
    public partial class UserControlCheckOut : UserControl
    {
        public UserControlCheckOut()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void LoadCartItems(List<CartItem> items)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in items)
            {
                Panel panel = new Panel();
                panel.Size = new Size(754, 114);
                panel.BackColor = Color.Linen;

                PictureBox pb = new PictureBox();
                pb.Image = item.ProductImage;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Dock = DockStyle.Top;
                pb.Height = 60;

                Label lbl = new Label();
                lbl.Text = item.ProductName;
                lbl.Dock = DockStyle.Bottom;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                panel.Controls.Add(lbl);
                panel.Controls.Add(pb);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
