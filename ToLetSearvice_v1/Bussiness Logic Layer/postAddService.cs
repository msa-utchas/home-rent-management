using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToLetSearvice_v1.Data_Access_Layer;


namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class postAddService
    {
        rentData rentalData = new rentData();
        dataAccessService dataAccess = new dataAccessService();
        
        public void postAddData(string type, string availableFor, string location, string renterEmail,string renterPhoneNumber, byte[] img1, byte[] img2, string price, string locationAndDetails)
        {
            rentalData.type = type;
            rentalData.availableFor = availableFor;
            rentalData.location = location;
            rentalData.renterEmail = renterEmail;
            rentalData.renterPhoneNumber = renterPhoneNumber;
            rentalData.img1 = img1;
            rentalData.img2 = img2;
            rentalData.price = price;
            rentalData.locationAndDetails = locationAndDetails;
            dataAccess.insertAddData(rentalData);
        }
        
    }

    
}
