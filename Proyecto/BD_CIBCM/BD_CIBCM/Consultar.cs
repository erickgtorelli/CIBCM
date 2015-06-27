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
        string consultaPacientes = "SELECT pe.PrimerNombre as 'Nombre', pe.Apellido1 as 'Primer Apellido', pe.Apellido2 as 'Segundo Apellido', pe.Cedula, pe.FechaDeNacimiento as 'Fecha de nacimiento', pe.Sexo FROM paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        string consultaEstudio = "SELECT e.CodigoEstudio, e.Descripcion, COUNT(r.Cedula) as 'No. de investigadores' FROM Estudio e LEFT JOIN Realiza r ON e.CodigoEstudio = r.CodigoEstudio GROUP BY e.CodigoEstudio, e.Descripcion;";

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
                    groupBoxConsultaEstudio.Hide();
                    groupBoxConsultaPaciente.Hide();
                    groupBoxConsultaInstrumentosClinicos.Show();
                    this.iniciarConsultaInstrumentos();
                    break;
                case ControlConsultar.Estudios:
                    groupBoxConsultaPaciente.Hide();
                    groupBoxConsultaInstrumentosClinicos.Hide();
                    groupBoxConsultaEstudio.Show();
                    break;
                case ControlConsultar.Pacientes:
                    groupBoxConsultaInstrumentosClinicos.Hide();
                    groupBoxConsultaEstudio.Hide();
                    groupBoxConsultaPaciente.Show();
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
    }
}
