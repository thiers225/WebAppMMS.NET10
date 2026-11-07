using WebAppMMS.Models;

namespace WebAppMMS.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories{get;set;} = new List<Category>();
        public  Product Product {get;set;} = new Product();
    }
}