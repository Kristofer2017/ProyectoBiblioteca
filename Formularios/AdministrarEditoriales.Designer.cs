namespace ProyectoBiblioteca.Formularios
{
    partial class AdministrarEditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarEditoriales));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionarEditorial = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(646, 28);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Editoriales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 46);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(111, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 46);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(219, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 46);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(327, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 46);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSeleccionarEditorial
            // 
            this.btnSeleccionarEditorial.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarEditorial.Location = new System.Drawing.Point(477, 286);
            this.btnSeleccionarEditorial.Name = "btnSeleccionarEditorial";
            this.btnSeleccionarEditorial.Size = new System.Drawing.Size(188, 64);
            this.btnSeleccionarEditorial.TabIndex = 42;
            this.btnSeleccionarEditorial.Text = "Seleccionar Editorial";
            this.btnSeleccionarEditorial.UseVisualStyleBackColor = true;
            this.btnSeleccionarEditorial.Click += new System.EventHandler(this.btnSeleccionarEditorial_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpiar, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 301);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 52);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre Editorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(143, 91);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 33;
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.AllowUserToAddRows = false;
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEditoriales.Location = new System.Drawing.Point(346, 65);
            this.dgvEditoriales.MultiSelect = false;
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditoriales.Size = new System.Drawing.Size(319, 184);
            this.dgvEditoriales.TabIndex = 30;
            this.dgvEditoriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditoriales_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Location = new System.Drawing.Point(19, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 190);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Editorial";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 107);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(151, 62);
            this.txtDireccion.TabIndex = 0;
            this.txtDireccion.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 36);
            this.label5.TabIndex = 44;
            this.label5.Text = "Acciones disponibles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSeleccionarEditorial);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvEditoriales);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.Editoriales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSeleccionarEditorial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvEditoriales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.Label label5;
    }
}