using DE_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Forms
{
    public partial class WindowWatchingForm: Form
    {
        public WindowWatchingForm(User user)
        {
            InitializeComponent();
            this.Text = $"Окно просмотра: {user.role}";
        }

        private void WindowWatchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
