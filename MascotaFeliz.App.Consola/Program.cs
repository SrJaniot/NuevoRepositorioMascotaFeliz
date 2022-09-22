using System.Diagnostics;
using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _RepoDueno =new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioHistoria _RepoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota _RepoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _RepoVisitaPyP=new RepositorioVisitaPyP (new Persistencia.AppContext());
        private static IrepositorioVeterinario _RepoVeterinario=new RepositorioVeterinario (new Persistencia.AppContext());


        static void Main(string[] args)

        {
            
            Console.WriteLine("Hello World! :3 ");
           //-----------------------------------------------------------------------------------------------
           _RepoDueno.AddDueno(CrearDueno());
           //_RepoDueno.GetDueno("Esteban");
           //_RepoDueno.DeleteDueno(4);
           //_RepoDueno.UpdateDueno(CrearDuenoConID());

           
           //-----------------------------------------------------------------------------------------------
           //_RepoHistoria.AddHistoria(CrearHistoria());
           //_RepoHistoria.GetHistoria(1);
           //_RepoHistoria.DeleteHistoria(2);
           //_RepoHistoria.UpdateHistoria(CrearHistoriaConID());
           //-----------------------------------------------------------------------------------------------
           //_RepoVeterinario.AddVeterinario(CrearVeterinario());
           // _RepoVeterinario.GetVeterinario("Vanessa");         
           //_RepoVeterinario.DeleteVeterinario(5);
           //_RepoVeterinario.UpdateVeterinario(CrearVeterinarioConID());
           //-----------------------------------------------------------------------------------------------
           //_RepoVisitaPyP.AddVisitaPyP(CrearVisitaPyP());
           //_RepoVisitaPyP.GetVisitaPyP(1);
           //_RepoVisitaPyP.DeleteVisitaPyP(1);
           //_RepoVisitaPyP.UpdateVisitaPyP(CrearVisitaPyPConID());
           //-----------------------------------------------------------------------------------------------
           _RepoMascota.AddMascota(CrearMascota());
           //_RepoMascota.Asignar_A_Mascota(4,8,9,1);
           //_RepoMascota.DeleteMascota(1);
           //_RepoMascota.UpdateMascota(CrearMascotaConID_SIN_Referancias());
           //CrearMascotaConID_SIN_Referancias();

           

            

            



        }

        private static Dueno CrearDueno()
        {
            var Dueno=new Dueno
            {
                Nombres="Esteban",
                Apellidos="Janiot",
                Correo="zzzzz@gmail.com",
                Direccion="MiCasa",
                Telefono="123456"  
                
            };
            return Dueno;
           
        }
        private static Dueno CrearDuenoConID()
        {
            var Dueno=new Dueno
            {
                Id=1,
                Nombres="Francisco",
                Apellidos="Janiot",
                Correo="estebanjaniot10@gmail.com",
                Direccion="MiCasa",
                Telefono="3000001"  
                
            };
            return Dueno;
           
        }
        //------------------------------------------------------------------------------------------
        private static Historia CrearHistoria ()
        {
            var Historia=new Historia
            {
                FechaInicial=new DateTime(2022,2,10),
                

            };
            return Historia;

        }
         private static Historia CrearHistoriaConID ()
        {
            var Historia=new Historia
            {
                Id=1,
                FechaInicial=new DateTime(2022,2,10)
            };
            return Historia;

        }
        //------------------------------------------------------------------------------------------
        private static Mascota CrearMascota()
        {
            
            
            
            var Mascota =new Mascota
            {
                Color="rojo",
                Especie="elefante",
                
                
                Nombre="dumbo",
                Raza="Africano",
                          
                

            };
            return Mascota;
        }
        private static Mascota CrearMascotaConID_SIN_Referancias()
        {
            
            
            
            var Mascota =new Mascota
            {
                Id=3,
                Color="Negro",
                Especie="GATO",
                Nombre="Laika",
                Raza="Labrador",
                


                
                
                          
                

            };
            Console.WriteLine(Mascota.Nombre);
            Console.WriteLine(Mascota.Dueno);
           
            return Mascota;
        }
        //--------------------------------------------------------------------------------------------
        private static VisitaPyP CrearVisitaPyP()
        {
            var VisitaPyP = new VisitaPyP
            {
                EstadoAnimo="Saludable",
                FechaVisita=new DateTime(2022,05,12),
                FrecuenciaCardiaca=10,
                FrecuenciaRespiratoria=10,
                IdVeterinario=000001,
                Peso=10,
                Recomendaciones="Darle Amor ",
                Temperatura=35

            };
            return VisitaPyP;

            
        }
        private static VisitaPyP CrearVisitaPyPConID()
        {
            var VisitaPyP = new VisitaPyP
            {
                Id=1,
                EstadoAnimo="Saludable",
                FechaVisita=new DateTime(2022,05,12),
                FrecuenciaCardiaca=10,
                FrecuenciaRespiratoria=10,
                IdVeterinario=000001,
                Peso=10,
                Recomendaciones="Darle Amor ",
                Temperatura=35

            };
            return VisitaPyP;

            
        }
        //-------------------------------------------------------------------------------------------
        private static Veterinario CrearVeterinario ()
        {
            var Veterinario=new Veterinario
            {
                Apellidos="Rivera",
                Direccion="calle 11",
                Nombres="pepito2",
                TarjetaProfesional="MuyProfesional",
                Telefono="12345"

            };
            return Veterinario;
        }
         private static Veterinario CrearVeterinarioConID ()
        {
            var Veterinario=new Veterinario
            {
                Id=1,
                Apellidos="Sanabria",
                Direccion="Su Casa",
                Nombres="Vanessa",
                TarjetaProfesional="MuyProfesional",
                Telefono="123456789"

            };
            return Veterinario;
        }
        


        
    }
}
