using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IrepositorioVeterinario
    {
        Veterinario AddVeterinario (Veterinario veterinario);
        void DeleteVeterinario (int idveterinario);
        IEnumerable<Veterinario> GetAllVeterinario ();
        Veterinario GetVeterinario(int iddveterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        Veterinario GetVeterinario(string nombreveterinario);
        

    }
}