using System;
using System.Collections.Generic;
using System.Text;

namespace ECOMMERCE.ApplicationCore.Model
{
    public class Drink
    {
        public Drink()
        {

        }

        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
