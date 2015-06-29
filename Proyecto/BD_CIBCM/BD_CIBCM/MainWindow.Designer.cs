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
            this.radioButtonConsultarPaciente = new System.Windows.Forms.RadioButton();
            this.radioButtonConsultarEstudio = new System.Windows.Forms.RadioButton();
            this.radioButtonConsultarInstrumentos = new System.Windows.Forms.RadioButton();
            this.Insertar = new System.Windows.Forms.TabPage();
            this.radioButtonInsertarInvestigador = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertarEstudio = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertarInstrumentos = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertarDiagnostico = new System.Windows.Forms.RadioButton();
            this.Borrar = new System.Windows.Forms.TabPage();
            this.borrarEstudio = new System.Windows.Forms.RadioButton();
            this.borrarInstrumentosClinicos = new System.Windows.Forms.RadioButton();
            this.radioButtonBorrarInvestigador = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.radioButtonConsultarDiagnostico = new System.Windows.Forms.RadioButton();
            this.panelInsertar = new BD_CIBCM.Insertar();
            this.panelConsultar = new BD_CIBCM.Consultar();
            this.panelBorrar = new BD_CIBCM.Borrar();
            this.VentanaPrincipal.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.Insertar.SuspendLayout();
            this.Borrar.SuspendLayout();
            this.panelInsertarInvestigador.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaPrincipal
            // 
            this.VentanaPrincipal.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.VentanaPrincipal.Controls.Add(this.Consultar);
            this.VentanaPrincipal.Controls.Add(this.Insertar);
            this.VentanaPrincipal.Controls.Add(this.Borrar);
            this.VentanaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentanaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.VentanaPrincipal.Multiline = true;
            this.VentanaPrincipal.Name = "VentanaPrincipal";
            this.VentanaPrincipal.SelectedIndex = 0;
            this.VentanaPrincipal.Size = new System.Drawing.Size(234, 296);
            this.VentanaPrincipal.TabIndex = 0;
            this.VentanaPrincipal.SelectedIndexChanged += new System.EventHandler(this.VentanaPrincipal_SelectedIndexChanged);
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.radioButtonConsultarDiagnostico);
            this.Consultar.Controls.Add(this.radioButtonConsultarPaciente);
            this.Consultar.Controls.Add(this.radioButtonConsultarEstudio);
            this.Consultar.Controls.Add(this.radioButtonConsultarInstrumentos);
            this.Consultar.Location = new System.Drawing.Point(28, 4);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3);
            this.Consultar.Size = new System.Drawing.Size(202, 288);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsultarPaciente
            // 
            this.radioButtonConsultarPaciente.AutoSize = true;
            this.radioButtonConsultarPaciente.Location = new System.Drawing.Point(19, 52);
            this.radioButtonConsultarPaciente.Name = "radioButtonConsultarPaciente";
            this.radioButtonConsultarPaciente.Size = new System.Drawing.Size(83, 22);
            this.radioButtonConsultarPaciente.TabIndex = 2;
            this.radioButtonConsultarPaciente.Text = "Paciente";
            this.radioButtonConsultarPaciente.UseVisualStyleBackColor = true;
            this.radioButtonConsultarPaciente.CheckedChanged += new System.EventHandler(this.radioButtonPaciente_CheckedChanged);
            // 
            // radioButtonConsultarEstudio
            // 
            this.radioButtonConsultarEstudio.AutoSize = true;
            this.radioButtonConsultarEstudio.Location = new System.Drawing.Point(19, 85);
            this.radioButtonConsultarEstudio.Name = "radioButtonConsultarEstudio";
            this.radioButtonConsultarEstudio.Size = new System.Drawing.Size(76, 22);
            this.radioButtonConsultarEstudio.TabIndex = 1;
            this.radioButtonConsultarEstudio.Text = "Estudio";
            this.radioButtonConsultarEstudio.UseVisualStyleBackColor = true;
            this.radioButtonConsultarEstudio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
            // 
            // radioButtonConsultarInstrumentos
            // 
            this.radioButtonConsultarInstrumentos.AutoSize = true;
            this.radioButtonConsultarInstrumentos.Checked = true;
            this.radioButtonConsultarInstrumentos.Location = new System.Drawing.Point(19, 18);
            this.radioButtonConsultarInstrumentos.Name = "radioButtonConsultarInstrumentos";
            this.radioButtonConsultarInstrumentos.Size = new System.Drawing.Size(173, 22);
            this.radioButtonConsultarInstrumentos.TabIndex = 0;
            this.radioButtonConsultarInstrumentos.TabStop = true;
            this.radioButtonConsultarInstrumentos.Text = "Instrumentos Clínicos ";
            this.radioButtonConsultarInstrumentos.UseVisualStyleBackColor = true;
            this.radioButtonConsultarInstrumentos.CheckedChanged += new System.EventHandler(this.radioButtonConsultarInstrumentos_CheckedChanged);
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.radioButtonInsertarInvestigador);
            this.Insertar.Controls.Add(this.radioButtonInsertarEstudio);
            this.Insertar.Controls.Add(this.radioButtonInsertarInstrumentos);
            this.Insertar.Controls.Add(this.radioButtonInsertarDiagnostico);
            this.Insertar.Location = new System.Drawing.Point(28, 4);
            this.Insertar.Name = "Insertar";
            this.Insertar.Padding = new System.Windows.Forms.Padding(3);
            this.Insertar.Size = new System.Drawing.Size(202, 288);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // radioButtonInsertarInvestigador
            // 
            this.radioButtonInsertarInvestigador.AutoSize = true;
            this.radioButtonInsertarInvestigador.Location = new System.Drawing.Point(18, 128);
            this.radioButtonInsertarInvestigador.Name = "radioButtonInsertarInvestigador";
            this.radioButtonInsertarInvestigador.Size = new System.Drawing.Size(105, 22);
            this.radioButtonInsertarInvestigador.TabIndex = 4;
            this.radioButtonInsertarInvestigador.Text = "Investigador";
            this.radioButtonInsertarInvestigador.UseVisualStyleBackColor = true;
            this.radioButtonInsertarInvestigador.CheckedChanged += new System.EventHandler(this.radioButtonInsertarInvestigador_CheckedChanged);
            // 
            // radioButtonInsertarEstudio
            // 
            this.radioButtonInsertarEstudio.AutoSize = true;
            this.radioButtonInsertarEstudio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonInsertarEstudio.Location = new System.Drawing.Point(18, 51);
            this.radioButtonInsertarEstudio.Name = "radioButtonInsertarEstudio";
            this.radioButtonInsertarEstudio.Size = new System.Drawing.Size(76, 22);
            this.radioButtonInsertarEstudio.TabIndex = 3;
            this.radioButtonInsertarEstudio.Text = "Estudio";
            this.radioButtonInsertarEstudio.UseVisualStyleBackColor = true;
            this.radioButtonInsertarEstudio.CheckedChanged += new System.EventHandler(this.radioButtonInsertarEstudio_CheckedChanged);
            // 
            // radioButtonInsertarInstrumentos
            // 
            this.radioButtonInsertarInstrumentos.AutoSize = true;
            this.radioButtonInsertarInstrumentos.Checked = true;
            this.radioButtonInsertarInstrumentos.Location = new System.Drawing.Point(19, 18);
            this.radioButtonInsertarInstrumentos.Name = "radioButtonInsertarInstrumentos";
            this.radioButtonInsertarInstrumentos.Size = new System.Drawing.Size(173, 22);
            this.radioButtonInsertarInstrumentos.TabIndex = 1;
            this.radioButtonInsertarInstrumentos.TabStop = true;
            this.radioButtonInsertarInstrumentos.Text = "Instrumentos Clínicos ";
            this.radioButtonInsertarInstrumentos.UseVisualStyleBackColor = true;
            this.radioButtonInsertarInstrumentos.CheckedChanged += new System.EventHandler(this.radioButtonInsertarInstrumentos_CheckedChanged);
            // 
            // radioButtonInsertarDiagnostico
            // 
            this.radioButtonInsertarDiagnostico.AutoSize = true;
            this.radioButtonInsertarDiagnostico.Location = new System.Drawing.Point(18, 88);
            this.radioButtonInsertarDiagnostico.Name = "radioButtonInsertarDiagnostico";
            this.radioButtonInsertarDiagnostico.Size = new System.Drawing.Size(105, 22);
            this.radioButtonInsertarDiagnostico.TabIndex = 0;
            this.radioButtonInsertarDiagnostico.Text = "Diagnóstico";
            this.radioButtonInsertarDiagnostico.UseVisualStyleBackColor = true;
            this.radioButtonInsertarDiagnostico.CheckedChanged += new System.EventHandler(this.radioButtonInsertarDiagnostico_CheckedChanged);
            // 
            // Borrar
            // 
            this.Borrar.Controls.Add(this.borrarEstudio);
            this.Borrar.Controls.Add(this.borrarInstrumentosClinicos);
            this.Borrar.Controls.Add(this.radioButtonBorrarInvestigador);
            this.Borrar.Location = new System.Drawing.Point(28, 4);
            this.Borrar.Name = "Borrar";
            this.Borrar.Padding = new System.Windows.Forms.Padding(3);
            this.Borrar.Size = new System.Drawing.Size(202, 288);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // borrarEstudio
            // 
            this.borrarEstudio.AutoSize = true;
            this.borrarEstudio.Location = new System.Drawing.Point(21, 143);
            this.borrarEstudio.Name = "borrarEstudio";
            this.borrarEstudio.Size = new System.Drawing.Size(76, 22);
            this.borrarEstudio.TabIndex = 4;
            this.borrarEstudio.TabStop = true;
            this.borrarEstudio.Text = "Estudio";
            this.borrarEstudio.UseVisualStyleBackColor = true;
            this.borrarEstudio.CheckedChanged += new System.EventHandler(this.borrarEstudio_CheckedChanged);
            // 
            // borrarInstrumentosClinicos
            // 
            this.borrarInstrumentosClinicos.AutoSize = true;
            this.borrarInstrumentosClinicos.Location = new System.Drawing.Point(21, 82);
            this.borrarInstrumentosClinicos.Name = "borrarInstrumentosClinicos";
            this.borrarInstrumentosClinicos.Size = new System.Drawing.Size(169, 22);
            this.borrarInstrumentosClinicos.TabIndex = 4;
            this.borrarInstrumentosClinicos.TabStop = true;
            this.borrarInstrumentosClinicos.Text = "Instrumentos Clínicos";
            this.borrarInstrumentosClinicos.UseVisualStyleBackColor = true;
            this.borrarInstrumentosClinicos.CheckedChanged += new System.EventHandler(this.borrarInstrumentosClinicos_CheckedChanged);
            // 
            // radioButtonBorrarInvestigador
            // 
            this.radioButtonBorrarInvestigador.AutoSize = true;
            this.radioButtonBorrarInvestigador.Checked = true;
            this.radioButtonBorrarInvestigador.Location = new System.Drawing.Point(21, 18);
            this.radioButtonBorrarInvestigador.Name = "radioButtonBorrarInvestigador";
            this.radioButtonBorrarInvestigador.Size = new System.Drawing.Size(105, 22);
            this.radioButtonBorrarInvestigador.TabIndex = 0;
            this.radioButtonBorrarInvestigador.TabStop = true;
            this.radioButtonBorrarInvestigador.Text = "Investigador";
            this.radioButtonBorrarInvestigador.UseVisualStyleBackColor = true;
            this.radioButtonBorrarInvestigador.CheckedChanged += new System.EventHandler(this.radioButtonBorrarInvestigador_CheckedChanged_3);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Borrar síntomas";
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
            this.panelInsertarInvestigador.Location = new System.Drawing.Point(199, 23);
            this.panelInsertarInvestigador.Name = "panelInsertarInvestigador";
            this.panelInsertarInvestigador.Size = new System.Drawing.Size(510, 347);
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
            // radioButtonConsultarDiagnostico
            // 
            this.radioButtonConsultarDiagnostico.AutoSize = true;
            this.radioButtonConsultarDiagnostico.Location = new System.Drawing.Point(19, 117);
            this.radioButtonConsultarDiagnostico.Name = "radioButtonConsultarDiagnostico";
            this.radioButtonConsultarDiagnostico.Size = new System.Drawing.Size(105, 22);
            this.radioButtonConsultarDiagnostico.TabIndex = 3;
            this.radioButtonConsultarDiagnostico.TabStop = true;
            this.radioButtonConsultarDiagnostico.Text = "Diagnóstico";
            this.radioButtonConsultarDiagnostico.UseVisualStyleBackColor = true;
            this.radioButtonConsultarDiagnostico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelInsertar
            // 
            this.panelInsertar.Location = new System.Drawing.Point(270, 16);
            this.panelInsertar.Name = "panelInsertar";
            this.panelInsertar.Size = new System.Drawing.Size(700, 562);
            this.panelInsertar.TabIndex = 3;
            // 
            // panelConsultar
            // 
            this.panelConsultar.Location = new System.Drawing.Point(270, 15);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(711, 563);
            this.panelConsultar.TabIndex = 2;
            // 
            // panelBorrar
            // 
            this.panelBorrar.Location = new System.Drawing.Point(270, 16);
            this.panelBorrar.Name = "panelBorrar";
            this.panelBorrar.Size = new System.Drawing.Size(612, 259);
            this.panelBorrar.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1144, 661);
            this.Controls.Add(this.VentanaPrincipal);
            this.Controls.Add(this.panelInsertar);
            this.Controls.Add(this.panelConsultar);
            this.Controls.Add(this.panelBorrar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::BD_CIBCM.Properties.Settings.Default, "Max", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaximizeBox = false;
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
            this.panelInsertarInvestigador.ResumeLayout(false);
            this.panelInsertarInvestigador.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.TabControl VentanaPrincipal;
        private System.Windows.Forms.TabPage Insertar;
        private System.Windows.Forms.TabPage Borrar;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.RadioButton radioButtonInsertarDiagnostico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolTip toolTip1;
        private RadioButton radioButtonInsertarInstrumentos;
        private RadioButton radioButtonInsertarEstudio;
        private RadioButton radioButtonConsultarEstudio;
        private RadioButton radioButtonConsultarInstrumentos;
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
        private RadioButton radioButtonBorrarInvestigador;
        private RadioButton radioButtonConsultarPaciente;
        private Borrar panelBorrar;
        private Consultar panelConsultar;
        private Insertar panelInsertar;
        private RadioButton borrarEstudio;
        private RadioButton borrarInstrumentosClinicos;
        private RadioButton radioButtonConsultarDiagnostico;
        // private Button guardarInstrumentosClinicos;
    }
}

