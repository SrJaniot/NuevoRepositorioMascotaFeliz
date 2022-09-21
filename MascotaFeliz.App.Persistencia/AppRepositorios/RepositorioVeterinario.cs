using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario:IrepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario (AppContext App)
        {
            _appContext=App;
        }
        //--------------------------------------------------------------------------------------------------------------------------------

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var VeterinarioAgregado=_appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return VeterinarioAgregado.Entity;
        }

        public void DeleteVeterinario(int idveterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id== idveterinario);
            if (VeterinarioEncontrado!=null)
            {
                _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            }
            _appContext.SaveChanges();
        }

        public IEnumerable<Veterinario> GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int iddveterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Id==iddveterinario);
            return VeterinarioEncontrado;  
            

        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v=>v.Id==veterinario.Id);
            if (VeterinarioEncontrado!=null)
            {
                VeterinarioEncontrado.Apellidos=veterinario.Apellidos;
                VeterinarioEncontrado.Direccion=veterinario.Direccion;
                VeterinarioEncontrado.Nombres=veterinario.Nombres;
                VeterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;
                VeterinarioEncontrado.Telefono=veterinario.Telefono;
                _appContext.SaveChanges();
                
            }
            return VeterinarioEncontrado;
        }

        public Veterinario GetVeterinario(string nombreveterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(v => v.Nombres==nombreveterinario);
            return VeterinarioEncontrado;
        }
    }
}