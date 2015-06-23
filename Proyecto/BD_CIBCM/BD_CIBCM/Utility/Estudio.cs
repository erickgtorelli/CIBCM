using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_CIBCM.Utility
{
    class Estudio
    {

        Check checks = new Check();
        public void InsertarEstudio(string codEstudio, DateTime fecha, string descripcion) {
            string insertEstudio = "Insert into Estudio Values ('" + codEstudio + "','" + fecha + "','" + descripcion + "')";
            if (checks.checkCodEstudio(codEstudio)) {
               // baseDatos.insertarDatos(insertEstudio);
            }
        }

        public void InsertarRealizoEstudio (string cedInvestigador, string codEstudio){
        
        }

        public void InsertarParticipoEsutdio(string cedPaciente, string codEstudio, string codParticipacion) { 
        string insertarParticipo = "Insert into Participo values (" + cedPaciente+","+codEstudio+","+codParticipacion+")"; 
            //SqlDataReader datos = 
            if (checks.checkCodEstudio(codEstudio) && checks.checkCodEstudio(codParticipacion)&& checks.checkCedula(cedPaciente)){
            
        } 
        }l
    }
}
