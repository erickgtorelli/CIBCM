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
    public enum ControlBorrar
    {
        Investigador,
        InstrumentosClinicos, 
        Estudio,
        Paciente
    };

    public partial class Borrar : UserControl
    {
        AccesoBaseDatos baseDatos;
        string consultaInvestigadores = "select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Investigador I JOIN Persona P ON I.Cedula = P.Cedula;";
        string consultaInstrumentos = "Select Cedula, NombreInstrumentoClinico From Lleno";
        string consultaEstudio = "Select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Participo Pa JOIN Persona P ON Pa.Cedula = P.Cedula";
        string consultaCodigo = "Select DISTINCT CodigoEstudio From Participo";
        string consultaNombreInst = "Select Nombre form instrumentosClinicos";
        string consultaPacientes = "select pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        public Borrar()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            baseDatos.llenarComboBox(consultaEstudio, comboBoxPacienteEstudio, 4);
            baseDatos.llenarComboBox(consultaCodigo, comboBoxBorrarCod, 1);
            baseDatos.llenarCheckedListBox(consultaNombreInst, borrarListaInstrumentos,1);
            baseDatos.llenarComboBox(consultaPacientes, comboBox1, 4);
            this.mostrarControl(ControlBorrar.InstrumentosClinicos);
        }

        public void mostrarControl(ControlBorrar c)
        {
            switch (c)
            {
                case ControlBorrar.Investigador:
                    panelBorrarInstrumentos.Hide();
                    panelBorrarEstudio.Hide();
                    panelBorrarInvest.Show();
                    break;
                case ControlBorrar.InstrumentosClinicos:
                    panelBorrarEstudio.Hide();
                    panelBorrarInvest.Hide();
                    panelBorrarNombreInst.Hide();

                    panelborrarInstPac.Show();
                    panelBorrarInstrumentos.Show();
                    break; 
                case ControlBorrar.Estudio:
                    panelBorrarInvest.Hide();
                    panelBorrarInstrumentos.Hide();
                    panelBorrarEstudio.Show();
                    break; 

                case ControlBorrar.Paciente:
          
                    break;

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

        private void buttonBorrarInvest_Click(object sender, EventArgs e)
        {
            baseDatos.insertarDatos("Delete from Persona where Cedula=" + seleccionarCedulaComboBox(comboBoxBorrarInvest));
            comboBoxBorrarInvest.Items.Clear();
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxBorrarInvest, 4);
        }

        private void buttonBorrarInstrumentos_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1) {
                string cedula = seleccionarCedulaComboBox(comboBox1);
                foreach (object itemChecked in listaInstPorPaciente.CheckedItems)
                {
                    baseDatos.ejecutarConsulta("Delete from Lleno where NombreInstrumentoClinico = '" + itemChecked.ToString() + "' AND Cedula = '"+cedula+"'");
                   
                }
                MessageBox.Show("Se borraron los datos");
            }
            
            
        }

        private void borrarEstudioPaciente_CheckedChanged(object sender, EventArgs e)
        {
            panelBorrarCodEst.Hide();    
            panelBorrarEstPaciente.Show();
           
        }

        private void borrarEstudioCodigo_CheckedChanged(object sender, EventArgs e)
        {
            panelBorrarCodEst.Show();
            panelBorrarEstPaciente.Hide();
           
        }

        private void buttonBorrarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = "";
            if (comboBoxBorrarCod.SelectedIndex > -1) {
                codigo = comboBoxBorrarCod.Text;
                baseDatos.ejecutarConsulta("Delete from Participo where codigoEstudio = '" + codigo + "'");
                baseDatos.ejecutarConsulta("Delete from estudio where codigoEstudio = '" + codigo + "'");
                comboBoxBorrarCod.Items.Remove(codigo);
                MessageBox.Show("Se borraron los datos del estudio con código: " + codigo, "Estudio borrado");
            }
        }

        private void buttonBorrarEstudioPaciente_Click(object sender, EventArgs e)
        {
            if (comboBoxPacienteEstudio.SelectedIndex > -1)
            {
                string cedula = seleccionarCedulaComboBox(comboBoxPacienteEstudio);
                foreach (object itemChecked in borrarListaInstrumentos.CheckedItems)
                {
                    baseDatos.ejecutarConsulta("Delete from Participo where CodigoEstudio = '" + itemChecked.ToString() + "' and Cedula = '"+cedula+"'");
                   // baseDatos.ejecutarConsulta("Delete from InstrumentosClinicos where Nombre = '" + itemChecked.ToString() + "'");
                } MessageBox.Show("datosBorrados");
               
            }
            else MessageBox.Show("Por favor seleccione la información del paciente");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelborrarInstPac.Show();
            panelBorrarNombreInst.Hide();
        }

        private void borrarNombreInst_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in borrarListaInstrumentos.CheckedItems)
            { 
             baseDatos.ejecutarConsulta("Delete from Lleno where NombreInstrumentoClinico = '" +itemChecked.ToString()+"'");
              baseDatos.ejecutarConsulta("Delete from InstrumentosClinicos where Nombre = '" +itemChecked.ToString()+"'"); 
            }
            MessageBox.Show("Se borraron los instrumentos clínicos");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelborrarInstPac.Hide();
            panelBorrarNombreInst.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1) {
                listaInstPorPaciente.Items.Clear();
                listaInstPorPaciente.Show();
                string cedula = seleccionarCedulaComboBox(comboBox1);
                string consultaPacInst = "Select NombreInstrumentoClinico from Lleno where Cedula = '" + cedula + "'";
                baseDatos.llenarCheckedListBox(consultaPacInst, listaInstPorPaciente, 1);

            }
        }

        private void comboBoxPacienteEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPacienteEstudio.SelectedIndex > -1) {
                string cedula = seleccionarCedulaComboBox(comboBoxPacienteEstudio);
                string consulta = "Select CodigoEstudio from Participo Where Cedula = '" + cedula + "'";
                listaBorrarEstudioPaciente.Items.Clear();
                baseDatos.llenarCheckedListBox(consulta, listaBorrarEstudioPaciente, 1);
            }
        }


    }

}
