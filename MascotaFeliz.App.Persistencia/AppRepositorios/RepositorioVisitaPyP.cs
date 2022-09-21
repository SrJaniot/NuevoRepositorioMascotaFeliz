using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP:IRepositorioVisitaPyP
    {
        private readonly AppContext _appContext;

        public RepositorioVisitaPyP (AppContext App)
        {
            _appContext=App;
        }
        //-------------------------------------------------------------------------------------

        public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
        {
            var VisitaPyPAgregada= _appContext.VisitasPyP.Add(visitaPyP);
            _appContext.SaveChanges();
            return VisitaPyPAgregada.Entity;
        }

        public void DeleteVisitaPyP(int idvisitapyp)
        {
            var VisitaEncontrada= _appContext.VisitasPyP.FirstOrDefault(v=>v.Id== idvisitapyp);
            if (VisitaEncontrada!=null)
            {
                _appContext.VisitasPyP.Remove(VisitaEncontrada);
                
            }
            _appContext.SaveChanges();
        }

        public IEnumerable<VisitaPyP> GetAllVisitaPyP()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idvisitapyp)
        {
            var VisitaPyPEncontrada=_appContext.VisitasPyP.FirstOrDefault(v =>v.Id==idvisitapyp);
            return VisitaPyPEncontrada;
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
        {
            var VisitaPyPEncontrada=_appContext.VisitasPyP.FirstOrDefault(v =>v.Id==visitaPyP.Id);
            if (VisitaPyPEncontrada!=null)
            {
                VisitaPyPEncontrada.EstadoAnimo=visitaPyP.EstadoAnimo;
                VisitaPyPEncontrada.FechaVisita=visitaPyP.FechaVisita;
                VisitaPyPEncontrada.FrecuenciaCardiaca=visitaPyP.FrecuenciaCardiaca;
                VisitaPyPEncontrada.FrecuenciaRespiratoria=visitaPyP.FrecuenciaRespiratoria;
                VisitaPyPEncontrada.IdVeterinario=visitaPyP.IdVeterinario;
                VisitaPyPEncontrada.Peso=visitaPyP.Peso;
                VisitaPyPEncontrada.Recomendaciones=visitaPyP.Recomendaciones;
                VisitaPyPEncontrada.Temperatura=visitaPyP.Temperatura;
                _appContext.SaveChanges();
            }
            return VisitaPyPEncontrada;
        }
    }
}