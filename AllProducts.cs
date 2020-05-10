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
    
    public partial class AllProducts : Form
    {
        public static AllProducts SelfRef { get; set; }
        public AllProducts()
        {
            SelfRef = this;
            InitializeComponent();
            AddComboBox();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (DataId.IsAdmin)
            { 
            AdminInterface admin = new AdminInterface();
            admin.Show();
            Hide();
            }
            else
            {
                KassirInterface kas = new KassirInterface();
                kas.Show();
                Hide();
            }
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
                    ItemObject[i] = categorys[i-1];
                }
                comboBox1.Items.AddRange(ItemObject);
            }
        }
        public void populateItems()
        {

            using (var context = new MyDbContext())
            {
                var prods = context.Products;
                ListItem[] listItems = new ListItem[prods.Count()];
                int count = 0;
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                foreach (Product u in prods)
                {
                    listItems[count] = new ListItem();
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
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addp = new AddProduct();
            addp.Show();
            Hide();
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
                         prod = context.Products.Select(b=>b).ToList();
                    }
                    else
                    {
                         prod = context.Products
                                                .Where(b => b.Category.Name == sort)
                                                .ToList();
                    }
                   IEnumerable<Product> prodSort = from prods in prod orderby prods.Name select prods;
                    ListItem[] listItems = new ListItem[prodSort.Count()];
                    int count = 0;
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (Product u in prodSort)
                    {
                        listItems[count] = new ListItem();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
