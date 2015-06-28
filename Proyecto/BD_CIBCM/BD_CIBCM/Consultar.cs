using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_CIBCM
{
    public enum ControlConsultar
    {
        Instrumentos,
        Estudios,
        Pacientes
    };

    public partial class Consultar : UserControl
    {
        AccesoBaseDatos baseDatos;
        string consultaInstrumentosClinicos = "SELECT i.Nombre, COUNT(l.Cedula) as 'Personas que han llenado el instrumento' FROM InstrumentosClinicos i LEFT JOIN Lleno l ON i.Nombre = l.NombreInstrumentoClinico GROUP BY i.Nombre;";
        string consultaPacientes = "SELECT pe.Cedula, pe.PrimerNombre as 'Nombre', pe.Apellido1 as 'Primer Apellido', pe.Apellido2 as 'Segundo Apellido', pe.FechaDeNacimiento as 'Fecha de nacimiento', pe.Sexo FROM paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        string consultaEstudio = "SELECT e.CodigoEstudio, e.Descripcion, COUNT(r.Cedula) as 'No. de investigadores' FROM Estudio e LEFT JOIN Realiza r ON e.CodigoEstudio = r.CodigoEstudio GROUP BY e.CodigoEstudio, e.Descripcion;";
        Persona datosPersona;

        public Consultar()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            this.mostrarControl(ControlConsultar.Instrumentos);
        }

        public void mostrarControl(ControlConsultar c)
        {
            switch(c)
            {
                case ControlConsultar.Instrumentos:
                    groupBoxDatosPaciente.Visible = false;
                    panelConsultaEstudio.Hide();
                    panelconsultaPaciente.Hide();

                    panelConsultaInstrumentos.Show();
                    this.iniciarConsultaInstrumentos();
                    break;
                case ControlConsultar.Estudios:
                    groupBoxDatosPaciente.Visible = false;
                    panelconsultaPaciente.Hide();
                    panelConsultaInstrumentos.Hide();

                    panelConsultaEstudio.Show();
                    this.iniciarConsultaEstudios();
                    break;
                case ControlConsultar.Pacientes:
                    panelConsultaInstrumentos.Hide();
                    panelConsultaEstudio.Hide();

                    panelconsultaPaciente.Show();
                    this.iniciarConsultaPacientes();
                    break;
            }
        }

        public void iniciarConsultaInstrumentos()
        {
            baseDatos.llenarTabla(consultaInstrumentosClinicos, dataGridViewInstrumentos1);

            groupBoxConsultaPaciente.Hide();
            groupBoxConsultaEstudio.Hide();
            groupBoxConsultaInstrumentosClinicos.Show();
        }

        public void iniciarConsultaEstudios() {

            baseDatos.llenarTabla(consultaEstudio, dataGridViewEstudio1);

            groupBoxConsultaInstrumentosClinicos.Hide();
            groupBoxConsultaPaciente.Hide();
            groupBoxConsultaEstudio.Show();

        }

        public void iniciarConsultaPacientes()
        {
            baseDatos.llenarTabla(consultaPacientes, dataGridViewPaciente1);

            groupBoxConsultaEstudio.Hide();
            groupBoxConsultaInstrumentosClinicos.Hide();
            groupBoxConsultaPaciente.Show();

        }

        private string formularConsultaPacientesLlenaron(string nombre)
        {
            return "SELECT p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido' from Persona p JOIN Lleno l ON p.Cedula = l.Cedula WHERE l.NombreInstrumentoClinico ='" + nombre + "';";
        }

        private string formularConsultaInvestigadorRealiza(string codigo)
        {
            return "SELECT p.PrimerNombre as 'Nombre', p.Apellido1 as 'Primer Apellido', p.Apellido2 as 'Segundo Apellido' FROM Persona p JOIN Realiza r ON p.Cedula = r.Cedula WHERE r.CodigoEstudio ='" + codigo + "'";
        }

        private void dataGridViewInstrumentos1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre = (string)dataGridViewInstrumentos1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(formularConsultaPacientesLlenaron(nombre), dataGridViewInstrumentos2);
        }

        private void dataGridViewEstudio1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string codigo = (string)dataGridViewEstudio1[0, e.RowIndex].Value;
            baseDatos.llenarTabla(formularConsultaInvestigadorRealiza(codigo), dataGridViewEstudio2);
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
            groupBoxDatosPaciente.Visible = true;
        }

        private void buttonActualizarPaciente_Click(object sender, EventArgs e)
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
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

    }
}
