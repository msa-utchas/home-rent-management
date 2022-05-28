using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ToLetSearvice_v1.Data_Access_Layer
{
    class getUserData
    {
        public user getData(string email)
        {
            user currentUser = new user(); ;
            SqlConnection con = new SqlConnection("Data Source=UTCHAS-PC;Initial Catalog=tolet_home;Integrated Security=True");
            string query = "select * from userInfo where email='" + email + "'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    currentUser.name= (string)(reader[1]);
                    currentUser.email= (string)(reader[2]);
                    currentUser.gender= (string)(reader[3]);
                    currentUser.phoneNumber= (string)(reader[4]);
                    currentUser.password= (string)(reader[5]);
                   
                    if (!Convert.IsDBNull(reader[6]))
                    {
                        currentUser.img = (byte[])(reader[6]);
                    }
                }
            }


            con.Close();
                    
            return currentUser;
        }
    }
}
