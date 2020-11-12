using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PadronObligados2021.Data;
using PadronObligados2021.Models;

namespace PadronObligados2021.Pages.Padron
{
    public class EditModel : PageModel
    {
        private readonly PadronObligados2021.Data.PadronObligados2021Context _context;

        public EditModel(PadronObligados2021.Data.PadronObligados2021Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ServidorPublico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServidorPublicoExists(ServidorPublico.ServidorPublicoId))
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

        private bool ServidorPublicoExists(int id)
        {
            return _context.ServidorPublico.Any(e => e.ServidorPublicoId == id);
        }
    }
}
