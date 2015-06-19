using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_CIBCM
{
    public partial class MainWindow : Form
    {

        AccesoBaseDatos baseDatos;
        string consultaPacientes = "select pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        public MainWindow()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
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
            PanelInsertarDiagnostico.Show();
            baseDatos.llenarComboBox(consultaPacientes, comboBoxPacienteInsertarDiagnostico,4);
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
    }
}
