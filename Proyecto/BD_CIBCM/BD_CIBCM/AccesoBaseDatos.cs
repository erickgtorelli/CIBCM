using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;

// Namespace para mostrar mensajes
using System.Windows.Forms;

namespace BD_CIBCM
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        String conexion = "Data Source=AERICK; Initial Catalog=BD_CIBCM; Integrated Security=SSPI";
        
        /**
         * Constructor
         */
        public AccesoBaseDatos(){
        }

            /**
             * Permite insertar datos en la base de Datos
             */
        public void insertarDatos(string Datos)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = Datos;
            command.ExecuteNonQuery();

        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                
            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();

            dataAdapter.Fill(table);
			
			return table;
        }
        /**
        *Llena el combo box que le entra como parametro
        *parametros es la cantidad de columnas por tupla en el select
        */
        public void llenarComboBox(String consulta, ComboBox comboBox,int parametros)
        {
            SqlDataReader datos = null;
            try
            {
                datos = this.ejecutarConsulta(consulta);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            if (datos != null)
            {
                while (datos.Read())
                {
                    string stringDatos = "";
                    for(int i =0;i<parametros;i++) {
                        if (i == parametros - 1) {
                            stringDatos += datos.GetValue(i) ;
                        }else
                        stringDatos += datos.GetValue(i) + " ";
                    }
                    Console.WriteLine(stringDatos);
                    comboBox.Items.Add(stringDatos);
                }
            }
            else
            {
                MessageBox.Show("Datos vacio");
            }
        }

        public void actualizarPaciente(string cedula, Persona p){
            string ced = p.cedula;
            string nombre = p.nombre;
            string a1 = p.apellido1;
            string a2 = p.apellido2;
            string sexo = p.sexo;
            string fecha = p.getHileraFecha();

            string consulta = "UPDATE Persona SET Cedula = '" + ced + "', PrimerNombre = '" + nombre + "', Apellido1 = '" + a1 + "', Apellido2 = '" + a2 + "', Sexo = '" + sexo + "', FechaDeNacimiento = '" + fecha + "' WHERE Cedula = '" + cedula + "'";
            Console.WriteLine(consulta);
            try
            {
                this.ejecutarConsulta(consulta);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }

        }

        public Persona obtenerPersona(string cedula)
        {
            SqlDataReader datos = null;
            Persona p = null;
            string consulta = "SELECT p.Cedula, p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido', p.FechaDeNacimiento as 'Fecha de nacimiento', p.Sexo FROM Persona p WHERE p.Cedula='" + cedula + "';";

            try
            {
                datos = this.ejecutarConsulta(consulta);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            if (datos != null)
            {
                datos.Read();
                string ced = datos.GetValue(0).ToString();
                string nombre = datos.GetValue(1).ToString();
                string a1 = datos.GetValue(2).ToString();
                string a2 = datos.GetValue(3).ToString();
                string fechaNac = datos.GetValue(4).ToString();
                string sexo = datos.GetValue(5).ToString();
                p = new Persona(ced, nombre, a1, a2, fechaNac, sexo);
            }
            else
            {
                MessageBox.Show("Datos vacio");
            }

            return p;
        }
  
       

        public void llenarTabla(String consulta, DataGridView dataGridView)
        {
            DataTable tabla = null;
           
            try
            {
                tabla = this.ejecutarConsultaTabla(consulta);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;
                dataGridView.DataSource = bindingSource;

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView.Columns[0].Width = 75;
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        public void llenarCheckedListBox(String consulta, CheckedListBox checkedListBox, int parametros)
        {
            SqlDataReader datos = null;
            try
            {
                datos = this.ejecutarConsulta(consulta);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            if (datos != null)
            {
                while (datos.Read())
                {
                    string stringDatos = "";
                    for (int i = 0; i < parametros; i++)
                    {
                        stringDatos += datos.GetValue(i) + " ";
                    }
                    Console.WriteLine(stringDatos);
                    checkedListBox.Items.Add(stringDatos);
                }
            }
            else
            {
                MessageBox.Show("Datos vacio");
            }
        }

        

    }
}
