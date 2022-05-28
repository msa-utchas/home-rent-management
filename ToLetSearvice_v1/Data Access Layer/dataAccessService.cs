using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ToLetSearvice_v1.Data_Access_Layer
{
    class dataAccessService
    {
        public static SqlConnection con = new SqlConnection("Data Source=UTCHAS-PC;Initial Catalog=tolet_home;Integrated Security=True");
        public bool isDataValid(user newUser)
        {


            string query = "select * from userInfo where email = '" + newUser.email + "'";
            con.Open();
            SqlCommand command = new SqlCommand(query,con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                con.Close();
                return true;

            }
            else
            {
                con.Close();
                return false;
                
            }

        }
        public bool isDataValid(string name,string password)
        {


            string query = "select * from userInfo where email = '" + name + "'and password='"+password+"'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                con.Close();
                return true;

            }
            else
            {
                con.Close();
                return false;

            }

        }

        public void insertData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void insertUserData(user newUser)
        {
            string query = "insert into userInfo(name,phoneNumber,email,password,gender) values('" + newUser.name + "','" + newUser.phoneNumber + "','" + newUser.email + "','" + newUser.password + "','" + newUser.gender + "')";
            insertData(query);
            
            
        }
        public void insertAddData(rentData rentalData)
        {
            string query = "insert into rentInfo(type,availableFor,location,renterEmail,renterPhoneNumber,img1,img2,price,locationAndDetails) values('" + rentalData.type + "','" + rentalData.availableFor + "','" + rentalData.location + "','" + rentalData.renterEmail + "','" + rentalData.renterPhoneNumber + "',@p1,@p2,'"+rentalData.price+"','"+rentalData.locationAndDetails+"')";
            con.Open();
            SqlCommand comamand = new SqlCommand(query,con);
            comamand.Parameters.Add(new SqlParameter("p1", rentalData.img1));
            comamand.Parameters.Add(new SqlParameter("p2", rentalData.img2));
            comamand.ExecuteNonQuery();
            con.Close();
        }

        public List<rentData> getUserAddData(string email)
        {
            
            List<rentData> list = new List<rentData>();
            string query = "select * from rentInfo where renterEmail='" + email + "'";
            con.Open();



            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    rentData rentalData = new rentData();
                    rentalData.id = (int)reader["id"];
                    rentalData.type = reader["type"].ToString();
                    rentalData.availableFor = reader["availableFor"].ToString();
                    rentalData.location = reader["location"].ToString();
                    rentalData.renterEmail = reader["renterEmail"].ToString();
                    rentalData.renterPhoneNumber = reader["renterPhoneNumber"].ToString();
                    rentalData.img1 = (byte[])(reader["img1"]);
                    rentalData.img2 = (byte[])(reader["img2"]);
                    rentalData.price = reader["price"].ToString();
                    rentalData.locationAndDetails = reader["locationAndDetails"].ToString();
                    list.Add(rentalData);
                }
                
            }
            con.Close();
            return list;
        }





        public List<rentData> getUserAddData(string type, string availabeFor, string location)
        {

            List<rentData> list = new List<rentData>();
            string query = "select * from rentInfo where type='" + type + "' and availableFor='"+availabeFor+"' and location = '"+location+"'";
            con.Open();



            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rentData rentalData = new rentData();
                    rentalData.id = (int)reader["id"];
                    rentalData.type = reader["type"].ToString();
                    rentalData.availableFor = reader["availableFor"].ToString();
                    rentalData.location = reader["location"].ToString();
                    rentalData.renterEmail = reader["renterEmail"].ToString();
                    rentalData.renterPhoneNumber = reader["renterPhoneNumber"].ToString();
                    rentalData.img1 = (byte[])(reader["img1"]);
                    rentalData.img2 = (byte[])(reader["img2"]);
                    rentalData.price = reader["price"].ToString();
                    rentalData.locationAndDetails = reader["locationAndDetails"].ToString();
                    list.Add(rentalData);
                }

            }
            con.Close();
            return list;
        }
        public void deleteAddData(int id)
        {

            string query = "delete from rentInfo where id= @uId";
            con.Open();
            SqlCommand comamand = new SqlCommand(query, con);
            comamand.Parameters.Add(new SqlParameter("uId", id));
            comamand.ExecuteNonQuery();
            con.Close();

        }
        public void updateName(string email,string name)
        {
            string query = "update userInfo set name = '" + name + "' where email = '" + email + "'";
            insertData(query);
        }
        public void updatePhoneNumber(string email,string phoneNumber)
        {
            string query = "update userInfo set phoneNumber = '" + phoneNumber + "' where email = '" + email + "'";
            insertData(query);
        }
        public void updateProfilePictue(string email, byte[] img)
        {
            string query = "update userInfo set profilePic= @pic where email = '" + email + "'";
            con.Open();
            SqlCommand comamand = new SqlCommand(query, con);
            comamand.Parameters.Add(new SqlParameter("pic", img));
            comamand.ExecuteNonQuery();
            con.Close();
        }
    }
}
