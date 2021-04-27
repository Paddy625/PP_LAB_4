﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly PP_LAB_4.Data.PP_LAB_4Context _context;

        public DetailsModel(PP_LAB_4.Data.PP_LAB_4Context context)
        {
            _context = context;
        }

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
    }
}
