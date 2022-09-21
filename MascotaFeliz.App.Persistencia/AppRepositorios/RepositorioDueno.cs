using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioDueno:IRepositorioDueno
    {
        private  readonly AppContext _appContext;


        public RepositorioDueno (AppContext App)
        {
            _appContext=App;
        }
//------------------------------------------------------------------------------------------------
        public Dueno AddDueno(Dueno dueno)
        {
            
           var AgregarDueno=_appContext.Duenos.Add(dueno);
           _appContext.SaveChanges();
           return AgregarDueno.Entity;

        }

        public void DeleteDueno(int iddueno)
        {
            var DuenoEncontrado = _appContext.Duenos.FirstOrDefault(d =>d.Id==iddueno);
            if (DuenoEncontrado!=null)
            {
                _appContext.Duenos.Remove(DuenoEncontrado);
            }
            _appContext.SaveChanges();
        }

        public IEnumerable<Dueno> GetAllDueno()
        {
            return _appContext.Duenos;
        }

        public Dueno GetDueno(int iddueno)
        {
            var DuenoEncontrado=_appContext.Duenos.FirstOrDefault(d => d.Id==iddueno);
            return DuenoEncontrado;
            
        }

        public Dueno UpdateDueno(Dueno dueno)
        {
            var DuenoEncontrado=_appContext.Duenos.FirstOrDefault(d => d.Id==dueno.Id);
            if (DuenoEncontrado!=null)
            {
                DuenoEncontrado.Nombres=dueno.Nombres;
                DuenoEncontrado.Apellidos=dueno.Apellidos;
                DuenoEncontrado.Correo=dueno.Correo;
                DuenoEncontrado.Direccion=dueno.Direccion;
                DuenoEncontrado.Telefono=dueno.Telefono;
                _appContext.SaveChanges();
                
            }
            return DuenoEncontrado;

        }

        public Dueno GetDueno (string nombredueno){
            var DuenoEncontrado=_appContext.Duenos.FirstOrDefault(d =>d.Nombres==nombredueno);
            return DuenoEncontrado;
        }
        
                


    }
}