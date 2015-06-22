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
          *devuelve true si la cedula contiene solo numeros
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
                System.Windows.Forms.MessageBox.Show("Error en el formato de la cédula", "Error de formato",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Exclamation,
                System.Windows.Forms.MessageBoxDefaultButton.Button1);
                return false;
            }

        }

        public bool checkCodEstudio(string codEstudio) {
            if (codEstudio.Length <= 6)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error en el formato del código Estudio ", "Error de formato",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Exclamation,
                System.Windows.Forms.MessageBoxDefaultButton.Button1);
                return false;
            }
            
        }
    }
  
}
