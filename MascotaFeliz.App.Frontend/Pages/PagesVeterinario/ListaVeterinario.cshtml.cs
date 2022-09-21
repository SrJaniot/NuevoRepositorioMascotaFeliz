using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaVeterinarioModel : PageModel
   {
        private readonly IrepositorioVeterinario _repositorioVeterinario;
        public IEnumerable<Veterinario> ListaVeterinario {get; set;}

        public ListaVeterinarioModel()
        {
            this._repositorioVeterinario=new RepositorioVeterinario(new Persistencia.AppContext());
        }


        public void OnGet()
        {
            ListaVeterinario=_repositorioVeterinario.GetAllVeterinario();
        }
    }
}
