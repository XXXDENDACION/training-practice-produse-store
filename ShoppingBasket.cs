using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;

namespace ShopOfProd
{
    public partial class ShoppingBasket : Form
    {
        int totalPrice = 0;
        public static ShoppingBasket SelfRef { get; set; }
        public ShoppingBasket()
        {
            SelfRef = this;
            InitializeComponent();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
        ICollection<Product> prodInBasket = new List<Product>();
        public void populateItems()
        {
            label4.Show();
            using (var context = new MyDbContext())
            {

                //EntityCollection<Product> prodList = new EntityCollection<Product>();
                foreach (var value in InBasketId.ListBasketId)
                {
                   
                    var prod = context.Products.Where(b=>b.Id == value).FirstOrDefault();
                    
                 
                        //.Where(b => b.Id == value)
                        //.FirstOrDefault();
                    prodInBasket.Add(prod);
                }
                
              
                ItemBasket[] listItems = new ItemBasket[prodInBasket.Count()];
                int count = 0;
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                
                foreach (var value in prodInBasket)
                {
                    label4.Hide();
                    //label4.Text = "";
                    listItems[count] = new ItemBasket();
                    //listItems[i].BackColor = Color.Silver;
                    listItems[count].Tittle = value.Name;
                    listItems[count].Message = value.AboutFood;
                    listItems[count].Price = (value.Price);
                    listItems[count].id = value.Id;
                    totalPrice += value.Price;



                    flowLayoutPanel1.Controls.Add(listItems[count]);
                    count++;
                }
            }
            prodInBasket.Clear();
        }
        public void AddToOrder()
        {
 
            
            User client;
            if (prodInBasket != null)
            {
                using (var context = new MyDbContext())
                {
                    Order ord = new Order();
                
                    //foreach (var value in InBasketId.ListBasketId)
                    //{
                    //    //var produ = context.Products.Where(b => b.Id == value).FirstOrDefault();
                    //    //var cat = context.CategoryProduct.Where(b => b.Id == produ.categoryId).FirstOrDefault();
                    //    //produ.Category = cat;
                    //    //orderproduct.Add(produ);
                    //    orderproduct.Add(context.Products.Where(b => b.Id == value).FirstOrDefault());
                       


                    //}
                   
                    
                    
                    client = context.Users.Find(DataId.GlobalId);
                    ord.userId = client.Id;
                    //ord.Products = prodInBasket;
                    ord.CreatedDate = DateTime.Now;
                    //foreach (var value in InBasketId.ListBasketId)
                    //{
                    //    var oderid = context.Products.Where(b => b.Id == value).FirstOrDefault();
                    //    oderid.orders.Add(ord);
                    //}   
                    
                    context.Orders.Add(ord);
                    context.SaveChanges();
                    foreach (var value in InBasketId.ListBasketId)
                    {
                        var produ = context.Products.Where(b => b.Id == value).FirstOrDefault();
                        produ.orders.Add(ord);
                    }
                    context.SaveChanges();
                    foreach (var value in InBasketId.ListBasketId)
                    {
                        ord.Products.Add(context.Products.Where(b => b.Id == value).FirstOrDefault());
                    }
                    context.SaveChanges();
                    client.Orders.Add(ord);

                    context.SaveChanges();
                    
                }
                //using(var context = new MyDbContext())
                //{
                //    //.Entry(ord).State = EntityState.Modified;
                //    context.Users.Attach(client);
                //    client.Orders.Add(ord);
                //    context.SaveChanges();
                //}
            }
            
            
        }
        private void ShoppingBasket_Load(object sender, EventArgs e)
        {
            populateItems();
            label2.Text = "Общая сумма: " + totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num;
            string str = textBox1.Text;
            bool isNum = int.TryParse(str, out Num);
            if (!isNum)
            {
                MessageBox.Show("Введите число");
                return;
            }
            else
            {
                if (Convert.ToInt32(textBox1.Text.Trim()) >= totalPrice)
                {
                    MessageBox.Show("Товар оплачен");
                    AddToOrder();
                    InBasketId.ListBasketId.Clear();
                    populateItems();
                    



                }
                else MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
