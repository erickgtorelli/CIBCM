using System;
using System.Windows.Forms;

namespace BD_CIBCM
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VentanaPrincipal = new System.Windows.Forms.TabControl();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.consultarEstudio = new System.Windows.Forms.RadioButton();
            this.radioButtonConsultarInstrumentos = new System.Windows.Forms.RadioButton();
            this.Insertar = new System.Windows.Forms.TabPage();
            this.radioButtonInsertarInvestigador = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertEstudio = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertarInstrumentos = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagnosticoInsertar = new System.Windows.Forms.RadioButton();
            this.Borrar = new System.Windows.Forms.TabPage();
            this.groupBoxConsenso = new System.Windows.Forms.GroupBox();
            this.groupBoxDiagnosticosParcialesDelPaciente = new System.Windows.Forms.GroupBox();
            this.dataGridViewParcialesPaciente = new System.Windows.Forms.DataGridView();
            this.Seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelInsertarDiagnostico = new System.Windows.Forms.Panel();
            this.panelInvestEstudioInsertar = new System.Windows.Forms.Panel();
            this.buttonGuardarDiagnostico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxParcial = new System.Windows.Forms.GroupBox();
            this.labelInvestigador = new System.Windows.Forms.Label();
            this.comboBoxInvestigador = new System.Windows.Forms.ComboBox();
            this.comboBoxPacienteInsertarDiagnostico = new System.Windows.Forms.ComboBox();
            this.radioButtonConsenso = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagnosticoParcial = new System.Windows.Forms.RadioButton();
            this.panelParcialInsertar = new System.Windows.Forms.Panel();
            this.dataGridViewSintomas = new System.Windows.Forms.DataGridView();
            this.Sintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLinkInsertarDiagnostico = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelAgregarSintoma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFechaDiagnostico = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelNumDiagnostico = new System.Windows.Forms.Label();
            this.textBoxNumDiagostico = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelInstrumentosClinicos = new System.Windows.Forms.Panel();
            this.groupBoxInstClinicos = new System.Windows.Forms.GroupBox();
            this.guardarInstrumentosClinicos = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxInstrumentos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCedInst = new System.Windows.Forms.ComboBox();
            this.listaInstClinicos = new System.Windows.Forms.CheckedListBox();
            this.groupBoxEstudio = new System.Windows.Forms.GroupBox();
            this.EstudioNuevo = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertPacEstudio = new System.Windows.Forms.RadioButton();
            this.panelEstudioNuevo = new System.Windows.Forms.Panel();
            this.comboBoxInvestEstudio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxInsertarEstudio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardarEstudio = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.codEst = new System.Windows.Forms.Label();
            this.panelPacienteEstudio = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.codigoParticipacion = new System.Windows.Forms.TextBox();
            this.guardarParticipo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxInsertarEstudioPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxCedPacEstudioInsert = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonInstClinicPaciente = new System.Windows.Forms.Button();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.groupBoxConsultaEstudio = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridViewEstudio2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewEstudio1 = new System.Windows.Forms.DataGridView();
            this.groupBoxConsultaInstrumentosClinicos = new System.Windows.Forms.GroupBox();
            this.dataGridViewInstrumentos2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewInstrumentos1 = new System.Windows.Forms.DataGridView();
            this.panelInsertarInvestigador = new System.Windows.Forms.Panel();
            this.buttonInsertarInvest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacInvest = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxInsertNombInvest = new System.Windows.Forms.TextBox();
            this.textBoxInsertAp1Invest = new System.Windows.Forms.TextBox();
            this.textBoxInsertAp2Invest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxInsertarinvestCedula = new System.Windows.Forms.TextBox();
            this.panelBorrarInvest = new System.Windows.Forms.Panel();
            this.comboBoxBorrarInvest = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonBorrarInvest = new System.Windows.Forms.Button();
            this.VentanaPrincipal.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.Insertar.SuspendLayout();
            this.Borrar.SuspendLayout();
            this.groupBoxConsenso.SuspendLayout();
            this.groupBoxDiagnosticosParcialesDelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcialesPaciente)).BeginInit();
            this.PanelInsertarDiagnostico.SuspendLayout();
            this.groupBoxParcial.SuspendLayout();
            this.panelParcialInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSintomas)).BeginInit();
            this.panelInstrumentosClinicos.SuspendLayout();
            this.groupBoxEstudio.SuspendLayout();
            this.panelEstudioNuevo.SuspendLayout();
            this.panelPacienteEstudio.SuspendLayout();
            this.groupBoxInstClinicos.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            this.groupBoxConsultaEstudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudio1)).BeginInit();
            this.groupBoxConsultaInstrumentosClinicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentos1)).BeginInit();
            this.panelInsertarInvestigador.SuspendLayout();
            this.panelBorrarInvest.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaPrincipal
            // 
            this.VentanaPrincipal.Controls.Add(this.Consultar);
            this.VentanaPrincipal.Controls.Add(this.Insertar);
            this.VentanaPrincipal.Controls.Add(this.Borrar);
            this.VentanaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.VentanaPrincipal.Name = "VentanaPrincipal";
            this.VentanaPrincipal.SelectedIndex = 0;
            this.VentanaPrincipal.Size = new System.Drawing.Size(181, 487);
            this.VentanaPrincipal.TabIndex = 0;
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.radioButton1);
            this.Consultar.Controls.Add(this.consultarEstudio);
            this.Consultar.Controls.Add(this.radioButtonConsultarInstrumentos);
            this.Consultar.Location = new System.Drawing.Point(4, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3);
            this.Consultar.Size = new System.Drawing.Size(173, 461);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 226);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Persona";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_3);
            // 
            // consultarEstudio
            // 
            this.consultarEstudio.AutoSize = true;
            this.consultarEstudio.Location = new System.Drawing.Point(19, 254);
            this.consultarEstudio.Name = "consultarEstudio";
            this.consultarEstudio.Size = new System.Drawing.Size(60, 17);
            this.consultarEstudio.TabIndex = 1;
            this.consultarEstudio.TabStop = true;
            this.consultarEstudio.Text = "Estudio";
            this.consultarEstudio.UseVisualStyleBackColor = true;
            this.consultarEstudio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
            // 
            // radioButtonConsultarInstrumentos
            // 
            this.radioButtonConsultarInstrumentos.AutoSize = true;
            this.radioButtonConsultarInstrumentos.Location = new System.Drawing.Point(19, 192);
            this.radioButtonConsultarInstrumentos.Name = "radioButtonConsultarInstrumentos";
            this.radioButtonConsultarInstrumentos.Size = new System.Drawing.Size(129, 17);
            this.radioButtonConsultarInstrumentos.TabIndex = 0;
            this.radioButtonConsultarInstrumentos.TabStop = true;
            this.radioButtonConsultarInstrumentos.Text = "Instrumentos Clínicos ";
            this.radioButtonConsultarInstrumentos.UseVisualStyleBackColor = true;
            this.radioButtonConsultarInstrumentos.CheckedChanged += new System.EventHandler(this.radioButtonConsultarInstrumentos_CheckedChanged);
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.radioButtonInsertarInvestigador);
            this.Insertar.Controls.Add(this.radioButtonInsertEstudio);
            this.Insertar.Controls.Add(this.radioButtonInsertarInstrumentos);
            this.Insertar.Controls.Add(this.radioButtonDiagnosticoInsertar);
            this.Insertar.Location = new System.Drawing.Point(4, 22);
            this.Insertar.Name = "Insertar";
            this.Insertar.Padding = new System.Windows.Forms.Padding(3);
            this.Insertar.Size = new System.Drawing.Size(173, 461);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsertarInvestigador
            // 
            this.radioButtonInsertarInvestigador.AutoSize = true;
            this.radioButtonInsertarInvestigador.Location = new System.Drawing.Point(19, 79);
            this.radioButtonInsertarInvestigador.Name = "radioButtonInsertarInvestigador";
            this.radioButtonInsertarInvestigador.Size = new System.Drawing.Size(83, 17);
            this.radioButtonInsertarInvestigador.TabIndex = 4;
            this.radioButtonInsertarInvestigador.TabStop = true;
            this.radioButtonInsertarInvestigador.Text = "Investigador";
            this.radioButtonInsertarInvestigador.UseVisualStyleBackColor = true;
            this.radioButtonInsertarInvestigador.CheckedChanged += new System.EventHandler(this.radioButtonInsertarInvestigador_CheckedChanged);
            // 
            // radioButtonInsertEstudio
            // 
            this.radioButtonInsertEstudio.AutoSize = true;
            this.radioButtonInsertEstudio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonInsertEstudio.Location = new System.Drawing.Point(19, 270);
            this.radioButtonInsertEstudio.Name = "radioButtonInsertEstudio";
            this.radioButtonInsertEstudio.Size = new System.Drawing.Size(60, 17);
            this.radioButtonInsertEstudio.TabIndex = 3;
            this.radioButtonInsertEstudio.TabStop = true;
            this.radioButtonInsertEstudio.Text = "Estudio";
            this.radioButtonInsertEstudio.UseVisualStyleBackColor = true;
            this.radioButtonInsertEstudio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButtonInsertarInstrumentos
            // 
            this.radioButtonInsertarInstrumentos.AutoSize = true;
            this.radioButtonInsertarInstrumentos.Location = new System.Drawing.Point(19, 207);
            this.radioButtonInsertarInstrumentos.Name = "radioButtonInsertarInstrumentos";
            this.radioButtonInsertarInstrumentos.Size = new System.Drawing.Size(129, 17);
            this.radioButtonInsertarInstrumentos.TabIndex = 1;
            this.radioButtonInsertarInstrumentos.TabStop = true;
            this.radioButtonInsertarInstrumentos.Text = "Instrumentos Clínicos ";
            this.radioButtonInsertarInstrumentos.UseVisualStyleBackColor = true;
            this.radioButtonInsertarInstrumentos.CheckedChanged += new System.EventHandler(this.radioButtonInsertarInstrumentos_CheckedChanged);
            // 
            // radioButtonDiagnosticoInsertar
            // 
            this.radioButtonDiagnosticoInsertar.AutoSize = true;
            this.radioButtonDiagnosticoInsertar.Location = new System.Drawing.Point(19, 13);
            this.radioButtonDiagnosticoInsertar.Name = "radioButtonDiagnosticoInsertar";
            this.radioButtonDiagnosticoInsertar.Size = new System.Drawing.Size(81, 17);
            this.radioButtonDiagnosticoInsertar.TabIndex = 0;
            this.radioButtonDiagnosticoInsertar.TabStop = true;
            this.radioButtonDiagnosticoInsertar.Text = "Diagnóstico";
            this.radioButtonDiagnosticoInsertar.UseVisualStyleBackColor = true;
            this.radioButtonDiagnosticoInsertar.CheckedChanged += new System.EventHandler(this.radioButtonDiagnosticoInsertar_CheckedChanged);
            // 
            // Borrar
            // 
            this.Borrar.Controls.Add(this.radioButton1);
            this.Borrar.Location = new System.Drawing.Point(4, 22);
            this.Borrar.Name = "Borrar";
            this.Borrar.Padding = new System.Windows.Forms.Padding(3);
            this.Borrar.Size = new System.Drawing.Size(173, 461);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsenso
            // 
            this.groupBoxConsenso.Controls.Add(this.groupBoxDiagnosticosParcialesDelPaciente);
            this.groupBoxConsenso.Location = new System.Drawing.Point(377, 192);
            this.groupBoxConsenso.Name = "groupBoxConsenso";
            this.groupBoxConsenso.Size = new System.Drawing.Size(384, 171);
            this.groupBoxConsenso.TabIndex = 1;
            this.groupBoxConsenso.TabStop = false;
            this.groupBoxConsenso.Text = "Diagnóstico Consenso";
            this.groupBoxConsenso.Visible = false;
            this.groupBoxConsenso.Enter += new System.EventHandler(this.groupBoxConsenso_Enter);
            // 
            // groupBoxDiagnosticosParcialesDelPaciente
            // 
            this.groupBoxDiagnosticosParcialesDelPaciente.Controls.Add(this.dataGridViewParcialesPaciente);
            this.groupBoxDiagnosticosParcialesDelPaciente.Location = new System.Drawing.Point(6, 23);
            this.groupBoxDiagnosticosParcialesDelPaciente.Name = "groupBoxDiagnosticosParcialesDelPaciente";
            this.groupBoxDiagnosticosParcialesDelPaciente.Size = new System.Drawing.Size(428, 142);
            this.groupBoxDiagnosticosParcialesDelPaciente.TabIndex = 0;
            this.groupBoxDiagnosticosParcialesDelPaciente.TabStop = false;
            this.groupBoxDiagnosticosParcialesDelPaciente.Text = "Diagnósticos parciales del paciente";
            // 
            // dataGridViewParcialesPaciente
            // 
            this.dataGridViewParcialesPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcialesPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionado});
            this.dataGridViewParcialesPaciente.Location = new System.Drawing.Point(0, 15);
            this.dataGridViewParcialesPaciente.Name = "dataGridViewParcialesPaciente";
            this.dataGridViewParcialesPaciente.Size = new System.Drawing.Size(428, 127);
            this.dataGridViewParcialesPaciente.TabIndex = 0;
            this.dataGridViewParcialesPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccionado
            // 
            this.Seleccionado.HeaderText = "Seleccionado";
            this.Seleccionado.Name = "Seleccionado";
            // 
            // PanelInsertarDiagnostico
            // 
            this.PanelInsertarDiagnostico.AutoSize = global::BD_CIBCM.Properties.Settings.Default.AutoSize;
            this.PanelInsertarDiagnostico.Controls.Add(this.buttonGuardarDiagnostico);
            this.PanelInsertarDiagnostico.Controls.Add(this.label1);
            this.PanelInsertarDiagnostico.Controls.Add(this.groupBoxParcial);
            this.PanelInsertarDiagnostico.Controls.Add(this.comboBoxPacienteInsertarDiagnostico);
            this.PanelInsertarDiagnostico.Controls.Add(this.radioButtonConsenso);
            this.PanelInsertarDiagnostico.Controls.Add(this.radioButtonDiagnosticoParcial);
            this.PanelInsertarDiagnostico.Controls.Add(this.panelParcialInsertar);
            this.PanelInsertarDiagnostico.DataBindings.Add(new System.Windows.Forms.Binding("AutoSize", global::BD_CIBCM.Properties.Settings.Default, "AutoSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelInsertarDiagnostico.Location = new System.Drawing.Point(207, 34);
            this.PanelInsertarDiagnostico.Name = "PanelInsertarDiagnostico";
            this.PanelInsertarDiagnostico.Size = new System.Drawing.Size(789, 549);
            this.PanelInsertarDiagnostico.TabIndex = 1;
            this.PanelInsertarDiagnostico.Visible = false;
            this.PanelInsertarDiagnostico.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInsertarDiagnostico_Paint);
            // 
            // buttonGuardarDiagnostico
            // 
            this.buttonGuardarDiagnostico.Location = new System.Drawing.Point(610, 502);
            this.buttonGuardarDiagnostico.Name = "buttonGuardarDiagnostico";
            this.buttonGuardarDiagnostico.Size = new System.Drawing.Size(105, 23);
            this.buttonGuardarDiagnostico.TabIndex = 4;
            this.buttonGuardarDiagnostico.Text = "Guardar";
            this.buttonGuardarDiagnostico.UseVisualStyleBackColor = true;
            this.buttonGuardarDiagnostico.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paciente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxParcial
            // 
            this.groupBoxParcial.AutoSize = true;
            this.groupBoxParcial.Controls.Add(this.labelInvestigador);
            this.groupBoxParcial.Controls.Add(this.comboBoxInvestigador);
            this.groupBoxParcial.Location = new System.Drawing.Point(444, 91);
            this.groupBoxParcial.Name = "groupBoxParcial";
            this.groupBoxParcial.Size = new System.Drawing.Size(295, 391);
            this.groupBoxParcial.TabIndex = 0;
            this.groupBoxParcial.TabStop = false;
            this.groupBoxParcial.Text = "Diagnóstico Parcial";
            this.groupBoxParcial.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // labelInvestigador
            // 
            this.labelInvestigador.AutoSize = true;
            this.labelInvestigador.Location = new System.Drawing.Point(18, 43);
            this.labelInvestigador.Name = "labelInvestigador";
            this.labelInvestigador.Size = new System.Drawing.Size(68, 13);
            this.labelInvestigador.TabIndex = 1;
            this.labelInvestigador.Text = "Investigador:";
            // 
            // comboBoxInvestigador
            // 
            this.comboBoxInvestigador.FormattingEnabled = true;
            this.comboBoxInvestigador.Location = new System.Drawing.Point(92, 40);
            this.comboBoxInvestigador.Name = "comboBoxInvestigador";
            this.comboBoxInvestigador.Size = new System.Drawing.Size(197, 21);
            this.comboBoxInvestigador.TabIndex = 0;
            this.comboBoxInvestigador.Text = "Seleccione el investigador";
            this.comboBoxInvestigador.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvestigador_SelectedIndexChanged);
            // 
            // comboBoxPacienteInsertarDiagnostico
            // 
            this.comboBoxPacienteInsertarDiagnostico.FormattingEnabled = true;
            this.comboBoxPacienteInsertarDiagnostico.Location = new System.Drawing.Point(390, 32);
            this.comboBoxPacienteInsertarDiagnostico.Name = "comboBoxPacienteInsertarDiagnostico";
            this.comboBoxPacienteInsertarDiagnostico.Size = new System.Drawing.Size(197, 21);
            this.comboBoxPacienteInsertarDiagnostico.TabIndex = 2;
            this.comboBoxPacienteInsertarDiagnostico.Text = "Seleccione un paciente";
            this.comboBoxPacienteInsertarDiagnostico.SelectedIndexChanged += new System.EventHandler(this.comboBoxPacienteInsertarDiagnostico_SelectedIndexChanged);
            // 
            // radioButtonConsenso
            // 
            this.radioButtonConsenso.AutoSize = true;
            this.radioButtonConsenso.Location = new System.Drawing.Point(13, 36);
            this.radioButtonConsenso.Name = "radioButtonConsenso";
            this.radioButtonConsenso.Size = new System.Drawing.Size(72, 17);
            this.radioButtonConsenso.TabIndex = 1;
            this.radioButtonConsenso.Text = "Consenso";
            this.radioButtonConsenso.UseVisualStyleBackColor = true;
            this.radioButtonConsenso.CheckedChanged += new System.EventHandler(this.radioButtonConsenso_CheckedChanged);
            // 
            // radioButtonDiagnosticoParcial
            // 
            this.radioButtonDiagnosticoParcial.AutoSize = true;
            this.radioButtonDiagnosticoParcial.Checked = true;
            this.radioButtonDiagnosticoParcial.Location = new System.Drawing.Point(13, 16);
            this.radioButtonDiagnosticoParcial.Name = "radioButtonDiagnosticoParcial";
            this.radioButtonDiagnosticoParcial.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDiagnosticoParcial.TabIndex = 0;
            this.radioButtonDiagnosticoParcial.TabStop = true;
            this.radioButtonDiagnosticoParcial.Text = "Parcial";
            this.radioButtonDiagnosticoParcial.UseVisualStyleBackColor = true;
            this.radioButtonDiagnosticoParcial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // panelParcialInsertar
            // 
            this.panelParcialInsertar.AutoSize = true;
            this.panelParcialInsertar.Controls.Add(this.dataGridViewSintomas);
            this.panelParcialInsertar.Controls.Add(this.labelLinkInsertarDiagnostico);
            this.panelParcialInsertar.Controls.Add(this.textBox2);
            this.panelParcialInsertar.Controls.Add(this.LabelAgregarSintoma);
            this.panelParcialInsertar.Controls.Add(this.textBox1);
            this.panelParcialInsertar.Controls.Add(this.labelFechaDiagnostico);
            this.panelParcialInsertar.Controls.Add(this.groupBoxConsenso);
            this.panelParcialInsertar.Controls.Add(this.dateTimePicker1);
            this.panelParcialInsertar.Controls.Add(this.LabelNumDiagnostico);
            this.panelParcialInsertar.Controls.Add(this.textBoxNumDiagostico);
            this.panelParcialInsertar.Location = new System.Drawing.Point(13, 91);
            this.panelParcialInsertar.Name = "panelParcialInsertar";
            this.panelParcialInsertar.Size = new System.Drawing.Size(773, 366);
            this.panelParcialInsertar.TabIndex = 2;
            this.panelParcialInsertar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelParcialInsertar_Paint);
            // 
            // dataGridViewSintomas
            // 
            this.dataGridViewSintomas.AllowUserToOrderColumns = true;
            this.dataGridViewSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sintoma});
            this.dataGridViewSintomas.Location = new System.Drawing.Point(6, 254);
            this.dataGridViewSintomas.Name = "dataGridViewSintomas";
            this.dataGridViewSintomas.ReadOnly = true;
            this.dataGridViewSintomas.Size = new System.Drawing.Size(338, 109);
            this.dataGridViewSintomas.TabIndex = 7;
            // 
            // Sintoma
            // 
            this.Sintoma.HeaderText = "Síntomas";
            this.Sintoma.Name = "Sintoma";
            this.Sintoma.ReadOnly = true;
            // 
            // labelLinkInsertarDiagnostico
            // 
            this.labelLinkInsertarDiagnostico.AutoSize = true;
            this.labelLinkInsertarDiagnostico.Location = new System.Drawing.Point(16, 135);
            this.labelLinkInsertarDiagnostico.Name = "labelLinkInsertarDiagnostico";
            this.labelLinkInsertarDiagnostico.Size = new System.Drawing.Size(27, 13);
            this.labelLinkInsertarDiagnostico.TabIndex = 9;
            this.labelLinkInsertarDiagnostico.Text = "Link";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelAgregarSintoma
            // 
            this.LabelAgregarSintoma.AutoSize = true;
            this.LabelAgregarSintoma.Location = new System.Drawing.Point(16, 206);
            this.LabelAgregarSintoma.Name = "LabelAgregarSintoma";
            this.LabelAgregarSintoma.Size = new System.Drawing.Size(85, 13);
            this.LabelAgregarSintoma.TabIndex = 6;
            this.LabelAgregarSintoma.Text = "Agregar síntoma";
            this.LabelAgregarSintoma.Click += new System.EventHandler(this.LabelAgregarSintoma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // labelFechaDiagnostico
            // 
            this.labelFechaDiagnostico.AutoSize = true;
            this.labelFechaDiagnostico.Location = new System.Drawing.Point(23, 71);
            this.labelFechaDiagnostico.Name = "labelFechaDiagnostico";
            this.labelFechaDiagnostico.Size = new System.Drawing.Size(111, 13);
            this.labelFechaDiagnostico.TabIndex = 4;
            this.labelFechaDiagnostico.Text = "Fecha del diagnóstico";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // LabelNumDiagnostico
            // 
            this.LabelNumDiagnostico.AutoSize = true;
            this.LabelNumDiagnostico.Location = new System.Drawing.Point(16, 12);
            this.LabelNumDiagnostico.Name = "LabelNumDiagnostico";
            this.LabelNumDiagnostico.Size = new System.Drawing.Size(116, 13);
            this.LabelNumDiagnostico.TabIndex = 2;
            this.LabelNumDiagnostico.Text = "Número de diagnóstico";
            // 
            // textBoxNumDiagostico
            // 
            this.textBoxNumDiagostico.Location = new System.Drawing.Point(19, 28);
            this.textBoxNumDiagostico.Name = "textBoxNumDiagostico";
            this.textBoxNumDiagostico.Size = new System.Drawing.Size(137, 20);
            this.textBoxNumDiagostico.TabIndex = 1;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Borrar síntomas";
            // 
            // panelInstrumentosClinicos
            // 
            this.panelInstrumentosClinicos.Controls.Add(this.panelInvestEstudioInsertar);
            this.panelInstrumentosClinicos.Controls.Add(this.groupBoxEstudio);
            this.panelInstrumentosClinicos.Controls.Add(this.groupBoxInstClinicos);
            this.panelInstrumentosClinicos.Location = new System.Drawing.Point(220, 34);
            this.panelInstrumentosClinicos.Name = "panelInstrumentosClinicos";
            this.panelInstrumentosClinicos.Size = new System.Drawing.Size(740, 476);
            this.panelInstrumentosClinicos.TabIndex = 5;
            this.panelInstrumentosClinicos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInstrumentosClinicos_Paint);
            // 
            // panelInvestEstudioInsertar
            // 
            this.panelInvestEstudioInsertar.Location = new System.Drawing.Point(238, 416);
            this.panelInvestEstudioInsertar.Name = "panelInvestEstudioInsertar";
            this.panelInvestEstudioInsertar.Size = new System.Drawing.Size(388, 37);
            this.panelInvestEstudioInsertar.TabIndex = 12;
            this.panelInvestEstudioInsertar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInvestEstudioInsertar_Paint);
            // 
            // guardarInstrumentosClinicos
            // 
            this.guardarInstrumentosClinicos.Location = new System.Drawing.Point(192, 375);
            this.guardarInstrumentosClinicos.Name = "guardarInstrumentosClinicos";
            this.guardarInstrumentosClinicos.Size = new System.Drawing.Size(75, 23);
            this.guardarInstrumentosClinicos.TabIndex = 7;
            this.guardarInstrumentosClinicos.Text = "Guardar";
            this.guardarInstrumentosClinicos.UseVisualStyleBackColor = true;
            // 
            // buttonInstClinicPaciente
            // 
            this.buttonInstClinicPaciente.Location = new System.Drawing.Point(120, 290);
            this.buttonInstClinicPaciente.Name = "buttonInstClinicPaciente";
            this.buttonInstClinicPaciente.Size = new System.Drawing.Size(214, 23);
            this.buttonInstClinicPaciente.TabIndex = 6;
            this.buttonInstClinicPaciente.Text = "Agregar instrumento(s) clínico(s) a paciente";
            this.buttonInstClinicPaciente.UseVisualStyleBackColor = true;
            this.buttonInstClinicPaciente.Click += new System.EventHandler(this.buttonInstClinicPaciente_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Inserte nombre de instrumento clínico";
            // 
            // textBoxInstrumentos
            // 
            this.textBoxInstrumentos.Location = new System.Drawing.Point(215, 58);
            this.textBoxInstrumentos.Name = "textBoxInstrumentos";
            this.textBoxInstrumentos.Size = new System.Drawing.Size(242, 20);
            this.textBoxInstrumentos.TabIndex = 4;
            this.textBoxInstrumentos.TextChanged += new System.EventHandler(this.textBoxInstrumentos_TextChanged);
            this.textBoxInstrumentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInstrumentos_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inserte o seleccione nombre de instrumento clínico";
            // 
            // comboBoxCedInst
            // 
            this.comboBoxCedInst.FormattingEnabled = true;
            this.comboBoxCedInst.Location = new System.Drawing.Point(86, 326);
            this.comboBoxCedInst.Name = "comboBoxCedInst";
            this.comboBoxCedInst.Size = new System.Drawing.Size(280, 21);
            this.comboBoxCedInst.TabIndex = 0;
            this.comboBoxCedInst.Text = "Seleccione Cedula Paciente";
            // 
            // listaInstClinicos
            // 
            this.listaInstClinicos.FormattingEnabled = true;
            this.listaInstClinicos.Location = new System.Drawing.Point(101, 94);
            this.listaInstClinicos.Name = "listaInstClinicos";
            this.listaInstClinicos.Size = new System.Drawing.Size(262, 184);
            this.listaInstClinicos.TabIndex = 2;
            this.listaInstClinicos.ThreeDCheckBoxes = true;
            this.listaInstClinicos.SelectedIndexChanged += new System.EventHandler(this.listaInstClinicos_SelectedIndexChanged);
            // 
            // groupBoxEstudio
            // 
            this.groupBoxEstudio.Controls.Add(this.EstudioNuevo);
            this.groupBoxEstudio.Controls.Add(this.radioButtonInsertPacEstudio);
            this.groupBoxEstudio.Controls.Add(this.panelEstudioNuevo);
            this.groupBoxEstudio.Controls.Add(this.panelPacienteEstudio);
            this.groupBoxEstudio.Location = new System.Drawing.Point(140, 54);
            this.groupBoxEstudio.Name = "groupBoxEstudio";
            this.groupBoxEstudio.Size = new System.Drawing.Size(580, 345);
            this.groupBoxEstudio.TabIndex = 4;
            this.groupBoxEstudio.TabStop = false;
            this.groupBoxEstudio.Text = "Estudio ";
            this.groupBoxEstudio.Enter += new System.EventHandler(this.groupBoxEstudio_Enter);
            // 
            // EstudioNuevo
            // 
            this.EstudioNuevo.AutoSize = true;
            this.EstudioNuevo.Location = new System.Drawing.Point(272, 33);
            this.EstudioNuevo.Name = "EstudioNuevo";
            this.EstudioNuevo.Size = new System.Drawing.Size(95, 17);
            this.EstudioNuevo.TabIndex = 14;
            this.EstudioNuevo.TabStop = true;
            this.EstudioNuevo.Text = "Estudio Nuevo";
            this.EstudioNuevo.UseVisualStyleBackColor = true;
            this.EstudioNuevo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // radioButtonInsertPacEstudio
            // 
            this.radioButtonInsertPacEstudio.AutoSize = true;
            this.radioButtonInsertPacEstudio.Location = new System.Drawing.Point(164, 31);
            this.radioButtonInsertPacEstudio.Name = "radioButtonInsertPacEstudio";
            this.radioButtonInsertPacEstudio.Size = new System.Drawing.Size(67, 17);
            this.radioButtonInsertPacEstudio.TabIndex = 10;
            this.radioButtonInsertPacEstudio.TabStop = true;
            this.radioButtonInsertPacEstudio.Text = "Paciente";
            this.radioButtonInsertPacEstudio.UseVisualStyleBackColor = true;
            this.radioButtonInsertPacEstudio.CheckedChanged += new System.EventHandler(this.radioButtonInsertPacEstudio_CheckedChanged);
            // 
            // panelEstudioNuevo
            // 
            this.panelEstudioNuevo.Controls.Add(this.comboBoxInvestEstudio);
            this.panelEstudioNuevo.Controls.Add(this.label2);
            this.panelEstudioNuevo.Controls.Add(this.comboBoxInsertarEstudio);
            this.panelEstudioNuevo.Controls.Add(this.label4);
            this.panelEstudioNuevo.Controls.Add(this.textBox4);
            this.panelEstudioNuevo.Controls.Add(this.label3);
            this.panelEstudioNuevo.Controls.Add(this.buttonGuardarEstudio);
            this.panelEstudioNuevo.Controls.Add(this.dateTimePicker2);
            this.panelEstudioNuevo.Controls.Add(this.codEst);
            this.panelEstudioNuevo.Location = new System.Drawing.Point(58, 71);
            this.panelEstudioNuevo.Name = "panelEstudioNuevo";
            this.panelEstudioNuevo.Size = new System.Drawing.Size(432, 260);
            this.panelEstudioNuevo.TabIndex = 15;
            this.panelEstudioNuevo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEstudioNuevo_Paint);
            // 
            // comboBoxInvestEstudio
            // 
            this.comboBoxInvestEstudio.FormattingEnabled = true;
            this.comboBoxInvestEstudio.Location = new System.Drawing.Point(132, 110);
            this.comboBoxInvestEstudio.Name = "comboBoxInvestEstudio";
            this.comboBoxInvestEstudio.Size = new System.Drawing.Size(251, 21);
            this.comboBoxInvestEstudio.TabIndex = 0;
            this.comboBoxInvestEstudio.Text = "Seleccione Cédula de Investigador";
            this.comboBoxInvestEstudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvestEstudio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Investigador";
            // 
            // comboBoxInsertarEstudio
            // 
            this.comboBoxInsertarEstudio.FormattingEnabled = true;
            this.comboBoxInsertarEstudio.Location = new System.Drawing.Point(132, 19);
            this.comboBoxInsertarEstudio.Name = "comboBoxInsertarEstudio";
            this.comboBoxInsertarEstudio.Size = new System.Drawing.Size(251, 21);
            this.comboBoxInsertarEstudio.TabIndex = 9;
            this.comboBoxInsertarEstudio.Text = "Seleccione o Inserte codigo estudio";
            this.comboBoxInsertarEstudio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // buttonGuardarEstudio
            // 
            this.buttonGuardarEstudio.Location = new System.Drawing.Point(307, 227);
            this.buttonGuardarEstudio.Name = "buttonGuardarEstudio";
            this.buttonGuardarEstudio.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarEstudio.TabIndex = 8;
            this.buttonGuardarEstudio.Text = "Guardar";
            this.buttonGuardarEstudio.UseVisualStyleBackColor = true;
            this.buttonGuardarEstudio.Click += new System.EventHandler(this.buttonGuardarEstudio_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // codEst
            // 
            this.codEst.AutoSize = true;
            this.codEst.Location = new System.Drawing.Point(13, 22);
            this.codEst.Name = "codEst";
            this.codEst.Size = new System.Drawing.Size(95, 13);
            this.codEst.TabIndex = 2;
            this.codEst.Text = "Código De Estudio";
            // 
            // panelPacienteEstudio
            // 
            this.panelPacienteEstudio.Controls.Add(this.label9);
            this.panelPacienteEstudio.Controls.Add(this.codigoParticipacion);
            this.panelPacienteEstudio.Controls.Add(this.guardarParticipo);
            this.panelPacienteEstudio.Controls.Add(this.label8);
            this.panelPacienteEstudio.Controls.Add(this.comboBoxInsertarEstudioPaciente);
            this.panelPacienteEstudio.Controls.Add(this.comboBoxCedPacEstudioInsert);
            this.panelPacienteEstudio.Controls.Add(this.label6);
            this.panelPacienteEstudio.Location = new System.Drawing.Point(76, 62);
            this.panelPacienteEstudio.Name = "panelPacienteEstudio";
            this.panelPacienteEstudio.Size = new System.Drawing.Size(378, 183);
            this.panelPacienteEstudio.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Código de Participación";
            // 
            // codigoParticipacion
            // 
            this.codigoParticipacion.Location = new System.Drawing.Point(144, 91);
            this.codigoParticipacion.Name = "codigoParticipacion";
            this.codigoParticipacion.Size = new System.Drawing.Size(100, 20);
            this.codigoParticipacion.TabIndex = 18;
            this.codigoParticipacion.TextChanged += new System.EventHandler(this.codigoParticipacion_TextChanged);
            // 
            // guardarParticipo
            // 
            this.guardarParticipo.Location = new System.Drawing.Point(230, 132);
            this.guardarParticipo.Name = "guardarParticipo";
            this.guardarParticipo.Size = new System.Drawing.Size(75, 23);
            this.guardarParticipo.TabIndex = 17;
            this.guardarParticipo.Text = "Guardar";
            this.guardarParticipo.UseVisualStyleBackColor = true;
            this.guardarParticipo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código Estudio";
            // 
            // comboBoxInsertarEstudioPaciente
            // 
            this.comboBoxInsertarEstudioPaciente.FormattingEnabled = true;
            this.comboBoxInsertarEstudioPaciente.Location = new System.Drawing.Point(144, 47);
            this.comboBoxInsertarEstudioPaciente.Name = "comboBoxInsertarEstudioPaciente";
            this.comboBoxInsertarEstudioPaciente.Size = new System.Drawing.Size(231, 21);
            this.comboBoxInsertarEstudioPaciente.TabIndex = 15;
            this.comboBoxInsertarEstudioPaciente.Text = "Seleccione el código de estudio";
            this.comboBoxInsertarEstudioPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertarEstudioPaciente_SelectedIndexChanged);
            // 
            // comboBoxCedPacEstudioInsert
            // 
            this.comboBoxCedPacEstudioInsert.FormattingEnabled = true;
            this.comboBoxCedPacEstudioInsert.Location = new System.Drawing.Point(144, 6);
            this.comboBoxCedPacEstudioInsert.Name = "comboBoxCedPacEstudioInsert";
            this.comboBoxCedPacEstudioInsert.Size = new System.Drawing.Size(231, 21);
            this.comboBoxCedPacEstudioInsert.TabIndex = 14;
            this.comboBoxCedPacEstudioInsert.Text = "Seleccione Cédula del Paciente";
            this.comboBoxCedPacEstudioInsert.SelectedIndexChanged += new System.EventHandler(this.comboBoxCedPacEstudioInsert_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cédula Paciente";
            // 
            // groupBoxInstClinicos
            // 
            this.groupBoxInstClinicos.Controls.Add(this.guardarInstrumentosClinicos);
            this.groupBoxInstClinicos.Controls.Add(this.buttonInstClinicPaciente);
            this.groupBoxInstClinicos.Controls.Add(this.label16);
            this.groupBoxInstClinicos.Controls.Add(this.textBoxInstrumentos);
            this.groupBoxInstClinicos.Controls.Add(this.label5);
            this.groupBoxInstClinicos.Controls.Add(this.comboBoxCedInst);
            this.groupBoxInstClinicos.Controls.Add(this.listaInstClinicos);
            this.groupBoxInstClinicos.Location = new System.Drawing.Point(173, 38);
            this.groupBoxInstClinicos.Name = "groupBoxInstClinicos";
            this.groupBoxInstClinicos.Size = new System.Drawing.Size(488, 409);
            this.groupBoxInstClinicos.TabIndex = 3;
            this.groupBoxInstClinicos.TabStop = false;
            this.groupBoxInstClinicos.Text = "Instrumentos Clínicos";
            this.groupBoxInstClinicos.Enter += new System.EventHandler(this.groupBoxInstClinicos_Enter);
            // 
            // guardarInstrumentosClinicos
            // 
            this.guardarInstrumentosClinicos.Location = new System.Drawing.Point(192, 375);
            this.guardarInstrumentosClinicos.Name = "guardarInstrumentosClinicos";
            this.guardarInstrumentosClinicos.Size = new System.Drawing.Size(75, 23);
            this.guardarInstrumentosClinicos.TabIndex = 7;
            this.guardarInstrumentosClinicos.Text = "Guardar";
            this.guardarInstrumentosClinicos.UseVisualStyleBackColor = true;
            // 
            // buttonInstClinicPaciente
            // 
            this.buttonInstClinicPaciente.Location = new System.Drawing.Point(120, 290);
            this.buttonInstClinicPaciente.Name = "buttonInstClinicPaciente";
            this.buttonInstClinicPaciente.Size = new System.Drawing.Size(214, 23);
            this.buttonInstClinicPaciente.TabIndex = 6;
            this.buttonInstClinicPaciente.Text = "Agregar instrumento(s) clínico(s) a paciente";
            this.buttonInstClinicPaciente.UseVisualStyleBackColor = true;
            this.buttonInstClinicPaciente.Click += new System.EventHandler(this.buttonInstClinicPaciente_Click);
            // 
            // textBoxInstrumentos
            // 
            this.textBoxInstrumentos.Location = new System.Drawing.Point(215, 58);
            this.textBoxInstrumentos.Name = "textBoxInstrumentos";
            this.textBoxInstrumentos.Size = new System.Drawing.Size(242, 20);
            this.textBoxInstrumentos.TabIndex = 4;
            this.textBoxInstrumentos.TextChanged += new System.EventHandler(this.textBoxInstrumentos_TextChanged);
            this.textBoxInstrumentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInstrumentos_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inserte o seleccione nombre de instrumento clínico";
            // 
            // comboBoxCedInst
            // 
            this.comboBoxCedInst.FormattingEnabled = true;
            this.comboBoxCedInst.Location = new System.Drawing.Point(86, 326);
            this.comboBoxCedInst.Name = "comboBoxCedInst";
            this.comboBoxCedInst.Size = new System.Drawing.Size(280, 21);
            this.comboBoxCedInst.TabIndex = 0;
            this.comboBoxCedInst.Text = "Seleccione Cedula Paciente";
            // 
            // panelConsultas
            // 
            this.panelConsultas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelConsultas.Controls.Add(this.groupBoxConsultaInstrumentosClinicos);
            this.panelConsultas.Controls.Add(this.groupBoxConsultaEstudio);
            this.panelConsultas.Location = new System.Drawing.Point(210, 19);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(804, 564);
            this.panelConsultas.TabIndex = 15;
            // 
            // groupBoxConsultaEstudio
            // 
            this.groupBoxConsultaEstudio.Controls.Add(this.label18);
            this.groupBoxConsultaEstudio.Controls.Add(this.dataGridViewEstudio2);
            this.groupBoxConsultaEstudio.Controls.Add(this.dataGridViewEstudio1);
            this.groupBoxConsultaEstudio.Location = new System.Drawing.Point(98, 47);
            this.groupBoxConsultaEstudio.Name = "groupBoxConsultaEstudio";
            this.groupBoxConsultaEstudio.Size = new System.Drawing.Size(556, 399);
            this.groupBoxConsultaEstudio.TabIndex = 8;
            this.groupBoxConsultaEstudio.TabStop = false;
            this.groupBoxConsultaEstudio.Text = "Consulta Estudio";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Pacientes que han llenado el estudio";
            // 
            // dataGridViewEstudio2
            // 
            this.dataGridViewEstudio2.AllowUserToAddRows = false;
            this.dataGridViewEstudio2.AllowUserToDeleteRows = false;
            this.dataGridViewEstudio2.AllowUserToResizeColumns = false;
            this.dataGridViewEstudio2.AllowUserToResizeRows = false;
            this.dataGridViewEstudio2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudio2.Location = new System.Drawing.Point(12, 236);
            this.dataGridViewEstudio2.Name = "dataGridViewEstudio2";
            this.dataGridViewEstudio2.ReadOnly = true;
            this.dataGridViewEstudio2.Size = new System.Drawing.Size(527, 150);
            this.dataGridViewEstudio2.TabIndex = 6;
            this.dataGridViewEstudio2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // dataGridViewEstudio1
            // 
            this.dataGridViewEstudio1.AllowUserToAddRows = false;
            this.dataGridViewEstudio1.AllowUserToDeleteRows = false;
            this.dataGridViewEstudio1.AllowUserToResizeColumns = false;
            this.dataGridViewEstudio1.AllowUserToResizeRows = false;
            this.dataGridViewEstudio1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEstudio1.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewEstudio1.Name = "dataGridViewEstudio1";
            this.dataGridViewEstudio1.ReadOnly = true;
            this.dataGridViewEstudio1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEstudio1.Size = new System.Drawing.Size(527, 168);
            this.dataGridViewEstudio1.TabIndex = 5;
            this.dataGridViewEstudio1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEstudio1_RowHeaderMouseClick);
            // 
            // groupBoxConsultaInstrumentosClinicos
            // 
            this.groupBoxConsultaInstrumentosClinicos.Controls.Add(this.label17);
            this.groupBoxConsultaInstrumentosClinicos.Controls.Add(this.dataGridViewInstrumentos2);
            this.groupBoxConsultaInstrumentosClinicos.Controls.Add(this.dataGridViewInstrumentos1);
            this.groupBoxConsultaInstrumentosClinicos.Location = new System.Drawing.Point(98, 47);
            this.groupBoxConsultaInstrumentosClinicos.Name = "groupBoxConsultaInstrumentosClinicos";
            this.groupBoxConsultaInstrumentosClinicos.Size = new System.Drawing.Size(556, 399);
            this.groupBoxConsultaInstrumentosClinicos.TabIndex = 0;
            this.groupBoxConsultaInstrumentosClinicos.TabStop = false;
            this.groupBoxConsultaInstrumentosClinicos.Text = "Consulta Instrumentos Clínicos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Pacientes que han llenado el instrumento";
            // 
            // dataGridViewInstrumentos2
            // 
            this.dataGridViewInstrumentos2.AllowUserToAddRows = false;
            this.dataGridViewInstrumentos2.AllowUserToDeleteRows = false;
            this.dataGridViewInstrumentos2.AllowUserToResizeColumns = false;
            this.dataGridViewInstrumentos2.AllowUserToResizeRows = false;
            this.dataGridViewInstrumentos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstrumentos2.Location = new System.Drawing.Point(12, 236);
            this.dataGridViewInstrumentos2.Name = "dataGridViewInstrumentos2";
            this.dataGridViewInstrumentos2.ReadOnly = true;
            this.dataGridViewInstrumentos2.Size = new System.Drawing.Size(527, 150);
            this.dataGridViewInstrumentos2.TabIndex = 6;
            // 
            // dataGridViewInstrumentos1
            // 
            this.dataGridViewInstrumentos1.AllowUserToAddRows = false;
            this.dataGridViewInstrumentos1.AllowUserToDeleteRows = false;
            this.dataGridViewInstrumentos1.AllowUserToResizeColumns = false;
            this.dataGridViewInstrumentos1.AllowUserToResizeRows = false;
            this.dataGridViewInstrumentos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewInstrumentos1.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewInstrumentos1.Name = "dataGridViewInstrumentos1";
            this.dataGridViewInstrumentos1.ReadOnly = true;
            this.dataGridViewInstrumentos1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewInstrumentos1.Size = new System.Drawing.Size(527, 168);
            this.dataGridViewInstrumentos1.TabIndex = 5;
            this.dataGridViewInstrumentos1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // panelInsertarInvestigador
            // 
            this.panelInsertarInvestigador.Controls.Add(this.buttonInsertarInvest);
            this.panelInsertarInvestigador.Controls.Add(this.label15);
            this.panelInsertarInvestigador.Controls.Add(this.dateTimePickerFechaNacInvest);
            this.panelInsertarInvestigador.Controls.Add(this.label14);
            this.panelInsertarInvestigador.Controls.Add(this.radioButtonF);
            this.panelInsertarInvestigador.Controls.Add(this.radioButtonM);
            this.panelInsertarInvestigador.Controls.Add(this.label13);
            this.panelInsertarInvestigador.Controls.Add(this.label12);
            this.panelInsertarInvestigador.Controls.Add(this.label11);
            this.panelInsertarInvestigador.Controls.Add(this.textBoxInsertNombInvest);
            this.panelInsertarInvestigador.Controls.Add(this.textBoxInsertAp1Invest);
            this.panelInsertarInvestigador.Controls.Add(this.textBoxInsertAp2Invest);
            this.panelInsertarInvestigador.Controls.Add(this.label10);
            this.panelInsertarInvestigador.Controls.Add(this.textBoxInsertarinvestCedula);
            this.panelInsertarInvestigador.Location = new System.Drawing.Point(198, 23);
            this.panelInsertarInvestigador.Name = "panelInsertarInvestigador";
            this.panelInsertarInvestigador.Size = new System.Drawing.Size(511, 344);
            this.panelInsertarInvestigador.TabIndex = 16;
            // 
            // buttonInsertarInvest
            // 
            this.buttonInsertarInvest.Location = new System.Drawing.Point(181, 265);
            this.buttonInsertarInvest.Name = "buttonInsertarInvest";
            this.buttonInsertarInvest.Size = new System.Drawing.Size(139, 25);
            this.buttonInsertarInvest.TabIndex = 12;
            this.buttonInsertarInvest.Text = "Insertar";
            this.buttonInsertarInvest.UseVisualStyleBackColor = true;
            this.buttonInsertarInvest.Click += new System.EventHandler(this.buttonInsertarInvest_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Fecha de nacimiento";
            // 
            // dateTimePickerFechaNacInvest
            // 
            this.dateTimePickerFechaNacInvest.Location = new System.Drawing.Point(168, 204);
            this.dateTimePickerFechaNacInvest.Name = "dateTimePickerFechaNacInvest";
            this.dateTimePickerFechaNacInvest.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerFechaNacInvest.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Sexo";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(219, 172);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 8;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(179, 172);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 5;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Primer Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Segundo Apellido";
            // 
            // textBoxInsertNombInvest
            // 
            this.textBoxInsertNombInvest.Location = new System.Drawing.Point(168, 81);
            this.textBoxInsertNombInvest.Name = "textBoxInsertNombInvest";
            this.textBoxInsertNombInvest.Size = new System.Drawing.Size(190, 20);
            this.textBoxInsertNombInvest.TabIndex = 4;
            // 
            // textBoxInsertAp1Invest
            // 
            this.textBoxInsertAp1Invest.Location = new System.Drawing.Point(168, 110);
            this.textBoxInsertAp1Invest.Name = "textBoxInsertAp1Invest";
            this.textBoxInsertAp1Invest.Size = new System.Drawing.Size(190, 20);
            this.textBoxInsertAp1Invest.TabIndex = 3;
            // 
            // textBoxInsertAp2Invest
            // 
            this.textBoxInsertAp2Invest.Location = new System.Drawing.Point(168, 141);
            this.textBoxInsertAp2Invest.Name = "textBoxInsertAp2Invest";
            this.textBoxInsertAp2Invest.Size = new System.Drawing.Size(190, 20);
            this.textBoxInsertAp2Invest.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cédula";
            // 
            // textBoxInsertarinvestCedula
            // 
            this.textBoxInsertarinvestCedula.Location = new System.Drawing.Point(168, 45);
            this.textBoxInsertarinvestCedula.Name = "textBoxInsertarinvestCedula";
            this.textBoxInsertarinvestCedula.Size = new System.Drawing.Size(190, 20);
            this.textBoxInsertarinvestCedula.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Investigador";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_3);
            // 
            // panelBorrarInvest
            // 
            this.panelBorrarInvest.Controls.Add(this.buttonBorrarInvest);
            this.panelBorrarInvest.Controls.Add(this.label17);
            this.panelBorrarInvest.Controls.Add(this.comboBoxBorrarInvest);
            this.panelBorrarInvest.Location = new System.Drawing.Point(239, 7);
            this.panelBorrarInvest.Name = "panelBorrarInvest";
            this.panelBorrarInvest.Size = new System.Drawing.Size(485, 166);
            this.panelBorrarInvest.TabIndex = 17;
            // 
            // comboBoxBorrarInvest
            // 
            this.comboBoxBorrarInvest.FormattingEnabled = true;
            this.comboBoxBorrarInvest.Location = new System.Drawing.Point(165, 58);
            this.comboBoxBorrarInvest.Name = "comboBoxBorrarInvest";
            this.comboBoxBorrarInvest.Size = new System.Drawing.Size(228, 21);
            this.comboBoxBorrarInvest.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(163, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Seleccionar Investigador/a para borrar";
            // 
            // buttonBorrarInvest
            // 
            this.buttonBorrarInvest.Location = new System.Drawing.Point(233, 90);
            this.buttonBorrarInvest.Name = "buttonBorrarInvest";
            this.buttonBorrarInvest.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarInvest.TabIndex = 2;
            this.buttonBorrarInvest.Text = "Borrar";
            this.buttonBorrarInvest.UseVisualStyleBackColor = true;
            this.buttonBorrarInvest.Click += new System.EventHandler(this.buttonBorrarInvest_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelBorrarInvest);
            this.Controls.Add(this.panelInsertarInvestigador);
            this.Controls.Add(this.PanelInsertarDiagnostico);
            this.Controls.Add(this.VentanaPrincipal);
            this.Controls.Add(this.panelConsultas);
            this.Controls.Add(this.panelInsertarInvestigador);
            this.Controls.Add(this.panelInstrumentosClinicos);
            this.Controls.Add(this.panelConsultas);
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::BD_CIBCM.Properties.Settings.Default, "Max", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos CIBCM";
            this.WindowState = global::BD_CIBCM.Properties.Settings.Default.Max;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.VentanaPrincipal.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            this.Borrar.ResumeLayout(false);
            this.Borrar.PerformLayout();
            this.groupBoxConsenso.ResumeLayout(false);
            this.groupBoxDiagnosticosParcialesDelPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcialesPaciente)).EndInit();
            this.PanelInsertarDiagnostico.ResumeLayout(false);
            this.PanelInsertarDiagnostico.PerformLayout();
            this.groupBoxParcial.ResumeLayout(false);
            this.groupBoxParcial.PerformLayout();
            this.panelParcialInsertar.ResumeLayout(false);
            this.panelParcialInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSintomas)).EndInit();
            this.panelInstrumentosClinicos.ResumeLayout(false);
            this.groupBoxEstudio.ResumeLayout(false);
            this.groupBoxEstudio.PerformLayout();
            this.panelEstudioNuevo.ResumeLayout(false);
            this.panelEstudioNuevo.PerformLayout();
            this.panelPacienteEstudio.ResumeLayout(false);
            this.panelPacienteEstudio.PerformLayout();
            this.groupBoxInstClinicos.ResumeLayout(false);
            this.groupBoxInstClinicos.PerformLayout();
            this.panelConsultas.ResumeLayout(false);
            this.groupBoxConsultaEstudio.ResumeLayout(false);
            this.groupBoxConsultaEstudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudio1)).EndInit();
            this.groupBoxConsultaInstrumentosClinicos.ResumeLayout(false);
            this.groupBoxConsultaInstrumentosClinicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentos1)).EndInit();
            this.panelInsertarInvestigador.ResumeLayout(false);
            this.panelInsertarInvestigador.PerformLayout();
            this.panelBorrarInvest.ResumeLayout(false);
            this.panelBorrarInvest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.TabControl VentanaPrincipal;
        private System.Windows.Forms.TabPage Insertar;
        private System.Windows.Forms.TabPage Borrar;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.Panel PanelInsertarDiagnostico;
        private System.Windows.Forms.RadioButton radioButtonConsenso;
        private System.Windows.Forms.RadioButton radioButtonDiagnosticoParcial;
        private System.Windows.Forms.RadioButton radioButtonDiagnosticoInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPacienteInsertarDiagnostico;
        private System.Windows.Forms.Panel panelParcialInsertar;
        private System.Windows.Forms.GroupBox groupBoxParcial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxConsenso;
        private System.Windows.Forms.Label labelFechaDiagnostico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelNumDiagnostico;
        private System.Windows.Forms.TextBox textBoxNumDiagostico;
        private System.Windows.Forms.Label LabelAgregarSintoma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewSintomas;
        private DataGridViewTextBoxColumn Sintoma;
        private ToolTip toolTip1;
        private Label labelInvestigador;
        private ComboBox comboBoxInvestigador;
        private GroupBox groupBoxDiagnosticosParcialesDelPaciente;
        private DataGridView dataGridViewParcialesPaciente;
        private DataGridViewCheckBoxColumn Seleccionado;
        private TextBox textBox2;
        private Label labelLinkInsertarDiagnostico;
        private Button buttonGuardarDiagnostico;
        private RadioButton radioButtonInsertarInstrumentos;
        private Panel panelInstrumentosClinicos;
        private CheckedListBox listaInstClinicos;
        private ComboBox comboBoxCedInst;
        private RadioButton radioButtonInsertEstudio;
        private GroupBox groupBoxInstClinicos;
        private GroupBox groupBoxEstudio;
        private Label codEst;
        private Label label2;
        private ComboBox comboBoxInvestEstudio;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Button buttonGuardarEstudio;
        private ComboBox comboBoxInsertarEstudio;
        private RadioButton consultarEstudio;
        private RadioButton radioButtonConsultarInstrumentos;
        private Label label5;
        private Panel panelPacienteEstudio;
        private Label label6;
        private Panel panelInvestEstudioInsertar;
        private RadioButton radioButtonInsertPacEstudio;
        private ComboBox comboBoxCedPacEstudioInsert;
        private RadioButton EstudioNuevo;
        private Panel panelConsultas;
        private GroupBox groupBoxConsultaInstrumentosClinicos;
        private Panel panelEstudioNuevo;
        private Label label8;
        private ComboBox comboBoxInsertarEstudioPaciente;
        private Button guardarParticipo;
        private TextBox codigoParticipacion;
        private Label label9;
        private RadioButton radioButtonInsertarInvestigador;
        private Panel panelInsertarInvestigador;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBoxInsertNombInvest;
        private TextBox textBoxInsertAp1Invest;
        private TextBox textBoxInsertAp2Invest;
        private Label label10;
        private TextBox textBoxInsertarinvestCedula;
        private Label label14;
        private RadioButton radioButtonF;
        private RadioButton radioButtonM;
        private Label label15;
        private DateTimePicker dateTimePickerFechaNacInvest;
        private Button buttonInsertarInvest;
        private Button buttonInstClinicPaciente;
        private Label label16;
        private TextBox textBoxInstrumentos;
        private Button guardarInstrumentosClinicos;
        private RadioButton radioButton1;
        private DataGridView dataGridViewInstrumentos1;
        private DataGridView dataGridViewInstrumentos2;
        private Label label17;
        private GroupBox groupBoxConsultaEstudio;
        private Label label18;
        private DataGridView dataGridViewEstudio2;
        private DataGridView dataGridViewEstudio1;
        private ComboBox comboBoxBorrarInvest;
        private Panel panelBorrarInvest;
        private Button buttonBorrarInvest;
       // private Button guardarInstrumentosClinicos;
    }
}

