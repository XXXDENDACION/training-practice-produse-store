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
   
    public partial class ListItemProduct : UserControl
    {
       
        public ListItemProduct()
        {
            InitializeComponent();
        }
        #region MyProperty
        private string _title;
        private string _message;
        private Image _icon;
        private int _price;
        private int _id;

        [Category("Custom Props")]
        public string Tittle
        {
            get { return _title; }
            set { _title = value; lblTtitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text ="Описание: " + value; }
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
            set { _price = value; lblPrice.Text = "Цена: " +value.ToString(); }
        }
        [Category("Custom Props")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


        #endregion
        private void ListItemProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InBasketId.Record(_id);
            MessageBox.Show("Товар был добавлен в корзину");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class InBasketId
    {
        public static List<int> ListBasketId;
        static InBasketId()
        {
            ListBasketId = new List<int>();
        }
        public static void Record(int value)
        {
            ListBasketId.Add(value);
        }

    }
}
