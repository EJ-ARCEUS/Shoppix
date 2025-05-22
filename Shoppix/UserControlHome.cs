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
    public partial class UserControlHome : UserControl
    {
        internal static object Instance;

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                // Call the method in Form1 to load new control
                mainForm.LoadUserControl(new UserControlProducts());

            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
