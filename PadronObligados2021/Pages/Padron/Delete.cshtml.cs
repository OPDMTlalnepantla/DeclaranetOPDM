﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PadronObligados2021.Data;
using PadronObligados2021.Models;

namespace PadronObligados2021.Pages.Padron
{
    public class DeleteModel : PageModel
    {
        private readonly PadronObligados2021.Data.PadronObligados2021Context _context;

        public DeleteModel(PadronObligados2021.Data.PadronObligados2021Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ServidorPublico ServidorPublico { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServidorPublico = await _context.ServidorPublico.FirstOrDefaultAsync(m => m.ServidorPublicoId == id);

            if (ServidorPublico == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServidorPublico = await _context.ServidorPublico.FindAsync(id);

            if (ServidorPublico != null)
            {
                _context.ServidorPublico.Remove(ServidorPublico);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}