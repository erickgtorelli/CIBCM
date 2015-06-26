using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BD_CIBCM
{
    public partial class MainWindow : Form
    {

        AccesoBaseDatos baseDatos;
        string consultaPacientes = "select pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        string consultaInvestigadores = "select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Investigador I JOIN Persona P ON I.Cedula = P.Cedula;";

        string consultaEstudio = "SELECT e.CodigoEstudio, e.Descripcion, COUNT(r.Cedula) as \'Investigadores que realizan el estudio\' FROM Estudio e LEFT JOIN Realiza r ON e.CodigoEstudio = r.CodigoEstudio GROUP BY e.CodigoEstudio, e.Descripcion;";
        string consultaInstrumentosClinicos = "SELECT i.Nombre, COUNT(l.Cedula) as \'Personas que han llenado el instrumento\' FROM InstrumentosClinicos i LEFT JOIN Lleno l ON i.Nombre = l.NombreInstrumentoClinico GROUP BY i.Nombre;";
        
        Utility.Diagnosticos diagnosticos = new Utility.Diagnosticos();
        bool agregarInstrumentosAPaciente = false;
        public MainWindow()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            panelInstrumentosClinicos.Hide();
            panelConsultas.Hide();
            panelEstudioNuevo.Hide();
            panelInsertarInvestigador.Hide();
            panelBorrarInvest.Hide();
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxInvestEstudio, 4);
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxBorrarInvest, 4);
            baseDatos.llenarComboBox(consultaPacientes, comboBoxPacienteInsertarDiagnostico, 4);
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxInvestigador, 4);
            baseDatos.llenarComboBox(consultaEstudio, comboBoxInsertarEstudio, 1);
            baseDatos.llenarComboBox(consultaPacientes, comboBoxCedInst, 4);
            baseDatos.llenarCheckedListBox(consultaInstrumentosClinicos, listaInstClinicos, 1);
            baseDatos.llenarComboBox(consultaPacientes, comboBoxCedPacEstudioInsert, 4);
            baseDatos.llenarComboBox(consultaEstudio, comboBoxInsertarEstudioPaciente, 1);

        }

        private string formularConsultaPacientesLlenaron(string nombre){
            return "SELECT p.PrimerNombre as \'Nombre\', p.Apellido1 as \'Primer Apellido\', p.Apellido2 as \'Segundo Apellido\' from Persona p JOIN Lleno l ON p.Cedula = l.Cedula WHERE l.NombreInstrumentoClinico = \'"+nombre+"\';";
        }

        private string formularConsultaInvestigadorRealiza(string codigo)
        {
            return "SELECT p.PrimerNombre as \'Nombre\', p.Apellido1 as \'Primer Apellido\', p.Apellido2 as \'Segundo Apellido\' FROM Persona p JOIN Realiza r ON p.Cedula = r.Cedula WHERE r.CodigoEstudio = \'"+codigo+"\'";  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButtonDiagnosticoInsertar_CheckedChanged(object sender, EventArgs e)
        {
            panelConsultas.Hide();
            panelInstrumentosClinicos.Hide();
            panelInsertarInvestigador.Hide();
            PanelInsertarDiagnostico.Show();
            
            
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxParcial.Show();
            groupBoxConsenso.Hide();
            
           
        }

        private void radioButtonConsenso_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxParcial.Hide();
            groupBoxConsenso.Show();
        }

        private void PanelInsertarDiagnostico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelParcialInsertar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               if(textBox1.Text != string.Empty)
                {
                    dataGridViewSintomas.Rows.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBoxConsenso_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxPacienteInsertarDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButtonConsenso.Checked == true){
                // diagnosticos.consultarParciales(string Cedula);
                // fill with checkbox(Group Box box,DataTable data);
                dataGridViewParcialesPaciente.DataSource = null;
                //Cambiar por consulta de parciales
                baseDatos.llenarTabla(diagnosticos.consultarParciales(seleccionarCedulaComboBox(comboBoxPacienteInsertarDiagnostico)), dataGridViewParcialesPaciente);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar Diagnostico 
            if (comboBoxPacienteInsertarDiagnostico.SelectedIndex > -1)
            {
                //Se seleciono un paciente
               if(textBoxNumDiagostico.Text != null)
                {

                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un paciente antes de continuar", 
                    "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LabelAgregarSintoma_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonInsertarInstrumentos_CheckedChanged(object sender, EventArgs e)
        {
            panelInstrumentosClinicos.Show();
            PanelInsertarDiagnostico.Hide();
            panelInsertarInvestigador.Hide();
            groupBoxEstudio.Hide();
            groupBoxInstClinicos.Show();
            comboBoxCedInst.Hide();
           

        }

        private void panelInstrumentosClinicos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxInstClinicos_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxEstudio_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxEstudio.Show();
            panelPacienteEstudio.Hide();
            panelInvestEstudioInsertar.Hide();
            groupBoxInstClinicos.Hide();
            PanelInsertarDiagnostico.Hide();
            panelInsertarInvestigador.Hide();
            panelInstrumentosClinicos.Show();
           
        }

        private void buttonGuardarEstudio_Click(object sender, EventArgs e)
        {        
            String codEstudio = comboBoxInsertarEstudio.Text.Trim();
            String consultaEstudio = "Select * from estudio where codigoEstudio = '" + codEstudio + "'";
            DateTime fechaTemp = dateTimePicker2.Value;
            String fecha = fechaTemp.ToString("dd-MM-yyyy");
            String investigador = seleccionarCedulaComboBox(comboBoxInvestEstudio);
            String insertarRealizaEstudio = "";
            SqlDataReader tuplas = baseDatos.ejecutarConsulta(consultaEstudio);
            if (tuplas == null || !tuplas.HasRows)
            {
                String descripcion = textBox4.Text;

                String insertarEstudio = "Insert into estudio values ('" + codEstudio + "',' " + descripcion + "','" + fecha + "')";
                baseDatos.insertarDatos(insertarEstudio);
                insertarRealizaEstudio = "Insert into realiza values ('" + investigador + "', '" + codEstudio + "')";
                MessageBox.Show("Se inserto el estudio" + codEstudio, "Insertar Estudio");
                comboBoxInsertarEstudio.Items.Add(codEstudio);
            }
            else
            {
                MessageBox.Show("El estudio con codigo " + codEstudio + "ya forma parte de la base de datos");
            }
            comboBoxInsertarEstudio.Text = " ";
            textBox4.Text = " ";


        }

        private void comboBoxInvestigador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxInvestEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaInstClinicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelInvestEstudioInsertar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonInsertPacEstudio_CheckedChanged(object sender, EventArgs e)
        {
            panelInvestEstudioInsertar.Hide();
            panelInsertarInvestigador.Hide();
            panelEstudioNuevo.Hide();
            panelPacienteEstudio.Show();
        }

        private void radioButtonInsertarInvEstudio_CheckedChanged(object sender, EventArgs e)
        {
            panelPacienteEstudio.Hide();
            panelInsertarInvestigador.Hide();
            panelEstudioNuevo.Hide();
            panelInvestEstudioInsertar.Show();
            
        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            baseDatos.llenarTabla(consultaEstudio, dataGridViewEstudio1);

            panelConsultas.Show();
            groupBoxConsultaInstrumentosClinicos.Hide();
            groupBoxConsultaEstudio.Show();
        }

        private void radioButtonConsultarInstrumentos_CheckedChanged(object sender, EventArgs e)
        {
            baseDatos.llenarTabla(consultaInstrumentosClinicos, dataGridViewInstrumentos1);

            panelConsultas.Show(); 
            groupBoxConsultaEstudio.Hide(); 
            groupBoxConsultaInstrumentosClinicos.Show();
        }

        
        /* luego pienso usar esto -- emma
        public void actualizarComboBoxPaciente(string cedula) { 
            //llamar siempre despues de insertar un paciente

               string consultaPacTemp=  "select pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = " +cedula+";";
               SqlDataReader datos = null;

              try
            {
                datos = baseDatos.ejecutarConsulta(consultaPacTemp);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
              while (datos.Read())
              {
                  string stringDatos = "";
                  for (int i = 0; i < 4; i++)
                  {
                      stringDatos += datos.GetValue(i) + " ";
                  }
                  comboBoxPacInst.Items.Add(stringDatos);
                  comboBoxPacienteInsertarDiagnostico.Items.Add(stringDatos);
                  comboBoxCedPacEstudioInsert.Items.Add(stringDatos);
                             
           
        }
        }
        */
        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            panelPacienteEstudio.Hide();
            panelInvestEstudioInsertar.Hide();
            panelEstudioNuevo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string cedPaciente = seleccionarCedulaComboBox(comboBoxCedPacEstudioInsert);
            string codEstudio = comboBoxInsertarEstudioPaciente.Text.Trim(); //trim elimina espacios en blanco
            string codParticipacion =codigoParticipacion.Text.Trim();
            string selectParticipo = "SELECT * FROM PARTICIPO WHERE Cedula = '" + cedPaciente + "'AND CodigoEstudio ='" + codEstudio + "' AND CodigoParticipacion ='" + codParticipacion + "'";
            string insertarParticipo="INSERT INTO PARTICIPO VALUES ('"+cedPaciente+"','"+codEstudio+"','"+codParticipacion+"')";
            SqlDataReader datos = baseDatos.ejecutarConsulta(selectParticipo);
            if (datos == null || !datos.HasRows)
            {
                if (cedPaciente != null && codEstudio != null && codParticipacion != null)
                {
                    baseDatos.ejecutarConsulta(insertarParticipo);
                    MessageBox.Show("Se insertaron correctamente los datos", "Insercion Estudio de Paciente");
                }
                else MessageBox.Show("Error al insertar los datos");
            }
            else MessageBox.Show("Los datos: cedula"+ cedPaciente +", codigo Estudio: "+ codEstudio +" y codigo de participacion: "+ codParticipacion+"\n Ya forman parte de la base de datos", "Error");

            
        }

        private string seleccionarCedulaComboBox(ComboBox comboBoxCedula) {
            string infoPersona = comboBoxCedula.Text;
            string cedula = "";
            int tamanio = 0;
            if (infoPersona != null) { 
                tamanio = infoPersona.Length;
                cedula = infoPersona.Substring(tamanio - 9);
            }
            cedula.Trim();
            return cedula;
        }

        private void codigoParticipacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxInsertarEstudioPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCedPacEstudioInsert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonInsertarInvestigador_CheckedChanged(object sender, EventArgs e)
        {
            panelConsultas.Hide();
            panelInstrumentosClinicos.Hide();
            panelInsertarInvestigador.Show();
            PanelInsertarDiagnostico.Hide();
        }

        private void panelEstudioNuevo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonInstClinicPaciente_Click(object sender, EventArgs e)
        {
            comboBoxCedInst.Show();
            agregarInstrumentosAPaciente = true;
        }

        private void guardarInstrumentosClinicos_Click(object sender, EventArgs e)
        {
            //string nuevoInstrumento = textBoxInstrumentos.Text;
            if (agregarInstrumentosAPaciente) {

                if (comboBoxCedInst.SelectedIndex > -1) {
                    //se inserta 
                }
                else MessageBox.Show("Por favor seleccione la cédula de algún paciente", "Faltan datos");
            }
        }

        private void textBoxInstrumentos_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInstrumentos_KeyDown(object sender, KeyEventArgs e)
        { /* *
           * cuando se le da enter en el textBox de instrumentos se revisa que el 
           * texto q  se trato de insertar no este en la base de datos
           * */
            string nuevoInstrumento = textBoxInstrumentos.Text;
            string consultaInstrumentos = "Select * from InstrumentosClinicos where nombre = '" + nuevoInstrumento + "';";
            string insertarInstrumento = "Insert into InstrumentosClinicos values ('"+nuevoInstrumento + "');";
            SqlDataReader datos;
            if (e.KeyCode == Keys.Enter)
            {
                if (nuevoInstrumento != string.Empty)
                {
                   
                    textBoxInstrumentos.Text = "";
                    datos = baseDatos.ejecutarConsulta(consultaInstrumentos);
                    if (!datos.HasRows || datos == null) {
                        baseDatos.insertarDatos(insertarInstrumento);
                        listaInstClinicos.Items.Add(nuevoInstrumento);
                    }
                    
                }
            }
        }
        private void buttonInsertarInvest_Click(object sender, EventArgs e)
        {
            string CedInvest = textBoxInsertarinvestCedula.Text.Trim();
            string NombInvest = textBoxInsertNombInvest.Text.Trim();
            string Ap1Invest = textBoxInsertAp1Invest.Text.Trim();
            string Ap2Invest = textBoxInsertAp2Invest.Text.Trim();
            bool sexo;
            if(radioButtonM.Checked==true)
            {
                sexo=true;
            }
            else
            {
                sexo = false;
            }
            string FechaNac = dateTimePickerFechaNacInvest.Value.ToString("yyyy-MM-dd");
            string InsertarPersona= "Insert into Persona values ('"+CedInvest+"', '"+NombInvest+"', '"+Ap1Invest+"', '"+Ap2Invest+"', '"+FechaNac+"', '"+sexo+"')";
            string InsertarInvestigador = "Insert into Investigador values ('" + CedInvest + "')";
            if(CedInvest.Length==9)
            {
                baseDatos.insertarDatos(InsertarPersona);
                baseDatos.insertarDatos(InsertarInvestigador);
                MessageBox.Show("Se agregó el investigador de cédula "+CedInvest+" a la base de datos");
            }
            else
            {
                MessageBox.Show("No se puede agregar el investigador porque el número de cédula no es válido");
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre = (string)dataGridViewInstrumentos1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(formularConsultaPacientesLlenaron(nombre), dataGridViewInstrumentos2);
            //MessageBox.Show("hjbagkbjadf");
        }

        private void radioButton1_CheckedChanged_3(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridViewEstudio1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string codigo = (string)dataGridViewEstudio1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(formularConsultaInvestigadorRealiza(codigo), dataGridViewEstudio2);
        }

        private void radioButton1_CheckedChanged_3(object sender, EventArgs e)
        {
            panelConsultas.Hide();
            panelInstrumentosClinicos.Hide();
            panelInsertarInvestigador.Hide();
            PanelInsertarDiagnostico.Hide();
            panelBorrarInvest.Show();
        }

        private void buttonBorrarInvest_Click(object sender, EventArgs e)
        {
            baseDatos.insertarDatos("Delete from Persona where Cedula=" + seleccionarCedulaComboBox(comboBoxBorrarInvest));
            comboBoxBorrarInvest.Items.Clear();
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxBorrarInvest, 4);
        }
    }
}
