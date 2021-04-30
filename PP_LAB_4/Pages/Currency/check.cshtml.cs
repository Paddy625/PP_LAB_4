using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PP_LAB_4.Data;
using PP_LAB_4.Models;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.Serialization.Json;

namespace PP_LAB_4.Pages.Currency
{
    public class checkModel : PageModel
    {

        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public checkModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public currency cur { get; set; }
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


                var curre = (from s in _context.currency
                             where s.record_date == cur.record_date && s.name == cur.name
                             select s).ToList<currency>();

            if (curre.Count() == 0) //jak nie ma w bazie
            {
                await cur.load(cur.record_date);
                cur.exchange = cur.rates[cur.name];
                _context.currency.Add(cur);
                await _context.SaveChangesAsync();
            }
           
            return RedirectToPage("./Index");
        }
    }
}
