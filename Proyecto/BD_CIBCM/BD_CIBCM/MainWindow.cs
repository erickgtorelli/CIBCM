﻿using System;
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
        enum Vista
        {
            Insertar,
            Borrar,
            Consultar
        };

        Utility.Diagnosticos diagnosticos = new Utility.Diagnosticos();
        
        public MainWindow()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            mostrarVista(Vista.Consultar);

        }

        private void mostrarVista(Vista v)
        {
            switch(v)
            {
                case Vista.Insertar:
                    panelBorrar.Hide();
                    panelConsultar.Hide();
                    panelInsertar.Show();
                    break;
                case Vista.Consultar:
                    panelBorrar.Hide();
                    panelInsertar.Hide();
                    panelConsultar.Show();
                    break;
                case Vista.Borrar:
                    panelInsertar.Hide();
                    panelConsultar.Hide();
                    panelBorrar.Show();
                    break;
            }
        }

        private void radioButtonInsertarDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsertarDiagnostico.Checked)
            {
                panelInsertar.mostrarControl(ControlInsertar.Diagnostico);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonInsertarInstrumentos_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonInsertarInstrumentos.Checked)
            {
                panelInsertar.mostrarControl(ControlInsertar.Instrumento);
            }

        }

        private void radioButtonInsertarEstudio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsertarEstudio.Checked)
            {
                panelInsertar.mostrarControl(ControlInsertar.Estudio);
            }

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            if (radioButtonConsultarEstudio.Checked)
            {
                panelConsultar.mostrarControl(ControlConsultar.Estudios);
            }
        }

        private void radioButtonConsultarInstrumentos_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButtonConsultarInstrumentos.Checked)
            {
                panelConsultar.mostrarControl(ControlConsultar.Instrumentos);
            }
        }

        // esto se que es alguien por eso no me lo vole
        public void actualizarComboBoxPacientes(ComboBox comboBox)
        {
            //llamar siempre despues de insertar un paciente

            string consultaPacTemp = "SELECT pe.PrimerNombre, pe.Apellido1, pe.Apellido2, pe.Cedula FROM paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
            SqlDataReader datos = null;

            try
            {
                datos = baseDatos.ejecutarConsulta(consultaPacTemp, new Dictionary<string, object> { });
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
                comboBox.Items.Add(stringDatos);
                //comboBoxPacienteInsertarDiagnostico.Items.Add(stringDatos);
                //comboBoxCedPacEstudioInsert.Items.Add(stringDatos);
            }
        }

        private void radioButtonInsertarInvestigador_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsertarInvestigador.Checked)
            {
                panelInsertar.mostrarControl(ControlInsertar.Investigador);
            }
        }

        private void buttonInsertarInvest_Click(object sender, EventArgs e)
        {
            string CedInvest = textBoxInsertarinvestCedula.Text.Trim();
            string NombInvest = textBoxInsertNombInvest.Text.Trim();
            string Ap1Invest = textBoxInsertAp1Invest.Text.Trim();
            string Ap2Invest = textBoxInsertAp2Invest.Text.Trim();
            bool sexo;
            if (radioButtonM.Checked == true)
            {
                sexo = true;
            }
            else
            {
                sexo = false;
            }
            string FechaNac = dateTimePickerFechaNacInvest.Value.ToString("yyyy-MM-dd");
            string InsertarPersona = "Insert into Persona values ('" + CedInvest + "', '" + NombInvest + "', '" + Ap1Invest + "', '" + Ap2Invest + "', '" + FechaNac + "', '" + sexo + "')";
            string InsertarInvestigador = "Insert into Investigador values ('" + CedInvest + "')";
            if (CedInvest.Length == 9)
            {
                baseDatos.insertarDatos(InsertarPersona);
                baseDatos.insertarDatos(InsertarInvestigador);
                MessageBox.Show("Se agregó el investigador de cédula " + CedInvest + " a la base de datos");
            }
            else
            {
                MessageBox.Show("No se puede agregar el investigador porque el número de cédula no es válido");
            }

        }

        private void radioButtonBorrarInvestigador_CheckedChanged_3(object sender, EventArgs e)
        {
            if(radioButtonBorrarInvestigador.Checked)
            {
                panelBorrar.mostrarControl(ControlBorrar.Investigador);
            }
        }

        private void radioButtonPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConsultarPaciente.Checked)
            {
                panelConsultar.mostrarControl(ControlConsultar.Pacientes);
            }
        }

        private void VentanaPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = VentanaPrincipal.SelectedIndex;
            switch(tabIndex)
            {
                case 0:
                    mostrarVista(Vista.Consultar);
                    break;
                case 1:
                    mostrarVista(Vista.Insertar);
                    break;
                case 2:
                    mostrarVista(Vista.Borrar);
                    break;
            }
            
        }

        private void Borrar_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {

        }

        private void borrarInstrumentosClinicos_CheckedChanged(object sender, EventArgs e)
        {
            if (borrarInstrumentosClinicos.Checked)
            {
                panelBorrar.mostrarControl(ControlBorrar.InstrumentosClinicos);
            }
        }

        private void borrarEstudio_CheckedChanged(object sender, EventArgs e)
        {
            if (borrarEstudio.Checked)
            {
                panelBorrar.mostrarControl(ControlBorrar.Estudio);
            }
        }

	 private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelConsultar.mostrarControl(ControlConsultar.Diagnostico);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void panelConsultaDiagnosticos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButtonInsertarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonInsertarPaciente.Checked)
            {
                panelInsertar.mostrarControl(ControlInsertar.Paciente);
            }
        }

        private void radioButtonBorrarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBorrarPaciente.Checked)
            {
                panelBorrar.mostrarControl(ControlBorrar.Paciente);
            }
        }

        private void panelInicio_Load(object sender, EventArgs e)
        {

        }

        private void borrar2_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal.SelectedIndex = 1;
            panel1.Hide();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal.SelectedIndex = 0;
            panel1.Hide();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal.SelectedIndex = 2;
            panel1.Hide();
        }

    }
}
