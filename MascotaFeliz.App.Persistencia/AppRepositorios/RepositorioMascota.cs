using System.Collections.Generic;
using System;
using MascotaFeliz.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;

        

        public RepositorioMascota(AppContext appContext){
            _appContext=appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var Agregarmascota = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return Agregarmascota.Entity;

        }

        public void DeleteMascota(int IDMascota)
        {
            var MascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m=>m.Id==IDMascota);
            if (MascotaEncontrada!=null)
            {
                _appContext.Mascotas.Remove(MascotaEncontrada);
            }
            _appContext.SaveChanges();

        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public Mascota GetMascota(int IDMascota)
        {
            var MascotaEncontrada= _appContext.Mascotas
                                                        .Include("Historia")
                                                        .Include("Veterinario")
                                                        .Include("Dueno")
                                                        .FirstOrDefault(m=>m.Id==IDMascota);
            return MascotaEncontrada;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var MascotaEncontrada= _appContext.Mascotas.FirstOrDefault(m => m.Id==mascota.Id);
            if (MascotaEncontrada!=null)
            {
                MascotaEncontrada.Nombre=mascota.Nombre;
                MascotaEncontrada.Color=mascota.Color;
                MascotaEncontrada.Dueno=mascota.Dueno;
                MascotaEncontrada.Especie=mascota.Especie;
                MascotaEncontrada.Historia=mascota.Historia;
                MascotaEncontrada.Raza=mascota.Raza;
                _appContext.SaveChanges();                
            }
            return MascotaEncontrada;
        }
        public Mascota Asignar_A_Mascota (int idmascota,int iddueno,int idveterinario,int idhistoria)
        {
            var Mascota =_appContext.Mascotas.FirstOrDefault(m =>m.Id==idmascota);
            if (Mascota!=null)
            {
                var Dueno=_appContext.Duenos.FirstOrDefault(d =>d.Id==iddueno);
                if (Dueno!=null)
                {
                    var Veterinario=_appContext.Veterinarios.FirstOrDefault(v => v.Id==idveterinario);
                    if (Veterinario!=null)
                    {
                        var Historia=_appContext.Historias.FirstOrDefault(h =>h.Id==idhistoria);
                        if (Historia!=null)
                        {
                            Mascota.Dueno=Dueno;
                            Mascota.Veterinario=Veterinario;
                            Mascota.Historia=Historia;   
                            _appContext.SaveChanges();                                                    
                        }
                    }
                    
                }
            }
            _appContext.SaveChanges();
            return Mascota;
            

        }
        public Mascota AsignarDueno_A_Mascota (int idmascota,int iddueno)
        {
            var mascota = _appContext.Mascotas.FirstOrDefault (m => m.Id==idmascota);
            if (mascota!=null)
            {
                var dueno =_appContext.Duenos.FirstOrDefault(d => d.Id==iddueno);
                if (dueno!=null)
                {
                    mascota.Dueno=dueno;
                    _appContext.SaveChanges();
                }
            }
            _appContext.SaveChanges();
            return mascota;
            
        }
        public Mascota AsignarVeterinario_A_Mascota (int idmascota,int idveterinario )
        {
            var mascota= _appContext.Mascotas.FirstOrDefault(m => m.Id==idmascota);
            if (mascota!=null)
            {
                var veteri =_appContext.Veterinarios.FirstOrDefault(v => v.Id==idveterinario);
                if (veteri!=null)
                {
                    mascota.Veterinario=veteri;
                    _appContext.SaveChanges();

                    
                }
                
            }
            _appContext.SaveChanges();
            return mascota;
            
            
        }
        public Mascota InsertarVisitaPyP (int idmascota,VisitaPyP visitapyp)
        {
            var mascota=_appContext.Mascotas.FirstOrDefault(m => m.Id==idmascota);
            if (mascota!=null)
            {
                mascota.Historia.VisitasPyP.Add(visitapyp);
                _appContext.SaveChanges();
            }
            return mascota;
            
        }
       
        public Historia BuscarIdHistoria(Mascota mascota)
        {
            var MascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m =>m.Id==mascota.Id);
            if (MascotaEncontrada!=null)
            {
                var HistoriaEncontrada=_appContext.Historias.FirstOrDefault(h => h== MascotaEncontrada.Historia);
                if (HistoriaEncontrada!=null)
                {
                    Console.WriteLine("ENCONTRE LA HISTORIA");
                    return HistoriaEncontrada;
                }
                
            }
            Console.WriteLine("No encontre LA HISTORIA");
            return null;
        }

        
    }
}