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
    public class CrearHistoriasModel : PageModel
    {
        
        //Constructor
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        [BindProperty]
        public Historia historia {get;set;}
            

        //LLama al metodo

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            /*if(!ModelState.IsValid){
                return Page();
            }*/
            if(_repoHistoria.AddHistoria(historia) != null){
                return RedirectToPage("ListaHistorias");
            }
            return Page();
        }
    }
}
