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
    public class CrearVisitasPyPModel : PageModel
    {
        //Constructor
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        [BindProperty]
        public VisitaPyP visitaPyP {get;set;}
            

        //LLama al metodo

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            /*if(!ModelState.IsValid){
                return Page();
            }*/
            if(_repoVisitaPyP.AddVisitaPyP(visitaPyP) != null){
                return RedirectToPage("ListaVisitasPyP");
            }
            return Page();
        }
    }
}
