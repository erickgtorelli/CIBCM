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
            this.VentanaPrincipal = new System.Windows.Forms.TabControl();
            this.Insertar = new System.Windows.Forms.TabPage();
            this.groupBoxConsenso = new System.Windows.Forms.GroupBox();
            this.radioButtonDiagnosticoInsertar = new System.Windows.Forms.RadioButton();
            this.Borrar = new System.Windows.Forms.TabPage();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PanelInsertarDiagnostico = new System.Windows.Forms.Panel();
            this.panelParcialInsertar = new System.Windows.Forms.Panel();
            this.labelFechaDiagnostico = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelNumDiagnostico = new System.Windows.Forms.Label();
            this.textBoxNumDiagostico = new System.Windows.Forms.TextBox();
            this.groupBoxParcial = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPacienteInsertarDiagnostico = new System.Windows.Forms.ComboBox();
            this.radioButtonConsenso = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagnosticoParcial = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.VentanaPrincipal.SuspendLayout();
            this.Insertar.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.PanelInsertarDiagnostico.SuspendLayout();
            this.panelParcialInsertar.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaPrincipal
            // 
            this.VentanaPrincipal.Controls.Add(this.Insertar);
            this.VentanaPrincipal.Controls.Add(this.Borrar);
            this.VentanaPrincipal.Controls.Add(this.Consultar);
            this.VentanaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.VentanaPrincipal.Name = "VentanaPrincipal";
            this.VentanaPrincipal.SelectedIndex = 0;
            this.VentanaPrincipal.Size = new System.Drawing.Size(181, 487);
            this.VentanaPrincipal.TabIndex = 0;
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.groupBoxConsenso);
            this.Insertar.Controls.Add(this.radioButtonDiagnosticoInsertar);
            this.Insertar.Location = new System.Drawing.Point(4, 22);
            this.Insertar.Name = "Insertar";
            this.Insertar.Padding = new System.Windows.Forms.Padding(3);
            this.Insertar.Size = new System.Drawing.Size(173, 461);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsenso
            // 
            this.groupBoxConsenso.Location = new System.Drawing.Point(6, 437);
            this.groupBoxConsenso.Name = "groupBoxConsenso";
            this.groupBoxConsenso.Size = new System.Drawing.Size(373, 342);
            this.groupBoxConsenso.TabIndex = 1;
            this.groupBoxConsenso.TabStop = false;
            this.groupBoxConsenso.Text = "Diagnóstico Consenso";
            this.groupBoxConsenso.Visible = false;
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
            // Consultar
            // 
            this.Consultar.Controls.Add(this.radioButton1);
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
            this.radioButton1.Location = new System.Drawing.Point(22, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Diagnóstico";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PanelInsertarDiagnostico
            // 
            this.PanelInsertarDiagnostico.AutoSize = true;
            this.PanelInsertarDiagnostico.Controls.Add(this.panelParcialInsertar);
            this.PanelInsertarDiagnostico.Controls.Add(this.label1);
            this.PanelInsertarDiagnostico.Controls.Add(this.comboBoxPacienteInsertarDiagnostico);
            this.PanelInsertarDiagnostico.Controls.Add(this.radioButtonConsenso);
            this.PanelInsertarDiagnostico.Controls.Add(this.radioButtonDiagnosticoParcial);
            this.PanelInsertarDiagnostico.Location = new System.Drawing.Point(199, 34);
            this.PanelInsertarDiagnostico.Name = "PanelInsertarDiagnostico";
            this.PanelInsertarDiagnostico.Size = new System.Drawing.Size(584, 451);
            this.PanelInsertarDiagnostico.TabIndex = 1;
            this.PanelInsertarDiagnostico.Visible = false;
            this.PanelInsertarDiagnostico.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInsertarDiagnostico_Paint);
            // 
            // panelParcialInsertar
            // 
            this.panelParcialInsertar.Controls.Add(this.labelFechaDiagnostico);
            this.panelParcialInsertar.Controls.Add(this.dateTimePicker1);
            this.panelParcialInsertar.Controls.Add(this.LabelNumDiagnostico);
            this.panelParcialInsertar.Controls.Add(this.textBoxNumDiagostico);
            this.panelParcialInsertar.Controls.Add(this.groupBoxParcial);
            this.panelParcialInsertar.Location = new System.Drawing.Point(13, 91);
            this.panelParcialInsertar.Name = "panelParcialInsertar";
            this.panelParcialInsertar.Size = new System.Drawing.Size(568, 357);
            this.panelParcialInsertar.TabIndex = 2;
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
            // groupBoxParcial
            // 
            this.groupBoxParcial.Location = new System.Drawing.Point(285, 0);
            this.groupBoxParcial.Name = "groupBoxParcial";
            this.groupBoxParcial.Size = new System.Drawing.Size(283, 342);
            this.groupBoxParcial.TabIndex = 0;
            this.groupBoxParcial.TabStop = false;
            this.groupBoxParcial.Text = "Diagnóstico Parcial";
            this.groupBoxParcial.Enter += new System.EventHandler(this.groupBox1_Enter_1);
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
            // comboBoxPacienteInsertarDiagnostico
            // 
            this.comboBoxPacienteInsertarDiagnostico.FormattingEnabled = true;
            this.comboBoxPacienteInsertarDiagnostico.Location = new System.Drawing.Point(390, 32);
            this.comboBoxPacienteInsertarDiagnostico.Name = "comboBoxPacienteInsertarDiagnostico";
            this.comboBoxPacienteInsertarDiagnostico.Size = new System.Drawing.Size(175, 21);
            this.comboBoxPacienteInsertarDiagnostico.TabIndex = 2;
            this.comboBoxPacienteInsertarDiagnostico.Text = "Seleccione un paciente";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 511);
            this.Controls.Add(this.PanelInsertarDiagnostico);
            this.Controls.Add(this.VentanaPrincipal);
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::BD_CIBCM.Properties.Settings.Default, "Max", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos CIBCM";
            this.WindowState = global::BD_CIBCM.Properties.Settings.Default.Max;
            this.VentanaPrincipal.ResumeLayout(false);
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.PanelInsertarDiagnostico.ResumeLayout(false);
            this.PanelInsertarDiagnostico.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
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
    }
}

