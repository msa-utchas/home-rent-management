using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToLetSearvice_v1.Presentation_Layer
{
    public partial class userControlSearchRentAdd : UserControl
    {
        string type1, availableFor1, location1, rent1, phonenumber1, details1;
        int id1;
        Image pic1, pic2;
        public userControlSearchRentAdd(string type, string availableFor, string location, string rent, int id, Image img1, Image img2, string phonenumber, string details)
        {
            InitializeComponent();
            ltype.Text = type;
            lAvailableFor.Text = availableFor;
            lLocation.Text = location;
            lRent.Text = rent;
            pictureBox1.Image = img1;
            type1 = type;
            availableFor1 = availableFor;
            location1 = location;
            rent1 = rent;
            phonenumber1 = phonenumber;
            details1 = details;
            id1 = id;
            pic1 = img1;
            pic2 = img2;
        }

        private void bViewDetails_Click(object sender, EventArgs e)
        {
            formAddDetails f = new formAddDetails(type1, availableFor1, location1, rent1, id1, pic1, pic2, phonenumber1, details1);
            f.Show();
        }
    }
}
