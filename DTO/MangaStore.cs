using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MangaStore
    {
        /*ID, Name, author, genre, covertype, version, publishing company, price, quantity*/
        private int id;
        private string name;
        private string author;
        private string genre;
        private string coverType;
        private string version;
        private string publishingCompany;
        private int price;
        private int quantity;

        public MangaStore(int id, string name, string author, string genre, string coverType, string version, string publishingCompany, int price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.coverType = coverType;
            this.version = version;
            this.publishingCompany = publishingCompany;
            this.price = price;
            this.quantity = quantity;
        }

        public MangaStore(string name, string author, string genre, string coverType, string version, string publishingCompany, int price, int quantity)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.coverType = coverType;
            this.version = version;
            this.publishingCompany = publishingCompany;
            this.price = price;
            this.quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public string CoverType { get => coverType; set => coverType = value; }
        public string Version { get => version; set => version = value; }
        public string PublishingCompany { get => publishingCompany; set => publishingCompany = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
