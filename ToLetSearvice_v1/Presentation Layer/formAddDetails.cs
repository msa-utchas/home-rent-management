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


namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formAddDetails : MaterialForm

    {
        public formAddDetails(string type, string availableFor, string location, string rent, int id, Image img1, Image img2, string phonenumber, string details)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);

            lType.Text = type;
            lAvailabeFor.Text = availableFor;
            lLocation.Text = location;
            LRentPrice.Text = rent;
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
            lPhoneNumber.Text = phonenumber;
            tLocationAndDetails.Text = details;
        }

        private void bGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
