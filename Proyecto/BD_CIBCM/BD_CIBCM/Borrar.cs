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
        Investigador
    };

    public partial class Borrar : UserControl
    {
        AccesoBaseDatos baseDatos;
        string consultaInvestigadores = "select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Investigador I JOIN Persona P ON I.Cedula = P.Cedula;";

        public Borrar()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            this.mostrarControl(ControlBorrar.Investigador);
        }

        public void mostrarControl(ControlBorrar c)
        {
            switch (c)
            {
                case ControlBorrar.Investigador:
                    panelBorrarInvest.Show();
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
    }
}
