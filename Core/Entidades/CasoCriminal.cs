using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entidades
{
    public class CasoCriminal
    {
        public int Id {get; set;}
        public string NombreCaso { get; set; }
        public string CiudadCaso { get; set; }
        public DateTime FechaAperturaCaso {get; set;}
        public DateTime? FechaHomicidio {get; set;}
        public List<Victima> Victimas {get; set;}
    }
}