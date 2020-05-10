using System;
using System.Windows.Forms;

namespace ShopOfProd
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSingKassir_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
            Hide();
        }

        private void btnSignUser_Click(object sender, EventArgs e)
        {
            AuthorizationFormTrue UserDialog = new AuthorizationFormTrue();
            UserDialog.Show();
            Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
