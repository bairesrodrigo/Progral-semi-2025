
namespace miPrimerProyectoCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblTipica = new System.Windows.Forms.Label();
            this.lblArmonica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(12, 26);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(56, 20);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(93, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(185, 53);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(75, 28);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(227, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(12, 66);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(62, 20);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "Media:";
            // 
            // lblTipica
            // 
            this.lblTipica.AutoSize = true;
            this.lblTipica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipica.Location = new System.Drawing.Point(12, 106);
            this.lblTipica.Name = "lblTipica";
            this.lblTipica.Size = new System.Drawing.Size(61, 20);
            this.lblTipica.TabIndex = 4;
            this.lblTipica.Text = "Tipica:";
            // 
            // lblArmonica
            // 
            this.lblArmonica.AutoSize = true;
            this.lblArmonica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmonica.Location = new System.Drawing.Point(12, 142);
            this.lblArmonica.Name = "lblArmonica";
            this.lblArmonica.Size = new System.Drawing.Size(89, 20);
            this.lblArmonica.TabIndex = 5;
            this.lblArmonica.Text = "Armonica:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.lblArmonica);
            this.Controls.Add(this.lblTipica);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Estadistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblTipica;
        private System.Windows.Forms.Label lblArmonica;
    }
}

