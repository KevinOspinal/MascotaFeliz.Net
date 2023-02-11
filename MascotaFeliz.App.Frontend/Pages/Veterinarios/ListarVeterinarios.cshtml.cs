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
    public class ListarVeterinariosModel : PageModel
    {
        //Constructor
        private readonly IRepositorioVeterinario _repoVeterinario;
        //Se crea una propiedad
        public IEnumerable<Veterinario> listaVeterinarios {get;set;}

        public ListarVeterinariosModel()
        {
            this._repoVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());
        }
    
        //LLama al metodo
        public void OnGet()
        {
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }
    }
}
