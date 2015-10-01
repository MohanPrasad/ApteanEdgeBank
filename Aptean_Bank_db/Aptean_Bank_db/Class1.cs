using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Aptean_Bank_db
{
    public  class Connection
       
    {
        
        public static SqlConnection setconnection()
        {
                 SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=WS003LT1614PRD;Initial Catalog=Aptean_Edge_Bank2.0(Gurpreet);Integrated Security=True";
                conn.Open();
                return conn;
           
        }

        public static void  closeconnection()
        
        {

         SqlConnection conn1= new SqlConnection();
         conn1.Close();
         //return conn1;
               
        }


        public class Data_Access_Layer : Connection
        {
          
            public static void create()
            {
                Connection.setconnection();
                
                SqlCommand cmd = new SqlCommand("Insert_cust ", Connection.setconnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.Add("@Customer_id", System.Data.SqlDbType.Int).Value = "12";
                cmd.Parameters.Add("@First_Name", System.Data.SqlDbType.NChar).Value="abc";
                cmd.Parameters.Add("@Middle_Name", System.Data.SqlDbType.NChar).Value="def";
                cmd.Parameters.Add("@Last_Name", System.Data.SqlDbType.NChar).Value="ghi" ;
              
                cmd.ExecuteNonQuery();
              Connection.closeconnection();
                

                //c.Close();
            }

            public static void read_customer()
            
            {
                Connection.setconnection();
                SqlCommand cmd = new SqlCommand("Read_Customer ", Connection.setconnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.Add("@Customer_id", System.Data.SqlDbType.Int).Value =12 ;

                //SqlDataReader sdr;
                //sdr = cmd.ExecuteReader();
                
             

            }

            public static void update()
            
            {

            }

            public static void delete()
            
            {

            }

        }


    }
}
