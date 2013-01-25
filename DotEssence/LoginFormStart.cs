using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotEssence
{
    public partial class LoginFormStart : Form
    {
        public LoginFormStart()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(label1.Text==Convert.ToString("22"))
            {
                MessageBox.Show("You are Logged in.");
                Close();
            }
            else
            {
                label1.Text="";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "22";
        }
    }
}
