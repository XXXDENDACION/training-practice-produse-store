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

namespace ShopOfProd
{
    public partial class AllProductsGuest : Form
    {
        public AllProductsGuest()
        {
            InitializeComponent();
            populateItems();
        }
        private void populateItems()
        {
           
            
               
                using (var context = new MyDbContext())
                {



                var ordid = context.Products.Select(b => b).ToList();
                    
                    ItemOrderList[] listItems = new ItemOrderList[ordid.Count()];
                    int count = 0;
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (var temp in ordid)
                    {
                        listItems[count] = new ItemOrderList();
                        listItems[count].Tittle = temp.Name;
                        //listItems[i].BackColor = Color.Silver;
                       

                        flowLayoutPanel1.Controls.Add(listItems[count]);
                        count++;
                    }
                }
            
        }
    }
}
