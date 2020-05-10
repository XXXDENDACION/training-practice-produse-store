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

    
    public partial class AuthorizationFormTrue : Form
    {
        

        public AuthorizationFormTrue()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            StartPage StartDialog = new StartPage();
            StartDialog.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsTrueAdmin = false;
            bool IsTrueKassir = false;
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля введены");
            }
            using (var context = new MyDbContext())
            {
                //var user = context.Users
                //                  .Where(b => b.LogName == txtLogin.Text.Trim() && b.Password == txtPassword.Text.Trim())
                //                  .FirstOrDefault();
                var users = from b in context.Users
                            where b.LogName == txtLogin.Text.Trim() && b.Password == txtPassword.Text.Trim()
                            select b;
                if (users.Count() == 0)
                {
                    MessageBox.Show("Введены неправильный логин или пароль");
                }
                else
                {
                    MessageBox.Show("Вы успешно авторизовались");
                    foreach (User u in users)
                    {
                        if (u.Status == "admin")
                        {
                            IsTrueAdmin = true;
                            DataId.GlobalId = u.Id;
                            DataId.IsAdmin = true;
                            break;
                        }
                        else if (u.Status == "kassir")
                        {
                            IsTrueKassir = true;
                            DataId.IsAdmin = false;
                            DataId.GlobalId = u.Id;
                            break;
                        }
                        else
                        {
                            DataId.GlobalId = u.Id;
                        }

                    }
                    if (IsTrueAdmin)
                    {
                        AdminInterface admin = new AdminInterface();
                        admin.Show();
                        Hide();
                    }
                    else if(IsTrueKassir)
                    {
                        KassirInterface form = new KassirInterface();
                        form.Show();
                        Hide();
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        Hide();
                    }

                }
                //foreach(User u in users)
                //{
                //    if(u.LogName == txtLogin.Text.Trim() && u.Password == txtPassword.Text.Trim())
                //    {
                //        MessageBox.Show("Вы успешно авторизовались");
                //        DataId.GlobalId = u.Id;
                //        if (u.Status == "admin")
                //        {
                //            AdminInterface admin = new AdminInterface();
                //            admin.Show();
                //            Hide();
                //            lean = false;

                //        }
                //        else if(u.Status != "admin")
                //        {
                //            Form1 page = new Form1();
                //            page.Show();
                //            Hide();
                //            lean = false;

                //        }

                //    }    
                //}
                
            }
        }
    }
    static class DataId
    {
        public static bool IsAdmin { get; set; }
        public static int GlobalId { get; set; }
    }
}
