namespace Cine
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TabSeleccion = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcMenuCine = new MaterialSkin.Controls.MaterialTabControl();
            this.tpInicioCine = new System.Windows.Forms.TabPage();
            this.pbCinemaLetreros = new System.Windows.Forms.PictureBox();
            this.pbCinemas = new System.Windows.Forms.PictureBox();
            this.pbCinemaCompany = new System.Windows.Forms.PictureBox();
            this.pbRetroCinemas = new System.Windows.Forms.PictureBox();
            this.pbCartelesCinemas = new System.Windows.Forms.PictureBox();
            this.tpContactanosCine = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pbComentarios = new System.Windows.Forms.PictureBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.tpCienteInvitadoCine = new System.Windows.Forms.TabPage();
            this.pbJurassicWorld = new System.Windows.Forms.PictureBox();
            this.pbIncreibles2 = new System.Windows.Forms.PictureBox();
            this.pbHombreAlAgua = new System.Windows.Forms.PictureBox();
            this.pbDeadPool2 = new System.Windows.Forms.PictureBox();
            this.tpLoginCine = new System.Windows.Forms.TabPage();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.chkCliente = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSalirCine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicioCine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPasswordCine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuarioCine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pbAyuda = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbVer = new System.Windows.Forms.PictureBox();
            this.pbFiesta = new System.Windows.Forms.PictureBox();
            this.pbNada = new System.Windows.Forms.PictureBox();
            this.pbInc2 = new System.Windows.Forms.PictureBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.tcMenuCine.SuspendLayout();
            this.tpInicioCine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemaLetreros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemaCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetroCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartelesCinemas)).BeginInit();
            this.tpContactanosCine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.tpCienteInvitadoCine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJurassicWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncreibles2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHombreAlAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeadPool2)).BeginInit();
            this.tpLoginCine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSeleccion
            // 
            this.TabSeleccion.BaseTabControl = this.tcMenuCine;
            this.TabSeleccion.Depth = 0;
            this.TabSeleccion.Location = new System.Drawing.Point(-2, 64);
            this.TabSeleccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSeleccion.Name = "TabSeleccion";
            this.TabSeleccion.Size = new System.Drawing.Size(978, 34);
            this.TabSeleccion.TabIndex = 28;
            this.TabSeleccion.Text = "Seleccionar";
            // 
            // tcMenuCine
            // 
            this.tcMenuCine.Controls.Add(this.tpInicioCine);
            this.tcMenuCine.Controls.Add(this.tpContactanosCine);
            this.tcMenuCine.Controls.Add(this.tpCienteInvitadoCine);
            this.tcMenuCine.Controls.Add(this.tpLoginCine);
            this.tcMenuCine.Depth = 0;
            this.tcMenuCine.Location = new System.Drawing.Point(12, 104);
            this.tcMenuCine.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMenuCine.Name = "tcMenuCine";
            this.tcMenuCine.SelectedIndex = 0;
            this.tcMenuCine.Size = new System.Drawing.Size(951, 474);
            this.tcMenuCine.TabIndex = 29;
            // 
            // tpInicioCine
            // 
            this.tpInicioCine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpInicioCine.Controls.Add(this.pbCinemaLetreros);
            this.tpInicioCine.Controls.Add(this.pbCinemas);
            this.tpInicioCine.Controls.Add(this.pbCinemaCompany);
            this.tpInicioCine.Controls.Add(this.pbRetroCinemas);
            this.tpInicioCine.Controls.Add(this.pbCartelesCinemas);
            this.tpInicioCine.ForeColor = System.Drawing.SystemColors.Window;
            this.tpInicioCine.Location = new System.Drawing.Point(4, 27);
            this.tpInicioCine.Name = "tpInicioCine";
            this.tpInicioCine.Padding = new System.Windows.Forms.Padding(3);
            this.tpInicioCine.Size = new System.Drawing.Size(943, 443);
            this.tpInicioCine.TabIndex = 0;
            this.tpInicioCine.Text = "Inicio";
            // 
            // pbCinemaLetreros
            // 
            this.pbCinemaLetreros.Image = ((System.Drawing.Image)(resources.GetObject("pbCinemaLetreros.Image")));
            this.pbCinemaLetreros.Location = new System.Drawing.Point(211, 47);
            this.pbCinemaLetreros.Name = "pbCinemaLetreros";
            this.pbCinemaLetreros.Size = new System.Drawing.Size(168, 168);
            this.pbCinemaLetreros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCinemaLetreros.TabIndex = 51;
            this.pbCinemaLetreros.TabStop = false;
            // 
            // pbCinemas
            // 
            this.pbCinemas.Image = ((System.Drawing.Image)(resources.GetObject("pbCinemas.Image")));
            this.pbCinemas.Location = new System.Drawing.Point(38, 221);
            this.pbCinemas.Name = "pbCinemas";
            this.pbCinemas.Size = new System.Drawing.Size(167, 170);
            this.pbCinemas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCinemas.TabIndex = 50;
            this.pbCinemas.TabStop = false;
            // 
            // pbCinemaCompany
            // 
            this.pbCinemaCompany.Image = ((System.Drawing.Image)(resources.GetObject("pbCinemaCompany.Image")));
            this.pbCinemaCompany.Location = new System.Drawing.Point(211, 221);
            this.pbCinemaCompany.Name = "pbCinemaCompany";
            this.pbCinemaCompany.Size = new System.Drawing.Size(168, 170);
            this.pbCinemaCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCinemaCompany.TabIndex = 49;
            this.pbCinemaCompany.TabStop = false;
            // 
            // pbRetroCinemas
            // 
            this.pbRetroCinemas.Image = ((System.Drawing.Image)(resources.GetObject("pbRetroCinemas.Image")));
            this.pbRetroCinemas.Location = new System.Drawing.Point(38, 47);
            this.pbRetroCinemas.Name = "pbRetroCinemas";
            this.pbRetroCinemas.Size = new System.Drawing.Size(167, 168);
            this.pbRetroCinemas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetroCinemas.TabIndex = 48;
            this.pbRetroCinemas.TabStop = false;
            // 
            // pbCartelesCinemas
            // 
            this.pbCartelesCinemas.Image = ((System.Drawing.Image)(resources.GetObject("pbCartelesCinemas.Image")));
            this.pbCartelesCinemas.Location = new System.Drawing.Point(432, 26);
            this.pbCartelesCinemas.Name = "pbCartelesCinemas";
            this.pbCartelesCinemas.Size = new System.Drawing.Size(473, 391);
            this.pbCartelesCinemas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartelesCinemas.TabIndex = 47;
            this.pbCartelesCinemas.TabStop = false;
            // 
            // tpContactanosCine
            // 
            this.tpContactanosCine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpContactanosCine.Controls.Add(this.pictureBox5);
            this.tpContactanosCine.Controls.Add(this.pictureBox4);
            this.tpContactanosCine.Controls.Add(this.lblDatos);
            this.tpContactanosCine.Controls.Add(this.pbComentarios);
            this.tpContactanosCine.Controls.Add(this.pbMapa);
            this.tpContactanosCine.Location = new System.Drawing.Point(4, 27);
            this.tpContactanosCine.Name = "tpContactanosCine";
            this.tpContactanosCine.Padding = new System.Windows.Forms.Padding(3);
            this.tpContactanosCine.Size = new System.Drawing.Size(943, 443);
            this.tpContactanosCine.TabIndex = 1;
            this.tpContactanosCine.Text = "Contáctanos";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(709, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(525, 335);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(412, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDatos.Location = new System.Drawing.Point(19, 332);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(478, 108);
            this.lblDatos.TabIndex = 47;
            this.lblDatos.Text = "Ubicado en: Plaza Fiesta Arboledas\r\n\r\nDirección: Av. Arboledas 2500 Local 15, Rin" +
    "conada de la Arboleda, \r\n44570 Guadalajara, Jal.\r\n\r\nTeléfono: 01 800 120 0228";
            // 
            // pbComentarios
            // 
            this.pbComentarios.Image = ((System.Drawing.Image)(resources.GetObject("pbComentarios.Image")));
            this.pbComentarios.Location = new System.Drawing.Point(599, 100);
            this.pbComentarios.Name = "pbComentarios";
            this.pbComentarios.Size = new System.Drawing.Size(319, 217);
            this.pbComentarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComentarios.TabIndex = 46;
            this.pbComentarios.TabStop = false;
            // 
            // pbMapa
            // 
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(22, 17);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(553, 300);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 45;
            this.pbMapa.TabStop = false;
            // 
            // tpCienteInvitadoCine
            // 
            this.tpCienteInvitadoCine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpCienteInvitadoCine.Controls.Add(this.pbCam);
            this.tpCienteInvitadoCine.Controls.Add(this.pbInc2);
            this.tpCienteInvitadoCine.Controls.Add(this.pbNada);
            this.tpCienteInvitadoCine.Controls.Add(this.pbFiesta);
            this.tpCienteInvitadoCine.Controls.Add(this.pbVer);
            this.tpCienteInvitadoCine.Controls.Add(this.pbJurassicWorld);
            this.tpCienteInvitadoCine.Controls.Add(this.pbIncreibles2);
            this.tpCienteInvitadoCine.Controls.Add(this.pbHombreAlAgua);
            this.tpCienteInvitadoCine.Controls.Add(this.pbDeadPool2);
            this.tpCienteInvitadoCine.Location = new System.Drawing.Point(4, 27);
            this.tpCienteInvitadoCine.Name = "tpCienteInvitadoCine";
            this.tpCienteInvitadoCine.Padding = new System.Windows.Forms.Padding(3);
            this.tpCienteInvitadoCine.Size = new System.Drawing.Size(943, 443);
            this.tpCienteInvitadoCine.TabIndex = 2;
            this.tpCienteInvitadoCine.Text = "Cliente Invitado";
            // 
            // pbJurassicWorld
            // 
            this.pbJurassicWorld.Image = ((System.Drawing.Image)(resources.GetObject("pbJurassicWorld.Image")));
            this.pbJurassicWorld.Location = new System.Drawing.Point(33, 232);
            this.pbJurassicWorld.Name = "pbJurassicWorld";
            this.pbJurassicWorld.Size = new System.Drawing.Size(139, 204);
            this.pbJurassicWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbJurassicWorld.TabIndex = 87;
            this.pbJurassicWorld.TabStop = false;
            // 
            // pbIncreibles2
            // 
            this.pbIncreibles2.Image = ((System.Drawing.Image)(resources.GetObject("pbIncreibles2.Image")));
            this.pbIncreibles2.Location = new System.Drawing.Point(781, 232);
            this.pbIncreibles2.Name = "pbIncreibles2";
            this.pbIncreibles2.Size = new System.Drawing.Size(139, 203);
            this.pbIncreibles2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIncreibles2.TabIndex = 86;
            this.pbIncreibles2.TabStop = false;
            // 
            // pbHombreAlAgua
            // 
            this.pbHombreAlAgua.Image = ((System.Drawing.Image)(resources.GetObject("pbHombreAlAgua.Image")));
            this.pbHombreAlAgua.Location = new System.Drawing.Point(781, 15);
            this.pbHombreAlAgua.Name = "pbHombreAlAgua";
            this.pbHombreAlAgua.Size = new System.Drawing.Size(139, 203);
            this.pbHombreAlAgua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHombreAlAgua.TabIndex = 85;
            this.pbHombreAlAgua.TabStop = false;
            // 
            // pbDeadPool2
            // 
            this.pbDeadPool2.Image = ((System.Drawing.Image)(resources.GetObject("pbDeadPool2.Image")));
            this.pbDeadPool2.Location = new System.Drawing.Point(33, 15);
            this.pbDeadPool2.Name = "pbDeadPool2";
            this.pbDeadPool2.Size = new System.Drawing.Size(139, 204);
            this.pbDeadPool2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDeadPool2.TabIndex = 84;
            this.pbDeadPool2.TabStop = false;
            // 
            // tpLoginCine
            // 
            this.tpLoginCine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpLoginCine.Controls.Add(this.lblPassword);
            this.tpLoginCine.Controls.Add(this.lblUsuario);
            this.tpLoginCine.Controls.Add(this.chkCliente);
            this.tpLoginCine.Controls.Add(this.btnSalirCine);
            this.tpLoginCine.Controls.Add(this.btnInicioCine);
            this.tpLoginCine.Controls.Add(this.txtPasswordCine);
            this.tpLoginCine.Controls.Add(this.txtUsuarioCine);
            this.tpLoginCine.Controls.Add(this.pbAyuda);
            this.tpLoginCine.Controls.Add(this.pictureBox3);
            this.tpLoginCine.Location = new System.Drawing.Point(4, 27);
            this.tpLoginCine.Name = "tpLoginCine";
            this.tpLoginCine.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginCine.Size = new System.Drawing.Size(943, 443);
            this.tpLoginCine.TabIndex = 3;
            this.tpLoginCine.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(463, 188);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 19);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(463, 148);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 60;
            this.lblUsuario.Text = "Usuario:";
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Depth = 0;
            this.chkCliente.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCliente.Location = new System.Drawing.Point(460, 102);
            this.chkCliente.Margin = new System.Windows.Forms.Padding(0);
            this.chkCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Ripple = true;
            this.chkCliente.Size = new System.Drawing.Size(141, 30);
            this.chkCliente.TabIndex = 59;
            this.chkCliente.Text = "Eres Cliente Socio";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalirCine
            // 
            this.btnSalirCine.AutoSize = true;
            this.btnSalirCine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCine.Depth = 0;
            this.btnSalirCine.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalirCine.Icon = null;
            this.btnSalirCine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirCine.Location = new System.Drawing.Point(664, 236);
            this.btnSalirCine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCine.Name = "btnSalirCine";
            this.btnSalirCine.Primary = true;
            this.btnSalirCine.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCine.TabIndex = 56;
            this.btnSalirCine.Text = "Salir";
            this.btnSalirCine.UseVisualStyleBackColor = true;
            this.btnSalirCine.Click += new System.EventHandler(this.btnSalirCine_Click);
            // 
            // btnInicioCine
            // 
            this.btnInicioCine.AutoSize = true;
            this.btnInicioCine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicioCine.BackColor = System.Drawing.SystemColors.Window;
            this.btnInicioCine.Depth = 0;
            this.btnInicioCine.ForeColor = System.Drawing.Color.Transparent;
            this.btnInicioCine.Icon = null;
            this.btnInicioCine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicioCine.Location = new System.Drawing.Point(482, 236);
            this.btnInicioCine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicioCine.Name = "btnInicioCine";
            this.btnInicioCine.Primary = true;
            this.btnInicioCine.Size = new System.Drawing.Size(167, 36);
            this.btnInicioCine.TabIndex = 55;
            this.btnInicioCine.Text = "Ingresar al sistema";
            this.btnInicioCine.UseVisualStyleBackColor = true;
            this.btnInicioCine.Click += new System.EventHandler(this.btnInicioCine_Click);
            // 
            // txtPasswordCine
            // 
            this.txtPasswordCine.Depth = 0;
            this.txtPasswordCine.Hint = "";
            this.txtPasswordCine.Location = new System.Drawing.Point(548, 184);
            this.txtPasswordCine.MaxLength = 32767;
            this.txtPasswordCine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswordCine.Name = "txtPasswordCine";
            this.txtPasswordCine.PasswordChar = '*';
            this.txtPasswordCine.SelectedText = "";
            this.txtPasswordCine.SelectionLength = 0;
            this.txtPasswordCine.SelectionStart = 0;
            this.txtPasswordCine.Size = new System.Drawing.Size(191, 23);
            this.txtPasswordCine.TabIndex = 54;
            this.txtPasswordCine.TabStop = false;
            this.txtPasswordCine.UseSystemPasswordChar = false;
            // 
            // txtUsuarioCine
            // 
            this.txtUsuarioCine.Depth = 0;
            this.txtUsuarioCine.Hint = "";
            this.txtUsuarioCine.Location = new System.Drawing.Point(534, 144);
            this.txtUsuarioCine.MaxLength = 32767;
            this.txtUsuarioCine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioCine.Name = "txtUsuarioCine";
            this.txtUsuarioCine.PasswordChar = '\0';
            this.txtUsuarioCine.SelectedText = "";
            this.txtUsuarioCine.SelectionLength = 0;
            this.txtUsuarioCine.SelectionStart = 0;
            this.txtUsuarioCine.Size = new System.Drawing.Size(205, 23);
            this.txtUsuarioCine.TabIndex = 53;
            this.txtUsuarioCine.TabStop = false;
            this.txtUsuarioCine.UseSystemPasswordChar = false;
            // 
            // pbAyuda
            // 
            this.pbAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pbAyuda.Image")));
            this.pbAyuda.Location = new System.Drawing.Point(895, 11);
            this.pbAyuda.Name = "pbAyuda";
            this.pbAyuda.Size = new System.Drawing.Size(32, 32);
            this.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAyuda.TabIndex = 52;
            this.pbAyuda.TabStop = false;
            this.pbAyuda.Click += new System.EventHandler(this.pbAyuda_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(193, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 230);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // pbVer
            // 
            this.pbVer.Image = ((System.Drawing.Image)(resources.GetObject("pbVer.Image")));
            this.pbVer.Location = new System.Drawing.Point(400, 121);
            this.pbVer.Name = "pbVer";
            this.pbVer.Size = new System.Drawing.Size(162, 201);
            this.pbVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVer.TabIndex = 88;
            this.pbVer.TabStop = false;
            this.pbVer.Click += new System.EventHandler(this.pbVer_Click);
            // 
            // pbFiesta
            // 
            this.pbFiesta.Image = ((System.Drawing.Image)(resources.GetObject("pbFiesta.Image")));
            this.pbFiesta.Location = new System.Drawing.Point(201, 15);
            this.pbFiesta.Name = "pbFiesta";
            this.pbFiesta.Size = new System.Drawing.Size(139, 203);
            this.pbFiesta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFiesta.TabIndex = 89;
            this.pbFiesta.TabStop = false;
            // 
            // pbNada
            // 
            this.pbNada.Image = ((System.Drawing.Image)(resources.GetObject("pbNada.Image")));
            this.pbNada.Location = new System.Drawing.Point(201, 232);
            this.pbNada.Name = "pbNada";
            this.pbNada.Size = new System.Drawing.Size(139, 203);
            this.pbNada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNada.TabIndex = 90;
            this.pbNada.TabStop = false;
            // 
            // pbInc2
            // 
            this.pbInc2.Image = ((System.Drawing.Image)(resources.GetObject("pbInc2.Image")));
            this.pbInc2.Location = new System.Drawing.Point(620, 15);
            this.pbInc2.Name = "pbInc2";
            this.pbInc2.Size = new System.Drawing.Size(139, 203);
            this.pbInc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInc2.TabIndex = 91;
            this.pbInc2.TabStop = false;
            // 
            // pbCam
            // 
            this.pbCam.Image = ((System.Drawing.Image)(resources.GetObject("pbCam.Image")));
            this.pbCam.Location = new System.Drawing.Point(620, 232);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(139, 203);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCam.TabIndex = 92;
            this.pbCam.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(975, 590);
            this.Controls.Add(this.tcMenuCine);
            this.Controls.Add(this.TabSeleccion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LA PERLA DE OCCIDENTE";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tcMenuCine.ResumeLayout(false);
            this.tpInicioCine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemaLetreros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinemaCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetroCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartelesCinemas)).EndInit();
            this.tpContactanosCine.ResumeLayout(false);
            this.tpContactanosCine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.tpCienteInvitadoCine.ResumeLayout(false);
            this.tpCienteInvitadoCine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJurassicWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncreibles2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHombreAlAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeadPool2)).EndInit();
            this.tpLoginCine.ResumeLayout(false);
            this.tpLoginCine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector TabSeleccion;
        private MaterialSkin.Controls.MaterialTabControl tcMenuCine;
        private System.Windows.Forms.TabPage tpInicioCine;
        private System.Windows.Forms.TabPage tpContactanosCine;
        private System.Windows.Forms.TabPage tpCienteInvitadoCine;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.PictureBox pbComentarios;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.PictureBox pbCinemaLetreros;
        private System.Windows.Forms.PictureBox pbCinemas;
        private System.Windows.Forms.PictureBox pbCinemaCompany;
        private System.Windows.Forms.PictureBox pbRetroCinemas;
        private System.Windows.Forms.PictureBox pbCartelesCinemas;
        private System.Windows.Forms.TabPage tpLoginCine;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialCheckBox chkCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCine;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicioCine;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswordCine;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioCine;
        private System.Windows.Forms.PictureBox pbAyuda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbJurassicWorld;
        private System.Windows.Forms.PictureBox pbIncreibles2;
        private System.Windows.Forms.PictureBox pbHombreAlAgua;
        private System.Windows.Forms.PictureBox pbDeadPool2;
        public System.Windows.Forms.DataGridView dgvListaCartelera;
        private System.Windows.Forms.PictureBox pbVer;
        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.PictureBox pbInc2;
        private System.Windows.Forms.PictureBox pbNada;
        private System.Windows.Forms.PictureBox pbFiesta;
    }
}

