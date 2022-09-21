using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria:IRepositorioHistoria
    {
        private readonly AppContext _appContext ;

        public RepositorioHistoria (AppContext App)
        {
            _appContext=App;

        }
        //--------------------------------------------------------------------------------------------

        public Historia AddHistoria(Historia historia)
        {
            var AgregarHistoria = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return AgregarHistoria.Entity;
        }

        public void DeleteHistoria(int idhistoria)
        {
            var HistoriaEncontrada=_appContext.Historias.FirstOrDefault(h=> h.Id== idhistoria);
            if (HistoriaEncontrada!=null)
            {
                _appContext.Historias.Remove(HistoriaEncontrada);
            }
            _appContext.SaveChanges();
        }

        public IEnumerable<Historia> GetAllHistoria()
        {
            return _appContext.Historias;
            
        }

        public Historia GetHistoria(int idhistoria)
        {
            var HistoriaEncontrada=_appContext.Historias.FirstOrDefault(h=> h.Id== idhistoria);
            return HistoriaEncontrada;
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var HistoriaEncontrada=_appContext.Historias.FirstOrDefault(h=> h.Id== historia.Id);
            if (HistoriaEncontrada!=null)
            {
                HistoriaEncontrada.FechaInicial=historia.FechaInicial;
                HistoriaEncontrada.VisitasPyP=historia.VisitasPyP;
                _appContext.SaveChanges();
            }
            return HistoriaEncontrada;


            
        }
    }
}
