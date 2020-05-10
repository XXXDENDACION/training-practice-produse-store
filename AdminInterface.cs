using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfProd
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
           
            panelSubFAQ.Visible = false;
        }
        private void hideSubMenu()
        {
           
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
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubFAQ);
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            AllUsersForm all = new AllUsersForm();
            all.Show();
            Hide();
        }

        private void btnClientandCassir_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            start.Show();
            Hide();
        }

        private void btnPROD_Click(object sender, EventArgs e)
        {
            AllProducts prod = new AllProducts();
            prod.Show();
            Hide();
        }
    }
}
