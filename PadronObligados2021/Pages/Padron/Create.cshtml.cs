using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PadronObligados2021.Data;
using PadronObligados2021.Models;

namespace PadronObligados2021.Pages.Padron
{
    public class CreateModel : PageModel
    {
        private readonly PadronObligados2021.Data.PadronObligados2021Context _context;

        public CreateModel(PadronObligados2021.Data.PadronObligados2021Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FuncionPrincipalId"] = new SelectList(_context.FuncionPrincipal, "FuncionPrincipalId", "FuncionPrincipalId");
        ViewData["MunicipioId"] = new SelectList(_context.Municipio, "MunicipioId", "MunicipioId");
        ViewData["NivelEscolarId"] = new SelectList(_context.NivelEscolar, "NivelEscolarId", "NivelEscolarId");
        ViewData["RegimenMatrimonialId"] = new SelectList(_context.RegimenMatrimonial, "RegimenMatrimonialId", "RegimenMatrimonialId");
        ViewData["SectorId"] = new SelectList(_context.Sector, "SectorId", "SectorId");
        ViewData["SituacionPersonalId"] = new SelectList(_context.SituacionPersonal, "SituacionPersonalId", "SituacionPersonalId");
            return Page();
        }

        [BindProperty]
        public ServidorPublico ServidorPublico { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ServidorPublico.Add(ServidorPublico);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
