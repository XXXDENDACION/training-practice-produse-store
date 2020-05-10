using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopOfProd.Context;
using ShopOfProd.Models;

namespace ShopOfProd
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            set { _message = value; lblMessage.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        
        [Category("Custom Props")]
        public int  Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var prod = context.Products.Where(c => c.Id == id).FirstOrDefault();
                if (prod == null)
                {
                    return;
                }
                else
                {
                    context.Products.Remove(prod);
                    context.SaveChanges();
                    MessageBox.Show("Товар  " + prod.Name + "  удален");
                    if (AllProducts.SelfRef != null)
                        AllProducts.SelfRef.populateItems();

                }
            }
        }
    }
}
