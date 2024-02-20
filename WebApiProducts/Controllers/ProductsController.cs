using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProducts.Models;

namespace WebApiProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       public static readonly List<Products> products = new List<Products>() {
    new Products(){Pid=1,P_Name="Shampoo",P_Price=32.23 },
    new Products(){Pid=2,P_Name="Soap",P_Price=10.99 },
    new Products(){Pid=3,P_Name="Toothpaste",P_Price=5.75 },
    new Products(){Pid=4,P_Name="Conditioner",P_Price=28.50 },
    new Products(){Pid=5,P_Name="Face Wash",P_Price=15.75 },
    new Products(){Pid=6,P_Name="Body Lotion",P_Price=20.00 },
    new Products(){Pid=7,P_Name="Deodorant",P_Price=12.49 },
};
        [HttpGet(Name="GetProducts")]
        public IEnumerable<Products> Get() { return products; }
    }
}
