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
            this.Insertar = new System.Windows.Forms.TabPage();
            this.radioButtonDiagnosticoInsertar = new System.Windows.Forms.RadioButton();
            this.Borrar = new System.Windows.Forms.TabPage();
            this.groupBoxConsenso = new System.Windows.Forms.GroupBox();
            this.groupBoxDiagnosticosParcialesDelPaciente = new System.Windows.Forms.GroupBox();
            this.dataGridViewParcialesPaciente = new System.Windows.Forms.DataGridView();
            this.Seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelInsertarDiagnostico = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxParcial = new System.Windows.Forms.GroupBox();
            this.dataGridViewSintomas = new System.Windows.Forms.DataGridView();
            this.Sintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInvestigador = new System.Windows.Forms.Label();
            this.LabelAgregarSintoma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxInvestigador = new System.Windows.Forms.ComboBox();
            this.comboBoxPacienteInsertarDiagnostico = new System.Windows.Forms.ComboBox();
            this.radioButtonConsenso = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagnosticoParcial = new System.Windows.Forms.RadioButton();
            this.panelParcialInsertar = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelFechaDiagnostico = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelNumDiagnostico = new System.Windows.Forms.Label();
            this.textBoxNumDiagostico = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelLinkInsertarDiagnostico = new System.Windows.Forms.Label();
            this.buttonGuardarDiagnostico = new System.Windows.Forms.Button();
            this.VentanaPrincipal.SuspendLayout();
            this.Insertar.SuspendLayout();
            this.groupBoxConsenso.SuspendLayout();
            this.groupBoxDiagnosticosParcialesDelPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcialesPaciente)).BeginInit();
            this.PanelInsertarDiagnostico.SuspendLayout();
            this.groupBoxParcial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSintomas)).BeginInit();
            this.panelParcialInsertar.SuspendLayout();
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
            this.Consultar.Location = new System.Drawing.Point(4, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3);
            this.Consultar.Size = new System.Drawing.Size(173, 461);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.radioButtonDiagnosticoInsertar);
            this.Insertar.Location = new System.Drawing.Point(4, 22);
            this.Insertar.Name = "Insertar";
            this.Insertar.Padding = new System.Windows.Forms.Padding(3);
            this.Insertar.Size = new System.Drawing.Size(173, 461);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
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
            this.PanelInsertarDiagnostico.Location = new System.Drawing.Point(210, 34);
            this.PanelInsertarDiagnostico.Name = "PanelInsertarDiagnostico";
            this.PanelInsertarDiagnostico.Size = new System.Drawing.Size(789, 549);
            this.PanelInsertarDiagnostico.TabIndex = 1;
            this.PanelInsertarDiagnostico.Visible = false;
            this.PanelInsertarDiagnostico.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInsertarDiagnostico_Paint);
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
            // labelInvestigador
            // 
            this.labelInvestigador.AutoSize = true;
            this.labelInvestigador.Location = new System.Drawing.Point(18, 43);
            this.labelInvestigador.Name = "labelInvestigador";
            this.labelInvestigador.Size = new System.Drawing.Size(68, 13);
            this.labelInvestigador.TabIndex = 1;
            this.labelInvestigador.Text = "Investigador:";
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
            // comboBoxInvestigador
            // 
            this.comboBoxInvestigador.FormattingEnabled = true;
            this.comboBoxInvestigador.Location = new System.Drawing.Point(92, 40);
            this.comboBoxInvestigador.Name = "comboBoxInvestigador";
            this.comboBoxInvestigador.Size = new System.Drawing.Size(197, 21);
            this.comboBoxInvestigador.TabIndex = 0;
            this.comboBoxInvestigador.Text = "Seleccione el investigador";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // labelLinkInsertarDiagnostico
            // 
            this.labelLinkInsertarDiagnostico.AutoSize = true;
            this.labelLinkInsertarDiagnostico.Location = new System.Drawing.Point(16, 135);
            this.labelLinkInsertarDiagnostico.Name = "labelLinkInsertarDiagnostico";
            this.labelLinkInsertarDiagnostico.Size = new System.Drawing.Size(27, 13);
            this.labelLinkInsertarDiagnostico.TabIndex = 9;
            this.labelLinkInsertarDiagnostico.Text = "Link";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.VentanaPrincipal);
            this.Controls.Add(this.PanelInsertarDiagnostico);
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::BD_CIBCM.Properties.Settings.Default, "Max", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos CIBCM";
            this.WindowState = global::BD_CIBCM.Properties.Settings.Default.Max;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.VentanaPrincipal.ResumeLayout(false);
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            this.groupBoxConsenso.ResumeLayout(false);
            this.groupBoxDiagnosticosParcialesDelPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcialesPaciente)).EndInit();
            this.PanelInsertarDiagnostico.ResumeLayout(false);
            this.PanelInsertarDiagnostico.PerformLayout();
            this.groupBoxParcial.ResumeLayout(false);
            this.groupBoxParcial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSintomas)).EndInit();
            this.panelParcialInsertar.ResumeLayout(false);
            this.panelParcialInsertar.PerformLayout();
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
    }
}

