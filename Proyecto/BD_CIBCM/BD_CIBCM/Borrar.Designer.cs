namespace BD_CIBCM
{
    partial class Borrar
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBorrarInvest = new System.Windows.Forms.Panel();
            this.groupBoxBorrarInvestigador = new System.Windows.Forms.GroupBox();
            this.comboBoxBorrarInvest = new System.Windows.Forms.ComboBox();
            this.buttonBorrarInvest = new System.Windows.Forms.Button();
            this.panelBorrarInstrumentos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelborrarInstPac = new System.Windows.Forms.Panel();
            this.listaInstPorPaciente = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBorrarInstrumentos = new System.Windows.Forms.Button();
            this.radioButtonBorrarPorPaciente = new System.Windows.Forms.RadioButton();
            this.panelBorrarNombreInst = new System.Windows.Forms.Panel();
            this.borrarNombreInst = new System.Windows.Forms.Button();
            this.borrarListaInstrumentos = new System.Windows.Forms.CheckedListBox();
            this.radioButtonBorrarPorNombre = new System.Windows.Forms.RadioButton();
            this.groupBoxBorrarEstudio = new System.Windows.Forms.GroupBox();
            this.panelBorrarEstPaciente = new System.Windows.Forms.Panel();
            this.listaBorrarEstudioPaciente = new System.Windows.Forms.CheckedListBox();
            this.buttonBorrarEstudioPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPacienteEstudio = new System.Windows.Forms.ComboBox();
            this.panelBorrarCodEst = new System.Windows.Forms.Panel();
            this.codEst = new System.Windows.Forms.Label();
            this.buttonBorrarCodigo = new System.Windows.Forms.Button();
            this.comboBoxBorrarCod = new System.Windows.Forms.ComboBox();
            this.borrarEstudioCodigo = new System.Windows.Forms.RadioButton();
            this.borrarEstudioPaciente = new System.Windows.Forms.RadioButton();
            this.panelBorrarEstudio = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelBorrarInvest.SuspendLayout();
            this.groupBoxBorrarInvestigador.SuspendLayout();
            this.panelBorrarInstrumentos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelborrarInstPac.SuspendLayout();
            this.panelBorrarNombreInst.SuspendLayout();
            this.groupBoxBorrarEstudio.SuspendLayout();
            this.panelBorrarEstPaciente.SuspendLayout();
            this.panelBorrarCodEst.SuspendLayout();
            this.panelBorrarEstudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorrarInvest
            // 
            this.panelBorrarInvest.Controls.Add(this.groupBoxBorrarInvestigador);
            this.panelBorrarInvest.Location = new System.Drawing.Point(0, 0);
            this.panelBorrarInvest.Name = "panelBorrarInvest";
            this.panelBorrarInvest.Size = new System.Drawing.Size(873, 600);
            this.panelBorrarInvest.TabIndex = 18;
            // 
            // groupBoxBorrarInvestigador
            // 
            this.groupBoxBorrarInvestigador.Controls.Add(this.comboBoxBorrarInvest);
            this.groupBoxBorrarInvestigador.Controls.Add(this.buttonBorrarInvest);
            this.groupBoxBorrarInvestigador.Location = new System.Drawing.Point(241, 0);
            this.groupBoxBorrarInvestigador.Name = "groupBoxBorrarInvestigador";
            this.groupBoxBorrarInvestigador.Size = new System.Drawing.Size(358, 179);
            this.groupBoxBorrarInvestigador.TabIndex = 5;
            this.groupBoxBorrarInvestigador.TabStop = false;
            this.groupBoxBorrarInvestigador.Text = "Borrar investigador";
            // 
            // comboBoxBorrarInvest
            // 
            this.comboBoxBorrarInvest.FormattingEnabled = true;
            this.comboBoxBorrarInvest.Location = new System.Drawing.Point(69, 60);
            this.comboBoxBorrarInvest.Name = "comboBoxBorrarInvest";
            this.comboBoxBorrarInvest.Size = new System.Drawing.Size(228, 21);
            this.comboBoxBorrarInvest.TabIndex = 0;
            // 
            // buttonBorrarInvest
            // 
            this.buttonBorrarInvest.Location = new System.Drawing.Point(137, 92);
            this.buttonBorrarInvest.Name = "buttonBorrarInvest";
            this.buttonBorrarInvest.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarInvest.TabIndex = 2;
            this.buttonBorrarInvest.Text = "Borrar";
            this.buttonBorrarInvest.UseVisualStyleBackColor = true;
            this.buttonBorrarInvest.Click += new System.EventHandler(this.buttonBorrarInvest_Click);
            // 
            // panelBorrarInstrumentos
            // 
            this.panelBorrarInstrumentos.Controls.Add(this.groupBox1);
            this.panelBorrarInstrumentos.Location = new System.Drawing.Point(0, 0);
            this.panelBorrarInstrumentos.Name = "panelBorrarInstrumentos";
            this.panelBorrarInstrumentos.Size = new System.Drawing.Size(873, 600);
            this.panelBorrarInstrumentos.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelborrarInstPac);
            this.groupBox1.Controls.Add(this.radioButtonBorrarPorPaciente);
            this.groupBox1.Controls.Add(this.panelBorrarNombreInst);
            this.groupBox1.Controls.Add(this.radioButtonBorrarPorNombre);
            this.groupBox1.Location = new System.Drawing.Point(122, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 287);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrar Instrumentos clinicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borrar:";
            // 
            // panelborrarInstPac
            // 
            this.panelborrarInstPac.Controls.Add(this.listaInstPorPaciente);
            this.panelborrarInstPac.Controls.Add(this.comboBox1);
            this.panelborrarInstPac.Controls.Add(this.buttonBorrarInstrumentos);
            this.panelborrarInstPac.Location = new System.Drawing.Point(43, 94);
            this.panelborrarInstPac.Name = "panelborrarInstPac";
            this.panelborrarInstPac.Size = new System.Drawing.Size(434, 166);
            this.panelborrarInstPac.TabIndex = 8;
            // 
            // listaInstPorPaciente
            // 
            this.listaInstPorPaciente.FormattingEnabled = true;
            this.listaInstPorPaciente.Location = new System.Drawing.Point(108, 34);
            this.listaInstPorPaciente.Name = "listaInstPorPaciente";
            this.listaInstPorPaciente.Size = new System.Drawing.Size(227, 34);
            this.listaInstPorPaciente.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Seleccione Datos del Paciente";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonBorrarInstrumentos
            // 
            this.buttonBorrarInstrumentos.Location = new System.Drawing.Point(350, 4);
            this.buttonBorrarInstrumentos.Name = "buttonBorrarInstrumentos";
            this.buttonBorrarInstrumentos.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarInstrumentos.TabIndex = 2;
            this.buttonBorrarInstrumentos.Text = "Borrar";
            this.buttonBorrarInstrumentos.UseVisualStyleBackColor = true;
            this.buttonBorrarInstrumentos.Click += new System.EventHandler(this.buttonBorrarInstrumentos_Click);
            // 
            // radioButtonBorrarPorPaciente
            // 
            this.radioButtonBorrarPorPaciente.AutoSize = true;
            this.radioButtonBorrarPorPaciente.Checked = true;
            this.radioButtonBorrarPorPaciente.Location = new System.Drawing.Point(55, 62);
            this.radioButtonBorrarPorPaciente.Name = "radioButtonBorrarPorPaciente";
            this.radioButtonBorrarPorPaciente.Size = new System.Drawing.Size(186, 17);
            this.radioButtonBorrarPorPaciente.TabIndex = 4;
            this.radioButtonBorrarPorPaciente.TabStop = true;
            this.radioButtonBorrarPorPaciente.Text = "Instrumentos Clínicos de Paciente";
            this.radioButtonBorrarPorPaciente.UseVisualStyleBackColor = true;
            this.radioButtonBorrarPorPaciente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelBorrarNombreInst
            // 
            this.panelBorrarNombreInst.Controls.Add(this.borrarNombreInst);
            this.panelBorrarNombreInst.Controls.Add(this.borrarListaInstrumentos);
            this.panelBorrarNombreInst.Location = new System.Drawing.Point(75, 93);
            this.panelBorrarNombreInst.Name = "panelBorrarNombreInst";
            this.panelBorrarNombreInst.Size = new System.Drawing.Size(344, 106);
            this.panelBorrarNombreInst.TabIndex = 7;
            // 
            // borrarNombreInst
            // 
            this.borrarNombreInst.Location = new System.Drawing.Point(249, 69);
            this.borrarNombreInst.Name = "borrarNombreInst";
            this.borrarNombreInst.Size = new System.Drawing.Size(72, 25);
            this.borrarNombreInst.TabIndex = 7;
            this.borrarNombreInst.Text = "Borrar";
            this.borrarNombreInst.UseVisualStyleBackColor = true;
            this.borrarNombreInst.Click += new System.EventHandler(this.borrarNombreInst_Click);
            // 
            // borrarListaInstrumentos
            // 
            this.borrarListaInstrumentos.FormattingEnabled = true;
            this.borrarListaInstrumentos.Location = new System.Drawing.Point(18, 1);
            this.borrarListaInstrumentos.Name = "borrarListaInstrumentos";
            this.borrarListaInstrumentos.Size = new System.Drawing.Size(325, 49);
            this.borrarListaInstrumentos.TabIndex = 6;
            // 
            // radioButtonBorrarPorNombre
            // 
            this.radioButtonBorrarPorNombre.AutoSize = true;
            this.radioButtonBorrarPorNombre.Location = new System.Drawing.Point(247, 62);
            this.radioButtonBorrarPorNombre.Name = "radioButtonBorrarPorNombre";
            this.radioButtonBorrarPorNombre.Size = new System.Drawing.Size(196, 17);
            this.radioButtonBorrarPorNombre.TabIndex = 5;
            this.radioButtonBorrarPorNombre.Text = "Instrumentos Clínicos por su nombre";
            this.radioButtonBorrarPorNombre.UseVisualStyleBackColor = true;
            this.radioButtonBorrarPorNombre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxBorrarEstudio
            // 
            this.groupBoxBorrarEstudio.Controls.Add(this.panelBorrarEstPaciente);
            this.groupBoxBorrarEstudio.Controls.Add(this.panelBorrarCodEst);
            this.groupBoxBorrarEstudio.Controls.Add(this.borrarEstudioCodigo);
            this.groupBoxBorrarEstudio.Controls.Add(this.borrarEstudioPaciente);
            this.groupBoxBorrarEstudio.Location = new System.Drawing.Point(165, 0);
            this.groupBoxBorrarEstudio.Name = "groupBoxBorrarEstudio";
            this.groupBoxBorrarEstudio.Size = new System.Drawing.Size(470, 277);
            this.groupBoxBorrarEstudio.TabIndex = 3;
            this.groupBoxBorrarEstudio.TabStop = false;
            this.groupBoxBorrarEstudio.Text = "Borrar Estudio ";
            // 
            // panelBorrarEstPaciente
            // 
            this.panelBorrarEstPaciente.Controls.Add(this.listaBorrarEstudioPaciente);
            this.panelBorrarEstPaciente.Controls.Add(this.buttonBorrarEstudioPaciente);
            this.panelBorrarEstPaciente.Controls.Add(this.label1);
            this.panelBorrarEstPaciente.Controls.Add(this.comboBoxPacienteEstudio);
            this.panelBorrarEstPaciente.Location = new System.Drawing.Point(30, 83);
            this.panelBorrarEstPaciente.Name = "panelBorrarEstPaciente";
            this.panelBorrarEstPaciente.Size = new System.Drawing.Size(403, 188);
            this.panelBorrarEstPaciente.TabIndex = 3;
            // 
            // listaBorrarEstudioPaciente
            // 
            this.listaBorrarEstudioPaciente.FormattingEnabled = true;
            this.listaBorrarEstudioPaciente.Location = new System.Drawing.Point(68, 63);
            this.listaBorrarEstudioPaciente.Name = "listaBorrarEstudioPaciente";
            this.listaBorrarEstudioPaciente.Size = new System.Drawing.Size(281, 49);
            this.listaBorrarEstudioPaciente.TabIndex = 4;
            // 
            // buttonBorrarEstudioPaciente
            // 
            this.buttonBorrarEstudioPaciente.Location = new System.Drawing.Point(274, 133);
            this.buttonBorrarEstudioPaciente.Name = "buttonBorrarEstudioPaciente";
            this.buttonBorrarEstudioPaciente.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarEstudioPaciente.TabIndex = 3;
            this.buttonBorrarEstudioPaciente.Text = "Borrar";
            this.buttonBorrarEstudioPaciente.UseVisualStyleBackColor = true;
            this.buttonBorrarEstudioPaciente.Click += new System.EventHandler(this.buttonBorrarEstudioPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Paciente";
            // 
            // comboBoxPacienteEstudio
            // 
            this.comboBoxPacienteEstudio.FormattingEnabled = true;
            this.comboBoxPacienteEstudio.Location = new System.Drawing.Point(173, 15);
            this.comboBoxPacienteEstudio.Name = "comboBoxPacienteEstudio";
            this.comboBoxPacienteEstudio.Size = new System.Drawing.Size(189, 21);
            this.comboBoxPacienteEstudio.TabIndex = 0;
            this.comboBoxPacienteEstudio.Text = "Seleccione los datos del paciente";
            this.comboBoxPacienteEstudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPacienteEstudio_SelectedIndexChanged);
            // 
            // panelBorrarCodEst
            // 
            this.panelBorrarCodEst.Controls.Add(this.codEst);
            this.panelBorrarCodEst.Controls.Add(this.buttonBorrarCodigo);
            this.panelBorrarCodEst.Controls.Add(this.comboBoxBorrarCod);
            this.panelBorrarCodEst.Location = new System.Drawing.Point(78, 69);
            this.panelBorrarCodEst.Name = "panelBorrarCodEst";
            this.panelBorrarCodEst.Size = new System.Drawing.Size(324, 124);
            this.panelBorrarCodEst.TabIndex = 4;
            // 
            // codEst
            // 
            this.codEst.AutoSize = true;
            this.codEst.Location = new System.Drawing.Point(40, 27);
            this.codEst.Name = "codEst";
            this.codEst.Size = new System.Drawing.Size(93, 13);
            this.codEst.TabIndex = 2;
            this.codEst.Text = "Código de Estudio";
            // 
            // buttonBorrarCodigo
            // 
            this.buttonBorrarCodigo.Location = new System.Drawing.Point(178, 87);
            this.buttonBorrarCodigo.Name = "buttonBorrarCodigo";
            this.buttonBorrarCodigo.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarCodigo.TabIndex = 1;
            this.buttonBorrarCodigo.Text = "Borrar";
            this.buttonBorrarCodigo.UseVisualStyleBackColor = true;
            this.buttonBorrarCodigo.Click += new System.EventHandler(this.buttonBorrarCodigo_Click);
            // 
            // comboBoxBorrarCod
            // 
            this.comboBoxBorrarCod.FormattingEnabled = true;
            this.comboBoxBorrarCod.Location = new System.Drawing.Point(139, 24);
            this.comboBoxBorrarCod.Name = "comboBoxBorrarCod";
            this.comboBoxBorrarCod.Size = new System.Drawing.Size(165, 21);
            this.comboBoxBorrarCod.TabIndex = 0;
            this.comboBoxBorrarCod.Text = "Seleccione el código a borrar";
            // 
            // borrarEstudioCodigo
            // 
            this.borrarEstudioCodigo.AutoSize = true;
            this.borrarEstudioCodigo.Location = new System.Drawing.Point(205, 38);
            this.borrarEstudioCodigo.Name = "borrarEstudioCodigo";
            this.borrarEstudioCodigo.Size = new System.Drawing.Size(111, 17);
            this.borrarEstudioCodigo.TabIndex = 1;
            this.borrarEstudioCodigo.TabStop = true;
            this.borrarEstudioCodigo.Text = "Código de Estudio";
            this.borrarEstudioCodigo.UseVisualStyleBackColor = true;
            this.borrarEstudioCodigo.CheckedChanged += new System.EventHandler(this.borrarEstudioCodigo_CheckedChanged);
            // 
            // borrarEstudioPaciente
            // 
            this.borrarEstudioPaciente.AutoSize = true;
            this.borrarEstudioPaciente.Location = new System.Drawing.Point(100, 38);
            this.borrarEstudioPaciente.Name = "borrarEstudioPaciente";
            this.borrarEstudioPaciente.Size = new System.Drawing.Size(67, 17);
            this.borrarEstudioPaciente.TabIndex = 0;
            this.borrarEstudioPaciente.TabStop = true;
            this.borrarEstudioPaciente.Text = "Paciente";
            this.borrarEstudioPaciente.UseVisualStyleBackColor = true;
            this.borrarEstudioPaciente.CheckedChanged += new System.EventHandler(this.borrarEstudioPaciente_CheckedChanged);
            // 
            // panelBorrarEstudio
            // 
            this.panelBorrarEstudio.Controls.Add(this.groupBoxBorrarEstudio);
            this.panelBorrarEstudio.Location = new System.Drawing.Point(0, 0);
            this.panelBorrarEstudio.Name = "panelBorrarEstudio";
            this.panelBorrarEstudio.Size = new System.Drawing.Size(873, 600);
            this.panelBorrarEstudio.TabIndex = 19;
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorrarEstudio);
            this.Controls.Add(this.panelBorrarInvest);
            this.Controls.Add(this.panelBorrarInstrumentos);
            this.Name = "Borrar";
            this.Size = new System.Drawing.Size(873, 600);
            this.panelBorrarInvest.ResumeLayout(false);
            this.groupBoxBorrarInvestigador.ResumeLayout(false);
            this.panelBorrarInstrumentos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelborrarInstPac.ResumeLayout(false);
            this.panelBorrarNombreInst.ResumeLayout(false);
            this.groupBoxBorrarEstudio.ResumeLayout(false);
            this.groupBoxBorrarEstudio.PerformLayout();
            this.panelBorrarEstPaciente.ResumeLayout(false);
            this.panelBorrarEstPaciente.PerformLayout();
            this.panelBorrarCodEst.ResumeLayout(false);
            this.panelBorrarCodEst.PerformLayout();
            this.panelBorrarEstudio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarInvest;
        private System.Windows.Forms.Button buttonBorrarInvest;
        private System.Windows.Forms.ComboBox comboBoxBorrarInvest;
        private System.Windows.Forms.Panel panelBorrarInstrumentos;
        private System.Windows.Forms.Button buttonBorrarInstrumentos;
        private System.Windows.Forms.GroupBox groupBoxBorrarEstudio;
        private System.Windows.Forms.Panel panelBorrarEstPaciente;
        private System.Windows.Forms.RadioButton borrarEstudioCodigo;
        private System.Windows.Forms.RadioButton borrarEstudioPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPacienteEstudio;
        private System.Windows.Forms.Panel panelBorrarCodEst;
        private System.Windows.Forms.Button buttonBorrarCodigo;
        private System.Windows.Forms.ComboBox comboBoxBorrarCod;
        private System.Windows.Forms.Label codEst;
        private System.Windows.Forms.Button buttonBorrarEstudioPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox borrarListaInstrumentos;
        private System.Windows.Forms.RadioButton radioButtonBorrarPorNombre;
        private System.Windows.Forms.RadioButton radioButtonBorrarPorPaciente;
        private System.Windows.Forms.Panel panelBorrarNombreInst;
        private System.Windows.Forms.Button borrarNombreInst;
        private System.Windows.Forms.Panel panelborrarInstPac;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox listaInstPorPaciente;
        private System.Windows.Forms.CheckedListBox listaBorrarEstudioPaciente;
        private System.Windows.Forms.Panel panelBorrarEstudio;
        private System.Windows.Forms.GroupBox groupBoxBorrarInvestigador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}
