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
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repositorioMascota;
        public IEnumerable<Mascota> ListaMascota {get;set;}

        public ListaMascotasModel()
        {
            this._repositorioMascota=new RepositorioMascota(new Persistencia.AppContext());
        }



        


        public void OnGet()
        {
            ListaMascota=_repositorioMascota.GetAllMascotas();
        }
    }
}
