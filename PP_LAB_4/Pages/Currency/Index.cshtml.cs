using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PP_LAB_4.Data;
using PP_LAB_4.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace PP_LAB_4.Pages.Currency
{
    public class IndexModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public IndexModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        public currency currency { get;set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task load(string date)
        {
            string call = "https://openexchangerates.org/api/historical/" + date + ".json?app_id=81c1723f53a04465aca559053eaa515a";
            HttpClient httpclient = new HttpClient();
            string json = await httpclient.GetStringAsync(call);
            currency cur = JsonConvert.DeserializeObject<currency>(json);
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.currency.Add(currency);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
