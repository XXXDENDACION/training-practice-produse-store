using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;

namespace ShopOfProd
{
    public partial class AuthorizationForm : Form
    {
        User user = new User();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regexuser = new Regex(@"\^[a-z0-9_-]{3,16}$");
            user.FullName = txtFullname.Text.Trim();
            user.LogName = txtLogin.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            MatchCollection matchesuser = regexuser.Matches(user.FullName);
            MatchCollection matchlog = regexuser.Matches(user.FullName);
            MatchCollection matchpass = regexuser.Matches(user.FullName);

            using (var context = new MyDbContext())
            {
                if (user.FullName == "" || user.LogName == "" || user.Password == "")
                {
                    MessageBox.Show("Не все поля введены");
                }
                else if (matchesuser.Count == 0)
                {
                    MessageBox.Show("Введите корректное имя(минимум 3 символа)");
                }
                else if(matchlog.Count == 0)
                {
                    MessageBox.Show("Введите корректный логин(минимум 3 символа)");

                }
                else if (matchpass.Count == 0)
                {
                    MessageBox.Show("Введите корректный пароль(минимум 3 символа)");

                }
                else
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешна");
                }
            }
            
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            StartPage StartDialog = new StartPage();
            StartDialog.Show();
            Hide();
        }
    }
}
