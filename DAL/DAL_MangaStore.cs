using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_MangaStore
    {
        clsDatabase data = new clsDatabase();

        //Lấy dl từ CSDL đổ vào datagridview
        public DataTable getDataMangaStore(string nameStore)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daMagastore = new SqlDataAdapter(cmd);
            daMagastore.Fill(dtResult);
            return dtResult;
        }

        public int addManga(MangaStore mg)
        {
            SqlCommand cmd = new SqlCommand("AddMangaStore", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Name", mg.Name));
            cmd.Parameters.Add(new SqlParameter("@Author", mg.Author));
            cmd.Parameters.Add(new SqlParameter("@Genre", mg.Genre));
            cmd.Parameters.Add(new SqlParameter("@CoverType", mg.CoverType));
            cmd.Parameters.Add(new SqlParameter("@Version", mg.Version));
            cmd.Parameters.Add(new SqlParameter("@PublishingCompany", mg.PublishingCompany));
            cmd.Parameters.Add(new SqlParameter("@Price", mg.Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", mg.Quantity));

            return cmd.ExecuteNonQuery();
        }

        public int deleteManga(MangaStore mg)
        {
            SqlCommand cmd = new SqlCommand("DeleteMangaStore", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", mg.Id);

            return cmd.ExecuteNonQuery();
        }

        public int editManga(MangaStore mg)
        {
            SqlCommand cmd = new SqlCommand("EditMangaStore", data.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ID", mg.Id));
            cmd.Parameters.Add(new SqlParameter("@Name", mg.Name));
            cmd.Parameters.Add(new SqlParameter("@Author", mg.Author));
            cmd.Parameters.Add(new SqlParameter("@Genre", mg.Genre));
            cmd.Parameters.Add(new SqlParameter("@CoverType", mg.CoverType));
            cmd.Parameters.Add(new SqlParameter("@Version", mg.Version));
            cmd.Parameters.Add(new SqlParameter("@PublishingCompany", mg.PublishingCompany));
            cmd.Parameters.Add(new SqlParameter("@Price", mg.Price));
            cmd.Parameters.Add(new SqlParameter("@Quantity", mg.Quantity));

            return cmd.ExecuteNonQuery();
        }

        public DataTable searchManga(string nameStore, string search)
        {
            DataTable dtResult = new DataTable();

            SqlCommand cmd = new SqlCommand(nameStore, data.con);
            cmd.Parameters.Add(new SqlParameter("@search", search));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daMagastore = new SqlDataAdapter(cmd);
            daMagastore.Fill(dtResult);

            return dtResult;
        }
    }
}
