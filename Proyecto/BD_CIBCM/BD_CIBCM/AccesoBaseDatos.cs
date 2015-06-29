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
        // FAMILIALEWIS\\SQLEXPRESS
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        String conexion = "Data Source=FAMILIALEWIS\\SQLEXPRESS; Initial Catalog=BD_CIBCM; Integrated Security=SSPI";

        /**
         * Constructor
         */
        public AccesoBaseDatos()
        {

        }

        public DataTable ejecutarConsultaTabla(string sql, IDictionary<string, object> values)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexion))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                foreach (KeyValuePair<string, object> item in values)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }

        public SqlDataReader ejecutarConsulta(string sql, IDictionary<string, object> values)
        {
            SqlDataReader datos = null;
            SqlConnection conn = new SqlConnection(conexion);
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = sql;
            foreach (KeyValuePair<string, object> item in values)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            datos = cmd.ExecuteReader();
            return datos;
     
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
        *Llena el combo box que le entra como parametro
        *parametros es la cantidad de columnas por tupla en el select
        */
        public void llenarComboBox(string sql, IDictionary<string, object> par, ComboBox comboBox, int parametros)
        {
            SqlDataReader datos = null;
            try
            {
                datos = this.ejecutarConsulta(sql, par);
                if (datos != null)
                {
                    while (datos.Read())
                    {
                        string stringDatos = "";
                        for (int i = 0; i < parametros; i++)
                        {
                            if (i == parametros - 1)
                            {
                                stringDatos += datos.GetValue(i);
                            }
                            else
                                stringDatos += datos.GetValue(i) + " ";
                        }
                        comboBox.Items.Add(stringDatos);
                    }
                }
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            catch (System.InvalidOperationException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        public void actualizarPaciente(string cedula, Persona p)
        {
            string ced = p.cedula;
            string nombre = p.nombre;
            string a1 = p.apellido1;
            string a2 = p.apellido2;
            string sexo = p.sexo;
            string fecha = p.getHileraFecha();

            string consulta = "UPDATE Persona SET Cedula = @ced, PrimerNombre = @nombre, Apellido1 = @a1, Apellido2 = @a2, Sexo = @sexo, FechaDeNacimiento = @fecha WHERE Cedula = @cedula";
            try
            {
                this.ejecutarConsulta(consulta, new Dictionary<string, object> { { "ced", ced }, { "nombre", nombre }, { "a1", a1 }, { "a2", a2 }, { "sexo", sexo }, { "fecha", fecha }, { "cedula", cedula } });
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
            string consulta = "SELECT p.Cedula, p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido', p.FechaDeNacimiento as 'Fecha de nacimiento', p.Sexo FROM Persona p WHERE p.Cedula=@cedula;";

            try
            {
                datos = this.ejecutarConsulta(consulta, new Dictionary<string, object> { { "cedula", cedula } });
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

            return p;
        }



        public void llenarTabla(string sql, IDictionary<string, object> par, DataGridView dataGridView)
        {
            DataTable tabla = null;

            try
            {
                tabla = this.ejecutarConsultaTabla(sql, par);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;
                dataGridView.DataSource = bindingSource;

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        public void llenarCheckedListBox(string sql, IDictionary<string, object> par, CheckedListBox checkedListBox, int parametros)
        {
            SqlDataReader datos = null;
            try
            {
                datos = this.ejecutarConsulta(sql, par);
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
        }

        public void llenarTextBox(string sql, IDictionary<string, object> par, TextBox textBox, int parametros)
        {
            SqlDataReader datos = null;
            try
            {
                datos = this.ejecutarConsulta(sql, par);
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

                    textBox.Text = (stringDatos);
                }
            }
            else
            {
                MessageBox.Show("Datos vacio");
            }
        }

    }
}
