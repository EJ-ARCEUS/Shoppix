using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        int q = 1;
        bool mClick = false;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!mClick)
            {
                mClick = true;
                // if q is equal to 0, output is 0 else, continue to minus
                if (q == 0)
                {
                    int i = 0;
                    string myString2 = i.ToString();
                    label1.Text = myString2;
                    mClick = false;
                }
                else
                {
                    q = q - 1;
                    string myString = q.ToString();
                    label1.Text = myString;
                    mClick = false;
                }
            } 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!mClick)
            {
                mClick = true;
                q = q + 1;
                string myString = q.ToString();
                label1.Text = myString;
                mClick = false;
            }
        }
    }
}
