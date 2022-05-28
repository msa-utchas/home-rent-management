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
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formSearchForRent : MaterialForm
    {
        dataRetriveSearvice dataRetrive = new dataRetriveSearvice();
        List<rentData> rentalData;
        string userEmail;
        public formSearchForRent(string mail)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            userEmail = mail;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if(cBAvailableFor.SelectedItem==null||cBLocation.SelectedItem==null||cBType.SelectedItem==null)
            {
                MessageBox.Show("input all the parametre");
            }
            else
            {
                flowLayoutPanel.Controls.Clear();
                rentalData = dataRetrive.getRenterAddData(cBType.SelectedItem.ToString(), cBAvailableFor.SelectedItem.ToString(), cBLocation.SelectedItem.ToString());
                foreach (var d in rentalData)
                {
                    if (d.renterEmail == userEmail)
                    {
                        continue;
                    }
                    else
                    {
                        MemoryStream stream1 = new MemoryStream(d.img1);
                        var pic1 = Image.FromStream(stream1);
                        MemoryStream stream2 = new MemoryStream(d.img2);
                        var pic2 = Image.FromStream(stream2);
                        userControlSearchRentAdd t = new userControlSearchRentAdd(d.type, d.availableFor, d.location, d.price, d.id, pic1, pic2, d.renterPhoneNumber, d.locationAndDetails);
                        flowLayoutPanel.Controls.Add(t);
                    }
                    
                }

            }
        }

        private void buttonGohome_Click(object sender, EventArgs e)
        {
            formHome f = new formHome(userEmail);
            this.Hide();
            f.Show();
        }
    }
}
