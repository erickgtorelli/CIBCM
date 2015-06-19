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
        public void insertarDiagnosticoParcial(String Cedula, int NumDiagnostico, string CedulaInvestigador,string Link,string Fecha,string Enfermedad, AccesoBaseDatos baseDatos)
        {
            string insertParcial = "insert into Parcial values(" + Cedula + ',' + NumDiagnostico + ',' + CedulaInvestigador + ')';
            string insertDiagnostico = "insert into Diagnostico values("+Cedula + ',' + NumDiagnostico + ',' + Link + ',' + Fecha + ','+ Enfermedad + ")";
            //Hacer Checks de los datos
            if (checks.checkCedula(Cedula))
            {
                baseDatos.insertarDatos(insertParcial);
                baseDatos.insertarDatos(insertDiagnostico);
            }   

        }

        public void consultarParciales(string Cedula,AccesoBaseDatos baseDatos)
        {
            string selectParciales = "Select D.Fecha,D.Enfermedad,D.NumDiagnostico,I.PrimerNombre,I.Apellido1" +
                "From (Parcial P Join Diagnostico D" +
                "ON (P.Cedula = D.Cedula AND P.NumDiagnostico = D.NumDiagnostico) Join" +
                "Persona I ON P.CedInvestigador = I.Cedula);";
            baseDatos.ejecutarConsultaTabla(selectParciales);
        }
    }
}
