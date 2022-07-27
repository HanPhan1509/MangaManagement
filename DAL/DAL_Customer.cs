using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Customer
    {
        clsDatabase data = new clsDatabase();

        //Lấy dl từ CSDL đổ vào datagridview
        public DataTable getDataCustomer(string nameStore)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daCustomer = new SqlDataAdapter(cmd);
            daCustomer.Fill(dtResult);
            return dtResult;
        }

        public int addCustomer(Customer cus)
        {
            SqlCommand cmd = new SqlCommand("AddCustomer", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            /*Name, Sex, DateOfBirth, Address, Phone*/
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@Sex", cus.Sex));
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", cus.DateOfBirth));
            cmd.Parameters.Add(new SqlParameter("@Address", cus.Address));
            cmd.Parameters.Add(new SqlParameter("@Phone", cus.Phone));

            return cmd.ExecuteNonQuery();
        }

        public int editCustomer(Customer cus)
        {
            SqlCommand cmd = new SqlCommand("EditCustomer", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ID", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@Sex", cus.Sex));
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", cus.DateOfBirth));
            cmd.Parameters.Add(new SqlParameter("@Address", cus.Address));
            cmd.Parameters.Add(new SqlParameter("@Phone", cus.Phone));

            return cmd.ExecuteNonQuery();
        }

        public int deleteCustomer(Customer cus)
        {
            SqlCommand cmd = new SqlCommand("DeleteCustomer", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", cus.Id);

            return cmd.ExecuteNonQuery();
        }

        public DataTable searchPhoneCustomer(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@search", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daCus = new SqlDataAdapter(cmd);
            daCus.Fill(dtResult);
            return dtResult;
        }
    }
}
