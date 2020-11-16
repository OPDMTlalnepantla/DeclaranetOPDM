using System;
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
    public class DetailsModel : PageModel
    {
        private readonly PadronObligados2021.Data.PadronObligados2021Context _context;

        public DetailsModel(PadronObligados2021.Data.PadronObligados2021Context context)
        {
            _context = context;
        }

        public ServidorPublico ServidorPublico { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServidorPublico = await _context.ServidorPublico
                .Include(s => s.FuncionPrincipal)
                .Include(s => s.Municipio)
                .Include(s => s.NivelEscolar)
                .Include(s => s.RegimenMatrimonial)
                .Include(s => s.Sector)
                .Include(s => s.SituacionPersonal).FirstOrDefaultAsync(m => m.ServidorPublicoId == id);

            if (ServidorPublico == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
