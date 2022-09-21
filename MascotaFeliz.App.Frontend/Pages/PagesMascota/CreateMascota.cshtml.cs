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
    public class CreateMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repositorioMascota;
        private readonly IRepositorioDueno _repositorioDueno;
        private readonly IrepositorioVeterinario _repositorioVeterinario;
        private readonly IRepositorioHistoria _repositorioHistoria;

        [BindProperty]
        public Mascota mascota {get;set;}
        [BindProperty]
        public int DuenoID {get;set;}
        [BindProperty]
        public int VeterinarioID {get;set;}

        public IEnumerable<Dueno> ListaDueno {get;set;}
        public IEnumerable<Veterinario> ListaVeterinario {get;set;}
        
        




        public CreateMascotaModel(){
            this._repositorioMascota=new RepositorioMascota(new Persistencia.AppContext());
            this._repositorioDueno=new RepositorioDueno(new Persistencia.AppContext());
            this._repositorioVeterinario=new RepositorioVeterinario(new Persistencia.AppContext());
            this._repositorioHistoria=new RepositorioHistoria(new Persistencia.AppContext());
        }



        public IActionResult OnGet(int? IdMascota)
        {
            ListaDueno=_repositorioDueno.GetAllDueno();
            ListaVeterinario=_repositorioVeterinario.GetAllVeterinario();
            if (IdMascota.HasValue)
            {
                mascota=_repositorioMascota.GetMascota(IdMascota.Value);
            }
            else
            {
                mascota=new Mascota();
            }
            if (mascota==null)
            {
                return RedirectToPage("./NotFound");
                
            }
            else
            {
                return Page();
            }

        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
                
            }
            if (mascota.Id>0)
            {
                _repositorioMascota.UpdateMascota(mascota);
                return RedirectToPage ("/PagesMascota/ListaMascotas");
                
            }
            else
            {
                Historia historia=new Historia();
                historia.FechaInicial=DateTime.Now;
                mascota.Historia=historia;

                Mascota mascota2= _repositorioMascota.AddMascota(mascota);
                
                _repositorioMascota.AsignarDueno_A_Mascota(mascota2.Id,DuenoID);
                _repositorioMascota.AsignarVeterinario_A_Mascota(mascota2.Id,VeterinarioID);
                //Console.WriteLine(mascota2.Id);
                //Console.WriteLine(DuenoID);
                //Console.WriteLine(VeterinarioID);
                 
                
                
                return RedirectToPage("/Index");


            }
            




        }






    }
}
