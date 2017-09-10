using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabyCakes.API.Models
{
    public enum Category
    {
        Cupcakes,
        Brownies,
        Cookies,
        Cakes
    }

    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public uint MinimumQuantity
        {
            get
            {
                return Category == Category.Cakes ? 1u : 12u;
            }
        }
    }
}
