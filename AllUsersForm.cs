using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;
using Microsoft.Office.Interop.Excel;


using Excel = Microsoft.Office.Interop.Excel;
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

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new MyDbContext())
            {
                var users = context.Users.Select(b => b).ToList();
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                DateTime dt = DateTime.Now;
                worksheet.Name = "Отчет за " + dt.ToShortDateString().ToString();
                worksheet.Rows[1].Columns[1] = "Имя";
                worksheet.Rows[1].Columns[2] = "Логин";
                worksheet.Rows[1].Columns[3] = "Статус";
                string path = System.IO.Directory.GetCurrentDirectory() + @"\" + worksheet.Name + ".xlsx";
                for (int i = 2; i < users.Count + 1; i++)
                {
                    worksheet.Rows[i].Columns[1] = users[i - 2].FullName;
                    worksheet.Rows[i].Columns[2] = users[i - 2].LogName;
                    worksheet.Rows[i].Columns[3] = users[i - 2].Status;
                }

                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path);
                MessageBox.Show("Excel создан!");
                excelapp.Quit();
            }
        }
    }
}
