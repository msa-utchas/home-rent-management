using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    
    class dataRetriveSearvice
    {
        getUserData userData = new getUserData();
        dataAccessService dataAccess = new dataAccessService();
        public user getUserdata(string email)
        {
            return userData.getData(email);
        }
        public List<rentData> getRenterAddData(string email)
        {
            return dataAccess.getUserAddData(email);
        }
        public List<rentData> getRenterAddData(string type,string availabeFor,string location)
        {
            return dataAccess.getUserAddData(type,availabeFor,location);
        }
    }
}
