using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PP_LAB_4.Data;
using PP_LAB_4.Models;

namespace PP_LAB_4.Pages.Currency
{
    public class IndexModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public IndexModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        public IList<currency> currency { get;set; }

        public async Task OnGetAsync()
        {
            currency = await _context.currency.ToListAsync();
        }
    }
}
