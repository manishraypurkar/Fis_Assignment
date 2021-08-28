using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime CreatedOn { get; set; }

        public Product(int id,string name,double price, string category,DateTime createon)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.CreatedOn = createon;
        }

        public override string ToString()
        {
            return $"ID-{this.Id}\tName{this.Name}\tPrice{this.Price}\tCategory{this.Category}\tCreated On{this.CreatedOn}";
        }
    }
}
