
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
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.cboConversor = new System.Windows.Forms.ComboBox();
            this.lblMoneda2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lblMasa2 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.cboConversor2 = new System.Windows.Forms.ComboBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConversor3 = new System.Windows.Forms.ComboBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblLongitud2 = new System.Windows.Forms.Label();
            this.cboConversor4 = new System.Windows.Forms.ComboBox();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.cboConversor5 = new System.Windows.Forms.ComboBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cboConversor6 = new System.Windows.Forms.ComboBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblAlmacenamiento2 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(12, 16);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(64, 16);
            this.lblMoneda.TabIndex = 0;
            this.lblMoneda.Text = "Moneda: ";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(73, 14);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtMoneda.TabIndex = 1;
            // 
            // cboConversor
            // 
            this.cboConversor.FormattingEnabled = true;
            this.cboConversor.Items.AddRange(new object[] {
            "Cordoba (Nicaragua)",
            "Lempira (Honduras)",
            "Balboa (Panamá)",
            "Colón (Costa Rica)",
            "Quetzal (Guatemala)",
            "Peso (México)",
            "Sol (Perú)",
            "Euro (Europa)",
            "Yen (Japón)",
            "Yuan (China)"});
            this.cboConversor.Location = new System.Drawing.Point(213, 15);
            this.cboConversor.Name = "cboConversor";
            this.cboConversor.Size = new System.Drawing.Size(121, 21);
            this.cboConversor.TabIndex = 2;
            // 
            // lblMoneda2
            // 
            this.lblMoneda2.AutoSize = true;
            this.lblMoneda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda2.Location = new System.Drawing.Point(188, 16);
            this.lblMoneda2.Name = "lblMoneda2";
            this.lblMoneda2.Size = new System.Drawing.Size(19, 16);
            this.lblMoneda2.TabIndex = 3;
            this.lblMoneda2.Text = "a ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(174, 52);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(355, 53);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado: ?";
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasa.Location = new System.Drawing.Point(13, 54);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(45, 16);
            this.lblMasa.TabIndex = 6;
            this.lblMasa.Text = "Masa:";
            // 
            // lblMasa2
            // 
            this.lblMasa2.AutoSize = true;
            this.lblMasa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasa2.Location = new System.Drawing.Point(188, 54);
            this.lblMasa2.Name = "lblMasa2";
            this.lblMasa2.Size = new System.Drawing.Size(16, 16);
            this.lblMasa2.TabIndex = 7;
            this.lblMasa2.Text = "a";
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(73, 53);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(100, 20);
            this.txtMasa.TabIndex = 8;
            // 
            // cboConversor2
            // 
            this.cboConversor2.FormattingEnabled = true;
            this.cboConversor2.Items.AddRange(new object[] {
            "Tonelada (t)",
            "Quintal (cwt)",
            "Stone (st)",
            "Libra (lb)",
            "Onza (oz)",
            "Hectogramo (hg)",
            "Decagramo (dg)",
            "Gramo (g)",
            "Miligramo (mg)",
            "Microgramo (µg)"});
            this.cboConversor2.Location = new System.Drawing.Point(213, 51);
            this.cboConversor2.Name = "cboConversor2";
            this.cboConversor2.Size = new System.Drawing.Size(121, 21);
            this.cboConversor2.TabIndex = 10;
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(12, 86);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(64, 16);
            this.lblVolumen.TabIndex = 11;
            this.lblVolumen.Text = "Volumen:";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(73, 85);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "a";
            // 
            // cboConversor3
            // 
            this.cboConversor3.FormattingEnabled = true;
            this.cboConversor3.Items.AddRange(new object[] {
            "Metro Cúbico (m3)",
            "Hectolitro (hL)",
            "Barril de Petróleo (bbl)",
            "Galón (gal)",
            "Decalitro (daL)",
            "Pinta (pt)",
            "Onza Liquida (ft Oz)",
            "Decalitro (dL)",
            "Centilitro (cL)",
            "Mililitro (mL)"});
            this.cboConversor3.Location = new System.Drawing.Point(213, 84);
            this.cboConversor3.Name = "cboConversor3";
            this.cboConversor3.Size = new System.Drawing.Size(121, 21);
            this.cboConversor3.TabIndex = 14;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(12, 119);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(62, 16);
            this.lblLongitud.TabIndex = 15;
            this.lblLongitud.Text = "Longitud:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(73, 118);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtLongitud.TabIndex = 16;
            // 
            // lblLongitud2
            // 
            this.lblLongitud2.AutoSize = true;
            this.lblLongitud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud2.Location = new System.Drawing.Point(188, 122);
            this.lblLongitud2.Name = "lblLongitud2";
            this.lblLongitud2.Size = new System.Drawing.Size(16, 16);
            this.lblLongitud2.TabIndex = 17;
            this.lblLongitud2.Text = "a";
            // 
            // cboConversor4
            // 
            this.cboConversor4.FormattingEnabled = true;
            this.cboConversor4.Items.AddRange(new object[] {
            "Kilómetro (km)",
            "Hectómetro (hm)",
            "Decámetro (dam)",
            "Decímetro (dm)",
            "Centímetro (cm)",
            "Milímetro (mm)",
            "Micrómetro (μm)",
            "Nanómetro (nm)",
            "Pulgada (in)",
            "Pie (ft)"});
            this.cboConversor4.Location = new System.Drawing.Point(213, 117);
            this.cboConversor4.Name = "cboConversor4";
            this.cboConversor4.Size = new System.Drawing.Size(121, 21);
            this.cboConversor4.TabIndex = 18;
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(9, 153);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(112, 16);
            this.lblAlmacenamiento.TabIndex = 19;
            this.lblAlmacenamiento.Text = "Almacenamiento:";
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(127, 152);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(100, 20);
            this.txtAlmacenamiento.TabIndex = 20;
            // 
            // cboConversor5
            // 
            this.cboConversor5.FormattingEnabled = true;
            this.cboConversor5.Items.AddRange(new object[] {
            "Yottabyte (YB)",
            "Zettabyte (ZB)",
            "Exabyte (EB)",
            "Petabyte (PB)",
            "Terabyte (TB)",
            "Gigabyte (GB)",
            "Megabyte (MB)",
            "Kilobyte (kB)",
            "Hectobyte (hB)",
            "Decabyte (daB)"});
            this.cboConversor5.Location = new System.Drawing.Point(233, 152);
            this.cboConversor5.Name = "cboConversor5";
            this.cboConversor5.Size = new System.Drawing.Size(121, 21);
            this.cboConversor5.TabIndex = 22;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(12, 188);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(58, 16);
            this.lblTiempo.TabIndex = 23;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(73, 187);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 24;
            // 
            // cboConversor6
            // 
            this.cboConversor6.FormattingEnabled = true;
            this.cboConversor6.Items.AddRange(new object[] {
            "Año",
            "Mes",
            "Semana",
            "Día",
            "Hora",
            "Minuto",
            "Milisegundo",
            "Microsegundo",
            "Nanosegundo",
            "Picosegundo"});
            this.cboConversor6.Location = new System.Drawing.Point(179, 188);
            this.cboConversor6.Name = "cboConversor6";
            this.cboConversor6.Size = new System.Drawing.Size(121, 21);
            this.cboConversor6.TabIndex = 26;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(201, 243);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(175, 52);
            this.btnReiniciar.TabIndex = 27;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblAlmacenamiento2
            // 
            this.lblAlmacenamiento2.AutoSize = true;
            this.lblAlmacenamiento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento2.Location = new System.Drawing.Point(360, 153);
            this.lblAlmacenamiento2.Name = "lblAlmacenamiento2";
            this.lblAlmacenamiento2.Size = new System.Drawing.Size(46, 16);
            this.lblAlmacenamiento2.TabIndex = 28;
            this.lblAlmacenamiento2.Text = "a Byte";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo2.Location = new System.Drawing.Point(306, 188);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(81, 16);
            this.lblTiempo2.TabIndex = 29;
            this.lblTiempo2.Text = "a Segundos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 307);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.lblAlmacenamiento2);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.cboConversor6);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.cboConversor5);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.cboConversor4);
            this.Controls.Add(this.lblLongitud2);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.cboConversor3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.cboConversor2);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.lblMasa2);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMoneda2);
            this.Controls.Add(this.cboConversor);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Name = "Form1";
            this.Text = "V";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.ComboBox cboConversor;
        private System.Windows.Forms.Label lblMoneda2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblMasa2;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.ComboBox cboConversor2;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConversor3;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblLongitud2;
        private System.Windows.Forms.ComboBox cboConversor4;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.ComboBox cboConversor5;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cboConversor6;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblAlmacenamiento2;
        private System.Windows.Forms.Label lblTiempo2;
    }
}

