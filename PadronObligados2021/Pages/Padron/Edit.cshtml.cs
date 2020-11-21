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
        [BindProperty]
        public int EntidadFederativaId { get; set; }


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
           ViewData["FuncionesPrincipales"] = new SelectList(_context.FuncionPrincipal, "FuncionPrincipalId", "Nombre");
           ViewData["EntidadesFederativas"] = new SelectList(_context.EntidadFederativa, "EntidadFederativaId", "Nombre");
           ViewData["Municipios"] = new SelectList(_context.Municipio, "MunicipioId", "Nombre");
           ViewData["NivelesEscolaridad"] = new SelectList(_context.NivelEscolar, "NivelEscolarId", "Nombre");
           ViewData["RegimenesMatrimoniales"] = new SelectList(_context.RegimenMatrimonial, "RegimenMatrimonialId", "Nombre");
           ViewData["Sectores"] = new SelectList(_context.Sector, "SectorId", "Nombre");
           ViewData["SituacionesPersonales"] = new SelectList(_context.SituacionPersonal, "SituacionPersonalId", "Nombre");
           ViewData["EstatusEscolaridad"] = new SelectList(_context.SituacionPersonal, "SituacionPersonalId", "Nombre");

            //Staff = new List<SelectListItem>
            //{
            //    new SelectListItem{ Value = "1", Text = "Mike", Group = IT},
            //    new SelectListItem{ Value = "2", Text = "Pete", Group = Sales},
            //    new SelectListItem{ Value = "3", Text = "Katy", Group = Admin},
            //    new SelectListItem{ Value = "4", Text = "Dean", Group = Sales}
            //};
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

            return RedirectToPage("/Login");
        }

        private bool ServidorPublicoExists(int id)
        {
            return _context.ServidorPublico.Any(e => e.ServidorPublicoId == id);
        }
    }
}
