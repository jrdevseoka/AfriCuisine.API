using Africuisine.Application.Config;
using Africuisine.Application.Data.Ingredients;
using Africuisine.Application.Data.Res;
using Africuisine.Application.Interfaces.Ingredients;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Africuisine.API.Controllers.Ingredients
{
    public class IngrCategoriesController : APIBaseController
    {
        private readonly IIngrCategoryService IngrCategoryService;

        public IngrCategoriesController(IIngrCategoryService ingrCategoryService)
        {
            IngrCategoryService = ingrCategoryService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await IngrCategoryService.GetIngredientCategories();
                return Ok(new ItemsResponse<IngredientCategoryDTO> { Items = categories, Succeeded = categories is not null});
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}