using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_CIBCM.Utility
{
    class Diagnosticos
    {
        Check checks = new Check();
        public void insertarDiagnosticoParcial(string Cedula, string NumDiagnostico, string CedulaInvestigador, string Link, string Fecha, string Enfermedad, AccesoBaseDatos baseDatos)
        {
            string insertParcial = "insert into Parcial values('" + Cedula + "','" + NumDiagnostico + "','" + CedulaInvestigador + "',null,null)";
            string insertDiagnostico = "insert into Diagnostico values('" + Cedula + "','" + NumDiagnostico + "','" + Link + "','" + Fecha + "','" + Enfermedad + "')";
            //Hacer Checks de los datos
            if (checks.checkCedula(Cedula))
            {
                baseDatos.insertarDatos(insertDiagnostico);
                baseDatos.insertarDatos(insertParcial);
            }

        }

        public string consultarParciales(string Cedula)
        {
            string consulta = "select DISTINCT D.NumDiagnostico, D.Fecha, D.Enfermedad,pe.PrimerNombre,pe.Apellido1, P.CedInvestigador from Diagnostico D Join Parcial P ON D.Cedula = P.Cedula Join  Persona pe ON pe.Cedula = P.CedInvestigador where P.Cedula =" + Cedula +
            "Order by  D.NumDiagnostico;";
            return consulta;
        }

        public void insertarSintomas(string CedPaciente, string NumDiagnostico, DataGridView Sintomas, AccesoBaseDatos baseDatos)
        {
            foreach (DataGridViewRow row in Sintomas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        string value = cell.Value.ToString();
                        string insertSintoma = "insert into Sintomas values('" + value + "','" + CedPaciente + "','" + NumDiagnostico + "');";
                        baseDatos.insertarDatos(insertSintoma);
                    }
                }
            }
        }

    }
}
