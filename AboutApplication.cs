using System.Windows.Forms;

namespace ShopOfProd
{
    public partial class AboutApplication : Form
    {
        public AboutApplication()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                label3.Text = "Под функционалом кассира, у вас будет доступна \n" +
                    " добавления" +
"                                       новых товаров ";
            }
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                label3.Text = "Под функционалом кассира, у вас будет доступна \n" +
                    " добавления" +
"                                       новых товаров ";
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, System.EventArgs e)
        {
            label3.Text = "";
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                label3.AutoSize = true;
                label3.Text = "Здесь, будучи клиентом, вы сможете просматривать " +
                    "\n товары, добавлять их в корзину и оформлять заказ. ";
            }
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            label3.Text = "";
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                label3.AutoSize = true;
                label3.Text = "В функционал администратора входит \n  возможность  просмотра клиентов,\n их удаления, а так же  весь функционал кассира. ";
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, System.EventArgs e)
        {
            label3.Text = "";
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                label3.AutoSize = true;
                label3.Text = "Под функционалом кассира, у вас будет доступна \n" +
                    " добавление новых товаров ";

            }
        }
    }
}
