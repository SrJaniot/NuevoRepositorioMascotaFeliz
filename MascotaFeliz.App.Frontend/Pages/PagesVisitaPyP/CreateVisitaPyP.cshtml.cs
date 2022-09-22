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
    public class CreateVisitaPyPModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repositorioVisitaPyP;
        private readonly IrepositorioVeterinario _repositorioVeterinario;
        private readonly IRepositorioMascota _repositorioMascota;
        private readonly IRepositorioHistoria _repositorioHistoria;

        [BindProperty]
        public VisitaPyP visitaPyP {get;set;}
        [BindProperty]
        public int IdMascota {get;set;}

        public IEnumerable<Mascota> ListaMascota {get; set;}
        public IEnumerable<Veterinario> ListaVeterinario {get;set;}

        public CreateVisitaPyPModel()
        {
            this._repositorioVisitaPyP=new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repositorioVeterinario=new RepositorioVeterinario(new Persistencia.AppContext());
            this._repositorioMascota=new RepositorioMascota(new Persistencia.AppContext());
            this._repositorioHistoria=new RepositorioHistoria(new Persistencia.AppContext());
        }



        public IActionResult OnGet(int? IdMascota)
        {
            ListaMascota=_repositorioMascota.GetAllMascotas();
            ListaVeterinario=_repositorioVeterinario.GetAllVeterinario();
            if (IdMascota.HasValue)
            {
                visitaPyP=_repositorioVisitaPyP.GetVisitaPyP(IdMascota.Value);
            }
            else
            {
                visitaPyP=new VisitaPyP();
            }
            if (visitaPyP==null)
            {
                return RedirectToPage("./NotFound");
                
            }
            else
            {
                return Page();
            }

        }

         public IActionResult OnPost ()
         {
             if (!ModelState.IsValid)
            {
                return Page();
                
            }
            else
            {
                VisitaPyP visitacreada=_repositorioVisitaPyP.AddVisitaPyP(visitaPyP);
                Mascota Mascotaencontrada=_repositorioMascota.GetMascota(IdMascota);
                Historia HistoriaEncontrada=_repositorioHistoria.GetHistoria(Mascotaencontrada.Historia.Id);
                _repositorioHistoria.AgregarVisitaPyP(HistoriaEncontrada,visitacreada);
               

                return RedirectToPage("/Index");

                
                
            }
            


         }
    }
}
