using System.Threading.Tasks;
using DBA.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBA.ViewComponents 
{
    public class SalesListItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CarViewModel model) 
        {
            return await Task.FromResult(View(model));
        }
    }
}