using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BUL
{
    public class BUL_Staff
    {
        DAL_Staff data = new DAL_Staff();
        public DataTable getDataStaff(string nameStore)
        {
            return data.getDataStaff(nameStore);
        }

        public int addData(Staff staff)
        {
            return data.addStaff(staff);
        }

        public int deleteData(Staff staff)
        {
            return data.deleteStaff(staff);
        }

        public int editData(Staff staff)
        {
            return data.editStaff(staff);
        }

        public DataTable searchData(string phone, string searchPhone)
        {
            return data.searchPhoneStaff(phone, searchPhone);
        }
    }
}
