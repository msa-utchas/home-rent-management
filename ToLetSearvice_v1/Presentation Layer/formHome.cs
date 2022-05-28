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
using ToLetSearvice_v1.Data_Access_Layer;
using ToLetSearvice_v1.Bussiness_Logic_Layer;
using System.IO;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class formHome : MaterialForm
    {
        user currentUser = new user();
        dataRetriveSearvice dataRetrive = new dataRetriveSearvice();
        public formHome(string email)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            
            currentUser= dataRetrive.getUserdata(email);
            lName.Text = currentUser.name;

        }

        private void bPostAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPostAdd f = new formPostAdd(currentUser.email);
            f.Show();
        }

        private void bPostedAdd_Click(object sender, EventArgs e)
        {
            formShowRenterAdd f = new formShowRenterAdd(currentUser.email);
            this.Hide();
            f.Show();
            
        }

        private void bSearchRent_Click(object sender, EventArgs e)
        {
            formSearchForRent f = new formSearchForRent(currentUser.email);
            this.Hide();
            f.Show();
        }

        private void bUserSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUserSettings f = new formUserSettings(currentUser.email);
            f.Show();
        }
    }
}
