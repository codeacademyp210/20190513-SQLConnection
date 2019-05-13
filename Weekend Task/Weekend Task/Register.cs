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
    public partial class Register : Form
    {
        Product productForm;
        Login loginForm;
        public Register( Product form, Login login )
        {
            InitializeComponent();
            productForm = form;
            loginForm = login;
        }

        public static List<User> users = new List<User>()
        {
            new User{
                Name = "Tamerlan",
                Surname = "Latifli",
                Email = "tamerlan@email.com",
                Password = "tamerlan123",
                Username = "tamerlanlatifli"
            }
        };

        private void btnRegister_Click(object sender, EventArgs e)
        {

            User user = new User
            {
                Name = txtRegName.Text,
                Password = txtRegPassword.Text,
                Email = txtRegEmail.Text,
                Surname = txtRegSurname.Text,
                Username = txtRegUsername.Text
            };

            
            Register.users.Add(user);

            this.Close();
            loginForm.Close();
            productForm.Show();
        }
    }
}
