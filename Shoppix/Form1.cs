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



        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;

            LoadUserControl(new UserControlHome());
        }

       
        //   Home / Dashboard

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Home);
            Home.Dock = DockStyle.Fill;

        }


        //Products

        private void button8_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button8.Height;
            Sidepanel.Top = button8.Top;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(Products);
            Products.Dock = DockStyle.Fill;
        }

        public void LoadUserControl(UserControl ProductControl)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            MainPanel.Controls.Clear();
            ProductControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ProductControl);
    
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

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    
}
