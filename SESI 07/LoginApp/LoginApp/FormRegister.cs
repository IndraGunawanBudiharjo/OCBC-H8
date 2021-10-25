using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormRegister : Form
    {
        Config db = new Config();

        public FormLogin login;

        public FormRegister()
        {
            InitializeComponent();

            // pass the database you want to connect to
            db.Connect("userdata");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if(tbName.Text == "") {
                MessageBox.Show("Please provide your name");
            }
            else if (tbUsername.Text == "") {
                MessageBox.Show("Please provide your username");
            }
            else if (tbPassword.Text == "") {
                MessageBox.Show("Please provide your password");
            }
            else
            {
                db.Execute($"INSERT INTO `user_info` (`name`, `username`, `password`) VALUES ('{tbName.Text}', '{tbUsername.Text}','{tbPassword.Text}')");
                MessageBox.Show("Your profile successfully recorded");
                this.Close();
                login.Show();
            }

            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

            tbPassword.UseSystemPasswordChar = true;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();
            form.Show();
        }
    }
}
