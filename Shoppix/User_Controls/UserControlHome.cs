﻿using System;
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
    public partial class UserControlHome : UserControl
    {
        internal static object Instance;

        public UserControlHome()
        {
            InitializeComponent();
             this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.button8.PerformClick();
            Form1.Instance.BackButton.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
