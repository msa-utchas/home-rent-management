using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class userProfileUpdateSearvice
    {
        dataAccessService accessService = new dataAccessService();
        public void updateNameSearvice(string email,string name)
        {
            accessService.updateName(email, name);
        }
        public void updatePhoneNumberSearvice(string email,string phoneNumber)
        {
            accessService.updatePhoneNumber(email, phoneNumber);
        }
        public void updateProfilePictueSearvice(string email, byte[] img)
        {
            accessService.updateProfilePictue(email, img);
        }
    }
}
