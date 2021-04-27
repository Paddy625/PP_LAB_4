using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PP_LAB_4.Data;
using PP_LAB_4.Models;

namespace PP_LAB_4.Pages.Games
{
    public class CreateModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public CreateModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public przykladowa_klasa przykladowa_klasa { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.przykladowa_klasa.Add(przykladowa_klasa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
