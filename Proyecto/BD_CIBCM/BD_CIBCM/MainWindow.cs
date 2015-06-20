﻿using System;
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
        string consultaInvestigadores = "select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Investigador I JOIN Persona P ON I.Cedula = P.Cedula;";
        Utility.Diagnosticos diagnosticos = new Utility.Diagnosticos();

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
            baseDatos.llenarComboBox(consultaInvestigadores, comboBoxInvestigador, 4);
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

                baseDatos.llenarTabla(consultaPacientes, dataGridViewParcialesPaciente);
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

        }

        private void LabelAgregarSintoma_Click(object sender, EventArgs e)
        {

        }
    }
}
