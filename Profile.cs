using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;
using System.Linq;


namespace ShopOfProd
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            ShowProfile();
        }

        private void ShowProfile()
        {
            int FindId = DataId.GlobalId;
            using (var context = new MyDbContext())
            {
                var users = context.Users;
                foreach (User u in users)
                {
                    if (u.Id == FindId)
                    {
                        txtFullname.Text = u.FullName;
                        txtLogin.Text = u.LogName;
                        txtStatus.Text = u.Status;
                        
                    }
                }
     

            }
        }
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Form1 StartDialog = new Form1();
            StartDialog.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int FindId = DataId.GlobalId;
            using (var context = new MyDbContext())
            {
                var user = context.Users
                            .Where(b => b.Id == FindId)
                            .FirstOrDefault();

                user.FullName = txtFullname.Text.Trim();
                user.LogName = txtLogin.Text.Trim();
                user.Status = txtStatus.Text.Trim();
                context.SaveChanges();
                MessageBox.Show("Данные изменились!");
            }
        }
    }
}
