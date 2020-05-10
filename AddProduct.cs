using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;

namespace ShopOfProd
{
    public partial class AddProduct : Form
    {
        Product prod = new Product();
        public AddProduct()
        {
            InitializeComponent();
            AddComboBox();
           
        }
        private void AddComboBox()
        {

            using (var context = new MyDbContext())
            {
                List<string> categorys = context.CategoryProduct.Select(c => c.Name).ToList();
                System.Object[] ItemObject = new System.Object[categorys.Count()];
              
                for (int i = 0; i < categorys.Count(); i++)
                {
                    ItemObject[i] = categorys[i];
                }
                comboBox1.Items.AddRange(ItemObject);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            AllProducts allp = new AllProducts();
            allp.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryProducts cat = new CategoryProducts();
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("Вы ввели не все поля");
                return;
            }
            string allows = maskedTextBox3.Text.Trim();
            for(int i = 0; i < maskedTextBox3.Text.Count(); i++)
            {
                if(allows[i] == ' ')
                {
                    MessageBox.Show("Введите корректную цену");
                    return;

                }
            }
            
                prod.Name = maskedTextBox1.Text.Trim();
            prod.AboutFood = maskedTextBox2.Text.Trim();
            prod.Price = Convert.ToInt32(maskedTextBox3.Text);
           

            using (var context = new MyDbContext())
            {
                prod.Category = context.CategoryProduct
                                .Where(b => b.Name == comboBox1.SelectedItem.ToString())
                                .FirstOrDefault();
                if (prod != null)
                {
                    context.Products.Add(prod);
                    context.SaveChanges();
                    MessageBox.Show("Продукт добавлен");
                    AllProducts allp = new AllProducts();
                    allp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить продукт");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewCategory adn = new AddNewCategory();
            adn.Show();
            Hide();
        }
    }
}
