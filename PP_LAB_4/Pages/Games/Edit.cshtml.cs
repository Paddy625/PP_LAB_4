using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PP_LAB_4.Data;
using PP_LAB_4.Models;

namespace PP_LAB_4.Pages.Games
{
    public class EditModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public EditModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        [BindProperty]
        public przykladowa_klasa przykladowa_klasa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            przykladowa_klasa = await _context.przykladowa_klasa.FirstOrDefaultAsync(m => m.ID == id);

            if (przykladowa_klasa == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(przykladowa_klasa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!przykladowa_klasaExists(przykladowa_klasa.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool przykladowa_klasaExists(int id)
        {
            return _context.przykladowa_klasa.Any(e => e.ID == id);
        }
    }
}
