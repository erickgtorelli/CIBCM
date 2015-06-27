using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_CIBCM
{
    
    class Persona
    {
        public string cedula, nombre, apellido1, apellido2, sexo;
        public DateTime fechaNacimiento;

        public Persona(string c, string n, string a1, string a2, string f, string s)
        {
            this.cedula = c;
            this.nombre = n;
            this.apellido1 = a1;
            this.apellido2 = a2;
            this.fechaNacimiento = DateTime.Parse(f);
            this.sexo = s;
        }

        public string getHileraFecha()
        {
            return this.fechaNacimiento.ToString();
        }

    }
}
