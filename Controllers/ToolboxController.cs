

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mytoolbox.Models;

namespace mytoolbox.Controllers
{
    [Authorize]
    public class ToolboxController : Controller
    {

        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Create(mytoolbox.Models.ToolboxViewModels.ToolboxViewModel model)
        {
            var newToolbox = new Toolbox {
                Purpose = model.Purpose
            };

            return RedirectToAction("Index");
            //unitOfWork.ToolboxRepository.Create(newToolbox);
        
        }
    }
}
