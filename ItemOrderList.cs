using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfProd
{
    public partial class ItemOrderList : UserControl
    {
        private string _title;
        [Category("Custom Props")]
        public string Tittle
        {
            get { return _title; }
            set { _title = value; label1.Text = "Имя товара: " + value; }
        }
        public ItemOrderList()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ItemOrderList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ItemOrderList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
