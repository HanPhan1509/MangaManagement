using System;
using System.Data;
using DTO;
using DAL;

namespace BUL
{
    public class BUL_Account
    {
        DAL_Account data = new DAL_Account();
        public DataTable getDataAccount(string name)
        {
            return data.getDataAccount(name);
        }

        public DataTable Login(string nameStore, Account acc)
        {
            return data.getCheckAccount(nameStore, acc);
        }

        public int addData(Account acc)
        {
            return data.addAccount(acc);
        }

        public int deleteData(Account acc)
        {
            return data.deleteAccount(acc);
        }

        public int editData(Account acc)
        {
            return data.editAccount(acc);
        }

        public DataTable searchData(string userName, string searchUser)
        {
            return data.searchAccount(userName, searchUser);
        }
    }
}
