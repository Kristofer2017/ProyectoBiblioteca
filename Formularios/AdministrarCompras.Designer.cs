namespace ProyectoBiblioteca.Formularios
{
    partial class AdministrarCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.Location = new System.Drawing.Point(30, 84);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 62;
            this.dgvCompras.RowTemplate.Height = 28;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(668, 324);
            this.dgvCompras.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(668, 55);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Registro De Compras";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReporteCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReporteCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCompras.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCompras.ForeColor = System.Drawing.Color.Black;
            this.btnReporteCompras.Image = global::ProyectoBiblioteca.Properties.Resources.reporte;
            this.btnReporteCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCompras.Location = new System.Drawing.Point(302, 425);
            this.btnReporteCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.btnReporteCompras.Size = new System.Drawing.Size(129, 47);
            this.btnReporteCompras.TabIndex = 32;
            this.btnReporteCompras.Text = "Reporte";
            this.btnReporteCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteCompras.UseVisualStyleBackColor = false;
            this.btnReporteCompras.Click += new System.EventHandler(this.btnReporteCompras_Click);
            // 
            // AdministrarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 495);
            this.Controls.Add(this.btnReporteCompras);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministrarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Compras";
            this.Load += new System.EventHandler(this.AdministrarCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label lblTitulo;
    }
}