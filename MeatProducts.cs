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
    public partial class MeatProducts : Form
    {
        public MeatProducts()
        {
            InitializeComponent();
            AddComboBox();
        }
        private void AddComboBox()
        {

            using (var context = new MyDbContext())
            {
                List<string> categorys = context.CategoryProduct.Select(c => c.Name).ToList();
                System.Object[] ItemObject = new System.Object[categorys.Count() + 1];
                ItemObject[0] = "Все категории";
                for (int i = 1; i < categorys.Count() + 1; i++)
                {
                    ItemObject[i] = categorys[i - 1];
                }
                comboBox1.Items.AddRange(ItemObject);
            }
        }
        private void populateItems()
        {

            using (var context = new MyDbContext())
            {
                var prods = context.Products;
                ListItemProduct[] listItems = new ListItemProduct[prods.Count()];
                int count = 0;
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                foreach (Product u in prods)
                {
                    listItems[count] = new ListItemProduct();
                    //listItems[i].BackColor = Color.Silver;
                    listItems[count].Tittle = u.Name;
                    listItems[count].Message = u.AboutFood;
                    listItems[count].Price = (u.Price);
                    listItems[count].id = u.Id;



                    flowLayoutPanel1.Controls.Add(listItems[count]);
                    count++;
                }
            }
        }

        private void MeatProducts_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string sort = comboBox1.SelectedItem.ToString();
                List<Product> prod;
                using (var context = new MyDbContext())
                {
                    if (sort == "Все категории")
                    {
                        prod = context.Products.Select(b => b).ToList();
                    }
                    else
                    {
                        prod = context.Products
                                               .Where(b => b.Category.Name == sort)
                                               .ToList();
                    }
                    IEnumerable<Product> prodSort = from prods in prod orderby prods.Name select prods;
                    ListItemProduct[] listItems = new ListItemProduct[prodSort.Count()];
                    int count = 0;
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (Product u in prodSort)
                    {
                        listItems[count] = new ListItemProduct();
                        //listItems[i].BackColor = Color.Silver;
                        listItems[count].Tittle = u.Name;
                        listItems[count].Message = u.AboutFood;
                        listItems[count].Price = (u.Price);
                        listItems[count].id = u.Id;


                        flowLayoutPanel1.Controls.Add(listItems[count]);
                        count++;
                    }
                }
            }
        }
    }
    
}
