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
    public class DetallesMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repositorioMascota;
        public Mascota Mascota {get;set;}

        public DetallesMascotaModel()
        {
            this._repositorioMascota=new RepositorioMascota(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdMascota)
        {
            Mascota=_repositorioMascota.GetMascota(IdMascota);
            return Page();


        }
    }
}
