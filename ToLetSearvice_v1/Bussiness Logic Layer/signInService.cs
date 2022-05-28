using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetSearvice_v1.Data_Access_Layer;


namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class signInService
    {
        user newUser = new user();
        dataAccessService accessService = new dataAccessService();
        public bool cheak_email_validity(string email,string password)
        {
           
            newUser.password = password;
            newUser.email = email;
            
            bool isEmailValid = accessService.isDataValid(newUser.email,newUser.password);
            if (isEmailValid)
            {

                return true;
            }
            else
            {

                return false;

            }


        }

    }

    
}
