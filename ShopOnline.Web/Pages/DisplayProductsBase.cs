using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        //Passing Collection of Objects of type ProductDto from Parent to Child
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
