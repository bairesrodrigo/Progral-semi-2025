namespace miPrimerProyectoCsharp
{
    partial class frmNotas
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
            System.Windows.Forms.Label lblIdNota;
            System.Windows.Forms.Label lblMateria;
            System.Windows.Forms.Label lblPeriodo;
            System.Windows.Forms.Label lblFecha;
            this.db_academicaDataSet = new miPrimerProyectoCsharp.db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.materiasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.materiasTableAdapter();
            this.periodosTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.periodosTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdNota = new System.Windows.Forms.Label();
            lblMateria = new System.Windows.Forms.Label();
            lblPeriodo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdNota
            // 
            lblIdNota.AutoSize = true;
            lblIdNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdNota.Location = new System.Drawing.Point(35, 32);
            lblIdNota.Name = "lblIdNota";
            lblIdNota.Size = new System.Drawing.Size(26, 16);
            lblIdNota.TabIndex = 0;
            lblIdNota.Text = "ID:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMateria.Location = new System.Drawing.Point(35, 61);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(63, 16);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPeriodo.Location = new System.Drawing.Point(377, 61);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(62, 16);
            lblPeriodo.TabIndex = 4;
            lblPeriodo.Text = "Periodo";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFecha.Location = new System.Drawing.Point(35, 116);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(54, 16);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdNota", true));
            this.idNotaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNotaLabel1.Location = new System.Drawing.Point(98, 32);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotaLabel1.TabIndex = 1;
            this.idNotaLabel1.Text = "label1";
            // 
            // cboMateria
            // 
            this.cboMateria.DataSource = this.materiasBindingSource;
            this.cboMateria.DisplayMember = "nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(98, 58);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(227, 24);
            this.cboMateria.TabIndex = 3;
            this.cboMateria.ValueMember = "IdMateria";
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.periodosBindingSource, "IdPeriodo", true));
            this.cboPeriodo.DataSource = this.periodosBindingSource;
            this.cboPeriodo.DisplayMember = "periodo";
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(440, 58);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 24);
            this.cboPeriodo.TabIndex = 5;
            this.cboPeriodo.ValueMember = "IdPeriodo";
            this.cboPeriodo.SelectedValueChanged += new System.EventHandler(this.cboPeriodo_SelectedValueChanged);
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(98, 112);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(296, 22);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "dnotas";
            this.dnotasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // dnotasDataGridView
            // 
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AutoGenerateColumns = false;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idNota,
            this.idMateria,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.DataSource = this.dnotasBindingSource;
            this.dnotasDataGridView.Location = new System.Drawing.Point(38, 159);
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.Size = new System.Drawing.Size(645, 257);
            this.dnotasDataGridView.TabIndex = 8;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(711, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "IdDetalle";
            this.idDetalle.HeaderText = "ID";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            this.idDetalle.Width = 50;
            // 
            // idNota
            // 
            this.idNota.DataPropertyName = "idNota";
            this.idNota.HeaderText = "idNota";
            this.idNota.Name = "idNota";
            this.idNota.ReadOnly = true;
            this.idNota.Visible = false;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 200;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB 1";
            this.lab1.Name = "lab1";
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB 2";
            this.lab2.Name = "lab2";
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "PARCIAL";
            this.parcial.Name = "parcial";
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 497);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(lblIdNota);
            this.Controls.Add(this.idNotaLabel1);
            this.Controls.Add(lblMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblPeriodo);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicaDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}