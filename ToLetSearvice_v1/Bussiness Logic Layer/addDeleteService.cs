using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetSearvice_v1.Data_Access_Layer;

namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class addDeleteService
    {
        dataAccessService accessService = new dataAccessService();
        public void deleteAddData(int id)
        {
            accessService.deleteAddData(id);
        }
    }
}
