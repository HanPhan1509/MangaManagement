using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DTO
{
    public class Customer
    {
        /*ID, Name, Sex, Dateofbirth, Address, phone*/
        private int id;
        private string name;
        private string sex;
        private DateTime dateOfBirth;
        private string address;
        private string phone;
        private DataRow item;

        public Customer(int id, string name, string sex, DateTime dateOfBirth, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
        }

        public Customer(string name, string sex, DateTime dateOfBirth, string address, string phone)
        {
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phone = phone;
        }

        public Customer(DataRow item)
        {
            this.item = item;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
