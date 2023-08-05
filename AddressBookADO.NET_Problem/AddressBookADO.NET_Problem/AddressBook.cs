using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET_Problem
{
    public class AddressBook
    {
        public static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AddressBookServiceDB;";
        public void AddNewContactInDatabase(Contacts contact) 
        {
            SqlConnection sqlConnection= new SqlConnection(connectionString);
            try
            {
                using(sqlConnection )
                {
                    sqlConnection.Open();
                    //Select * from TableName 
                    SqlCommand cmd = new SqlCommand("SPAdiingNewData", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                    cmd.Parameters.AddWithValue("@Address", contact.Address);
                    cmd.Parameters.AddWithValue("@City", contact.City);
                    cmd.Parameters.AddWithValue("@State", contact.State);
                    cmd.Parameters.AddWithValue("@Zip", contact.Zip);
                    cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", contact.EmilID);
                    int result = cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (result>=1)
                    {
                        Console.WriteLine("Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
