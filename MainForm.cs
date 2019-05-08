using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pingpong
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sign_in_bt_Click(object sender, EventArgs e)
        {
            SignIn aForm= new SignIn();
            aForm.Show();
        }

        
        
    }
}
