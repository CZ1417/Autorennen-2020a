namespace Autorennen
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFahrbahn = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonBremsen = new System.Windows.Forms.Button();
            this.buttonBeschleunigen = new System.Windows.Forms.Button();
            this.buttonHupe = new System.Windows.Forms.Button();
            this.tachoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelFahrbahn
            // 
            this.panelFahrbahn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFahrbahn.Location = new System.Drawing.Point(0, 0);
            this.panelFahrbahn.Margin = new System.Windows.Forms.Padding(2);
            this.panelFahrbahn.Name = "panelFahrbahn";
            this.panelFahrbahn.Size = new System.Drawing.Size(770, 348);
            this.panelFahrbahn.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonBremsen
            // 
            this.buttonBremsen.Location = new System.Drawing.Point(41, 412);
            this.buttonBremsen.Name = "buttonBremsen";
            this.buttonBremsen.Size = new System.Drawing.Size(75, 32);
            this.buttonBremsen.TabIndex = 1;
            this.buttonBremsen.Text = "Bremsen";
            this.buttonBremsen.UseVisualStyleBackColor = true;
            this.buttonBremsen.Click += new System.EventHandler(this.ButtonBremsen_Click);
            // 
            // buttonBeschleunigen
            // 
            this.buttonBeschleunigen.Location = new System.Drawing.Point(122, 412);
            this.buttonBeschleunigen.Name = "buttonBeschleunigen";
            this.buttonBeschleunigen.Size = new System.Drawing.Size(89, 32);
            this.buttonBeschleunigen.TabIndex = 2;
            this.buttonBeschleunigen.Text = "Beschleunigen";
            this.buttonBeschleunigen.UseVisualStyleBackColor = true;
            this.buttonBeschleunigen.Click += new System.EventHandler(this.ButtonBeschleunigen_Click);
            // 
            // buttonHupe
            // 
            this.buttonHupe.Location = new System.Drawing.Point(41, 374);
            this.buttonHupe.Name = "buttonHupe";
            this.buttonHupe.Size = new System.Drawing.Size(62, 32);
            this.buttonHupe.TabIndex = 3;
            this.buttonHupe.Text = "Hupe";
            this.buttonHupe.UseVisualStyleBackColor = true;
            this.buttonHupe.Click += new System.EventHandler(this.ButtonHupe_Click);
            // 
            // tachoLabel
            // 
            this.tachoLabel.AutoSize = true;
            this.tachoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tachoLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tachoLabel.Location = new System.Drawing.Point(122, 375);
            this.tachoLabel.Name = "tachoLabel";
            this.tachoLabel.Size = new System.Drawing.Size(56, 29);
            this.tachoLabel.TabIndex = 4;
            this.tachoLabel.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "km/h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tachoLabel);
            this.Controls.Add(this.buttonHupe);
            this.Controls.Add(this.buttonBeschleunigen);
            this.Controls.Add(this.buttonBremsen);
            this.Controls.Add(this.panelFahrbahn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFahrbahn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonBremsen;
        private System.Windows.Forms.Button buttonBeschleunigen;
        private System.Windows.Forms.Button buttonHupe;
        private System.Windows.Forms.Label tachoLabel;
        private System.Windows.Forms.Label label2;
    }
}

