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
    public partial class FormUser : Form
    {
        private UserItem _item;
        public FormUser(UserItem item)
        {
            InitializeComponent();
            _item = item;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            textBoxName.Text = _item.name;
            textBoxUsername.Text = _item.username;
        }
    }
}
