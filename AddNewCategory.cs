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
    public partial class AddNewCategory : Form
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryProducts cat = new CategoryProducts();
            if(maskedTextBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели значение");
            }
            using(var context = new MyDbContext())
            {
                cat.Name = maskedTextBox1.Text;
                if(cat != null)
                {
                    context.CategoryProduct.Add(cat);
                    context.SaveChanges();
                    MessageBox.Show("Новая категория добавлена");
                    AddProduct add = new AddProduct();
                    add.Show();
                    Close();
                }
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
            Close();
        }
    }
}
