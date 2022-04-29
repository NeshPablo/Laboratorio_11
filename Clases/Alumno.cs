using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_11.Clases
{
    public class Alumno:Persona
    {
        public List<int> Notas { get; set; }

        public string Carne { get; set; }
    }
}