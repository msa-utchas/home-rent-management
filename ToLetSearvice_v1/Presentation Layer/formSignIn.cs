using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToLetSearvice_v1.Bussiness_Logic_Layer;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formSignIn : MaterialForm
    {
        signInService signIn = new signInService();
        public formSignIn()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            tEmail.Text = "utchas.sd@gmail.com";
           tPassword.Text = "12345678";
            if(string.IsNullOrWhiteSpace(tEmail.Text)||string.IsNullOrWhiteSpace(tPassword.Text))
            {
                MessageBox.Show("input everything");
            }
            else
            {
                bool isvalid = signIn.cheak_email_validity(tEmail.Text, tPassword.Text);
                if(isvalid==true)
                {
                    this.Hide();
                    formHome f = new formHome(tEmail.Text);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("email or password is incorrect");
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSignUp signUp = new formSignUp();
            signUp.Show();
        }
    }
}
