using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        clsDatabase data = new clsDatabase();

        public DataTable getDataAccount(string nameStore)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daAccount = new SqlDataAdapter(cmd);
            daAccount.Fill(dtResult);
            return dtResult;
        }

        public DataTable getCheckAccount(String nameStore, Account acc)
        {

            DataTable dtResult = new DataTable();
            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", acc.UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", acc.PassWord));
            
            SqlDataAdapter daAccount = new SqlDataAdapter(cmd);
            daAccount.Fill(dtResult);
            return dtResult;
        }

        public int addAccount(Account acc)
        {
            SqlCommand cmd = new SqlCommand("AddAcc", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Username", acc.UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", acc.PassWord));

            return cmd.ExecuteNonQuery();
        }

        public int deleteAccount(Account acc)
        {
            SqlCommand cmd = new SqlCommand("DeleteAcc", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", acc.UserName);

            return cmd.ExecuteNonQuery();
        }

        public int editAccount(Account acc)
        {
            SqlCommand cmd = new SqlCommand("EditAcc", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ID", acc.Id));
            cmd.Parameters.Add(new SqlParameter("@Username", acc.UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", acc.PassWord));

            return cmd.ExecuteNonQuery();
        }

        public DataTable searchAccount(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@search", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daAccount = new SqlDataAdapter(cmd);
            daAccount.Fill(dtResult);

            return dtResult;
        }

        //public int searchAccount(string search)
        //{
        //    SqlCommand cmd = new SqlCommand("SearchAcc", data.con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add(new SqlParameter("@search", search));

        //    return cmd.ExecuteNonQuery();
        //}
    }
}
