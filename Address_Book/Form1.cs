using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            String name = name_textBox.Text;
            String email = email_textBox.Text;
            String phone = phone_textBox.Text;

            String filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "details.txt");

            if (name.Equals("") || email.Equals("") || phone.Equals("")) {
                MessageBox.Show("Please make sure you have provided the requested information", "Empty data");
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Email: {email}");
                        writer.WriteLine($"Phone: {phone}");
                        writer.WriteLine("--------------------");
                    }

                    MessageBox.Show("Information saved to file (details) in the same directory.", "Success");

                    name_textBox.Clear();
                    email_textBox.Clear();
                    phone_textBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error while saving the information: {ex.Message}", "Error");
                }
            }
        }
    }
}
