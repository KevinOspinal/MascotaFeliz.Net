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
    public class CrearMascotasModel : PageModel
    {
        //Constructor
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        [BindProperty]
        public Mascota mascota {get;set;}
            

        //LLama al metodo y actualiza 

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            /*if(!ModelState.IsValid){
                return Page();
            }*/
            if(_repoMascota.AddMascota(mascota) != null){
                return RedirectToPage("ListaMascotas");
            }
            return Page();
        }
        

    }
}
