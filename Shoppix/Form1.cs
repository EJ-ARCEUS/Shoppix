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
    public partial class Form1 : Form
    {
        UserControlHome Home = new UserControlHome();
        UserControlProducts Products = new UserControlProducts();
        UserControlCart Cart = new UserControlCart();
        UserControlSpecialOffers Offers = new UserControlSpecialOffers();
        UserControlCheckOut Checkout = new UserControlCheckOut();

        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }

        }



        public Panel Mnpanel
        {
            get { return MainPanel; }
            set { MainPanel = value; }
        }

        public Button BackButton
        {
            get { return BckButton; }
            set { BckButton = value; }

        }

        public Form1()
        {
            InitializeComponent();

        }

        // Before the form is load

        private void Form1_Load(object sender, EventArgs e)
        {
            BckButton.Visible = false;
            _obj = this;

            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;

        }

        private void BckButton_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            BckButton.Visible = false;

        }


        //   Home / Dashboard

        private void button1_Click(object sender, EventArgs e)
        {
            BackButton.Visible = false;

            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;

        }


        //Products

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (!Form1.Instance.Mnpanel.Controls.ContainsKey("UserControlProducts"))
            {
                UserControlProducts Ucp = new UserControlProducts();
                Ucp.Dock = DockStyle.Fill;
                Form1.Instance.Mnpanel.Controls.Add(Ucp);

                Sidepanel.Height = button8.Height;
                Sidepanel.Top = button8.Top;
            }
            Form1.Instance.Mnpanel.Controls["UserControlProducts"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
        }

        //cart

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Cart);
            Cart.Dock = DockStyle.Fill;
        }

        //Offers

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;


            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Offers);
            Offers.Dock = DockStyle.Fill;

        }

        // Checkout

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Checkout);
            Offers.Dock = DockStyle.Fill;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

    
}
