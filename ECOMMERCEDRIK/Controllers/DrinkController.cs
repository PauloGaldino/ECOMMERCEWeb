using ECOMMERCE.ApplicationCore.Interfaces.InterfaceDrink;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECOMMERCEDRIK.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;

        }

        public ViewResult List()
        {
            var drink = _drinkRepository.Drinks;
            return View(drink);
        }
    }
}
