namespace Cine.Capa_de_Presentación
{
    partial class VistaSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaSala));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.btnVaciarSala = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblAsientosP = new System.Windows.Forms.Label();
            this.lblAsientosT = new System.Windows.Forms.Label();
            this.gbPreferencial = new System.Windows.Forms.GroupBox();
            this.gbTradicional = new System.Windows.Forms.GroupBox();
            this.pbPantallaCine = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaCine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(244, 120);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(70, 18);
            this.lblHora.TabIndex = 28;
            this.lblHora.Text = "00:00:00";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraInicio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHoraInicio.Location = new System.Drawing.Point(130, 120);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(108, 18);
            this.lblHoraInicio.TabIndex = 27;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPelicula.Location = new System.Drawing.Point(60, 77);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(67, 18);
            this.lblPelicula.TabIndex = 26;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(133, 74);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(161, 26);
            this.cbPeliculas.TabIndex = 25;
            this.cbPeliculas.SelectedIndexChanged += new System.EventHandler(this.cbPeliculas_SelectedIndexChanged);
            // 
            // btnVaciarSala
            // 
            this.btnVaciarSala.Image = ((System.Drawing.Image)(resources.GetObject("btnVaciarSala.Image")));
            this.btnVaciarSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaciarSala.Location = new System.Drawing.Point(95, 141);
            this.btnVaciarSala.Name = "btnVaciarSala";
            this.btnVaciarSala.Size = new System.Drawing.Size(280, 40);
            this.btnVaciarSala.TabIndex = 24;
            this.btnVaciarSala.Text = "Eliminar Esta Cartelera";
            this.btnVaciarSala.UseVisualStyleBackColor = true;
            this.btnVaciarSala.Click += new System.EventHandler(this.btnVaciarSala_Click);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(300, 67);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 39);
            this.btnVer.TabIndex = 23;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblAsientosP
            // 
            this.lblAsientosP.AutoSize = true;
            this.lblAsientosP.BackColor = System.Drawing.Color.Transparent;
            this.lblAsientosP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAsientosP.Location = new System.Drawing.Point(70, 507);
            this.lblAsientosP.Name = "lblAsientosP";
            this.lblAsientosP.Size = new System.Drawing.Size(178, 18);
            this.lblAsientosP.TabIndex = 21;
            this.lblAsientosP.Text = "Asientos Preferenciales:";
            // 
            // lblAsientosT
            // 
            this.lblAsientosT.AutoSize = true;
            this.lblAsientosT.BackColor = System.Drawing.Color.Transparent;
            this.lblAsientosT.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAsientosT.Location = new System.Drawing.Point(70, 320);
            this.lblAsientosT.Name = "lblAsientosT";
            this.lblAsientosT.Size = new System.Drawing.Size(170, 18);
            this.lblAsientosT.TabIndex = 22;
            this.lblAsientosT.Text = "Asientos Tradicionales:";
            // 
            // gbPreferencial
            // 
            this.gbPreferencial.BackColor = System.Drawing.SystemColors.Window;
            this.gbPreferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreferencial.Location = new System.Drawing.Point(73, 528);
            this.gbPreferencial.Name = "gbPreferencial";
            this.gbPreferencial.Size = new System.Drawing.Size(320, 150);
            this.gbPreferencial.TabIndex = 19;
            this.gbPreferencial.TabStop = false;
            // 
            // gbTradicional
            // 
            this.gbTradicional.BackColor = System.Drawing.SystemColors.Window;
            this.gbTradicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTradicional.Location = new System.Drawing.Point(73, 341);
            this.gbTradicional.Name = "gbTradicional";
            this.gbTradicional.Size = new System.Drawing.Size(320, 150);
            this.gbTradicional.TabIndex = 20;
            this.gbTradicional.TabStop = false;
            // 
            // pbPantallaCine
            // 
            this.pbPantallaCine.Image = ((System.Drawing.Image)(resources.GetObject("pbPantallaCine.Image")));
            this.pbPantallaCine.Location = new System.Drawing.Point(73, 187);
            this.pbPantallaCine.Name = "pbPantallaCine";
            this.pbPantallaCine.Size = new System.Drawing.Size(320, 130);
            this.pbPantallaCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPantallaCine.TabIndex = 18;
            this.pbPantallaCine.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(376, 67);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 39);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VistaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 690);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.cbPeliculas);
            this.Controls.Add(this.btnVaciarSala);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblAsientosP);
            this.Controls.Add(this.lblAsientosT);
            this.Controls.Add(this.gbPreferencial);
            this.Controls.Add(this.gbTradicional);
            this.Controls.Add(this.pbPantallaCine);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VistaSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Sala";
            this.Load += new System.EventHandler(this.VistaSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblHora;
        internal System.Windows.Forms.Label lblHoraInicio;
        internal System.Windows.Forms.Label lblPelicula;
        internal System.Windows.Forms.ComboBox cbPeliculas;
        internal System.Windows.Forms.Button btnVaciarSala;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.Label lblAsientosP;
        internal System.Windows.Forms.Label lblAsientosT;
        internal System.Windows.Forms.GroupBox gbPreferencial;
        internal System.Windows.Forms.GroupBox gbTradicional;
        internal System.Windows.Forms.PictureBox pbPantallaCine;
        internal System.Windows.Forms.Button btnSalir;
    }
}