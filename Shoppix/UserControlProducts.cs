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
        UserControlProductDesc productDesc = new UserControlProductDesc();

        static UserControlProducts _obj;

        public static UserControlProducts Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UserControlProducts();
                }
                return _obj;
            }

        }

        public Panel prevPanel
        {
            get { return panel1; }
            set { prevPanel = value; }
        }

        

        //dynamic user control
        private void dynamicControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UserControl[] listItems = new UserControl[1];

            string[] titles = new string[1] { "bin" };
            string[] descriptions = new string[1] { "bin is bin" };
            Image[] icons = new Image[1] { Properties.Resources._0a6yzg9k7ypd1};
            /*
            for(int i = 0; i < listItems.Length; i++)
            {
                //store control object on list array
                listItems[i] = new UserControl();

                listItems[i].titl = titles[i];
                listItems[i]
                listItems[i]

            }
            */
        }

        public UserControlProducts()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
            // Handles event with no event data
            picturebox1.Click += new System.EventHandler(this.panelClick);
        }

        void panelClick(object sender, EventArgs e)
        {
            if (!UserControlProducts.Instance.prevPanel.Controls.ContainsKey("UserControlProductDesc"))
            {
                UserControlProductDesc ucpd = new UserControlProductDesc();
                ucpd.Dock = DockStyle.Fill;
                Form1.Instance.Mnpanel.Controls.Clear();
                Form1.Instance.Mnpanel.Controls.Add(ucpd);
                ucpd.Show();
            }
        }
    }

}
