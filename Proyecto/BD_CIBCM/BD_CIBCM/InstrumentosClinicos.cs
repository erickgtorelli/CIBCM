using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//acceso bases de datos 
using System.Data;
using System.Data.SqlClient;
namespace BD_CIBCM.Utility
{
    class InstrumentosClinicos
    {
        Check checks = new Check();
        AccesoBaseDatos baseDatos = new AccesoBaseDatos  ();
        public void insertarInstrumenosClinicos(string nombreInstrumento) { 
            string selectInst = "SELECT COUNT (*) FROM INSTRUMENTOSCLINICOS WHERE NOMBRE = @nombre;";
            string insertInstrumentos = "INSERT INTO INSTRUMENTOS CLINICOS VALUES (" + nombreInstrumento + ")";
           /** //Int32 count = Int32 cmd.ExecuteScalar ();
            SqlDataReader reader = baseDatos.ejecutarConsulta(selectInst);
            int numInst = reader.
            if (numInst = 0){
               
            }
            * */
            SqlDataReader reader = baseDatos.ejecutarConsulta(selectInst, new Dictionary<string, object> { { "nombre", nombreInstrumento } });
            if (reader == null) {
                baseDatos.insertarDatos(insertInstrumentos);
            }
            
        }
        public void insertarLlenoInstrumentosClinicos(string Cedula, string instClinico) {
            
            //cmd.CommandText = "SELECT COUNT (*) FROM INSTRUMENTOSCLINICOS WHERE NOMBRE = "+instClinico; 
            //Int32 count = Int32 cmd.ExecuteScalar ();

            string insertLlenoInstrumentos = "INSERT INTO LLENO VALUES ("+Cedula+ "," +instClinico+")";

            if (checks.checkCedula(Cedula))
            {
                insertarInstrumenosClinicos(instClinico);
                baseDatos.insertarDatos(insertLlenoInstrumentos);
               
            }   
        }
    }
}
