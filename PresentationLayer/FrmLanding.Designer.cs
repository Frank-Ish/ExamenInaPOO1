namespace PresentationLayer
{
    partial class FrmLanding
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbRegistrar = new System.Windows.Forms.Label();
            this.lbMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(106, 26);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(389, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Bienvenido a nuestro sistema de base de datos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.Location = new System.Drawing.Point(250, 249);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(250, 143);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(74, 25);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbRegistrar
            // 
            this.lbRegistrar.AutoSize = true;
            this.lbRegistrar.Location = new System.Drawing.Point(219, 213);
            this.lbRegistrar.Name = "lbRegistrar";
            this.lbRegistrar.Size = new System.Drawing.Size(141, 13);
            this.lbRegistrar.TabIndex = 3;
            this.lbRegistrar.Text = "Registre un nuevo automivil.";
            // 
            // lbMostrar
            // 
            this.lbMostrar.AutoSize = true;
            this.lbMostrar.Location = new System.Drawing.Point(196, 98);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(191, 13);
            this.lbMostrar.TabIndex = 4;
            this.lbMostrar.Text = "Lista de automoviles en base de datos.";
            // 
            // FrmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(586, 302);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.lbRegistrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmLanding";
            this.Text = "frmLanding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbRegistrar;
        private System.Windows.Forms.Label lbMostrar;
    }
}

