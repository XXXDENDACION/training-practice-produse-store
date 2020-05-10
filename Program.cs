using System;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;
using System.Linq;
using System.Collections.Generic;
using System.Net.Mime;

namespace ShopOfProd
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new MyDbContext())
            {
                
                //foreach (Order prod in client.Orders)
                //{
                //    a += prod.Id + " ";
                //}
                //MessageBox.Show(a.ToString());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartPage());
            
            
        }
    }
}
