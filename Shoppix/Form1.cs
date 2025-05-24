using Shoppix.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoppix.User_Controls;
using static Shoppix.UserControlCart;

namespace Shoppix
{
    public partial class Form1 : Form
    {
        UserControlHome Home = new UserControlHome();
        UserControlProducts Products = new UserControlProducts();
        UserControlCart Cart = new UserControlCart();
        UserControlCheckOut Checkout = new UserControlCheckOut();
        UserControlTesting Test = new UserControlTesting();

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

            if (!Form1.Instance.Mnpanel.Controls.ContainsKey("UserControlHome"))
            {
                UserControlHome Ucp = new UserControlHome();
                Ucp.Dock = DockStyle.Fill;
                Form1.Instance.MainPanel.Controls.Add(Ucp);

            }
            Form1.Instance.MainPanel.Controls["UserControlHome"].BringToFront();
            Form1.Instance.BackButton.Visible = true;

            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
        }

        //Products

        private void button8_Click(object sender, EventArgs e)
        {

            if (!Form1.Instance.Mnpanel.Controls.ContainsKey("UserControlProducts"))
            {
                UserControlProducts Ucp = new UserControlProducts();
                Ucp.Dock = DockStyle.Fill;
                Form1.Instance.MainPanel.Controls.Add(Ucp);

            }
            Form1.Instance.MainPanel.Controls["UserControlProducts"].BringToFront();
            Form1.Instance.BackButton.Visible = true;

            Sidepanel.Height = button8.Height;
            Sidepanel.Top = button8.Top;
        }

        //cart

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Mnpanel.Controls.ContainsKey("UserControlCart"))
            {
                Form1.Instance.Mnpanel.Controls.Clear();
                UserControlCart Ucc = new UserControlCart();
                Ucc.Dock = DockStyle.Fill;
                Form1.Instance.MainPanel.Controls.Add(Ucc);


            }
            Form1.Instance.MainPanel.Controls["UserControlCart"].BringToFront();
            Form1.Instance.BackButton.Visible = true;

            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
        }


        // Checkout

        private void button4_Click(object sender, EventArgs e)
        {
            List<CartItem> cartItems = Cart.GetCartItems();

            UserControlCheckOut checkout = new UserControlCheckOut();
            checkout.LoadCartItems(cartItems);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(checkout);

            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;

            SoundPlayer selecta = new SoundPlayer(Properties.Resources.SELECTA_THEME_SONG);
            //selecta.Play();

        }


        // Exit
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

    
}
