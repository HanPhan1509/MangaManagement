using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BUL
{
    public class BUL_MangaStore
    {
        public DataTable getDataMangaStore(string manga)
        {
            DAL_MangaStore data = new DAL_MangaStore();
            return data.getDataMangaStore(manga);
        }

        public int addData(MangaStore manga)
        {
            DAL_MangaStore data = new DAL_MangaStore();
            return data.addManga(manga);
        }

        public int deleteData(MangaStore manga)
        {
            DAL_MangaStore data = new DAL_MangaStore();
            return data.deleteManga(manga);
        }

        public int editData(MangaStore manga)
        {
            DAL_MangaStore data = new DAL_MangaStore();
            return data.editManga(manga);
        }

        public DataTable searchData(string name, string searchManga)
        {
            DAL_MangaStore data = new DAL_MangaStore();
            return data.searchManga(name, searchManga);
        }
    }
}
