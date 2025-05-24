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

        // Properties for the icon, title, and description
        private Image _icon;
        private string _title;
        private string _description;
        private string _price;

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; icon.Image = value;}
        }

        [Category("Custom Props")]

        public string Title
        {
            get { return _title; }
            set { _title = value; name.Text = value; }
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

        private void UserControlProductDesc_Load(object sender, EventArgs e)
        {

        }

    }
}
