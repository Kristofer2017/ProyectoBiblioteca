namespace ProyectoBiblioteca.Formularios
{
    partial class AdministrarComprasVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarComprasVentas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCompras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVentas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ventas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompras
            // 
            this.btnCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompras.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.shopping_cart;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompras.Location = new System.Drawing.Point(3, 3);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(184, 120);
            this.btnCompras.TabIndex = 4;
            this.btnCompras.TabStop = false;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVentas.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.venta;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Location = new System.Drawing.Point(193, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(184, 120);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.TabStop = false;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 50);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Elije una opción";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministrarComprasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 304);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministrarComprasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Compras y Ventas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
    }
}