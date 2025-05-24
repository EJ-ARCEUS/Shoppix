using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppix
{
    public partial class UserControlCart : UserControl
    {
        public UserControlCart()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public class CartItem
        {
            public string ProductName { get; set; }
            public Image ProductImage { get; set; }
        }

        public List<CartItem> GetCartItems()
        {
            List<CartItem> items = new List<CartItem>();

            // Loop through each panel in the FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var panel = flowLayoutPanel1.Controls[i] as Panel;

                if (panel != null)
                {
                    PictureBox pb = panel.Controls.OfType<PictureBox>().FirstOrDefault();
                    Label lbl = panel.Controls.OfType<Label>().FirstOrDefault();

                    if (pb != null && lbl != null)
                    {
                        items.Add(new CartItem
                        {
                            ProductName = lbl.Text,
                            ProductImage = pb.Image // Reference the existing image
                        });
                    }
                }
            }

            return items;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.button4.PerformClick();
        }
    }
}
