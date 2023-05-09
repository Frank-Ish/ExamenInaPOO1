namespace PresentationLayer
{
    partial class FrmRegristo
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbVin = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(141, 49);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(71, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Registo";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(83, 127);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 1;
            this.lbPlaca.Text = "Placa";
            // 
            // lbVin
            // 
            this.lbVin.AutoSize = true;
            this.lbVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVin.Location = new System.Drawing.Point(83, 173);
            this.lbVin.Name = "lbVin";
            this.lbVin.Size = new System.Drawing.Size(26, 16);
            this.lbVin.TabIndex = 2;
            this.lbVin.Text = "Vin";
            this.lbVin.Click += new System.EventHandler(this.lbVin_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(83, 220);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 16);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(83, 263);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 16);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(83, 308);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(39, 16);
            this.lbColor.TabIndex = 5;
            this.lbColor.Text = "Color";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(145, 127);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 7;
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(145, 173);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(121, 20);
            this.txtVin.TabIndex = 8;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(145, 220);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 9;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(145, 262);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 10;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(145, 303);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 21);
            this.cbxColor.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.Location = new System.Drawing.Point(145, 381);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmRegristo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbVin);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmRegristo";
            this.Text = "FrmRegristo";
            this.Load += new System.EventHandler(this.FrmRegristo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbVin;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Button btnRegistrar;
    }
}