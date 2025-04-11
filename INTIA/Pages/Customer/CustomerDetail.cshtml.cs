using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace INTIA.Pages.Customer
{
    public class CustomerDetailModel : PageModel
    {
		private readonly AppDbContext _context;

		public CustomerDetailModel(AppDbContext context)
		{
			_context = context;
		}

		public INTIA.Models.Customer? Customer { get; set; }
		public IActionResult OnGet(int id)
        {
			Customer = _context.Customers.FirstOrDefault(x => x.Id == id);
			if (Customer == null)
			{
				return NotFound();
			}
			return Page();
        }
    }
}
