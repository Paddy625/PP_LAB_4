using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PP_LAB_4.Data;
using PP_LAB_4.Models;

namespace PP_LAB_4.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public IndexModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

        public IList<przykladowa_klasa> przykladowa_klasa { get;set; }

        public async Task OnGetAsync()
        {
            przykladowa_klasa = await _context.przykladowa_klasa.ToListAsync();
        }
    }
}
