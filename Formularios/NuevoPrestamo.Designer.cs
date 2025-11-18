namespace ProyectoBiblioteca.Formularios
{
    partial class NuevoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamo));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkHabilitarDias = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.numCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDias)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de prestamo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(196, 80);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaDevolucion.TabIndex = 15;
            this.dtpFechaDevolucion.ValueChanged += new System.EventHandler(this.dtpFechaDevolucion_ValueChanged);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(196, 41);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaPrestamo.TabIndex = 16;
            this.dtpFechaPrestamo.ValueChanged += new System.EventHandler(this.dtpFechaPrestamo_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Libro a prestar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuario.Location = new System.Drawing.Point(4, 35);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(425, 206);
            this.dgvUsuario.TabIndex = 11;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToAddRows = false;
            this.dgvLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLibro.Location = new System.Drawing.Point(436, 35);
            this.dgvLibro.MultiSelect = false;
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibro.Size = new System.Drawing.Size(426, 206);
            this.dgvLibro.TabIndex = 12;
            this.dgvLibro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibro_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(870, 33);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Nuevo Préstamo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de devolución";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkHabilitarDias
            // 
            this.checkHabilitarDias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkHabilitarDias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkHabilitarDias.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHabilitarDias.Location = new System.Drawing.Point(13, 120);
            this.checkHabilitarDias.Name = "checkHabilitarDias";
            this.checkHabilitarDias.Size = new System.Drawing.Size(167, 20);
            this.checkHabilitarDias.TabIndex = 24;
            this.checkHabilitarDias.Text = "Cantidad días";
            this.checkHabilitarDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHabilitarDias.UseVisualStyleBackColor = true;
            this.checkHabilitarDias.CheckedChanged += new System.EventHandler(this.checkHabilitarDias_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvLibro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 245);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Detalles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Usuario que realiza el préstamo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Libro a prestar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTarifa, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaDevolucion, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFechaPrestamo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblLibro, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblUsuario, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(463, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(427, 151);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total préstamo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fecha de devolución";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fecha préstamo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarifa
            // 
            this.lblTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarifa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(217, 124);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(206, 26);
            this.lblTarifa.TabIndex = 29;
            this.lblTarifa.Text = "Desconocido";
            this.lblTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.label11, 2);
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(419, 30);
            this.label11.TabIndex = 23;
            this.label11.Text = "Resumen";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(217, 101);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(206, 22);
            this.lblFechaDevolucion.TabIndex = 29;
            this.lblFechaDevolucion.Text = "Desconocido";
            this.lblFechaDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(217, 78);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(206, 22);
            this.lblFechaPrestamo.TabIndex = 29;
            this.lblFechaPrestamo.Text = "Desconocido";
            this.lblFechaPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibro
            // 
            this.lblLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(217, 55);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(206, 22);
            this.lblLibro.TabIndex = 29;
            this.lblLibro.Text = "Desconocido";
            this.lblLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(217, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(206, 22);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Desconocido";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPrestamo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(446, 3);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(177, 41);
            this.btnAgregarPrestamo.TabIndex = 27;
            this.btnAgregarPrestamo.Text = "Guardar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(243, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 41);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.checkHabilitarDias, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaDevolucion, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaPrestamo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 68);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 151);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.numCantidadDias, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(196, 113);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(229, 34);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 34);
            this.label12.TabIndex = 26;
            this.label12.Text = "Presiona Enter si ingresas desde teclado para actualizar datos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCantidadDias
            // 
            this.numCantidadDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numCantidadDias.Enabled = false;
            this.numCantidadDias.Location = new System.Drawing.Point(3, 7);
            this.numCantidadDias.Name = "numCantidadDias";
            this.numCantidadDias.Size = new System.Drawing.Size(62, 20);
            this.numCantidadDias.TabIndex = 27;
            this.numCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCantidadDias.ValueChanged += new System.EventHandler(this.numCantidadDias_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregarPrestamo, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 493);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(866, 47);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 568);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Prestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDias)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkHabilitarDias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numCantidadDias;
    }
}