using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ToLetSearvice_v1.Bussiness_Logic_Layer;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formSignUpEmailVerify : MaterialForm

    {
        string userName, phoneNumber, password, gender, email;
        string verificationCode;
        signUpSearvice signUp = new signUpSearvice();
        public formSignUpEmailVerify(string vCode, string name, string phnNumber, String pass, string gen, string mail)
        {
            InitializeComponent();
            userName = name;
            phoneNumber = phnNumber;
            password = pass;
            gender = gen;
            email = mail;
            verificationCode = vCode;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if(tVerificationcode.Text.ToString()==verificationCode)
            {
                signUp.createUser(userName, phoneNumber, password, gender, email);
                MessageBox.Show("user created");
                this.Hide();
                formSignIn f = new formSignIn();
                f.Show();
            }
            else
            {
                MessageBox.Show("code mismatch");
            }
        }
    }
}
