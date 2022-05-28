using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class signUpSearvice
    {
        user newUser = new user();
        dataAccessService accessService = new dataAccessService();
      
        public bool cheak_email_validity(string name, string phoneNumber, String password, string gender, string email)
        {
            newUser.name = name;
            newUser.password = password;
            newUser.gender = gender;
            newUser.email = email;
            newUser.phoneNumber = phoneNumber;
            bool isEmailValid=accessService.isDataValid(newUser);
            if(isEmailValid)
            {
               
                return true;
            }
            else
            {
                
                return false;

            }
            
            
        }
        public string send_verification_code()
        {
            emailSearvice mail = new emailSearvice();
            Random random = new Random();
            int vCode = random.Next(10000, 99999);

            mail.send_email("verification", vCode.ToString(), newUser.email);
            string verificationCode = vCode.ToString();
            return verificationCode;
        }
        public void createUser(string name, string phoneNumber, String password, string gender, string email)
        {
            newUser.name = name;
            newUser.password = password;
            newUser.gender = gender;
            newUser.email = email;
            newUser.phoneNumber = phoneNumber;
            accessService.insertUserData(newUser);
        }
    }
}
