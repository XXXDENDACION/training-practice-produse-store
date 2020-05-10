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
    public partial class AllUsersForm : Form
    {
        public static AllUsersForm SelfRef { get; set; }
        public AllUsersForm()
        {
            SelfRef = this;
            InitializeComponent();
        }
        public  void RefreshPage()
        {
            this.Update();
        }
        public void populateItems()
        {

            using (var context = new MyDbContext())
            {
                var users = from b in context.Users
                            where b.Status != "admin"
                            select b;
        ListUserItem[] listItems = new ListUserItem[users.Count()];
                int count = 0;
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                foreach (User u in users)
                {
                    listItems[count] = new ListUserItem();
                    //listItems[i].BackColor = Color.Silver;
                    listItems[count].id = u.Id;
                    listItems[count].Tittle = u.FullName;
                    listItems[count].Message = u.Status;
                    listItems[count].Log = u.LogName;
                    
                   
                    flowLayoutPanel1.Controls.Add(listItems[count]);
                    count++;
                }
            }
           
        }
       
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            AdminInterface admin = new AdminInterface();
            admin.Show();
            Hide();
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            populateItems();
        }

       
    }
}
