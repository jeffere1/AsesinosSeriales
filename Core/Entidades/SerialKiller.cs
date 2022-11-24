using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class SerialKiller
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public string Nacionalidad {get; set;}
        //public List<CasoCriminal> CasosCriminales {get; set;}
    }
}