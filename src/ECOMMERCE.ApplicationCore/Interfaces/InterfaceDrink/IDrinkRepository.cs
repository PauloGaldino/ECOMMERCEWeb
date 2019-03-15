using ECOMMERCE.ApplicationCore.Model;
using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Interfaces.InterfaceDrink
{
    public interface IDrinkRepository
    {
         IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> IPreferredDrink { get; set; }

        Drink GetDrinkById(int DrinkId);
    }
}
