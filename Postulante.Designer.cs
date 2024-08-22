namespace DEMOPROY
{
    partial class Postulante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postulante));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPostulantes = new System.Windows.Forms.DataGridView();
            this.dEMOPROYDataSet = new DEMOPROY.DEMOPROYDataSet();
            this.pOSTULANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSTULANTETableAdapter = new DEMOPROY.DEMOPROYDataSetTableAdapters.POSTULANTETableAdapter();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarCI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTULANTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSTULANTE";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(187, 69);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 26);
            this.txtCI.TabIndex = 1;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(187, 111);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(100, 26);
            this.txtPrimerNombre.TabIndex = 2;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(187, 153);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(100, 26);
            this.txtSegundoNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro Carnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundo Nombre";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.AutoSize = true;
            this.txtSegundoApellido.Location = new System.Drawing.Point(345, 156);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(134, 20);
            this.txtSegundoApellido.TabIndex = 7;
            this.txtSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.AutoSize = true;
            this.txtPrimerApellido.Location = new System.Drawing.Point(345, 117);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(114, 20);
            this.txtPrimerApellido.TabIndex = 8;
            this.txtPrimerApellido.Text = "Primer Apellido";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(496, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(496, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Carrera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(187, 202);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 26);
            this.txtCarrera.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(496, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(101, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(83, 390);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 34);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Yellow;
            this.btnEditar.Location = new System.Drawing.Point(203, 390);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 34);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Lavender;
            this.btnEliminar.Location = new System.Drawing.Point(317, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 34);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 34);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewPostulantes
            // 
            this.dataGridViewPostulantes.AutoGenerateColumns = false;
            this.dataGridViewPostulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.segundoNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewPostulantes.DataSource = this.pOSTULANTEBindingSource;
            this.dataGridViewPostulantes.Location = new System.Drawing.Point(-1, 234);
            this.dataGridViewPostulantes.Name = "dataGridViewPostulantes";
            this.dataGridViewPostulantes.RowHeadersWidth = 62;
            this.dataGridViewPostulantes.RowTemplate.Height = 28;
            this.dataGridViewPostulantes.Size = new System.Drawing.Size(956, 150);
            this.dataGridViewPostulantes.TabIndex = 19;
            this.dataGridViewPostulantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostulantes_CellContentClick);
            // 
            // dEMOPROYDataSet
            // 
            this.dEMOPROYDataSet.DataSetName = "DEMOPROYDataSet";
            this.dEMOPROYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSTULANTEBindingSource
            // 
            this.pOSTULANTEBindingSource.DataMember = "POSTULANTE";
            this.pOSTULANTEBindingSource.DataSource = this.dEMOPROYDataSet;
            // 
            // pOSTULANTETableAdapter
            // 
            this.pOSTULANTETableAdapter.ClearBeforeFill = true;
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            this.cIDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cIDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.Width = 150;
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            this.primerNombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // segundoNombreDataGridViewTextBoxColumn
            // 
            this.segundoNombreDataGridViewTextBoxColumn.DataPropertyName = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.HeaderText = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.segundoNombreDataGridViewTextBoxColumn.Name = "segundoNombreDataGridViewTextBoxColumn";
            this.segundoNombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "SegundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "SegundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            this.carreraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            this.carreraDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // txtBuscarCI
            // 
            this.txtBuscarCI.Location = new System.Drawing.Point(631, 27);
            this.txtBuscarCI.Name = "txtBuscarCI";
            this.txtBuscarCI.Size = new System.Drawing.Size(121, 26);
            this.txtBuscarCI.TabIndex = 20;
            // 
            // Postulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.txtBuscarCI);
            this.Controls.Add(this.dataGridViewPostulantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postulante";
            this.Text = "Postulante";
            this.Load += new System.EventHandler(this.Postulante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMOPROYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTULANTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSegundoApellido;
        private System.Windows.Forms.Label txtPrimerApellido;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewPostulantes;
        private DEMOPROYDataSet dEMOPROYDataSet;
        private System.Windows.Forms.BindingSource pOSTULANTEBindingSource;
        private DEMOPROYDataSetTableAdapters.POSTULANTETableAdapter pOSTULANTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBuscarCI;
    }
}