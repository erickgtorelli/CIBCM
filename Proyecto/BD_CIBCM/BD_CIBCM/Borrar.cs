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
            baseDatos.llenarComboBox(consultaEstudio, new Dictionary<string, object>{}, comboBoxPacienteEstudio, 4);
            baseDatos.llenarComboBox(consultaCodigo, new Dictionary<string, object> { }, comboBoxBorrarCod, 1);
            baseDatos.llenarComboBox(consultaInvestigadores, new Dictionary<string, object> { }, comboBoxBorrarInvest, 4);
            baseDatos.llenarCheckedListBox(consultaNombreInst, borrarListaInstrumentos,1);
            baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBox1, 4);
            this.mostrarControl(ControlBorrar.InstrumentosClinicos);
        }

        public void mostrarControl(ControlBorrar c)
        {
            switch (c)
            {
                case ControlBorrar.Investigador:
                    panelBorrarInstrumentos.Hide();
                    panelBorrarEstudio.Hide();
                    panelBorrarPaciente.Hide();

                    panelBorrarInvest.Show();
                    break;
                case ControlBorrar.InstrumentosClinicos:
                    panelBorrarEstudio.Hide();
                    panelBorrarInvest.Hide();
                    panelBorrarNombreInst.Hide();
                    panelBorrarPaciente.Hide();

                    panelborrarInstPac.Show();
                    panelBorrarInstrumentos.Show();
                    break; 
                case ControlBorrar.Estudio:
                    panelBorrarInvest.Hide();
                    panelBorrarInstrumentos.Hide();
                    panelBorrarPaciente.Hide();

                    panelBorrarEstudio.Show();
                    break; 

                case ControlBorrar.Paciente:
                    panelBorrarInvest.Hide();
                    panelBorrarInstrumentos.Hide();
                    panelBorrarEstudio.Hide();

                    panelBorrarPaciente.Show();
                    comboBoxBorrarPaciente.Items.Clear();
                    baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxBorrarPaciente, 4);
                    break;

            }
        }

        private string seleccionarCedulaComboBox(ComboBox comboBoxCedula)
        {
            string infoPersona = comboBoxCedula.Text;
            string[] chunks = infoPersona.Split(null);
            MessageBox.Show("la cedula es " + chunks[chunks.Length - 1]);
            return chunks[chunks.Length-1];
        }

        private void buttonBorrarInvest_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea borrar al investigador", "Borrar investigador", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                baseDatos.insertarDatos("Delete from Persona where Cedula=" + seleccionarCedulaComboBox(comboBoxBorrarInvest));
                MessageBox.Show("Se borró el investigador seleccionado");
                comboBoxBorrarInvest.Items.Clear();
                comboBoxBorrarInvest.Text = "";
                baseDatos.llenarComboBox(consultaInvestigadores, new Dictionary<string, object> { }, comboBoxBorrarInvest, 4);
            }

            
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

        private void buttonBorrarPaciente_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea borrar al paciente", "Borrar paciente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                baseDatos.insertarDatos("DELETE FROM Persona WHERE Cedula=" + seleccionarCedulaComboBox(comboBoxBorrarPaciente));
                MessageBox.Show("Se borró el paciente seleccionado");
                comboBoxBorrarPaciente.Items.Clear();
                comboBoxBorrarPaciente.Text = "";
                baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxBorrarPaciente, 4);
            }
            
        }


    }

}
