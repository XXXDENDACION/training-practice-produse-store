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

namespace ShopOfProd
{
    public partial class ListUserItem : UserControl
    {
        
        public ListUserItem()
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
        private Color _iconBack;
        private int _id;
        private string _logname;

        [Category("Custom Props")]
        public string Tittle
        {
            get { return _title; }
            set { _title = value; lblTtitle.Text = "Имя: " + value; }
        }
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = "Статус: "+value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        [Category("Custom Props")]
        public Color BackgroudColor
        {
            get { return _iconBack; }
            set { _iconBack = value; }
        }
        [Category("Custom Props")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Category("Custom Props")]
        public string Log
        {
            get { return _logname; }
            set { _logname = value; lblLog.Text = "Логин: " +value; }
        }
        
    

        private void ListUserItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListUserItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
     
            using(var context = new MyDbContext())
            {
                var user = context.Users.Where(c => c.Id == id).FirstOrDefault();
                if( user == null)
                {
                    return;
                }
                else
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("Пользователь  " + user.FullName + "  удален");
                 if(AllUsersForm.SelfRef != null)
                     AllUsersForm.SelfRef.populateItems();
                    
                }
            }
        }
    }
    #endregion
}
