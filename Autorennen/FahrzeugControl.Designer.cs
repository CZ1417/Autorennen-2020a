namespace Autorennen
{
    partial class FahrzeugControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTacho = new System.Windows.Forms.Label();
            this.btnHupe = new System.Windows.Forms.Button();
            this.btnBremse = new System.Windows.Forms.Button();
            this.btnGas = new System.Windows.Forms.Button();
            this.grpFahrzeug = new System.Windows.Forms.GroupBox();
            this.grpFahrzeug.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTacho
            // 
            this.lblTacho.AutoSize = true;
            this.lblTacho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTacho.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacho.Location = new System.Drawing.Point(79, 26);
            this.lblTacho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTacho.Name = "lblTacho";
            this.lblTacho.Size = new System.Drawing.Size(56, 29);
            this.lblTacho.TabIndex = 8;
            this.lblTacho.Text = "000";
            // 
            // btnHupe
            // 
            this.btnHupe.Location = new System.Drawing.Point(8, 18);
            this.btnHupe.Margin = new System.Windows.Forms.Padding(2);
            this.btnHupe.Name = "btnHupe";
            this.btnHupe.Size = new System.Drawing.Size(48, 47);
            this.btnHupe.TabIndex = 7;
            this.btnHupe.Text = "Hupe";
            this.btnHupe.UseVisualStyleBackColor = true;
            this.btnHupe.Click += new System.EventHandler(this.btnHupe_Click);
            // 
            // btnBremse
            // 
            this.btnBremse.Location = new System.Drawing.Point(8, 76);
            this.btnBremse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBremse.Name = "btnBremse";
            this.btnBremse.Size = new System.Drawing.Size(78, 41);
            this.btnBremse.TabIndex = 6;
            this.btnBremse.Text = "Bremse";
            this.btnBremse.UseVisualStyleBackColor = true;
            this.btnBremse.Click += new System.EventHandler(this.btnBremse_Click);
            // 
            // btnGas
            // 
            this.btnGas.Location = new System.Drawing.Point(98, 76);
            this.btnGas.Margin = new System.Windows.Forms.Padding(2);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(52, 42);
            this.btnGas.TabIndex = 5;
            this.btnGas.Text = "Gas";
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // grpFahrzeug
            // 
            this.grpFahrzeug.Controls.Add(this.lblTacho);
            this.grpFahrzeug.Controls.Add(this.btnHupe);
            this.grpFahrzeug.Controls.Add(this.btnBremse);
            this.grpFahrzeug.Controls.Add(this.btnGas);
            this.grpFahrzeug.Location = new System.Drawing.Point(6, 9);
            this.grpFahrzeug.Name = "grpFahrzeug";
            this.grpFahrzeug.Size = new System.Drawing.Size(158, 127);
            this.grpFahrzeug.TabIndex = 9;
            this.grpFahrzeug.TabStop = false;
            this.grpFahrzeug.Text = "groupBox1";
            // 
            // FahrzeugControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFahrzeug);
            this.Name = "FahrzeugControl";
            this.Size = new System.Drawing.Size(173, 146);
            this.grpFahrzeug.ResumeLayout(false);
            this.grpFahrzeug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTacho;
        private System.Windows.Forms.Button btnHupe;
        private System.Windows.Forms.Button btnBremse;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.GroupBox grpFahrzeug;
    }
}
