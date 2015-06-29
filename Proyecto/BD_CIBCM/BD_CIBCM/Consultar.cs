using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BD_CIBCM
{
    public enum ControlConsultar
    {
        Instrumentos,
        Estudios,
        Pacientes,
        Diagnostico
    };

    public partial class Consultar : UserControl
    {
        AccesoBaseDatos baseDatos;
        string consultaInstrumentosClinicos = "SELECT i.Nombre, COUNT(l.Cedula) as 'Participantes' FROM InstrumentosClinicos i LEFT JOIN Lleno l ON i.Nombre = l.NombreInstrumentoClinico GROUP BY i.Nombre;";
        string consultaPacientes = "SELECT pe.Cedula, pe.PrimerNombre as 'Nombre', pe.Apellido1 as 'Primer Apellido', pe.Apellido2 as 'Segundo Apellido', pe.FechaDeNacimiento as 'Fecha de nacimiento', pe.Sexo FROM paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        string consultaEstudio = "SELECT e.CodigoEstudio, e.Descripcion, COUNT(r.Cedula) as 'Investigadores', COUNT(p.Cedula) AS 'Participantes' FROM Estudio e LEFT JOIN Realiza r ON e.CodigoEstudio = r.CodigoEstudio LEFT JOIN Participo p ON e.CodigoEstudio = p.CodigoEstudio GROUP BY e.CodigoEstudio, e.Descripcion;";
        string consultaPacientes1 = "select pe.PrimerNombre as 'Nombre', pe.Apellido1 as 'Primer Apellido', pe.Apellido2 as 'Segundo Apellido', pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        string consultaPacientesParticipo = "Select  pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula From Persona Pe Join Participo Pa On Pe.cedula = Pa.cedula";
        string consultaPacientesLlenaron = "SELECT p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido' from Persona p JOIN Lleno l ON p.Cedula = l.Cedula WHERE l.NombreInstrumentoClinico = @nombre;";
        string consultaInvestigadorRealiza = "SELECT p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido' FROM Persona p JOIN Realiza r ON p.Cedula = r.Cedula WHERE r.CodigoEstudio = @codigo;";
        string consultaPacienteParticipa = "SELECT p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido' FROM Persona P JOIN Participo Pa ON Pa.Cedula = P.Cedula Where Pa.CodigoEstudio = @codigo;";
        string consultaPacienteMuestra = "SELECT m.cedula AS 'Cedula', m.TipoDeMuestra AS 'Tipo de Muestra', m.Localizacion FROM Muestra m WHERE m.Cedula = @cedula;";
        string consultaPacienteGenotipeo = "SELECT g.Metodo, g.Link FROM Genotipeo g WHERE g.Cedula = @cedula;";

        Persona datosPersona;
        Utility.Diagnosticos diagnosticos = new Utility.Diagnosticos();

        public Consultar()
        {
            datosPersona = null;
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            this.mostrarControl(ControlConsultar.Instrumentos);
        }

        public void mostrarControl(ControlConsultar c)
        {
            switch(c)
            {
                case ControlConsultar.Instrumentos:
                    panelConsultaEstudio.Hide();
                    panelConsultaPaciente.Hide();
                    panelConsultaDiagnostico.Hide();

                    panelConsultaInstrumentos.Show();
                    this.iniciarConsultaInstrumentos();
                    string consulta = "Select nombre From InstrumentosClinicos";
                    baseDatos.llenarComboBox(consulta, new Dictionary<string, object>{}, comboBoxActInstClinico, 1);
                    break;
                case ControlConsultar.Estudios:
                    panelConsultaPaciente.Hide();
                    panelConsultaDiagnostico.Hide();
                    panelConsultaInstrumentos.Hide();

                    panelConsultaEstudio.Show();
                    this.iniciarConsultaEstudios();
                    break;
                case ControlConsultar.Pacientes:
                    panelConsultaDiagnostico.Hide();
                    panelConsultaInstrumentos.Hide();
                    panelConsultaEstudio.Hide();

                    panelConsultaPaciente.Show();
                    this.iniciarConsultaPacientes();
                    break;
                case ControlConsultar.Diagnostico:
                    panelConsultaInstrumentos.Hide();
                    panelConsultaEstudio.Hide();
                    panelConsultaPaciente.Hide();

                    panelConsultaDiagnostico.Show();
                    this.iniciarConsultaDiagnosticos();
                    break;

            }
        }

        private void iniciarConsultaDiagnosticos()
        {
            //panelConsultaDiagnosticos.Show();
            //baseDatos.llenarComboBox(consultaPacientes1, comboBoxConsultarDiagnosticos, 4);
        }

        public void iniciarConsultaInstrumentos()
        {
            baseDatos.llenarTabla(consultaInstrumentosClinicos, new Dictionary<string, object>{}, dataGridViewInstrumentos1);
        }

        public void iniciarConsultaEstudios() {
            baseDatos.llenarTabla(consultaEstudio, new Dictionary<string, object>{}, dataGridViewEstudio1);
        }

        public void iniciarConsultaPacientes()
        {
            baseDatos.llenarTabla(consultaPacientes, new Dictionary<string, object>{}, dataGridViewPaciente1);

        }

        private void dataGridViewInstrumentos1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre = (string)dataGridViewInstrumentos1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(consultaPacientesLlenaron, new Dictionary<string, object>{{ "nombre", nombre }},  dataGridViewInstrumentos2);
        }

        private void dataGridViewEstudio1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string codigo = (string)dataGridViewEstudio1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(consultaInvestigadorRealiza, new Dictionary<string, object> { { "codigo", codigo } }, dataGridViewEstudio2);
            baseDatos.llenarTabla(consultaPacienteParticipa, new Dictionary<string, object> { { "codigo", codigo } }, dataGridViewEstudio3);
        }

        private void actualizarPaciente(Persona p)
        {
            textBoxConsultaCedula.Text = p.cedula;
            textBoxConsultaNombre.Text = p.nombre;
            textBoxConsultaApellido1.Text = p.apellido1;
            textBoxConsultaApellido2.Text = p.apellido2;
            dateTimePickerConsultaFecha.Value = p.fechaNacimiento;
        }

        private void dataGridViewPaciente1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string cedula = (string)dataGridViewPaciente1[0, e.RowIndex].Value;
            datosPersona = baseDatos.obtenerPersona(cedula);
            this.actualizarPaciente(datosPersona);
            baseDatos.llenarTabla(consultaPacienteMuestra, new Dictionary<string, object> { { "cedula", cedula } }, dataGridViewPaciente2);
            baseDatos.llenarTabla(consultaPacienteGenotipeo, new Dictionary<string, object> { { "cedula", cedula } }, dataGridViewPaciente3);
        }

        private void buttonActualizarPaciente_Click(object sender, EventArgs e)
        {
            if(datosPersona != null)
            {
                DialogResult dialogResult = MessageBox.Show("Desea actulizar los datos del paciente", "Actualizar del paciente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string c = datosPersona.cedula;
                    datosPersona.cedula = textBoxConsultaCedula.Text;
                    datosPersona.nombre = textBoxConsultaNombre.Text;
                    datosPersona.apellido1 = textBoxConsultaApellido1.Text;
                    datosPersona.apellido2 = textBoxConsultaApellido2.Text;
                    datosPersona.fechaNacimiento = dateTimePickerConsultaFecha.Value;
                    baseDatos.actualizarPaciente(c, datosPersona);
                    this.iniciarConsultaPacientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para actulizar su informacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private string seleccionarCedulaComboBox(ComboBox comboBoxCedula)
        {
            string infoPersona = comboBoxCedula.Text;
            string cedula = "";
            int tamanio = 0;
            if (infoPersona != null)
            {
                tamanio = infoPersona.Length;
                cedula = infoPersona.Substring(tamanio - 9);
            }
            cedula.Trim();
            return cedula;
        }

		  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonConsultaParcial.Checked == true)
            {
                dataGridViewConsultaDiagnosticos.DataSource = null;
                //Cambiar por consulta de parciales
                string cedula = seleccionarCedulaComboBox(comboBoxConsultarDiagnosticos);
                baseDatos.llenarTabla(diagnosticos.consultarParciales(), new Dictionary<string, object>{{ "cedula", cedula}}, dataGridViewConsultaDiagnosticos);
            }
        }

        private void dataGridViewPaciente1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewEstudio2_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            string cedula = (string)dataGridViewEstudio2[0, e.RowIndex].Value;
            MessageBox.Show("Cedula" + cedula);
        }
        private void dataGridViewEstudio2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonActualizarEstPac_CheckedChanged(object sender, EventArgs e)
        {
            //string cedula = "Select Cedula from Participo";
            groupBoxActEstudio.Hide();
            baseDatos.llenarComboBox(consultaPacientesParticipo, new Dictionary<string, object> { }, comboBoxdatosPacienteEstudio, 4);
            groupBoxActPacEst.Show();
        }

        private void buttonUpdateEstudioPaciente_Click(object sender, EventArgs e)
        {

            if (comboBoxdatosPacienteEstudio.SelectedIndex > -1)
            {
                string cedula = seleccionarCedulaComboBox(comboBoxdatosPacienteEstudio);
                if (comboBoxCodEstudio.SelectedIndex > -1)
                {
                    string codEstudio = comboBoxCodEstudio.Text;
                    if (textBoxCodPart.Text != string.Empty)
                    {
                        string codigoParticipacion = textBoxCodPart.Text;
                        DialogResult dialogResult = MessageBox.Show("Desea actualizar los datos del paciente", "Actualizar del paciente", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string consulta = "Select * From Estudio Where CodigoEstudio = '" + codEstudio + "'";
                            SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                            if (datos!=null&&datos.HasRows)
                            {
                                string actualizar = "Update Participo Set CodigoEstudio ='" + codEstudio + "', CodigoParticipacion = '" + codigoParticipacion + "' where Cedula ='" + cedula + "';";
                                baseDatos.insertarDatos(actualizar);
                                MessageBox.Show("Datos Actualizados Exitosamente", "Actualizacion estudio de Paciente");
                                groupBoxActPacEst.Hide();
                                comboBoxdatosPacienteEstudio.Items.Clear();
                                comboBoxCodEstudio.Items.Clear();
                            }
                            else MessageBox.Show("Ese estudio no forma parte de la base de Datos", "Error");
                        }
                        else { 
                        //do nothing
                        }
                        
                    } else  MessageBox.Show("Por favor seleccionar código de Participación", "Faltan Datos");
                } else MessageBox.Show("Por favor seleccionar código de Estudio", "Faltan Datos");
            }
            else MessageBox.Show("Por favor seleccionar cédula Paciente", "Faltan Datos");
        }

        private void comboBoxdatosPacienteEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxdatosPacienteEstudio.SelectedIndex>-1){
                string cedula = seleccionarCedulaComboBox(comboBoxdatosPacienteEstudio);
                string consulta = "Select CodigoEstudio From Participo where Cedula = @cedula";
                SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                if (!datos.HasRows) {

                    baseDatos.llenarComboBox("Select CodigoEstudio From Participo", new Dictionary<string, object> { }, comboBoxCodEstudio, 1);
                }
                else baseDatos.llenarComboBox(consulta, new Dictionary<string, object>{{ "cedula", cedula}}, comboBoxCodEstudio, 1);

            }
           
        }

        private void comboBoxCodEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxdatosPacienteEstudio.SelectedIndex > -1)
            {
                string cedula = seleccionarCedulaComboBox(comboBoxdatosPacienteEstudio);
                if (comboBoxCodEstudio.SelectedIndex >-1){
                    string codEstudio = comboBoxCodEstudio.Text.Trim( );
                    MessageBox.Show("Este codigo " + codEstudio);
                    string consulta = "Select CodigoParticipacion From Participo where Cedula = '" + cedula + "' AND CodigoEstudio = '" + codEstudio + "';";
                    SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                    if (datos==null) {
                        MessageBox.Show("No Deberia meter"); baseDatos.llenarTextBox("Select CodigoParticipacion From Participo", textBoxCodPart, 1);   
                    }
                    else 
                    MessageBox.Show("Deberia meter");
                    baseDatos.llenarTextBox(consulta, textBoxCodPart, 1);
                }
            }
        }


    
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string codEst = "Select CodigoEstudio From Estudio";
            baseDatos.llenarComboBox(codEst, new Dictionary<string, object> { }, comboBoxCodEstudio2, 1);
            groupBoxActPacEst.Hide();
            groupBoxActEstudio.Show();

        }

        private void comboBoxCodEstudio2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCodEstudio2.SelectedIndex > -1) {
                string codigoEstudio = comboBoxCodEstudio2.Text;
                String consulta = "Select Descripcion from Estudio Where CodigoEstudio = '" + codigoEstudio + "'";
                SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                if (datos == null || !datos.HasRows)
                {
                    MessageBox.Show("No se encontraron datos", "Error");
                }
                else baseDatos.llenarTextBox(consulta, textBoxDescripcionEstudio, 1);
            }
        }

        private void buttonActDescEst_Click(object sender, EventArgs e)
        {
            if (comboBoxCodEstudio2.SelectedIndex > -1) {
                string codigoEstudio = comboBoxCodEstudio2.Text;
                string descripcion = textBoxDescripcionEstudio.Text;
                if (descripcion != string.Empty) {
                    String consulta = "Select Descripcion from Estudio Where CodigoEstudio = '" + codigoEstudio + "'";
                    SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                    if (datos == null || !datos.HasRows)
                    {
                        MessageBox.Show("El codigo de estudio seleccionado no forma parte de la base de datos", "Error");
                    }
                    else {
                          DialogResult dialogResult = MessageBox.Show("Desea actualizar la descripción del estudio", "Actualizar Estudio", MessageBoxButtons.YesNo);
                          if (dialogResult == DialogResult.Yes)
                          {
                              string actualizar = "Update Estudio Set Descripcion = '" + descripcion + "' WHERE codigoEstudio = '" + codigoEstudio + "'";
                              MessageBox.Show("Datos actualizados exitosamente", "Estudio Actualizado");
                              comboBoxCodEstudio2.Items.Clear();
                              groupBoxActEstudio.Hide();
                          }
                    }
                }
            }
        }

        private void groupBoxConsultaInstrumentosClinicos_Enter(object sender, EventArgs e)
        {

        }

        private void buttonActualizarInstClinico_Click(object sender, EventArgs e)
        {
            if (comboBoxActInstClinico.SelectedIndex > -1) { 
                string nombre = comboBoxActInstClinico.Text;
                string consulta = "Select nombre from InstrumentosClinicos Where nombre = '" + nombre + "'";
                string nombreNuevo = textBoxInstNuevo.Text;
                SqlDataReader datos = baseDatos.ejecutarConsulta(consulta);
                if (datos == null || !datos.HasRows)
                {
                    MessageBox.Show("No se encontraron los datos", "Error");
                }
                else
                    if (nombreNuevo != string.Empty)
                    {
                        string ejecutarProcedimiento = "EXEC ActualizarInstrumentos @nombreViejo = '" + nombre + "',@nombreNuevo= '" + nombreNuevo + "'";
                        baseDatos.insertarDatos(ejecutarProcedimiento);
                        MessageBox.Show("Datos actualizados", "Instrumentos clínicos");
                    }
                    else MessageBox.Show("Por favor inserte el nombre nuevo", "Actualizar Instrumentos");
            }
        }

        private void comboBoxActInstClinico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
