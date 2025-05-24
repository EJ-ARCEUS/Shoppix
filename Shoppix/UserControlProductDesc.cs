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
    public partial class UserControlProductDesc : UserControl
    {
        public UserControlProductDesc()
        {
            InitializeComponent();
        }

        // Properties for the icon, name, description, and price
        private Image _icon;
        private string _name;
        private string _description;
        private string _price;

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; icon.Image = value;}
        }

        [Category("Custom Props")]

        public string Name
        {
            get { return _name; }
            set { _name = value; name.Text = value; }
        }

        [Category("Custom Props")]

        public string Desc
        {
            get { return _description; }
            set { _description = value; desc.Text = value; }
        }

        public string Price
        {
            get { return _description; }
            set { _description = value; price.Text = value; }
        }

        // Quantity math

        int q = 1, val = 1;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            q =- val;
            string myString = q.ToString();
            label1.Text = myString;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            q =+ val;
            string myString = q.ToString();
            label1.Text = myString;
        }
    }
}
