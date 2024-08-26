using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion2.Clases_
{
    internal class Persona
    {
        public Persona() { }

        public string Nombre { get; set; } //get obtenr,set asignar
        public DateTime FechaNac {  get; set; }

        public int Calcularedad()
        {
            return DateTime.Now.Year - FechaNac.Year;
        }

        public string EvaluarEdad()
        {
        if (Calcularedad() >= 18) return "Mayor  de edad";
            return "Menor  de edad";
        }
    }
}
