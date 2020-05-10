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
    public partial class ItemBasket : UserControl
    {
        public ItemBasket()
        {
            InitializeComponent();
        }
        private string _title;
        private string _message;
        private Image _icon;
        private int _price;
        private int _id;

        [Category("Custom Props")]
        public string Tittle
        {
            get { return _title; }
            set { _title = value; lblTtitle.Text = "Название: " + value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = "Описание: " + value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public int Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = "Цена: " + value.ToString(); }
        }
        [Category("Custom Props")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InBasketId.ListBasketId.Remove(_id);
            MessageBox.Show("Товар был удален из корзины");
            if (ShoppingBasket.SelfRef != null)
                ShoppingBasket.SelfRef.populateItems();
            
        }
    }
}
