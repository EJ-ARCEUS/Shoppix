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
        UserControlHome Home = new UserControlHome() { Dock = DockStyle.Fill };
        UserControlProducts Products = new UserControlProducts() { Dock = DockStyle.Fill };
        UserControlCart Cart = new UserControlCart() { Dock = DockStyle.Fill };
        UserControlCheckOut Checkout = new UserControlCheckOut() { Dock = DockStyle.Fill };
        UserControlTesting Test = new UserControlTesting() { Dock = DockStyle.Fill };

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
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Home);

        }

        private void BckButton_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            BckButton.Visible = false;

        }

        // multiple user control

        private void addUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //   Home / Dashboard

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(Home);
        }

        //Products

        private void button8_Click(object sender, EventArgs e)
        {
            addUserControl(Products);
            Form1.Instance.BackButton.Visible = true;
        }

        //cart

        private void button2_Click(object sender, EventArgs e)
        {
            addUserControl(Cart);
            Form1.Instance.BackButton.Visible = true;
        }

        // Checkout

        private void button4_Click(object sender, EventArgs e)
        {
            addUserControl(Checkout);
            Form1.Instance.BackButton.Visible = true;
            SoundPlayer selecta = new SoundPlayer(Properties.Resources.SELECTA_THEME_SONG);
            //selecta.Play();

        }

        // Exit
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
