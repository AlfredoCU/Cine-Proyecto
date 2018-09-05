namespace Cine.Capa_de_Presentación
{
    partial class AgregarPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPeliculas));
            this.gbPortada = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtDuracion = new System.Windows.Forms.MaskedTextBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbPortada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPortada
            // 
            this.gbPortada.BackColor = System.Drawing.Color.Transparent;
            this.gbPortada.Controls.Add(this.btnExaminar);
            this.gbPortada.Controls.Add(this.pbPortada);
            this.gbPortada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPortada.ForeColor = System.Drawing.SystemColors.Window;
            this.gbPortada.Location = new System.Drawing.Point(325, 74);
            this.gbPortada.Margin = new System.Windows.Forms.Padding(2);
            this.gbPortada.Name = "gbPortada";
            this.gbPortada.Padding = new System.Windows.Forms.Padding(2);
            this.gbPortada.Size = new System.Drawing.Size(305, 373);
            this.gbPortada.TabIndex = 12;
            this.gbPortada.TabStop = false;
            this.gbPortada.Text = "Portada";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExaminar.Image = ((System.Drawing.Image)(resources.GetObject("btnExaminar.Image")));
            this.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExaminar.Location = new System.Drawing.Point(164, 331);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(117, 37);
            this.btnExaminar.TabIndex = 4;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(25, 20);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(256, 303);
            this.pbPortada.TabIndex = 3;
            this.pbPortada.TabStop = false;
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.txtDuracion);
            this.gbDatos.Controls.Add(this.cbFormato);
            this.gbDatos.Controls.Add(this.cbClasificacion);
            this.gbDatos.Controls.Add(this.cbGenero);
            this.gbDatos.Controls.Add(this.txtTitulo);
            this.gbDatos.Controls.Add(this.lblFormato);
            this.gbDatos.Controls.Add(this.lblDuracion);
            this.gbDatos.Controls.Add(this.lblClasificacion);
            this.gbDatos.Controls.Add(this.lblTitulo);
            this.gbDatos.Controls.Add(this.lblGenero);
            this.gbDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.gbDatos.Location = new System.Drawing.Point(20, 74);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(277, 260);
            this.gbDatos.TabIndex = 11;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(93, 70);
            this.txtDuracion.Mask = "0:00";
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(37, 26);
            this.txtDuracion.TabIndex = 3;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Items.AddRange(new object[] {
            "Normal (2D)",
            "Especial (3D)"});
            this.cbFormato.Location = new System.Drawing.Point(89, 199);
            this.cbFormato.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(131, 26);
            this.cbFormato.TabIndex = 2;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Items.AddRange(new object[] {
            "APT",
            "14 PG",
            "18 +"});
            this.cbClasificacion.Location = new System.Drawing.Point(120, 156);
            this.cbClasificacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(131, 26);
            this.cbClasificacion.TabIndex = 2;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Ciencia Ficción",
            "Comedia",
            "Documental",
            "Romantico",
            "Terror"});
            this.cbGenero.Location = new System.Drawing.Point(82, 112);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(131, 26);
            this.cbGenero.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(66, 26);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(194, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(12, 202);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(71, 18);
            this.lblFormato.TabIndex = 0;
            this.lblFormato.Text = "Formato:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(12, 73);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(75, 18);
            this.lblDuracion.TabIndex = 0;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(12, 159);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(102, 18);
            this.lblClasificacion.TabIndex = 0;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(12, 115);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Genero:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(134, 35);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(15, 35);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 44);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbControles
            // 
            this.gbControles.BackColor = System.Drawing.Color.Transparent;
            this.gbControles.Controls.Add(this.btnCancelar);
            this.gbControles.Controls.Add(this.btnGuardar);
            this.gbControles.Controls.Add(this.btnNuevo);
            this.gbControles.Controls.Add(this.btnSalir);
            this.gbControles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControles.ForeColor = System.Drawing.SystemColors.Window;
            this.gbControles.Location = new System.Drawing.Point(20, 354);
            this.gbControles.Margin = new System.Windows.Forms.Padding(2);
            this.gbControles.Name = "gbControles";
            this.gbControles.Padding = new System.Windows.Forms.Padding(2);
            this.gbControles.Size = new System.Drawing.Size(277, 93);
            this.gbControles.TabIndex = 13;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(134, 35);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 44);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(15, 35);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 44);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(650, 464);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.gbPortada);
            this.Controls.Add(this.gbDatos);
            this.MaximizeBox = false;
            this.Name = "AgregarPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Peliculas";
            this.Load += new System.EventHandler(this.AgregarPeliculas_Load);
            this.gbPortada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbPortada;
        internal System.Windows.Forms.Button btnExaminar;
        internal System.Windows.Forms.PictureBox pbPortada;
        internal System.Windows.Forms.GroupBox gbDatos;
        internal System.Windows.Forms.MaskedTextBox txtDuracion;
        internal System.Windows.Forms.ComboBox cbFormato;
        internal System.Windows.Forms.ComboBox cbClasificacion;
        internal System.Windows.Forms.ComboBox cbGenero;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.Label lblFormato;
        internal System.Windows.Forms.Label lblDuracion;
        internal System.Windows.Forms.Label lblClasificacion;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.Label lblGenero;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.GroupBox gbControles;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
    }
}