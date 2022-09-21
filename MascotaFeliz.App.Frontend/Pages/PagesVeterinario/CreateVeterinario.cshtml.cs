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
    public class CreateVeterinarioModel : PageModel
    {
        private readonly IrepositorioVeterinario _repositorioVeterinario;

        //Importante poner eso 
        [BindProperty]
        public Veterinario veterinario {get; set;}

        public CreateVeterinarioModel(){
            this._repositorioVeterinario=new RepositorioVeterinario(new Persistencia.AppContext());            
        }

        public IActionResult OnGet(int? veterinarioID)
        {
            if (veterinarioID.HasValue)
            {
                veterinario=_repositorioVeterinario.GetVeterinario(veterinarioID.Value);
            }
            else
            {
             veterinario=new Veterinario();   
            }
             if (veterinario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost(){
            if (!ModelState.IsValid)
           {
               return Page();
           }
           if (veterinario.Id>0)
           {
               _repositorioVeterinario.UpdateVeterinario(veterinario);
               return RedirectToPage("/PagesVeterinario/ListaVeterinario");
           }
           else
           {
               _repositorioVeterinario.AddVeterinario(veterinario);
               return RedirectToPage("/Index");
           }

           

            
        }
    }
}
