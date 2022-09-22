using System;
namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public String Nombre {get;set;}
        public String Color {get;set;}
        public String Especie {get;set;}
        public String Raza {get;set;}
        public  Historia  Historia {get;set;}
        public  Dueno Dueno {get;set;}
        public  Veterinario Veterinario {get;set;}
        
        
    }
}