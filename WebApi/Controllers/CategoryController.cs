using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]  
    public class CategoryController : Controller  
    {  
        private readonly ApiContext _apiContext;  
  
        public CategoryController(ApiContext apiContext)  
        {  
            _apiContext = apiContext;  
        }  
  
        // GET api/values  
        [HttpGet]  
        public async Task<IActionResult> Get()  
        {  
            List<Category> categories = _apiContext.GetCategories();  
            return Ok(categories);  
        }  
    }  
}