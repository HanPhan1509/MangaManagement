using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Sell
    {
        clsDatabase data = new clsDatabase();

        public DataTable getDataSell(string nameStore)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter daSell = new SqlDataAdapter(cmd);
            daSell.Fill(dtResult);
            return dtResult;
        }

        public int addSell(Sell sell)
        {
            SqlCommand cmd = new SqlCommand("AddSell", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            /*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity*/
            cmd.Parameters.Add(new SqlParameter("@IDCustomer", sell.IdCustomer));
            cmd.Parameters.Add(new SqlParameter("@IDManga", sell.IdManga));
            cmd.Parameters.Add(new SqlParameter("@CustomerName", sell.CustomerName));
            cmd.Parameters.Add(new SqlParameter("@MangaName", sell.MangaName));
            cmd.Parameters.Add(new SqlParameter("@Price", sell.Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", sell.Quantity));

            return cmd.ExecuteNonQuery();
        }

        public int editSell(Sell sell)
        {
            SqlCommand cmd = new SqlCommand("EditSell", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            /*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity*/
            cmd.Parameters.Add(new SqlParameter("@ID", sell.Id));
            cmd.Parameters.Add(new SqlParameter("@IDCustomer", sell.IdCustomer));
            cmd.Parameters.Add(new SqlParameter("@IDManga", sell.IdManga));
            cmd.Parameters.Add(new SqlParameter("@CustomerName", sell.CustomerName));
            cmd.Parameters.Add(new SqlParameter("@MangaName", sell.MangaName));
            cmd.Parameters.Add(new SqlParameter("@Price", sell.Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", sell.Quantity));

            return cmd.ExecuteNonQuery();
        }

        public int deleteSell(Sell sell)
        {
            SqlCommand cmd = new SqlCommand("DeleteSell", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", sell.Id);

            return cmd.ExecuteNonQuery();
        }

        public DataTable getNameCustomerByPhone(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@phone", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daCus = new SqlDataAdapter(cmd);
            daCus.Fill(dtResult);
            return dtResult;
        }

        public DataTable getMangaByName(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@name", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daMg = new SqlDataAdapter(cmd);
            daMg.Fill(dtResult);
            return dtResult;
        }

        public DataTable getTotalPrice()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd = new SqlCommand("TotalPrice", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter daTP = new SqlDataAdapter(cmd);
            daTP.Fill(dtResult);
            return dtResult;
        }

        public DataTable deleteDataSell()
        {
            DataTable dtResult = new DataTable();
            SqlCommand cmd = new SqlCommand("DeleteDataSell", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter daTP = new SqlDataAdapter(cmd);
            daTP.Fill(dtResult);
            return dtResult;
        }


    }
}
