using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE_Lib;

namespace DE_Forms
{
    public partial class AuthorizationForm: Form
    {
        private User user_ = new User();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string userLogin = login_textBox.Text;
            string userPassword = password_textBox.Text;
            if (userLogin == user_.login && userPassword == user_.password)
            {
                string userRole = user_.role;
                WindowWatchingForm windowWatchingForm = new WindowWatchingForm(userRole);

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
