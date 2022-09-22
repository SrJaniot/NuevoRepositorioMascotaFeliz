
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia{
    public interface IRepositorioMascota{
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int IDMascota);
        Mascota GetMascota(int IDMascota);

        Mascota Asignar_A_Mascota (int idmascota,int iddueno,int idveterinario,int idhistoria);
        Mascota AsignarDueno_A_Mascota (int idmascota,int iddueno);

        Mascota AsignarVeterinario_A_Mascota (int idmascota,int idveterinario );

        Mascota InsertarVisitaPyP (int idmascota,VisitaPyP visitapyp);

        Historia BuscarIdHistoria(Mascota mascota);


        
        


    }

}