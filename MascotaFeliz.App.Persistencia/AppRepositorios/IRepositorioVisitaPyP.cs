
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        VisitaPyP AddVisitaPyP (VisitaPyP visitaPyP);
        void DeleteVisitaPyP (int idvisitapyp);
        IEnumerable<VisitaPyP> GetAllVisitaPyP ();
        VisitaPyP GetVisitaPyP(int idvisitapyp);
        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP);
        

    }
}