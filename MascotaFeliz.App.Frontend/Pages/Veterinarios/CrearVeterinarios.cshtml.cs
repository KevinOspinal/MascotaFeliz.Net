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
    public class CrearVeterinariosModel : PageModel
    {
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        [BindProperty]
        public Veterinario veterinario {get;set;} //NO SE PUEDE HACER LA HERENCIA POR QUE NO PERMITE HACERLO DESDE TABLAS
            

        //LLama al metodo

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            /*if(!ModelState.IsValid){
                return Page();
            }*/
            if(_repoVeterinario.AddVeterinario(veterinario) != null){
                return RedirectToPage("ListarVeterinarios");
            }
            return Page();
        }
    }
}
