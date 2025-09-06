
namespace miPrimerProyectoCsharp
{
    partial class Form2
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
            this.cboMedidaObtener = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboMedidaOrigen = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblResultadoConversion = new System.Windows.Forms.Label();
            this.lblMedidaObtener = new System.Windows.Forms.Label();
            this.lblMedidaOrigen = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMedidaObtener
            // 
            this.cboMedidaObtener.FormattingEnabled = true;
            this.cboMedidaObtener.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.cboMedidaObtener.Location = new System.Drawing.Point(204, 169);
            this.cboMedidaObtener.Name = "cboMedidaObtener";
            this.cboMedidaObtener.Size = new System.Drawing.Size(121, 21);
            this.cboMedidaObtener.TabIndex = 18;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(405, 113);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(111, 88);
            this.btnConvertir.TabIndex = 17;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboMedidaOrigen
            // 
            this.cboMedidaOrigen.FormattingEnabled = true;
            this.cboMedidaOrigen.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.cboMedidaOrigen.Location = new System.Drawing.Point(172, 126);
            this.cboMedidaOrigen.Name = "cboMedidaOrigen";
            this.cboMedidaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cboMedidaOrigen.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(138, 90);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // lblResultadoConversion
            // 
            this.lblResultadoConversion.AutoSize = true;
            this.lblResultadoConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoConversion.Location = new System.Drawing.Point(52, 212);
            this.lblResultadoConversion.Name = "lblResultadoConversion";
            this.lblResultadoConversion.Size = new System.Drawing.Size(203, 18);
            this.lblResultadoConversion.TabIndex = 14;
            this.lblResultadoConversion.Text = "Resultado de Conversión:";
            // 
            // lblMedidaObtener
            // 
            this.lblMedidaObtener.AutoSize = true;
            this.lblMedidaObtener.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidaObtener.Location = new System.Drawing.Point(52, 172);
            this.lblMedidaObtener.Name = "lblMedidaObtener";
            this.lblMedidaObtener.Size = new System.Drawing.Size(146, 18);
            this.lblMedidaObtener.TabIndex = 13;
            this.lblMedidaObtener.Text = "Medida a Obtener:";
            // 
            // lblMedidaOrigen
            // 
            this.lblMedidaOrigen.AutoSize = true;
            this.lblMedidaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidaOrigen.Location = new System.Drawing.Point(52, 130);
            this.lblMedidaOrigen.Name = "lblMedidaOrigen";
            this.lblMedidaOrigen.Size = new System.Drawing.Size(122, 18);
            this.lblMedidaOrigen.TabIndex = 12;
            this.lblMedidaOrigen.Text = "Medida Origen:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(52, 93);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 18);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Conversor de medidas (Salvadoreñas) de área.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.Controls.Add(this.cboMedidaObtener);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboMedidaOrigen);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblResultadoConversion);
            this.Controls.Add(this.lblMedidaObtener);
            this.Controls.Add(this.lblMedidaOrigen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMedidaObtener;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboMedidaOrigen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblResultadoConversion;
        private System.Windows.Forms.Label lblMedidaObtener;
        private System.Windows.Forms.Label lblMedidaOrigen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
    }
}