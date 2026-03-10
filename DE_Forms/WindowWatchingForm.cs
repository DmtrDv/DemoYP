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
        private Products products;
        private List<Products> allProducts;
        private List<ProductCard> allCard;
        public WindowWatchingForm(User user)
        {
            InitializeComponent();
            if (user.role == "Гость")
            {
                this.Text = $"Окно просмотра: {user.role}";
            }
            else
            {
                this.Text = $"Окно просмотра: {user.fio}";
            }
        }

        private void WindowWatchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WindowWatchingForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadProduct()
        {
            
        }
    }
}
