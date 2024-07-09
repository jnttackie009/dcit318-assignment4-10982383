using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void login_button_clicked(object sender, EventArgs e)
        {
            String uname = username.Text;
            String pwd = password.Text;
            MessageBox.Show($"Your username is: {uname}\n Your password is: {pwd}");
        }
    }
}
