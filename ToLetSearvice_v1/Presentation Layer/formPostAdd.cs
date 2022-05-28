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
using MaterialSkin;
using MaterialSkin.Controls;
using ToLetSearvice_v1.Bussiness_Logic_Layer;


namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formPostAdd : MaterialForm

    {
        postAddService postService = new postAddService();

        byte[] img1 = null;
        byte[] img2 = null;

        string currentUserEmail;
        public formPostAdd(string uEmail)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            currentUserEmail = uEmail;
        }

        private void bUploadPic1_Click(object sender, EventArgs e)
        {
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
            }
            
        }

        private void bUploadPic2_Click(object sender, EventArgs e)
        {
            string imgloc = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgloc = dlg.FileName.ToString();
                pictureBox2.ImageLocation = dlg.FileName.ToString();
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img2 = br.ReadBytes((int)fs.Length);
            }
           
        }

        private void bPostAdd_Click(object sender, EventArgs e)
        {
            if (cBType.SelectedItem == null || cBAvailableFor.SelectedItem == null || cBLocation.SelectedItem == null || string.IsNullOrWhiteSpace(tPhonenumber.Text) || string.IsNullOrWhiteSpace(tPrice.Text) || string.IsNullOrWhiteSpace(tLocationAndDetails.Text))
            {
                MessageBox.Show("input everything");
            }
            else if (img1 == null || img2 == null)
            {
                MessageBox.Show("upload images");
            }
            else
            {
                try
                {
                    int rent_price = Convert.ToInt32(tPrice.Text);
                    postService.postAddData(cBType.SelectedItem.ToString(), cBAvailableFor.SelectedItem.ToString(), cBLocation.SelectedItem.ToString(), currentUserEmail, tPhonenumber.Text, img1, img2, tPrice.Text, tLocationAndDetails.Text);
                    MessageBox.Show("post inserted");
                    //replace with form
                    this.Hide();
                    formPostAdd f = new formPostAdd(currentUserEmail);
                    f.Show();

                }
                catch (Exception f)
                {
                    MessageBox.Show("please provide numbers only");
                }
            }
        }

        private void bGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHome f = new formHome(currentUserEmail);
            f.Show();
        }
    }
}
