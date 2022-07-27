using System;

namespace DTO
{
    public class Account
    {
        /*ID, UserName, Password*/
        private int id;
        private string userName;
        private string passWord;

        public Account(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        public Account(int id, string userName, string passWord)
        {
            this.id = id;
            this.userName = userName;
            this.passWord = passWord;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
