using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLetSearvice_v1.Data_Access_Layer
{
    class rentData
    {
        public int id { get; set; }
        public string type { get; set; }
        public string availableFor { get; set; }
        public string location { get; set; }
        public string renterEmail { get; set; }
        public string renterPhoneNumber { get; set; }
        
        public byte[] img1 { get; set; }
        public byte[] img2 { get; set; }
        public string price { get; set; }
        public string locationAndDetails { get; set; }
    }
}
