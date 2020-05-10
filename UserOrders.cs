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
    public partial class UserOrders : Form
    {
        public UserOrders()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddComboBox()
        {

            using (var context = new MyDbContext())
            {
                List<string> categorys = context.Orders.Select(c => c.CreatedDate.ToString()).ToList();
                System.Object[] ItemObject = new System.Object[categorys.Count()];
                ItemObject[0] = "Все категории";
                for (int i = 0; i < categorys.Count() ; i++)
                {
                    ItemObject[i] = categorys[i];
                }
                comboBox1.Items.AddRange(ItemObject);
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            if (comboBox1.SelectedItem != null)
            {
                string sort = comboBox1.SelectedItem.ToString();
                List<string> prod = new List<string>();
                using (var context = new MyDbContext())
                {



                    var ordid = context.Orders.Where(b => b.CreatedDate.ToString() == sort).FirstOrDefault();
                    foreach (var temp in ordid.Products)
                    {
                        prod.Add(temp.Name);

                    }
                    ItemOrderList[] listItems = new ItemOrderList[prod.Count()];
                    int count = 0;
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    foreach (var temp in prod)
                    {
                        listItems[count] = new ItemOrderList();
                        listItems[count].Tittle = temp;
                        //listItems[i].BackColor = Color.Silver;
                        listItems[count].Left = (this.ClientSize.Width - listItems[count].Width) / 2;
                        
                        listItems[count].Top = (this.ClientSize.Height - listItems[count].Height) / 2;
                        listItems[count].Anchor = AnchorStyles.None;

                        flowLayoutPanel1.Controls.Add(listItems[count]);
                        count++;
                    }
                }
            }
        }
        private void UserOrders_Load(object sender, EventArgs e)
        {
            AddComboBox();
        }
    }
}
