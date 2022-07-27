using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class clsDatabase
    {
        public SqlConnection con = new SqlConnection();
        string sConnection = @"Data Source=.;Initial Catalog=MANGAMANAGEMENT;Integrated Security=True";
        public clsDatabase()
        {
            try
            {
                con.ConnectionString = sConnection;
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
