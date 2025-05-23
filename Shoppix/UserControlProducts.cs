using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppix
{
    public partial class UserControlProducts : UserControl
    {

        // Properties for the icon, title, and description
        private Image _icon;
        private string _title;
        private string _description;

        [Category("Custom Props")]

        
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; btn_icon.Image = value;}
        }

        [Category("Custom Props")]

        public string Title
        {
            get { return _title; }
            set { _title = value; btn_title.Text = value; }
        }

        [Category("Custom Props")]

        public string Description
        {
            get { return _description; }
            set { _description = value; btn_description.Text = value; }
        }
        

        //dynamic user control
        private void dynamicControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UserControl[] listItems = new UserControl[1];

            string[] titles = new string[1] { "bin" };
            string[] descriptions = new string[1] { "bin is bin" };
            Image[] icons = { Properties.Resources._0a6yzg9k7ypd1 };
        }

        public UserControlProducts()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
