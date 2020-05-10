using System;
using System.Windows.Forms;

namespace ShopOfProd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelSubLC.Visible = false;
        
            panelSubFAQ.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubLC.Visible == true)
                panelSubLC.Visible = false;
            
            if (panelSubFAQ.Visible == true)
                panelSubFAQ.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        #region LC
        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLC);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserOrders usrord = new UserOrders();
            usrord.Show();
            Hide();
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }
        #endregion
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubLC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        #region PROD
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            MeatProducts meat = new MeatProducts();
            meat.Show();
            Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
            hideSubMenu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ShoppingBasket shop = new ShoppingBasket();
            shop.Show();
            Hide();
        }
        #endregion

        #region FAQ
        private void iconButton4_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubFAQ);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
           OpenChildForm(new AboutApplication());
            //...
            hideSubMenu();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }
        private void panelSubFQA_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }
        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StartPage StartDialog = new StartPage();
            StartDialog.Show();
            Hide();

        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
