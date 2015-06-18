using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_CIBCM.Utility
{
    class Check
    {

        /**
         * Constructor
         */
        public Check()
        {

        }
        /**
    *Verifica que la cedula unicamente contenga numeros
    */
        public bool checkCedula(string Cedula)
        {
            int num;
            if (int.TryParse(Cedula, out num))
            {
                return true;
            }
            else
            {
                //Falta enviar mensaje de alerta al usuario
                return false;
            }

        }
    }
  
}
