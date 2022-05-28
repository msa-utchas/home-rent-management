using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToLetSearvice_v1.Bussiness_Logic_Layer;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formSignUp : MaterialForm
    {
        signUpSearvice signUpSearvice1 = new signUpSearvice();
        public formSignUp()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
           

            if(string.IsNullOrWhiteSpace(tEmail.Text)|| string.IsNullOrWhiteSpace(tName.Text) || string.IsNullOrWhiteSpace(tPhoneNumber.Text) || string.IsNullOrWhiteSpace(tPassword.Text) || string.IsNullOrWhiteSpace(tConfirmPassword.Text) || cBGender.SelectedItem == null)
            {
                MessageBox.Show("input everything");
            }
            else
            {
                string email = tEmail.Text.ToString();
                var email_valid = new EmailAddressAttribute();
                bool isvalid = email_valid.IsValid(email);
                string name = tName.Text.ToString();
                string gender = cBGender.SelectedItem.ToString();
                string phoneNumber = tPhoneNumber.Text.ToString();
                string password = tPassword.Text.ToString();
                if (tPassword.Text!=tConfirmPassword.Text)
                {
                    MessageBox.Show("password not match");
                }
                else if (!isvalid)
                {
                    MessageBox.Show("email is not valid");
                }
                else if (tPassword.Text.Length < 8) 
                {
                    MessageBox.Show("password must be 8 character long");
                }
                else
                
                {
                    bool isValidEmail = signUpSearvice1.cheak_email_validity(name, phoneNumber, password, gender, email);
                    if(isValidEmail)
                    {
                        MessageBox.Show("email already exsits");
                    }
                    else
                    {
                        string vCode = signUpSearvice1.send_verification_code();
                        formSignUpEmailVerify f = new formSignUpEmailVerify(vCode, name, phoneNumber, password, gender, email);
                        this.Hide();
                        f.Show();
                    }
                }

            }
            
        }

        private void bLoginPage_Click(object sender, EventArgs e)
        {
            formSignIn f = new formSignIn();
            this.Hide();
            f.Show();
        }
    }
}
