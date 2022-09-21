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
    public class CreateDuenoModel : PageModel
    {
        private readonly IRepositorioDueno _repositorioDueno;

        [BindProperty]
        public Dueno dueno {get;set;}


        public CreateDuenoModel(){
            this._repositorioDueno=new RepositorioDueno(new Persistencia.AppContext());
        }


        public IActionResult OnGet(int? dddduenoId)
        {
            if (dddduenoId.HasValue)
            {
                dueno=_repositorioDueno.GetDueno(dddduenoId.Value);
            }
            else
            {
                dueno =new Dueno();
            }
            if (dueno==null)
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
           if (dueno.Id>0)
           {
               dueno=_repositorioDueno.UpdateDueno(dueno);
               
               return RedirectToPage("/PagesDueno/ListaDuenos");
           }
           else
           {
               _repositorioDueno.AddDueno(dueno);
               return RedirectToPage("/Index");
           }
          
        }
        





       
    }
}
