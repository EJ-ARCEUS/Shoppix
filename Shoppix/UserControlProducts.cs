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

        //dynamic user control
        private void dynamicControl()
        {
            flowLayoutPanel1.Controls.Clear();

            UserControlProductDesc[] listItems = new UserControlProductDesc[5];

            string[] titles = new string[5] { "camellya's armpit", "Vivian's nude", "Master shifu", "pyromaniac armpit", "summer chocolate", };
            string[] descriptions = new string[5] { "some juicy shit", "im hard rn", "very powerful ally", "smells like nitro fuel", "this is a supposed child wtf", };
            string[] price = new string[5] { "377.99", "739.99", "455.99", "599.99", "289.99", };
            Image[] icons = new Image[5] { Properties.Resources.camellya, Properties.Resources.vivian, Properties.Resources.master, Properties.Resources.burnice, Properties.Resources.iori};
            
            for(int i = 0; i < listItems.Length; i++)
            {
                //store control object on list array
                listItems[i] = new UserControlProductDesc();
                
                listItems[i].Name = titles[i];
                listItems[i].Desc = descriptions[i];
                listItems[i].Price = price[i];
                listItems[i].Icon = icons[i];

                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            
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
            dynamicControl();
        }

    }

}
