using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BUL
{
    public class BUL_Sell
    {
        DAL_Sell data = new DAL_Sell();
        public DataTable getDataSell(string nameStore)
        {
            return data.getDataSell(nameStore);
        }

        public int addData(Sell sell)
        {
            return data.addSell(sell);
        }
        public int editData(Sell sell)
        {
            return data.editSell(sell);
        }

        public int deleteData(Sell sell)
        {
            return data.deleteSell(sell);
        }

        public DataTable searchInfoCustomer(string nameStore, string phone)
        {
            return data.getNameCustomerByPhone(nameStore, phone);
        }

        public DataTable searchNameManga(string nameStore, string name)
        {
            return data.getMangaByName(nameStore, name);
        }

        public DataTable getTotalPrice()
        {
            return data.getTotalPrice();
        }

        public DataTable deleteSell()
        {
            return data.deleteDataSell();
        }
    }
}
