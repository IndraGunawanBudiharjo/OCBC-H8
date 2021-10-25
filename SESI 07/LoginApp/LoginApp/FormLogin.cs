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
    public partial class FormLogin : Form
    {
        // Initialize the connection class
        Config db = new Config();
        public int attempt = 3;
        public FormLogin()
        {
            InitializeComponent();

            // pass the database you want to connect to
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //db.ExecuteSelect("SELECT * FROM `user_info` where username='" + tbLogin.Text + "' and password ='" + tbPassword.Text + "'");
            UserItem item = db.login(tbLogin.Text, tbPassword.Text);

            //if(db.Count() == 1)
            if (item.username != "")
            {
                //MessageBox.Show("Success You will login as " + db.Results(0, "name"));
                //MessageBox.Show($"Success You will login as name: {item.name}, username: {item.username}");
                FormUser user = new FormUser(item);
                user.Show();

            }
            else if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill your username or password correctly");
            }
            else
            {
                
                if (attempt == 0)
                {
                    MessageBox.Show("Whoops, try again later");
                    this.Close(); 
                }
                MessageBox.Show($"Wrong username and password combination, you have {attempt} more attempts" );
                attempt--;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the application
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // start register window
            this.Hide();
            FormRegister register = new FormRegister();
            register.login = this;
            register.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
