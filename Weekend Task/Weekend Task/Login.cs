using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekend_Task
{
    public partial class Login : Form
    {
        Product productForm;
        public Login(Product form)
        {
            InitializeComponent();
            productForm = form;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username ve Password daxil edin");
                return;
            }

            bool isMatch = Register.users.Exists(u => u.Username == username && u.Password == password);

            if (isMatch)
            {
                this.Close();
                productForm.Show();
            } else
            {
                MessageBox.Show("Username ve password tapilmadi");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(productForm, this);
            register.ShowDialog();

        }
    }
}
