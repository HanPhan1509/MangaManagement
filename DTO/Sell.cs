using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Sell
    {
        /*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity*/
        private int id;
        private int idCustomer;
        private int idManga;
        private string customerName;
        private string mangaName;
        private int price;
        private int quantity;

        public int Id { get => id; set => id = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public int IdManga { get => idManga; set => idManga = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string MangaName { get => mangaName; set => mangaName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public Sell(int id, int idCustomer, int idManga, string customerName, string mangaName, int price, int quantity)
        {
            this.id = id;
            this.idCustomer = idCustomer;
            this.idManga = idManga;
            this.customerName = customerName;
            this.mangaName = mangaName;
            this.price = price;
            this.quantity = quantity;
        }

        public Sell(int idCustomer, int idManga, string customerName, string mangaName, int price, int quantity)
        {
            this.idCustomer = idCustomer;
            this.idManga = idManga;
            this.customerName = customerName;
            this.mangaName = mangaName;
            this.price = price;
            this.quantity = quantity;
        }

        public Sell(string customerName, string mangaName, int price, int quantity)
        {
            this.customerName = customerName;
            this.mangaName = mangaName;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
