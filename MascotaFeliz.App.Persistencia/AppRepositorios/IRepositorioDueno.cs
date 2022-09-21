using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        IEnumerable<Dueno> GetAllDueno();
        Dueno AddDueno (Dueno dueno);
        Dueno UpdateDueno (Dueno dueno);
        void DeleteDueno (int iddueno);
        Dueno GetDueno (int iddueno);
        Dueno GetDueno (string nombredueno);


        
    }

}

