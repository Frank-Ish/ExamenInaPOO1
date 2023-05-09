namespace PresentationLayer
{
    partial class FrmListaAutomoviles
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
            this.lstAutomoviles = new System.Windows.Forms.ListView();
            this.colPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAutomoviles
            // 
            this.lstAutomoviles.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstAutomoviles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlaca,
            this.colVin,
            this.colMarca,
            this.colTipo,
            this.colColor,
            this.colEstado});
            this.lstAutomoviles.HideSelection = false;
            this.lstAutomoviles.Location = new System.Drawing.Point(12, 103);
            this.lstAutomoviles.Name = "lstAutomoviles";
            this.lstAutomoviles.Size = new System.Drawing.Size(363, 100);
            this.lstAutomoviles.TabIndex = 0;
            this.lstAutomoviles.UseCompatibleStateImageBehavior = false;
            this.lstAutomoviles.View = System.Windows.Forms.View.Details;
            this.lstAutomoviles.SelectedIndexChanged += new System.EventHandler(this.lstAutomoviles_SelectedIndexChanged);
            // 
            // colPlaca
            // 
            this.colPlaca.Text = "Placa";
            // 
            // colVin
            // 
            this.colVin.Text = "Vin";
            // 
            // colMarca
            // 
            this.colMarca.Text = "Marca";
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 61;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(109, 47);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(180, 20);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Lista de Automoviles.";
            // 
            // FrmListaAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(388, 273);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lstAutomoviles);
            this.Name = "FrmListaAutomoviles";
            this.Text = "FrmListaAutomoviles";
            this.Load += new System.EventHandler(this.FrmListaAutomoviles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAutomoviles;
        private System.Windows.Forms.ColumnHeader colPlaca;
        private System.Windows.Forms.ColumnHeader colVin;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.Label lbTitulo;
    }
}