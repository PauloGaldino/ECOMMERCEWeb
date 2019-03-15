using ECOMMERCE.ApplicationCore.Model;
using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Interfaces.InterfaceDrink
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
