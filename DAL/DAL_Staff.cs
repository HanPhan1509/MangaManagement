using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Staff
    {
        clsDatabase data = new clsDatabase();

        //Lấy dl từ CSDL đổ vào datagridview
        public DataTable getDataStaff(string nameStore)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daStaff = new SqlDataAdapter(cmd);
            daStaff.Fill(dtResult);
            return dtResult;
        }

        public int addStaff(Staff staff)
        {
            SqlCommand cmd = new SqlCommand("AddStaff", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            /*Name, Sex, DateOfBirth, Address, Phone*/
            cmd.Parameters.Add(new SqlParameter("@Name", staff.Name));
            cmd.Parameters.Add(new SqlParameter("@Sex", staff.Sex));
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", staff.DateOfBirth));
            cmd.Parameters.Add(new SqlParameter("@Address", staff.Address));
            cmd.Parameters.Add(new SqlParameter("@Phone", staff.Phone));

            return cmd.ExecuteNonQuery();
        }

        public int editStaff(Staff staff)
        {
            SqlCommand cmd = new SqlCommand("EditStaff", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ID", staff.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", staff.Name));
            cmd.Parameters.Add(new SqlParameter("@Sex", staff.Sex));
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", staff.DateOfBirth));
            cmd.Parameters.Add(new SqlParameter("@Address", staff.Address));
            cmd.Parameters.Add(new SqlParameter("@Phone", staff.Phone));

            return cmd.ExecuteNonQuery();
        }

        public int deleteStaff(Staff staff)
        {
            SqlCommand cmd = new SqlCommand("DeleteStaff", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", staff.Id);

            return cmd.ExecuteNonQuery();
        }

        public DataTable searchPhoneStaff(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@search", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daStaff = new SqlDataAdapter(cmd);
            daStaff.Fill(dtResult);
            return dtResult;
        }
    }
}
