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

            for (int i = 0; i < items.Count; i++)
            {
                CartItem item = items[i];

                Panel panel = new Panel();
                panel.Size = new Size(754, 114);
                panel.BackColor = Color.Linen;

                PictureBox pb = new PictureBox();
                pb.Image = item.ProductImage;
                pb.BackColor = Color.Yellow;
                pb.Size = new Size(80, 80);
                pb.Location = new Point(10, 10);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lbl = new Label();
                lbl.Text = item.ProductName;
                lbl.AutoSize = true;
                lbl.Location = new Point(100, 40);

                panel.Controls.Add(pb);
                panel.Controls.Add(lbl);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
 }
