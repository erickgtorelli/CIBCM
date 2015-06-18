using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_CIBCM.Utility
{
    class Diagnosticos
    {
        Check checks = new Check();
        public void insertarDiagnosticoParcial(String Cedula, int NumDiagnostico, string CedulaInvestigador, AccesoBaseDatos baseDatos)
        {
            string Consulta = "insert into Parcial values(" + Cedula + ',' + NumDiagnostico + ',' + CedulaInvestigador + ')';
            //Hacer Checks de los datos
            if (checks.checkCedula(Cedula))
            {
                baseDatos.insertarDatos(Consulta);
            }   

        }
      
    }
}
