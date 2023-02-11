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
    public class ListaDuenosModel : PageModel
    {
        //Constructor
        private readonly IRepositorioDueno _repoDueno;
        //Se crea una propiedad
        public IEnumerable<Dueno> listaDuenos {get;set;}

        public ListaDuenosModel()
        {
            this._repoDueno= new RepositorioDueno(new Persistencia.AppContext());
        }
    
        //LLama al metodo
        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
        }
    }
        
}
