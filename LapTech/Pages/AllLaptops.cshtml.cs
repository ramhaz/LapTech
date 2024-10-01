using LapTech.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LapTech.Pages
{
    public class AllLaptopsModel : PageModel
    {
        private ILaptopRepository _laptopRepository;

        public AllLaptopsModel(ILaptopRepository laptopRepository)
        {
            _laptopRepository = laptopRepository;
        }

        public List<Models.Laptop> Laptops { get; set; }
        public IActionResult OnGet()
        {
            Laptops = _laptopRepository.GetAllLaptops();
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _laptopRepository.DeleteLaptop(id);
            Laptops = _laptopRepository.GetAllLaptops();
            return RedirectToPage("AllLaptops");
        }
    }
}
