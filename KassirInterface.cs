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
    public partial class KassirInterface : Form
    {
        public KassirInterface()
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
        private void btnPROD_Click(object sender, EventArgs e)
        {
            AllProducts all = new AllProducts();
            all.Show();
            Hide();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubFAQ);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage(); ;
            start.Show();
            Close();
        }
    }
}
