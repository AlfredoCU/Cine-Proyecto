namespace Cine.Capa_de_Presentación
{
    partial class MantenimientoPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPeliculas));
            this.gbListaPeliculas = new System.Windows.Forms.GroupBox();
            this.lbListaPeliculas = new System.Windows.Forms.ListBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPortada = new System.Windows.Forms.Label();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbListaPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.gbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaPeliculas
            // 
            this.gbListaPeliculas.Controls.Add(this.lbListaPeliculas);
            this.gbListaPeliculas.ForeColor = System.Drawing.SystemColors.Window;
            this.gbListaPeliculas.Location = new System.Drawing.Point(22, 72);
            this.gbListaPeliculas.Name = "gbListaPeliculas";
            this.gbListaPeliculas.Size = new System.Drawing.Size(233, 385);
            this.gbListaPeliculas.TabIndex = 1;
            this.gbListaPeliculas.TabStop = false;
            this.gbListaPeliculas.Text = "Lista de Peliculas";
            // 
            // lbListaPeliculas
            // 
            this.lbListaPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListaPeliculas.ForeColor = System.Drawing.SystemColors.Window;
            this.lbListaPeliculas.FormattingEnabled = true;
            this.lbListaPeliculas.ItemHeight = 18;
            this.lbListaPeliculas.Location = new System.Drawing.Point(16, 34);
            this.lbListaPeliculas.Name = "lbListaPeliculas";
            this.lbListaPeliculas.Size = new System.Drawing.Size(200, 328);
            this.lbListaPeliculas.TabIndex = 0;
            this.lbListaPeliculas.SelectedIndexChanged += new System.EventHandler(this.lbListaPeliculas_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(63, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(152, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(90, 77);
            this.txtDuracion.Mask = "0:00";
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(44, 26);
            this.txtDuracion.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(9, 80);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(75, 18);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración:";
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
            this.cbGenero.Location = new System.Drawing.Point(79, 121);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(151, 26);
            this.cbGenero.TabIndex = 5;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Items.AddRange(new object[] {
            "APT",
            "14 PG",
            "18 +"});
            this.cbClasificacion.Location = new System.Drawing.Point(117, 167);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(113, 26);
            this.cbClasificacion.TabIndex = 5;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Items.AddRange(new object[] {
            "Normal (2D)",
            "Especial (3D) "});
            this.cbFormato.Location = new System.Drawing.Point(86, 212);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(129, 26);
            this.cbFormato.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(9, 124);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClasificacion.Location = new System.Drawing.Point(9, 170);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(102, 18);
            this.lblClasificacion.TabIndex = 6;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFormato.Location = new System.Drawing.Point(9, 215);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(71, 18);
            this.lblFormato.TabIndex = 6;
            this.lblFormato.Text = "Formato:";
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(255, 31);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(237, 285);
            this.pbPortada.TabIndex = 7;
            this.pbPortada.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(18, 326);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 36);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(128, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(18, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(128, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(90, 247);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 47);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPortada.Location = new System.Drawing.Point(9, 261);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(68, 18);
            this.lblPortada.TabIndex = 11;
            this.lblPortada.Text = "Portada:";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.btnSalir);
            this.gbMantenimiento.Controls.Add(this.lblPortada);
            this.gbMantenimiento.Controls.Add(this.btnBuscar);
            this.gbMantenimiento.Controls.Add(this.btnCancelar);
            this.gbMantenimiento.Controls.Add(this.btnGuardar);
            this.gbMantenimiento.Controls.Add(this.btnEliminar);
            this.gbMantenimiento.Controls.Add(this.btnEditar);
            this.gbMantenimiento.Controls.Add(this.pbPortada);
            this.gbMantenimiento.Controls.Add(this.lblFormato);
            this.gbMantenimiento.Controls.Add(this.lblClasificacion);
            this.gbMantenimiento.Controls.Add(this.lblGenero);
            this.gbMantenimiento.Controls.Add(this.cbFormato);
            this.gbMantenimiento.Controls.Add(this.cbClasificacion);
            this.gbMantenimiento.Controls.Add(this.cbGenero);
            this.gbMantenimiento.Controls.Add(this.lblDuracion);
            this.gbMantenimiento.Controls.Add(this.lblTitulo);
            this.gbMantenimiento.Controls.Add(this.txtDuracion);
            this.gbMantenimiento.Controls.Add(this.txtTitulo);
            this.gbMantenimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.gbMantenimiento.Location = new System.Drawing.Point(276, 72);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(518, 385);
            this.gbMantenimiento.TabIndex = 3;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Datos de la Pelicula";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(367, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MantenimientoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 477);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbListaPeliculas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MantenimientoPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Películas";
            this.Load += new System.EventHandler(this.MantenimientoPeliculas_Load);
            this.gbListaPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.gbMantenimiento.ResumeLayout(false);
            this.gbMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbListaPeliculas;
        internal System.Windows.Forms.ListBox lbListaPeliculas;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.MaskedTextBox txtDuracion;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.Label lblDuracion;
        internal System.Windows.Forms.ComboBox cbGenero;
        internal System.Windows.Forms.ComboBox cbClasificacion;
        internal System.Windows.Forms.ComboBox cbFormato;
        internal System.Windows.Forms.Label lblGenero;
        internal System.Windows.Forms.Label lblClasificacion;
        internal System.Windows.Forms.Label lblFormato;
        internal System.Windows.Forms.PictureBox pbPortada;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Label lblPortada;
        internal System.Windows.Forms.GroupBox gbMantenimiento;
        internal System.Windows.Forms.Button btnSalir;
    }
}