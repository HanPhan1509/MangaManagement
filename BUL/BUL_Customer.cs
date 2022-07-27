using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BUL
{
    public class BUL_Customer
    {
        DAL_Customer data = new DAL_Customer();
        public DataTable getDataCustomer(string nameStore)
        { 
            return data.getDataCustomer(nameStore);
        }

        public DataTable getDataCustomerReport()
        {
            return data.getDataCustomer("GetDataCustomer");
        }

        public int addData(Customer cus)
        {
            return data.addCustomer(cus);
        }

        public int deleteData(Customer cus)
        {
            return data.deleteCustomer(cus);
        }

        public int editData(Customer cus)
        {
            return data.editCustomer(cus);
        }

        public DataTable searchData(string phone, string searchPhone)
        {
            return data.searchPhoneCustomer(phone, searchPhone);
        }
    }
}
