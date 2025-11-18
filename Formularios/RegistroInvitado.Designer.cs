namespace ProyectoBiblioteca.Formularios
{
    partial class RegistroInvitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInvitado));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtNombreInvitado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(28, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 66);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "¿Cuál es su nombre?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(28, 135);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 42);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(180, 135);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(140, 42);
            this.btnContinuar.TabIndex = 28;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtNombreInvitado
            // 
            this.txtNombreInvitado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInvitado.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInvitado.Location = new System.Drawing.Point(28, 74);
            this.txtNombreInvitado.Multiline = true;
            this.txtNombreInvitado.Name = "txtNombreInvitado";
            this.txtNombreInvitado.Size = new System.Drawing.Size(288, 39);
            this.txtNombreInvitado.TabIndex = 29;
            this.txtNombreInvitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NombreInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 211);
            this.Controls.Add(this.txtNombreInvitado);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NombreInvitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar como Invitado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtNombreInvitado;
    }
}