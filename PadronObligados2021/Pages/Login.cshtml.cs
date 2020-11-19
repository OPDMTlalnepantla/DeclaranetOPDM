using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PadronObligados2021.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PadronObligados2021.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Msg;
        private readonly PadronObligados2021.Data.PadronObligados2021Context _context;
        public LoginModel(PadronObligados2021.Data.PadronObligados2021Context context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {

            ServidorPublico servidorPublico = await _context.ServidorPublico.FirstOrDefaultAsync(s => s.NumeroEmpleado.ToString() == Username);

            if (servidorPublico == null)
            {
                Msg = "Empleado NO EXISTE!!!";
                return Page();
            }

            if (Username.Equals(servidorPublico.NumeroEmpleado.ToString()) && Password.Equals(servidorPublico.RFC))
            {
                //HttpContext.Session.SetString("username", Username);
                //return RedirectToPage("/Padron/Edit?id="+ servidorPublico.ServidorPublicoId.ToString());
                if (servidorPublico.NumeroEmpleado == 5450)
                {
                    return RedirectToPage("/Padron/Index");
                } else
                {
                    return RedirectToPage("/Padron/Edit", new { id = servidorPublico.ServidorPublicoId.ToString() });
                }
            }
            else
            {
                Msg = "Contraseña ERRONEA!!!";
                return Page();
            }
        }
    }
}
