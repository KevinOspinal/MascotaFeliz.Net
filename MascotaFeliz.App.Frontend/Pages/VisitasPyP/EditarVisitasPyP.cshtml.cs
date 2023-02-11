using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarVisitasPyPModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        [BindProperty]
        public VisitaPyP visitaPyP { get; set; }

        public EditarVisitasPyPModel()
        {
            this._repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }
        // OnGet muestra con visitaPyP lleno dueño vacio, muestre el formulario
        public IActionResult OnGet(int? visitaPyPId)// Puede o no recibir un id
        {
            if (visitaPyPId.HasValue)
            {
                visitaPyP = _repoVisitaPyP.GetVisitasPyP(visitaPyPId.Value);
            }
            else
            {
                visitaPyP = new VisitaPyP();
            }
            if (visitaPyP == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
         // grabar
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (visitaPyP.Id > 0)
            {
                visitaPyP = _repoVisitaPyP.UpdateVisitasPyP(visitaPyP);
            }
            else
            {
                _repoVisitaPyP.AddVisitaPyP(visitaPyP);
            }
            return Page();
        }
    }
}
