using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_CIBCM.Utility
{
    class Diagnosticos
    {
        public int insertarDiagnosticoParcial(String Cedula, int NumDiagnostico, string CedulaInvestigador, AccesoBaseDatos baseDatos)
        {
            string Consulta = "insert into Parcial values(" + Cedula + ',' + NumDiagnostico + ',' + CedulaInvestigador + ')';
            //Hacer Checks de los datos   
            baseDatos.insertarDatos(Consulta);

            return 1;

        }
    }
}
