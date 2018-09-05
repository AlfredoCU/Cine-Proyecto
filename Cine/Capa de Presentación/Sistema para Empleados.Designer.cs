namespace Cine.Pantallas
{
    partial class SistemaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaEmpleados));
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.mtsMenuPrincipal = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tpEmpleados = new System.Windows.Forms.TabPage();
            this.btnEmpleado = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.pbCineE = new System.Windows.Forms.PictureBox();
            this.mtsEmpleados = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.btnClientes = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpControlSalas = new System.Windows.Forms.TabPage();
            this.pbSalas = new System.Windows.Forms.PictureBox();
            this.btnVerSala2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerSala1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAsignarCartelera = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbCineCS = new System.Windows.Forms.PictureBox();
            this.mtsControlSalas = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpPeliculas = new System.Windows.Forms.TabPage();
            this.pbPelicula = new System.Windows.Forms.PictureBox();
            this.btnVerTodas = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMantenimiento = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarPelicula = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbCineP = new System.Windows.Forms.PictureBox();
            this.mtsPeliculas = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpVentas = new System.Windows.Forms.TabPage();
            this.btnReporteVentas = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbVenta = new System.Windows.Forms.PictureBox();
            this.btnVenderBoletos = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbCineV = new System.Windows.Forms.PictureBox();
            this.mtsVentas = new MaterialSkin.Controls.MaterialTabSelector();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.tcMenuPrincipal.SuspendLayout();
            this.tpEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineE)).BeginInit();
            this.tpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpControlSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineCS)).BeginInit();
            this.tpPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineP)).BeginInit();
            this.tpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmpleado.Location = new System.Drawing.Point(593, 28);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(86, 19);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtsMenuPrincipal
            // 
            this.mtsMenuPrincipal.BaseTabControl = this.tcMenuPrincipal;
            this.mtsMenuPrincipal.Depth = 0;
            this.mtsMenuPrincipal.Location = new System.Drawing.Point(-5, 63);
            this.mtsMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtsMenuPrincipal.Name = "mtsMenuPrincipal";
            this.mtsMenuPrincipal.Size = new System.Drawing.Size(1698, 30);
            this.mtsMenuPrincipal.TabIndex = 4;
            this.mtsMenuPrincipal.Text = "materialTabSelector1";
            // 
            // tcMenuPrincipal
            // 
            this.tcMenuPrincipal.Controls.Add(this.tpEmpleados);
            this.tcMenuPrincipal.Controls.Add(this.tpCliente);
            this.tcMenuPrincipal.Controls.Add(this.tpControlSalas);
            this.tcMenuPrincipal.Controls.Add(this.tpPeliculas);
            this.tcMenuPrincipal.Controls.Add(this.tpVentas);
            this.tcMenuPrincipal.Depth = 0;
            this.tcMenuPrincipal.Location = new System.Drawing.Point(-5, 96);
            this.tcMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMenuPrincipal.Name = "tcMenuPrincipal";
            this.tcMenuPrincipal.SelectedIndex = 0;
            this.tcMenuPrincipal.Size = new System.Drawing.Size(406, 612);
            this.tcMenuPrincipal.TabIndex = 5;
            // 
            // tpEmpleados
            // 
            this.tpEmpleados.Controls.Add(this.btnEmpleado);
            this.tpEmpleados.Controls.Add(this.pbEmpleado);
            this.tpEmpleados.Controls.Add(this.pbCineE);
            this.tpEmpleados.Controls.Add(this.mtsEmpleados);
            this.tpEmpleados.Location = new System.Drawing.Point(4, 27);
            this.tpEmpleados.Name = "tpEmpleados";
            this.tpEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpleados.Size = new System.Drawing.Size(398, 581);
            this.tpEmpleados.TabIndex = 0;
            this.tpEmpleados.Text = "Empleados";
            this.tpEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.AutoSize = true;
            this.btnEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleado.Depth = 0;
            this.btnEmpleado.Icon = null;
            this.btnEmpleado.Location = new System.Drawing.Point(23, 155);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Primary = false;
            this.btnEmpleado.Size = new System.Drawing.Size(183, 36);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.Text = "Agregar, Modificar\r\nVer, Buscar y Eliminar";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpleado.Image")));
            this.pbEmpleado.Location = new System.Drawing.Point(49, 432);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(122, 121);
            this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpleado.TabIndex = 9;
            this.pbEmpleado.TabStop = false;
            // 
            // pbCineE
            // 
            this.pbCineE.Image = ((System.Drawing.Image)(resources.GetObject("pbCineE.Image")));
            this.pbCineE.Location = new System.Drawing.Point(36, 6);
            this.pbCineE.Name = "pbCineE";
            this.pbCineE.Size = new System.Drawing.Size(148, 140);
            this.pbCineE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCineE.TabIndex = 4;
            this.pbCineE.TabStop = false;
            // 
            // mtsEmpleados
            // 
            this.mtsEmpleados.BaseTabControl = null;
            this.mtsEmpleados.Depth = 0;
            this.mtsEmpleados.Location = new System.Drawing.Point(0, 0);
            this.mtsEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtsEmpleados.Name = "mtsEmpleados";
            this.mtsEmpleados.Size = new System.Drawing.Size(224, 786);
            this.mtsEmpleados.TabIndex = 2;
            this.mtsEmpleados.Text = "Empleados";
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.pbCliente);
            this.tpCliente.Controls.Add(this.btnClientes);
            this.tpCliente.Controls.Add(this.pictureBox1);
            this.tpCliente.Controls.Add(this.materialTabSelector1);
            this.tpCliente.Location = new System.Drawing.Point(4, 27);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(398, 581);
            this.tpCliente.TabIndex = 4;
            this.tpCliente.Text = "Clientes";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // pbCliente
            // 
            this.pbCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbCliente.Image")));
            this.pbCliente.Location = new System.Drawing.Point(49, 432);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(122, 121);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 8;
            this.pbCliente.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = true;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Depth = 0;
            this.btnClientes.Icon = null;
            this.btnClientes.Location = new System.Drawing.Point(23, 155);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Primary = false;
            this.btnClientes.Size = new System.Drawing.Size(183, 36);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Agregar, Modificar\r\nVer, Buscar y Eliminar";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(224, 822);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "Empleados";
            // 
            // tpControlSalas
            // 
            this.tpControlSalas.Controls.Add(this.pbSalas);
            this.tpControlSalas.Controls.Add(this.btnVerSala2);
            this.tpControlSalas.Controls.Add(this.btnVerSala1);
            this.tpControlSalas.Controls.Add(this.btnAsignarCartelera);
            this.tpControlSalas.Controls.Add(this.pbCineCS);
            this.tpControlSalas.Controls.Add(this.mtsControlSalas);
            this.tpControlSalas.Location = new System.Drawing.Point(4, 27);
            this.tpControlSalas.Name = "tpControlSalas";
            this.tpControlSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tpControlSalas.Size = new System.Drawing.Size(398, 581);
            this.tpControlSalas.TabIndex = 1;
            this.tpControlSalas.Text = "Control Salas";
            this.tpControlSalas.UseVisualStyleBackColor = true;
            // 
            // pbSalas
            // 
            this.pbSalas.Image = ((System.Drawing.Image)(resources.GetObject("pbSalas.Image")));
            this.pbSalas.Location = new System.Drawing.Point(49, 432);
            this.pbSalas.Name = "pbSalas";
            this.pbSalas.Size = new System.Drawing.Size(122, 121);
            this.pbSalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalas.TabIndex = 7;
            this.pbSalas.TabStop = false;
            // 
            // btnVerSala2
            // 
            this.btnVerSala2.AutoSize = true;
            this.btnVerSala2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerSala2.Depth = 0;
            this.btnVerSala2.Icon = null;
            this.btnVerSala2.Location = new System.Drawing.Point(36, 251);
            this.btnVerSala2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerSala2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerSala2.Name = "btnVerSala2";
            this.btnVerSala2.Primary = false;
            this.btnVerSala2.Size = new System.Drawing.Size(95, 36);
            this.btnVerSala2.TabIndex = 6;
            this.btnVerSala2.Text = "Ver Sala 2";
            this.btnVerSala2.UseVisualStyleBackColor = true;
            this.btnVerSala2.Click += new System.EventHandler(this.btnVerSala2_Click);
            // 
            // btnVerSala1
            // 
            this.btnVerSala1.AutoSize = true;
            this.btnVerSala1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerSala1.Depth = 0;
            this.btnVerSala1.Icon = null;
            this.btnVerSala1.Location = new System.Drawing.Point(36, 203);
            this.btnVerSala1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerSala1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerSala1.Name = "btnVerSala1";
            this.btnVerSala1.Primary = false;
            this.btnVerSala1.Size = new System.Drawing.Size(95, 36);
            this.btnVerSala1.TabIndex = 6;
            this.btnVerSala1.Text = "Ver Sala 1";
            this.btnVerSala1.UseVisualStyleBackColor = true;
            this.btnVerSala1.Click += new System.EventHandler(this.btnVerSala1_Click);
            // 
            // btnAsignarCartelera
            // 
            this.btnAsignarCartelera.AutoSize = true;
            this.btnAsignarCartelera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignarCartelera.Depth = 0;
            this.btnAsignarCartelera.Icon = null;
            this.btnAsignarCartelera.Location = new System.Drawing.Point(36, 155);
            this.btnAsignarCartelera.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignarCartelera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignarCartelera.Name = "btnAsignarCartelera";
            this.btnAsignarCartelera.Primary = false;
            this.btnAsignarCartelera.Size = new System.Drawing.Size(158, 36);
            this.btnAsignarCartelera.TabIndex = 6;
            this.btnAsignarCartelera.Text = "Asignar Cartelera";
            this.btnAsignarCartelera.UseVisualStyleBackColor = true;
            this.btnAsignarCartelera.Click += new System.EventHandler(this.btnAsignarCartelera_Click);
            // 
            // pbCineCS
            // 
            this.pbCineCS.Image = ((System.Drawing.Image)(resources.GetObject("pbCineCS.Image")));
            this.pbCineCS.Location = new System.Drawing.Point(36, 6);
            this.pbCineCS.Name = "pbCineCS";
            this.pbCineCS.Size = new System.Drawing.Size(148, 140);
            this.pbCineCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCineCS.TabIndex = 5;
            this.pbCineCS.TabStop = false;
            // 
            // mtsControlSalas
            // 
            this.mtsControlSalas.BaseTabControl = null;
            this.mtsControlSalas.Depth = 0;
            this.mtsControlSalas.Location = new System.Drawing.Point(0, 0);
            this.mtsControlSalas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtsControlSalas.Name = "mtsControlSalas";
            this.mtsControlSalas.Size = new System.Drawing.Size(224, 808);
            this.mtsControlSalas.TabIndex = 3;
            this.mtsControlSalas.Text = "Control Salas";
            // 
            // tpPeliculas
            // 
            this.tpPeliculas.Controls.Add(this.pbPelicula);
            this.tpPeliculas.Controls.Add(this.btnVerTodas);
            this.tpPeliculas.Controls.Add(this.btnMantenimiento);
            this.tpPeliculas.Controls.Add(this.btnAgregarPelicula);
            this.tpPeliculas.Controls.Add(this.pbCineP);
            this.tpPeliculas.Controls.Add(this.mtsPeliculas);
            this.tpPeliculas.Location = new System.Drawing.Point(4, 27);
            this.tpPeliculas.Name = "tpPeliculas";
            this.tpPeliculas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeliculas.Size = new System.Drawing.Size(398, 581);
            this.tpPeliculas.TabIndex = 2;
            this.tpPeliculas.Text = "Películas";
            this.tpPeliculas.UseVisualStyleBackColor = true;
            // 
            // pbPelicula
            // 
            this.pbPelicula.Image = ((System.Drawing.Image)(resources.GetObject("pbPelicula.Image")));
            this.pbPelicula.Location = new System.Drawing.Point(49, 432);
            this.pbPelicula.Name = "pbPelicula";
            this.pbPelicula.Size = new System.Drawing.Size(122, 121);
            this.pbPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPelicula.TabIndex = 7;
            this.pbPelicula.TabStop = false;
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.AutoSize = true;
            this.btnVerTodas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerTodas.Depth = 0;
            this.btnVerTodas.Icon = null;
            this.btnVerTodas.Location = new System.Drawing.Point(36, 251);
            this.btnVerTodas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerTodas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Primary = false;
            this.btnVerTodas.Size = new System.Drawing.Size(94, 36);
            this.btnVerTodas.TabIndex = 6;
            this.btnVerTodas.Text = "Ver Todas";
            this.btnVerTodas.UseVisualStyleBackColor = true;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.AutoSize = true;
            this.btnMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimiento.Depth = 0;
            this.btnMantenimiento.Icon = null;
            this.btnMantenimiento.Location = new System.Drawing.Point(36, 203);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Primary = false;
            this.btnMantenimiento.Size = new System.Drawing.Size(133, 36);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.AutoSize = true;
            this.btnAgregarPelicula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPelicula.Depth = 0;
            this.btnAgregarPelicula.Icon = null;
            this.btnAgregarPelicula.Location = new System.Drawing.Point(36, 155);
            this.btnAgregarPelicula.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarPelicula.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Primary = false;
            this.btnAgregarPelicula.Size = new System.Drawing.Size(149, 36);
            this.btnAgregarPelicula.TabIndex = 6;
            this.btnAgregarPelicula.Text = "Agregar Película";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // pbCineP
            // 
            this.pbCineP.Image = ((System.Drawing.Image)(resources.GetObject("pbCineP.Image")));
            this.pbCineP.Location = new System.Drawing.Point(36, 6);
            this.pbCineP.Name = "pbCineP";
            this.pbCineP.Size = new System.Drawing.Size(148, 140);
            this.pbCineP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCineP.TabIndex = 6;
            this.pbCineP.TabStop = false;
            // 
            // mtsPeliculas
            // 
            this.mtsPeliculas.BaseTabControl = null;
            this.mtsPeliculas.Depth = 0;
            this.mtsPeliculas.Location = new System.Drawing.Point(0, 0);
            this.mtsPeliculas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtsPeliculas.Name = "mtsPeliculas";
            this.mtsPeliculas.Size = new System.Drawing.Size(224, 830);
            this.mtsPeliculas.TabIndex = 3;
            this.mtsPeliculas.Text = "Peliculas";
            // 
            // tpVentas
            // 
            this.tpVentas.Controls.Add(this.btnReporteVentas);
            this.tpVentas.Controls.Add(this.pbVenta);
            this.tpVentas.Controls.Add(this.btnVenderBoletos);
            this.tpVentas.Controls.Add(this.pbCineV);
            this.tpVentas.Controls.Add(this.mtsVentas);
            this.tpVentas.Location = new System.Drawing.Point(4, 27);
            this.tpVentas.Name = "tpVentas";
            this.tpVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVentas.Size = new System.Drawing.Size(398, 581);
            this.tpVentas.TabIndex = 3;
            this.tpVentas.Text = "Ventas";
            this.tpVentas.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.AutoSize = true;
            this.btnReporteVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteVentas.Depth = 0;
            this.btnReporteVentas.Icon = null;
            this.btnReporteVentas.Location = new System.Drawing.Point(36, 203);
            this.btnReporteVentas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Primary = false;
            this.btnReporteVentas.Size = new System.Drawing.Size(156, 36);
            this.btnReporteVentas.TabIndex = 8;
            this.btnReporteVentas.Text = "Reporte de Ventas";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // pbVenta
            // 
            this.pbVenta.Image = ((System.Drawing.Image)(resources.GetObject("pbVenta.Image")));
            this.pbVenta.Location = new System.Drawing.Point(49, 432);
            this.pbVenta.Name = "pbVenta";
            this.pbVenta.Size = new System.Drawing.Size(122, 121);
            this.pbVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVenta.TabIndex = 7;
            this.pbVenta.TabStop = false;
            // 
            // btnVenderBoletos
            // 
            this.btnVenderBoletos.AutoSize = true;
            this.btnVenderBoletos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenderBoletos.Depth = 0;
            this.btnVenderBoletos.Icon = null;
            this.btnVenderBoletos.Location = new System.Drawing.Point(36, 155);
            this.btnVenderBoletos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenderBoletos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenderBoletos.Name = "btnVenderBoletos";
            this.btnVenderBoletos.Primary = false;
            this.btnVenderBoletos.Size = new System.Drawing.Size(136, 36);
            this.btnVenderBoletos.TabIndex = 6;
            this.btnVenderBoletos.Text = "Vender Boletos";
            this.btnVenderBoletos.UseVisualStyleBackColor = true;
            this.btnVenderBoletos.Click += new System.EventHandler(this.btnComprarBoletos_Click);
            // 
            // pbCineV
            // 
            this.pbCineV.Image = ((System.Drawing.Image)(resources.GetObject("pbCineV.Image")));
            this.pbCineV.Location = new System.Drawing.Point(36, 6);
            this.pbCineV.Name = "pbCineV";
            this.pbCineV.Size = new System.Drawing.Size(148, 140);
            this.pbCineV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCineV.TabIndex = 7;
            this.pbCineV.TabStop = false;
            // 
            // mtsVentas
            // 
            this.mtsVentas.BaseTabControl = null;
            this.mtsVentas.Depth = 0;
            this.mtsVentas.Location = new System.Drawing.Point(0, 0);
            this.mtsVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtsVentas.Name = "mtsVentas";
            this.mtsVentas.Size = new System.Drawing.Size(224, 877);
            this.mtsVentas.TabIndex = 3;
            this.mtsVentas.Text = "Ventas";
            // 
            // pbRegresar
            // 
            this.pbRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pbRegresar.Image")));
            this.pbRegresar.Location = new System.Drawing.Point(1272, 613);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(60, 63);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegresar.TabIndex = 6;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
            // 
            // pbInformacion
            // 
            this.pbInformacion.Image = ((System.Drawing.Image)(resources.GetObject("pbInformacion.Image")));
            this.pbInformacion.Location = new System.Drawing.Point(1295, 99);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(37, 36);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInformacion.TabIndex = 7;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.Click += new System.EventHandler(this.pbInformacion_Click);
            // 
            // SistemaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1344, 688);
            this.Controls.Add(this.pbInformacion);
            this.Controls.Add(this.pbRegresar);
            this.Controls.Add(this.tcMenuPrincipal);
            this.Controls.Add(this.mtsMenuPrincipal);
            this.Controls.Add(this.lblEmpleado);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema para Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.tcMenuPrincipal.ResumeLayout(false);
            this.tpEmpleados.ResumeLayout(false);
            this.tpEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineE)).EndInit();
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpControlSalas.ResumeLayout(false);
            this.tpControlSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineCS)).EndInit();
            this.tpPeliculas.ResumeLayout(false);
            this.tpPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineP)).EndInit();
            this.tpVentas.ResumeLayout(false);
            this.tpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCineV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private MaterialSkin.Controls.MaterialTabSelector mtsMenuPrincipal;
        private MaterialSkin.Controls.MaterialTabControl tcMenuPrincipal;
        private System.Windows.Forms.TabPage tpEmpleados;
        private MaterialSkin.Controls.MaterialTabSelector mtsEmpleados;
        private System.Windows.Forms.TabPage tpControlSalas;
        private System.Windows.Forms.TabPage tpPeliculas;
        private System.Windows.Forms.TabPage tpVentas;
        private System.Windows.Forms.PictureBox pbCineE;
        private MaterialSkin.Controls.MaterialTabSelector mtsControlSalas;
        private System.Windows.Forms.PictureBox pbCineCS;
        private MaterialSkin.Controls.MaterialTabSelector mtsPeliculas;
        private MaterialSkin.Controls.MaterialTabSelector mtsVentas;
        private MaterialSkin.Controls.MaterialFlatButton btnVerSala2;
        private MaterialSkin.Controls.MaterialFlatButton btnVerSala1;
        private MaterialSkin.Controls.MaterialFlatButton btnAsignarCartelera;
        private System.Windows.Forms.PictureBox pbCineP;
        private System.Windows.Forms.PictureBox pbCineV;
        private MaterialSkin.Controls.MaterialFlatButton btnVerTodas;
        private MaterialSkin.Controls.MaterialFlatButton btnMantenimiento;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarPelicula;
        private MaterialSkin.Controls.MaterialFlatButton btnVenderBoletos;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pbSalas;
        private System.Windows.Forms.PictureBox pbPelicula;
        private System.Windows.Forms.PictureBox pbVenta;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private MaterialSkin.Controls.MaterialFlatButton btnReporteVentas;
        private MaterialSkin.Controls.MaterialFlatButton btnEmpleado;
        private MaterialSkin.Controls.MaterialFlatButton btnClientes;
    }
}