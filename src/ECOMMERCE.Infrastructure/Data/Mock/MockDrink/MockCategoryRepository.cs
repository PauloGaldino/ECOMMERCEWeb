using ECOMMERCE.ApplicationCore.Interfaces.InterfaceDrink;
using ECOMMERCE.ApplicationCore.Model;
using System.Collections.Generic;

namespace ECOMMERCE.Infrastructure.Data.Mock.MockDrink
{
   public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get {
                return new List<Category>
                {
                    new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks"},
                    new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                };
            } }
    }
}
