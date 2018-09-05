namespace Cine.Capa_de_Presentación
{
    partial class AsignarCartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCartelera));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAsignarCartelera = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbPortada = new System.Windows.Forms.GroupBox();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.gbEliminarCartelera = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCodigoCartelera = new System.Windows.Forms.Label();
            this.dgvListaCartelera = new System.Windows.Forms.DataGridView();
            this.gbAsignarCartelera.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbPortada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.gbEliminarCartelera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAsignarCartelera
            // 
            this.gbAsignarCartelera.BackColor = System.Drawing.Color.Transparent;
            this.gbAsignarCartelera.Controls.Add(this.btnSalir);
            this.gbAsignarCartelera.Controls.Add(this.gbDatos);
            this.gbAsignarCartelera.Controls.Add(this.btnCancelar);
            this.gbAsignarCartelera.Controls.Add(this.btnGuardar);
            this.gbAsignarCartelera.Controls.Add(this.btnNuevo);
            this.gbAsignarCartelera.Controls.Add(this.gbPortada);
            this.gbAsignarCartelera.ForeColor = System.Drawing.SystemColors.Window;
            this.gbAsignarCartelera.Location = new System.Drawing.Point(13, 75);
            this.gbAsignarCartelera.Margin = new System.Windows.Forms.Padding(4);
            this.gbAsignarCartelera.Name = "gbAsignarCartelera";
            this.gbAsignarCartelera.Padding = new System.Windows.Forms.Padding(4);
            this.gbAsignarCartelera.Size = new System.Drawing.Size(541, 332);
            this.gbAsignarCartelera.TabIndex = 1;
            this.gbAsignarCartelera.TabStop = false;
            this.gbAsignarCartelera.Text = "Asignar una Cartelera";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(359, 279);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtHoraFin);
            this.gbDatos.Controls.Add(this.cbSala);
            this.gbDatos.Controls.Add(this.cbPelicula);
            this.gbDatos.Controls.Add(this.txtMinuto);
            this.gbDatos.Controls.Add(this.txtHora);
            this.gbDatos.Controls.Add(this.txtDuracion);
            this.gbDatos.Controls.Add(this.lblDuracion);
            this.gbDatos.Controls.Add(this.btnValidar);
            this.gbDatos.Controls.Add(this.lblHoraFin);
            this.gbDatos.Controls.Add(this.lblHoraInicio);
            this.gbDatos.Controls.Add(this.lblSala);
            this.gbDatos.Controls.Add(this.lblPelicula);
            this.gbDatos.Controls.Add(this.Label6);
            this.gbDatos.Location = new System.Drawing.Point(10, 19);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatos.Size = new System.Drawing.Size(318, 252);
            this.gbDatos.TabIndex = 15;
            this.gbDatos.TabStop = false;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(87, 218);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(77, 26);
            this.txtHoraFin.TabIndex = 19;
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(59, 30);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(155, 26);
            this.cbSala.TabIndex = 18;
            // 
            // cbPelicula
            // 
            this.cbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(82, 77);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(227, 26);
            this.cbPelicula.TabIndex = 17;
            this.cbPelicula.SelectedIndexChanged += new System.EventHandler(this.cbPelicula_SelectedIndexChanged);
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(136, 172);
            this.txtMinuto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(28, 26);
            this.txtMinuto.TabIndex = 13;
            this.txtMinuto.TextChanged += new System.EventHandler(this.txtMinuto_TextChanged);
            this.txtMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuto_KeyPress);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(100, 172);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(28, 26);
            this.txtHora.TabIndex = 13;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHora_KeyPress);
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(91, 123);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(70, 26);
            this.txtDuracion.TabIndex = 11;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(8, 126);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(75, 18);
            this.lblDuracion.TabIndex = 10;
            this.lblDuracion.Text = "Duración:";
            // 
            // btnValidar
            // 
            this.btnValidar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnValidar.Location = new System.Drawing.Point(194, 123);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(115, 116);
            this.btnValidar.TabIndex = 9;
            this.btnValidar.Text = "Validar Hora";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(8, 221);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(72, 18);
            this.lblHoraFin.TabIndex = 6;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(8, 175);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(86, 18);
            this.lblHoraInicio.TabIndex = 5;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.Location = new System.Drawing.Point(8, 33);
            this.lblSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(44, 18);
            this.lblSala.TabIndex = 3;
            this.lblSala.Text = "Sala:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.Location = new System.Drawing.Point(8, 80);
            this.lblPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(66, 18);
            this.lblPelicula.TabIndex = 2;
            this.lblPelicula.Text = "Película:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(127, 176);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(12, 18);
            this.Label6.TabIndex = 14;
            this.Label6.Text = ":";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(179, 279);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(10, 279);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(10, 279);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 41);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbPortada
            // 
            this.gbPortada.Controls.Add(this.pbPortada);
            this.gbPortada.ForeColor = System.Drawing.SystemColors.Window;
            this.gbPortada.Location = new System.Drawing.Point(336, 19);
            this.gbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.gbPortada.Name = "gbPortada";
            this.gbPortada.Padding = new System.Windows.Forms.Padding(4);
            this.gbPortada.Size = new System.Drawing.Size(197, 252);
            this.gbPortada.TabIndex = 0;
            this.gbPortada.TabStop = false;
            this.gbPortada.Text = "Portada";
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(10, 21);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(173, 218);
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // gbEliminarCartelera
            // 
            this.gbEliminarCartelera.BackColor = System.Drawing.Color.Transparent;
            this.gbEliminarCartelera.Controls.Add(this.btnEliminar);
            this.gbEliminarCartelera.Controls.Add(this.txtCod);
            this.gbEliminarCartelera.Controls.Add(this.lblCodigoCartelera);
            this.gbEliminarCartelera.ForeColor = System.Drawing.SystemColors.Window;
            this.gbEliminarCartelera.Location = new System.Drawing.Point(13, 414);
            this.gbEliminarCartelera.Name = "gbEliminarCartelera";
            this.gbEliminarCartelera.Size = new System.Drawing.Size(541, 66);
            this.gbEliminarCartelera.TabIndex = 3;
            this.gbEliminarCartelera.TabStop = false;
            this.gbEliminarCartelera.Text = "Eliminar Cartelera";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(204, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 41);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Cartelera";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(146, 28);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(46, 26);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // lblCodigoCartelera
            // 
            this.lblCodigoCartelera.AutoSize = true;
            this.lblCodigoCartelera.Location = new System.Drawing.Point(7, 31);
            this.lblCodigoCartelera.Name = "lblCodigoCartelera";
            this.lblCodigoCartelera.Size = new System.Drawing.Size(133, 18);
            this.lblCodigoCartelera.TabIndex = 0;
            this.lblCodigoCartelera.Text = "Código Cartelera:";
            // 
            // dgvListaCartelera
            // 
            this.dgvListaCartelera.AllowUserToAddRows = false;
            this.dgvListaCartelera.AllowUserToDeleteRows = false;
            this.dgvListaCartelera.AllowUserToResizeColumns = false;
            this.dgvListaCartelera.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaCartelera.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCartelera.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCartelera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListaCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCartelera.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCartelera.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListaCartelera.Location = new System.Drawing.Point(561, 85);
            this.dgvListaCartelera.MultiSelect = false;
            this.dgvListaCartelera.Name = "dgvListaCartelera";
            this.dgvListaCartelera.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaCartelera.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListaCartelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCartelera.ShowEditingIcon = false;
            this.dgvListaCartelera.Size = new System.Drawing.Size(509, 395);
            this.dgvListaCartelera.TabIndex = 82;
            this.dgvListaCartelera.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvListaCartelera_ColumnAdded);
            // 
            // AsignarCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 493);
            this.Controls.Add(this.gbEliminarCartelera);
            this.Controls.Add(this.dgvListaCartelera);
            this.Controls.Add(this.gbAsignarCartelera);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AsignarCartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Cartelera";
            this.Load += new System.EventHandler(this.AsignarCartelera_Load);
            this.gbAsignarCartelera.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbPortada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.gbEliminarCartelera.ResumeLayout(false);
            this.gbEliminarCartelera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCartelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbAsignarCartelera;
        internal System.Windows.Forms.GroupBox gbDatos;
        internal System.Windows.Forms.TextBox txtMinuto;
        internal System.Windows.Forms.TextBox txtHora;
        internal System.Windows.Forms.TextBox txtDuracion;
        internal System.Windows.Forms.Label lblDuracion;
        internal System.Windows.Forms.Button btnValidar;
        internal System.Windows.Forms.Label lblHoraFin;
        internal System.Windows.Forms.Label lblHoraInicio;
        internal System.Windows.Forms.Label lblSala;
        internal System.Windows.Forms.Label lblPelicula;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.GroupBox gbPortada;
        internal System.Windows.Forms.PictureBox pbPortada;
        internal System.Windows.Forms.GroupBox gbEliminarCartelera;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.TextBox txtCod;
        internal System.Windows.Forms.Label lblCodigoCartelera;
        internal System.Windows.Forms.ComboBox cbSala;
        internal System.Windows.Forms.ComboBox cbPelicula;
        internal System.Windows.Forms.TextBox txtHoraFin;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.DataGridView dgvListaCartelera;
    }
}