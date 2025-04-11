using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INTIA.Pages.Customers
{
    public class CustomersListModel : PageModel
    {
        private readonly AppDbContext _context;

        public CustomersListModel(AppDbContext context)
        {
            _context = context;
        }

        public List<INTIA.Models.Customer> Customers { get; set; } = new();
        public void OnGet()
        {
            Customers = _context.Customers.ToList();
        }
    }
}
