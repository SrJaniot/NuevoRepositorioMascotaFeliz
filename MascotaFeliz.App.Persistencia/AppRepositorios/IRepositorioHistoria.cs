using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        Historia AddHistoria (Historia historia);
        void DeleteHistoria (int idhistoria);
        IEnumerable<Historia> GetAllHistoria ();
        Historia GetHistoria (int idhistoria);
        Historia UpdateHistoria (Historia historia);

        Historia AgregarVisitaPyP (Historia historia, VisitaPyP visitapyp);
        
        
    }
}