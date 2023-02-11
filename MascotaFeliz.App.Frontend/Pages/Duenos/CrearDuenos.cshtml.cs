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
    public class CrearDuenosModel : PageModel
    {

        //Constructor
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        [BindProperty]
        public Dueno dueno {get;set;}
            

        //LLama al metodo

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            /*if(!ModelState.IsValid){
                return Page();
            }*/
            if(_repoDueno.AddDueno(dueno) != null){
                return RedirectToPage("ListaDuenos");
            }
            return Page();
        }
        
    }
}
