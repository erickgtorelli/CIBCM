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
            this.buttonBorrarInvest = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxBorrarInvest = new System.Windows.Forms.ComboBox();
            this.panelBorrarInvest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorrarInvest
            // 
            this.panelBorrarInvest.Controls.Add(this.buttonBorrarInvest);
            this.panelBorrarInvest.Controls.Add(this.label17);
            this.panelBorrarInvest.Controls.Add(this.comboBoxBorrarInvest);
            this.panelBorrarInvest.Location = new System.Drawing.Point(38, 24);
            this.panelBorrarInvest.Name = "panelBorrarInvest";
            this.panelBorrarInvest.Size = new System.Drawing.Size(485, 166);
            this.panelBorrarInvest.TabIndex = 18;
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
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 3;
            // 
            // comboBoxBorrarInvest
            // 
            this.comboBoxBorrarInvest.FormattingEnabled = true;
            this.comboBoxBorrarInvest.Location = new System.Drawing.Point(165, 58);
            this.comboBoxBorrarInvest.Name = "comboBoxBorrarInvest";
            this.comboBoxBorrarInvest.Size = new System.Drawing.Size(228, 21);
            this.comboBoxBorrarInvest.TabIndex = 0;
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorrarInvest);
            this.Name = "Borrar";
            this.Size = new System.Drawing.Size(612, 259);
            this.panelBorrarInvest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarInvest;
        private System.Windows.Forms.Button buttonBorrarInvest;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxBorrarInvest;

    }
}
