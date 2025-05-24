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

            foreach (Panel panel in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                var pic = panel.Controls.OfType<PictureBox>().FirstOrDefault();
                var lbl = panel.Controls.OfType<Label>().FirstOrDefault();

                if (pic == null || lbl == null)
                {
                    MessageBox.Show("Missing image or label");
                    continue;
                }

                items.Add(new CartItem
                {
                    ProductName = lbl.Text,
                    ProductImage = pic.Image
                });
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
