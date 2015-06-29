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
    public enum ControlInsertar
    {
        Diagnostico,
        Investigador,
        Instrumento,
        Estudio,
        Paciente
    };

    public partial class Insertar : UserControl
    {
        AccesoBaseDatos baseDatos;
        bool agregarInstrumentosAPaciente = false;
        Utility.Diagnosticos diagnosticos = new Utility.Diagnosticos();
        Utility.Check checks = new Utility.Check();
        
        string consultaInvestigadores = "select P.PrimerNombre, Apellido1, P.Apellido2,P.Cedula From Investigador I JOIN Persona P ON I.Cedula = P.Cedula;";
        string consultaInstrumentos = "select Nombre from InstrumentosClinicos";
        string consultaEstudio = "select CodigoEstudio from Estudio";
        string consultaPacientes = "select pe.PrimerNombre as 'Nombre', pe.Apellido1 as 'Primer Apellido', pe.Apellido2 as 'Segundo Apellido', pe.Cedula from paciente pa JOIN persona pe ON pa.Cedula = pe.Cedula;";
        public Insertar()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object>{}, comboBoxCedInst, 4);
            baseDatos.llenarCheckedListBox(consultaInstrumentos, new Dictionary<string, object>{ }, listaInstClinicos, 1);
            baseDatos.llenarComboBox(consultaInvestigadores, new Dictionary<string, object> { }, comboBoxInvestEstudio, 4);
            baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxCedPacEstudioInsert, 4);
            baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxPaciente1, 4);
            baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxPaciente2, 4);
            baseDatos.llenarComboBox(consultaEstudio, new Dictionary<string, object> { }, comboBoxInsertarEstudioPaciente, 1);
            this.mostrarControl(ControlInsertar.Instrumento);

            // - emma did this
            dataGridViewSintomas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewParcialesPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void mostrarControl(ControlInsertar c)
        {

            PanelInsertarDiagnostico.Show();
            switch (c)
            {
                case ControlInsertar.Diagnostico:
                    panelInsertarEstudio.Hide();
                    panelInstrumentosClinicos.Hide();
                    panelInsertarInvestigador.Hide();
                    panelInsertarPaciente.Hide();

                    PanelInsertarDiagnostico.Show();

                    baseDatos.llenarComboBox(consultaInvestigadores, new Dictionary<string, object> { }, comboBoxInvestigador, 4);
                    baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxPacienteInsertarDiagnostico, 4);
                    break;
                case ControlInsertar.Estudio:
                    PanelInsertarDiagnostico.Hide();
                    panelInstrumentosClinicos.Hide();
                    panelInsertarInvestigador.Hide();
                    panelInsertarPaciente.Hide();
                    panelEstudioNuevo.Hide();

                    panelPacienteEstudio.Show();
                    panelInsertarEstudio.Show();
                    break;
                case ControlInsertar.Instrumento:
                    PanelInsertarDiagnostico.Hide();
                    panelInsertarEstudio.Hide();
                    panelInsertarInvestigador.Hide();
                    panelInsertarPaciente.Hide();
                    
                    panelInstrumentosClinicos.Show();
                    break;
                case ControlInsertar.Investigador:
                    PanelInsertarDiagnostico.Hide();
                    panelInsertarEstudio.Hide();
                    panelInstrumentosClinicos.Hide();
                    panelInsertarPaciente.Hide();

                    panelInsertarInvestigador.Show();
                    break;
                case ControlInsertar.Paciente:
                    PanelInsertarDiagnostico.Hide();
                    panelInsertarEstudio.Hide();
                    panelInstrumentosClinicos.Hide();
                    panelInsertarInvestigador.Hide();

                    panelInsertarPaciente.Show();
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

        private void buttonGuardarEstudio_Click(object sender, EventArgs e)
        {
            String codEstudio = textBoxCodigoEstudio.Text.Trim();
            String consultaEstudio = "Select * from estudio where codigoEstudio = @codEstudio;";
            DateTime fechaTemp = dateTimePicker2.Value;
            String fecha = fechaTemp.ToString("dd-MM-yyyy");
            String investigador = seleccionarCedulaComboBox(comboBoxInvestEstudio);
            String insertarRealizaEstudio = "";
            SqlDataReader tuplas = baseDatos.ejecutarConsulta(consultaEstudio, new Dictionary<string, object> { { "codEstudio", codEstudio } });
            if (tuplas == null || !tuplas.HasRows)
            {
                String descripcion = textBox4.Text;
                if (comboBoxInvestEstudio.SelectedIndex > -1)
                {
                    if (textBoxCodigoEstudio.Text != string.Empty)
                    {
                        String insertarEstudio = "Insert into estudio values ('" + codEstudio + "',' " + descripcion + "','" + fecha + "')";
                        baseDatos.insertarDatos(insertarEstudio);
                        insertarRealizaEstudio = "Insert into realiza values ('" + investigador + "', '" + codEstudio + "')";
                        String consultaRealiza = "select * from Realiza where cedula = @investigador AND CodigoEstudio = @codEstudio;";
                        if (!baseDatos.ejecutarConsulta(consultaRealiza, new Dictionary<string, object> { { "investigador", investigador }, { "codEstudio", codEstudio } }).HasRows)
                        {
                        baseDatos.insertarDatos(insertarRealizaEstudio);
                        }
                        MessageBox.Show("Se inserto el estudio" + codEstudio, "Insertar Estudio");
                        
                    }
                    else 
                        MessageBox.Show("Por favor inserte un código de estudio", "Error: Faltan datos");
                }
                else MessageBox.Show("Por favor seleccione la cédula del investigador", "Error: Faltan datos por llenar");
            }
            else
            {
                MessageBox.Show("El estudio con codigo " + codEstudio + "ya forma parte de la base de datos");
            }
            textBoxCodigoEstudio.Text = " ";
            textBox4.Text = " ";
        }

        private void buttonInstClinicPaciente_Click(object sender, EventArgs e)
        {
            comboBoxCedInst.Show();
            agregarInstrumentosAPaciente = true;
            guardarInstrumentosClinicos.Show();
        }

        private void guardarInstrumentosClinicos_Click(object sender, EventArgs e)
        {
            SqlDataReader tuplas;
            
            if (agregarInstrumentosAPaciente)
            {

                if (comboBoxCedInst.SelectedIndex > -1)
                {
                    String cedula = seleccionarCedulaComboBox(comboBoxCedInst);
                    String insertLleno = "";
                    foreach (object itemChecked in listaInstClinicos.CheckedItems)
                    {
                        string nombre = itemChecked.ToString();
                        String consulta = "Select * from Lleno where Cedula = @cedula AND NombreInstrumentoClinico = @nombre;";
                        tuplas = baseDatos.ejecutarConsulta(consulta, new Dictionary<string, object> { { "cedula", cedula }, { "nombre", nombre } });
                        if (tuplas == null || !tuplas.HasRows)
                        {
                            insertLleno = "Insert into Lleno Values ('" + cedula + "','" + itemChecked.ToString() + "')";
                            baseDatos.insertarDatos(insertLleno);
                        }
                        else MessageBox.Show("La cedula " + cedula + " y el instrumento clinico" + itemChecked.ToString() + " ya forman parte de la base de datos.", "Error al Insertar instrumentos clínicos a Paciente");

                    }
                    bool state = false;
                    foreach (int indexChecked in listaInstClinicos.CheckedIndices)
                    {
                        listaInstClinicos.SetItemCheckState(indexChecked, (state ? CheckState.Checked : CheckState.Unchecked));
                    }

                    MessageBox.Show("Se insertaron los datos correctamente", "Inserción Instrumentos clínicos a persona");

                    guardarInstrumentosClinicos.Hide();
                    comboBoxCedInst.Hide();
                    agregarInstrumentosAPaciente = false;
                }
                else
                {
                    MessageBox.Show("Por favor seleccione la cédula de algún paciente", "Faltan datos");
                }


            }
        }

        private void textBoxInstrumentos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInstrumentos_KeyDown(object sender, KeyEventArgs e)
        {
            /* *
           * cuando se le da enter en el textBox de instrumentos se revisa que el 
           * texto q  se trato de insertar no este en la base de datos
           * */
            string nuevoInstrumento = textBoxInstrumentos.Text;
            string consultaInstrumentos = "Select * from InstrumentosClinicos where nombre = @nuevoInstrumento;";
            string insertarInstrumento = "Insert into InstrumentosClinicos values ('" + nuevoInstrumento + "');";
            SqlDataReader datos;
            if (e.KeyCode == Keys.Enter)
            {
                if (nuevoInstrumento != string.Empty)
                {

                    textBoxInstrumentos.Text = "";
                    datos = baseDatos.ejecutarConsulta(consultaInstrumentos, new Dictionary<string, object> { { "nuevoInstrumento", nuevoInstrumento } });
                    if (!datos.HasRows || datos == null)
                    {
                        baseDatos.insertarDatos(insertarInstrumento);
                        listaInstClinicos.Items.Add(nuevoInstrumento);
                    }

                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != string.Empty)
                {
                    dataGridViewSintomas.Rows.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void comboBoxPacienteInsertarDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonConsenso.Checked == true)
            {
                // diagnosticos.consultarParciales(string Cedula);
                // fill with checkbox(Group Box box,DataTable data);
                dataGridViewParcialesPaciente.DataSource = null;
               
                //Cambiar por consulta de parciales
                string cedula = seleccionarCedulaComboBox(comboBoxPacienteInsertarDiagnostico);
                baseDatos.llenarTabla(diagnosticos.consultarParciales(), new Dictionary<string, object>{{ "cedula", cedula}}, dataGridViewParcialesPaciente);
            }
        }

        private void radioButtonInsertPacEstudio_CheckedChanged(object sender, EventArgs e)
        {
            panelEstudioNuevo.Hide();
           // panelInsertarInvestigador.Hide();
            panelEstudioNuevo.Hide();
            panelPacienteEstudio.Show();
        }

        private void guardarParticipo_Click(object sender, EventArgs e)
        {
            string cedPaciente = seleccionarCedulaComboBox(comboBoxCedPacEstudioInsert);
            string codEstudio = comboBoxInsertarEstudioPaciente.Text.Trim(); //trim elimina espacios en blanco
            string codParticipacion = codigoParticipacion.Text.Trim();
            string selectParticipo = "SELECT * FROM PARTICIPO WHERE Cedula = @cedPaciente AND CodigoEstudio = @codEstudio AND CodigoParticipacion = @codParticipacion;";
            string insertarParticipo = "INSERT INTO PARTICIPO VALUES ('" + cedPaciente + "','" + codEstudio + "','" + codParticipacion + "')";
            SqlDataReader datos = baseDatos.ejecutarConsulta(selectParticipo, new Dictionary<string, object> { { "cedPaciente", cedPaciente }, { "codEstudio", codEstudio }, { "codParticipacion", codParticipacion } });
            if (datos == null || !datos.HasRows)
            {
                if (comboBoxCedPacEstudioInsert.SelectedIndex >-1) 
                {
                    if (comboBoxInsertarEstudioPaciente.SelectedIndex > -1)
                    {
                        if (codParticipacion != string.Empty)
                        {
                            baseDatos.insertarDatos(insertarParticipo);
                            MessageBox.Show("Se insertaron correctamente los datos", "Insercion Estudio de Paciente");
                        }
                        else
                            MessageBox.Show("Por favor inserte el código de Participación", "Error: Faltan datos");
                    }
                    else MessageBox.Show("Por favor Seleccione el código de Estudio", "Error: Faltan datos del Estudio");
                }
                else MessageBox.Show("Por favor seleccione la información del paciente", "Error: Faltan datos del Paciente");
            }
            else MessageBox.Show("Los datos: cedula" + cedPaciente + ", codigo Estudio: " + codEstudio + " y codigo de participacion: " + codParticipacion + "\n Ya forman parte de la base de datos", "Error");
        }

        private void radioButtonConsenso_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxParcial.Hide();
            groupBoxConsenso.Show();
        }

        private void radioButtonDiagnosticoParcial_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxParcial.Show();
            groupBoxConsenso.Hide();
        }

        private void buttonGuardarDiagnostico_Click(object sender, EventArgs e)
        {
            //Guardar Diagnostico 
            if (comboBoxPacienteInsertarDiagnostico.SelectedIndex > -1)
            {
                //Se seleciono un paciente
                if (textBoxNumDiagostico.Text != null)
                {

                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un paciente antes de continuar",
                    "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
	

        private void panelInstrumentosClinicos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxEstudio_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInstClinicos_Enter(object sender, EventArgs e)
        {

        }

        private void EstudioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            panelPacienteEstudio.Hide();
            panelEstudioNuevo.Show();
        }

        private void comboBoxInvestigador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewParcialesPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Guardar Diagnostico 
            if (comboBoxPacienteInsertarDiagnostico.SelectedIndex > -1)
            {
                //Se seleciono un paciente
                if (textBoxEnfermedad.Text != String.Empty)
                {
                    if (textBoxNumDiagostico.Text != String.Empty)
                    {
                        string numDiagnostico = textBoxNumDiagostico.Text;
                        string consultaDiagnostico = "Select * from Diagnostico where NumDiagnostico = @numDiagnostico";
                        SqlDataReader tuplas = baseDatos.ejecutarConsulta(consultaDiagnostico, new Dictionary<string, object> { { "numDiagnostico", numDiagnostico } });
                        if (tuplas.HasRows)
                        {
                            MessageBox.Show("El número de diagnóstico ya existe",
                                            "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            if (textBoxLinkDiagnostico.Text != String.Empty)
                            {
                                if (dataGridViewSintomas.Rows.Count > 0)
                                {
                                    if (radioButtonDiagnosticoParcial.Checked)
                                    {
                                        if (comboBoxInvestigador.SelectedIndex > -1)
                                        {
                                            DateTime fechaTemp = dateTimePicker2.Value;
                                            string fecha = fechaTemp.ToString("yyyy-MM-dd");

                                            //Seleciono parcial e investigador, Guardar Parcial
                                            diagnosticos.insertarDiagnosticoParcial(seleccionarCedulaComboBox(comboBoxPacienteInsertarDiagnostico), textBoxNumDiagostico.Text,
                                                seleccionarCedulaComboBox(comboBoxInvestigador), textBoxLinkDiagnostico.Text,
                                                fecha, textBoxEnfermedad.Text, baseDatos);
                                            diagnosticos.insertarSintomas(seleccionarCedulaComboBox(comboBoxPacienteInsertarDiagnostico),
                                                textBoxNumDiagostico.Text, dataGridViewSintomas, baseDatos);

                                            MessageBox.Show("La información fue insertada exitosamente",
                                                "Inserción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            textBoxLinkDiagnostico.Text = null;
                                            textBoxNumDiagostico.Text = null;
                                            dataGridViewSintomas.Rows.Clear();
                                            textBoxEnfermedad.Text = null;

                                        }
                                        else
                                        {
                                            MessageBox.Show("Por favor seleccione un investigador antes de continuar",
                                                "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                    }
                                    else
                                    {
                                        //Seleciono Concenso
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Por favor inserte al menos un síntoma en el diagnóstico",
                                "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Por favor inserte el link del diagnóstico antes de continuar",
                                 "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor inserte el número de diagnóstico antes de continuar",
                       "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor inserte la enfermedad antes de continuar",
                 "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un paciente antes de continuar",
                    "La información no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void PanelInsertarDiagnostico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInsertarInvestigador_Click(object sender, EventArgs e)
        {
            string CedInvest = textBoxInsertarinvestCedula.Text.Trim();
            string NombInvest = textBoxInsertNombInvest.Text.Trim();
            string Ap1Invest = textBoxInsertAp1Invest.Text.Trim();
            string Ap2Invest = textBoxInsertAp2Invest.Text.Trim();
            char sexo;
            if (radioButtonMInv.Checked == true)
            {
                sexo = 'M';
            }
            else if (radioButtonFInv.Checked == true)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'I';
            }
            string FechaNac = dateTimePickerFechaNacInvest.Value.ToString("yyyy-MM-dd");
            string InsertarPersona = "Insert into Persona values ('" + CedInvest + "', '" + NombInvest + "', '" + Ap1Invest + "', '" + Ap2Invest + "', '" + FechaNac + "', '" + sexo + "')";
            string InsertarInvestigador = "Insert into Investigador values ('" + CedInvest + "')";
            if (checks.checkCedula(CedInvest))
            {
                baseDatos.insertarDatos(InsertarPersona);
                baseDatos.insertarDatos(InsertarInvestigador);
                MessageBox.Show("Se agregó el investigador de cédula " + CedInvest + " a la base de datos");
            }

        }

        private void buttonInsertarPac_Click(object sender, EventArgs e)
        {
            string CedPac = textBoxCedPac.Text.Trim();
            string NombPac = textBoxNomPac.Text.Trim();
            string Ap1Pac = textBoxAp1Pac.Text.Trim();
            string Ap2Pac = textBoxAp2Pac.Text.Trim();
            char sexo;
            string InsertarPersona = "";
            string FechaNac = dateTimePickerPac.Value.ToString("yyyy-MM-dd");
            if (radioButtonMPac.Checked == true)
            {
                sexo = 'M';
                InsertarPersona = "INSERT INTO Persona VALUES ('" + CedPac + "', '" + NombPac + "', '" + Ap1Pac + "', '" + Ap2Pac + "', '" + FechaNac + "', '" + sexo + "')";
            }
            else if (radioButtonFPac.Checked == true)
            {
                sexo = 'F';
                InsertarPersona = "INSERT INTO Persona  VALUES ('" + CedPac + "', '" + NombPac + "', '" + Ap1Pac + "', '" + Ap2Pac + "', '" + FechaNac + "', '" + sexo + "')";
            }
             else
            {
                InsertarPersona = "INSERT INTO Persona (Cedula,PrimerNombre,Apellido1,Apellido2,FechaDeNacimiento) VALUES ('" + CedPac + "', '" + NombPac + "', '" + Ap1Pac + "', '" + Ap2Pac + "', '" + FechaNac + "')";
               // sexo = 'I';
            }
            
           
            string InsertarPaciente = "INSERT INTO Paciente VALUES ('" + CedPac + "')";
            if (checks.checkCedula(CedPac))
            {
                baseDatos.insertarDatos(InsertarPersona);
                baseDatos.insertarDatos(InsertarPaciente);
                baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxPaciente1, 4);
                baseDatos.llenarComboBox(consultaPacientes, new Dictionary<string, object> { }, comboBoxPaciente2, 4);
                MessageBox.Show("Se agregó el paciente de cédula " + CedPac + " a la base de datos");
            }
        }

        private void buttonInsertarMuestra_Click(object sender, EventArgs e)
        {
            if(comboBoxPaciente1.Text == "")
            {
                MessageBox.Show("No puedes dejar el campo de nombre vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cedula = seleccionarCedulaComboBox(comboBoxPaciente1);
                string tipo = textBoxTipoMuestra.Text;
                string localizacion = textBoxLocalizacion.Text;
                string consulta = "INSERT INTO Muestra VALUES(@cedula, @tipo, @localizacion)";
                baseDatos.ejecutarConsulta(consulta, new Dictionary<string, object> { {"cedula",cedula},{"tipo",tipo},{"localizacion", localizacion}});
                MessageBox.Show("Se agregó la muestra del paciente.");
                textBoxTipoMuestra.Text = "";
                textBoxLocalizacion.Text = "";
            }
        }

        private void buttonInsertarGenotipeo_Click(object sender, EventArgs e)
        {
            if (comboBoxPaciente2.Text == "")
            {
                MessageBox.Show("No puedes dejar el campo de nombre vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cedula = seleccionarCedulaComboBox(comboBoxPaciente2);
                string metodo = textBoxMetodo.Text;
                string link = textBoxLink.Text;
                string consulta = "INSERT INTO Genotipeo VALUES(@cedula, @metodo, @link)";
                baseDatos.ejecutarConsulta(consulta, new Dictionary<string, object> { { "cedula", cedula }, { "metodo", metodo }, { "link", link } });
                MessageBox.Show("Se agregó el genotipeo del paciente.");
                textBoxMetodo.Text = "";
                textBoxLink.Text = "";
            }
        }
    }
}
