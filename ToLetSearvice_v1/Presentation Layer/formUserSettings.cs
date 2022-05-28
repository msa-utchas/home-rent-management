using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToLetSearvice_v1.Bussiness_Logic_Layer;
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formUserSettings : MaterialForm
    {
        user userData = new user();
        dataRetriveSearvice dataRetrive = new dataRetriveSearvice();
        userProfileUpdateSearvice updateSearvice = new userProfileUpdateSearvice();
        public formUserSettings(string email)
        {
            
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            userData = dataRetrive.getUserdata(email);
            tName.Text = userData.name;
            lEmail.Text = userData.email;
            lGender.Text = userData.gender;
            tPhoneNumber.Text = userData.phoneNumber;
            if (userData.img!=null)
            {
                MemoryStream stream1 = new MemoryStream(userData.img);
                var pic1 = Image.FromStream(stream1);
                pictureBox1.Image = pic1;
            }
           

        }

        private void buttonGohome_Click(object sender, EventArgs e)
        {
            formHome f = new formHome(userData.email);
            this.Hide();
            f.Show();
        }

        private void bEditUserName_Click(object sender, EventArgs e)
        {
            updateSearvice.updateNameSearvice(userData.email, tName.Text.ToString());
            MessageBox.Show("name updated");
        }

        private void bEditNumber_Click(object sender, EventArgs e)
        {
            updateSearvice.updatePhoneNumberSearvice(userData.email, tPhoneNumber.Text.ToString());
            MessageBox.Show("phone  updated");
        }

        private void bUpdatePic_Click(object sender, EventArgs e)
        {
            byte[] img1 = null;
            string imgloc = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgloc = dlg.FileName.ToString();
                pictureBox1.ImageLocation = dlg.FileName.ToString();
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img1 = br.ReadBytes((int)fs.Length);
                updateSearvice.updateProfilePictueSearvice(userData.email, img1);
            }
        }
    }
}
