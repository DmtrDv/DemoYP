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
        private List<Products> allProducts_;
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
            LoadProduct();
            findText_toolStripTextBox.TextChanged += findText_toolStripTextBox_TextChanged;
        }
        private void LoadProduct()
        {
            try
            {
                //получаем данные из бд
                allProducts_ = Database.GetAllProducts();
                // отображаем товары
                ShowOnDisplayProducts(allProducts_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки товаров: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOnDisplayProducts(List<Products> products)
        {
            MainPanel_flowLayoutPanel.Controls.Clear();
            if (products.Count == 0)
            {
                return;
            }
            foreach (Products product in products)
            {
                var card = new ProductCard();
                card.SetProduct(product);
                MainPanel_flowLayoutPanel.Controls.Add(card);
            }
        }
        private void WindowWatchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void findText_toolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = findText_toolStripTextBox.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                ShowOnDisplayProducts(allProducts_);
            }
            else
            { 
                List<Products> needProducts = new List<Products>();
                foreach (Products product in allProducts_)
                {
                    string searchableText = allAtributsForSearch(product);
                    bool visible = searchableText.ToLower().Contains(searchText);
                    if (visible == true)
                    {
                        needProducts.Add(product);
                    }
                }
                ShowOnDisplayProducts(needProducts);
            }
        }
        private string allAtributsForSearch(Products product)
        {
            string searchableText = $@"
                {product.name} ,
                {product.category} ,
                {product.description} ,
                {product.manufacturer} ,
                {product.supplier} ,
                {product.unit}
            ".ToLower();
            return searchableText;
        }
    }
}
