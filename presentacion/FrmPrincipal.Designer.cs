namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnTitulo = new System.Windows.Forms.Panel();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.PnContenedorMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnBoletosVendidos = new System.Windows.Forms.Button();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.PnSubmenuEstadisticas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BtnDineroGenerado = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.BtnTiempoxMeses = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.BtnDestinosPopulares = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.BtnEstadoVuelos = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.PbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnAviones = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAeropuertos = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVuelos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.TmrFechaYHora = new System.Windows.Forms.Timer(this.components);
            this.PnTitulo.SuspendLayout();
            this.PnMenu.SuspendLayout();
            this.PnContenedorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnSubmenuEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTitulo
            // 
            this.PnTitulo.BackColor = System.Drawing.Color.Firebrick;
            this.PnTitulo.Controls.Add(this.BtnCerrrar);
            this.PnTitulo.Controls.Add(this.BtnMinimizar);
            this.PnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnTitulo.Name = "PnTitulo";
            this.PnTitulo.Size = new System.Drawing.Size(1300, 35);
            this.PnTitulo.TabIndex = 0;
            this.PnTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTitulo_MouseDown);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCerrrar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.window_close_icon_135015;
            this.BtnCerrrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrrar.Location = new System.Drawing.Point(1264, 0);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Size = new System.Drawing.Size(36, 24);
            this.BtnCerrrar.TabIndex = 18;
            this.BtnCerrrar.UseVisualStyleBackColor = false;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnMinimizar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.window_minimize_icon_138009;
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMinimizar.Location = new System.Drawing.Point(1229, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(36, 24);
            this.BtnMinimizar.TabIndex = 17;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.White;
            this.PnMenu.Controls.Add(this.PnContenedorMenu);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 35);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(200, 615);
            this.PnMenu.TabIndex = 1;
            // 
            // PnContenedorMenu
            // 
            this.PnContenedorMenu.BackColor = System.Drawing.Color.FloralWhite;
            this.PnContenedorMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnContenedorMenu.Controls.Add(this.pictureBox2);
            this.PnContenedorMenu.Controls.Add(this.pictureBox3);
            this.PnContenedorMenu.Controls.Add(this.pictureBox1);
            this.PnContenedorMenu.Controls.Add(this.panel4);
            this.PnContenedorMenu.Controls.Add(this.panel7);
            this.PnContenedorMenu.Controls.Add(this.BtnClientes);
            this.PnContenedorMenu.Controls.Add(this.BtnBoletosVendidos);
            this.PnContenedorMenu.Controls.Add(this.LblNombreUsuario);
            this.PnContenedorMenu.Controls.Add(this.PnSubmenuEstadisticas);
            this.PnContenedorMenu.Controls.Add(this.label2);
            this.PnContenedorMenu.Controls.Add(this.pictureBox7);
            this.PnContenedorMenu.Controls.Add(this.PbLogoPrincipal);
            this.PnContenedorMenu.Controls.Add(this.panel6);
            this.PnContenedorMenu.Controls.Add(this.BtnAviones);
            this.PnContenedorMenu.Controls.Add(this.pictureBox6);
            this.PnContenedorMenu.Controls.Add(this.panel5);
            this.PnContenedorMenu.Controls.Add(this.BtnAeropuertos);
            this.PnContenedorMenu.Controls.Add(this.pictureBox5);
            this.PnContenedorMenu.Controls.Add(this.panel1);
            this.PnContenedorMenu.Controls.Add(this.BtnVuelos);
            this.PnContenedorMenu.Controls.Add(this.panel3);
            this.PnContenedorMenu.Controls.Add(this.BtnEstadisticas);
            this.PnContenedorMenu.Location = new System.Drawing.Point(0, 0);
            this.PnContenedorMenu.Name = "PnContenedorMenu";
            this.PnContenedorMenu.Size = new System.Drawing.Size(200, 615);
            this.PnContenedorMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.boletoPng;
            this.pictureBox2.Location = new System.Drawing.Point(11, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.ClientesPn;
            this.pictureBox3.Location = new System.Drawing.Point(10, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(11, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Location = new System.Drawing.Point(0, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 44);
            this.panel4.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.Location = new System.Drawing.Point(-1, 381);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 44);
            this.panel7.TabIndex = 29;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Location = new System.Drawing.Point(0, 381);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(197, 44);
            this.BtnClientes.TabIndex = 32;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnBoletosVendidos
            // 
            this.BtnBoletosVendidos.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnBoletosVendidos.FlatAppearance.BorderSize = 0;
            this.BtnBoletosVendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnBoletosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoletosVendidos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletosVendidos.Location = new System.Drawing.Point(1, 328);
            this.BtnBoletosVendidos.Name = "BtnBoletosVendidos";
            this.BtnBoletosVendidos.Size = new System.Drawing.Size(197, 44);
            this.BtnBoletosVendidos.TabIndex = 28;
            this.BtnBoletosVendidos.Text = "Boletos";
            this.BtnBoletosVendidos.UseVisualStyleBackColor = false;
            this.BtnBoletosVendidos.Click += new System.EventHandler(this.BtnBoletosVendidos_Click_1);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblNombreUsuario.Location = new System.Drawing.Point(1, 155);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(131, 13);
            this.LblNombreUsuario.TabIndex = 19;
            this.LblNombreUsuario.Text = "Nombre de usuario";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnSubmenuEstadisticas
            // 
            this.PnSubmenuEstadisticas.Controls.Add(this.panel2);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel16);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel9);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel11);
            this.PnSubmenuEstadisticas.Controls.Add(this.BtnDineroGenerado);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel17);
            this.PnSubmenuEstadisticas.Controls.Add(this.BtnTiempoxMeses);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel15);
            this.PnSubmenuEstadisticas.Controls.Add(this.BtnDestinosPopulares);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel13);
            this.PnSubmenuEstadisticas.Controls.Add(this.BtnEstadoVuelos);
            this.PnSubmenuEstadisticas.Controls.Add(this.panel10);
            this.PnSubmenuEstadisticas.Location = new System.Drawing.Point(36, 481);
            this.PnSubmenuEstadisticas.Name = "PnSubmenuEstadisticas";
            this.PnSubmenuEstadisticas.Size = new System.Drawing.Size(159, 130);
            this.PnSubmenuEstadisticas.TabIndex = 0;
            this.PnSubmenuEstadisticas.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(4, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 27);
            this.panel2.TabIndex = 26;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Firebrick;
            this.panel16.Location = new System.Drawing.Point(4, 93);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(13, 27);
            this.panel16.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Firebrick;
            this.panel9.Location = new System.Drawing.Point(4, 33);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 21);
            this.panel9.TabIndex = 25;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Firebrick;
            this.panel11.Location = new System.Drawing.Point(4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(13, 21);
            this.panel11.TabIndex = 25;
            // 
            // BtnDineroGenerado
            // 
            this.BtnDineroGenerado.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnDineroGenerado.FlatAppearance.BorderSize = 0;
            this.BtnDineroGenerado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnDineroGenerado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDineroGenerado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDineroGenerado.Location = new System.Drawing.Point(6, 93);
            this.BtnDineroGenerado.Name = "BtnDineroGenerado";
            this.BtnDineroGenerado.Size = new System.Drawing.Size(152, 27);
            this.BtnDineroGenerado.TabIndex = 26;
            this.BtnDineroGenerado.Text = "Dinero generado";
            this.BtnDineroGenerado.UseVisualStyleBackColor = false;
            this.BtnDineroGenerado.Click += new System.EventHandler(this.BtnDineroGenerado_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.SkyBlue;
            this.panel17.Location = new System.Drawing.Point(6, 93);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(11, 21);
            this.panel17.TabIndex = 25;
            // 
            // BtnTiempoxMeses
            // 
            this.BtnTiempoxMeses.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnTiempoxMeses.FlatAppearance.BorderSize = 0;
            this.BtnTiempoxMeses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnTiempoxMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTiempoxMeses.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTiempoxMeses.Location = new System.Drawing.Point(5, 63);
            this.BtnTiempoxMeses.Name = "BtnTiempoxMeses";
            this.BtnTiempoxMeses.Size = new System.Drawing.Size(153, 24);
            this.BtnTiempoxMeses.TabIndex = 26;
            this.BtnTiempoxMeses.Text = "Histograma";
            this.BtnTiempoxMeses.UseVisualStyleBackColor = false;
            this.BtnTiempoxMeses.Click += new System.EventHandler(this.BtnTiempoxMeses_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SkyBlue;
            this.panel15.Location = new System.Drawing.Point(5, 63);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(11, 21);
            this.panel15.TabIndex = 25;
            // 
            // BtnDestinosPopulares
            // 
            this.BtnDestinosPopulares.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnDestinosPopulares.FlatAppearance.BorderSize = 0;
            this.BtnDestinosPopulares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnDestinosPopulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDestinosPopulares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDestinosPopulares.Location = new System.Drawing.Point(5, 33);
            this.BtnDestinosPopulares.Name = "BtnDestinosPopulares";
            this.BtnDestinosPopulares.Size = new System.Drawing.Size(153, 21);
            this.BtnDestinosPopulares.TabIndex = 26;
            this.BtnDestinosPopulares.Text = "Destinos populares";
            this.BtnDestinosPopulares.UseVisualStyleBackColor = false;
            this.BtnDestinosPopulares.Click += new System.EventHandler(this.BtnDestinosPopulares_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SkyBlue;
            this.panel13.Location = new System.Drawing.Point(5, 33);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(11, 21);
            this.panel13.TabIndex = 25;
            // 
            // BtnEstadoVuelos
            // 
            this.BtnEstadoVuelos.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnEstadoVuelos.FlatAppearance.BorderSize = 0;
            this.BtnEstadoVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnEstadoVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadoVuelos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadoVuelos.Location = new System.Drawing.Point(5, 3);
            this.BtnEstadoVuelos.Name = "BtnEstadoVuelos";
            this.BtnEstadoVuelos.Size = new System.Drawing.Size(153, 21);
            this.BtnEstadoVuelos.TabIndex = 26;
            this.BtnEstadoVuelos.Text = "Estado vuelos";
            this.BtnEstadoVuelos.UseVisualStyleBackColor = false;
            this.BtnEstadoVuelos.Click += new System.EventHandler(this.BtnEstadoVuelos_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SkyBlue;
            this.panel10.Location = new System.Drawing.Point(5, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(11, 21);
            this.panel10.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "¡Bienvenido!";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.vueloPng1;
            this.pictureBox7.Location = new System.Drawing.Point(11, 279);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // PbLogoPrincipal
            // 
            this.PbLogoPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.PbLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("PbLogoPrincipal.Image")));
            this.PbLogoPrincipal.Location = new System.Drawing.Point(0, 4);
            this.PbLogoPrincipal.Name = "PbLogoPrincipal";
            this.PbLogoPrincipal.Size = new System.Drawing.Size(197, 121);
            this.PbLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogoPrincipal.TabIndex = 8;
            this.PbLogoPrincipal.TabStop = false;
            this.PbLogoPrincipal.Click += new System.EventHandler(this.PbLogoPrincipal_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Firebrick;
            this.panel6.Location = new System.Drawing.Point(0, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 44);
            this.panel6.TabIndex = 20;
            // 
            // BtnAviones
            // 
            this.BtnAviones.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnAviones.FlatAppearance.BorderSize = 0;
            this.BtnAviones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAviones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAviones.Location = new System.Drawing.Point(0, 279);
            this.BtnAviones.Name = "BtnAviones";
            this.BtnAviones.Size = new System.Drawing.Size(197, 44);
            this.BtnAviones.TabIndex = 19;
            this.BtnAviones.Text = "Aviones";
            this.BtnAviones.UseVisualStyleBackColor = false;
            this.BtnAviones.Click += new System.EventHandler(this.BtnAviones_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.AeropertoPng;
            this.pictureBox6.Location = new System.Drawing.Point(11, 229);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Location = new System.Drawing.Point(0, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 44);
            this.panel5.TabIndex = 17;
            // 
            // BtnAeropuertos
            // 
            this.BtnAeropuertos.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnAeropuertos.FlatAppearance.BorderSize = 0;
            this.BtnAeropuertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnAeropuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAeropuertos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAeropuertos.Location = new System.Drawing.Point(0, 229);
            this.BtnAeropuertos.Name = "BtnAeropuertos";
            this.BtnAeropuertos.Size = new System.Drawing.Size(197, 44);
            this.BtnAeropuertos.TabIndex = 16;
            this.BtnAeropuertos.Text = "Aeropuertos";
            this.BtnAeropuertos.UseVisualStyleBackColor = false;
            this.BtnAeropuertos.Click += new System.EventHandler(this.BtnAeropuertos_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.EstadisticasPng;
            this.pictureBox5.Location = new System.Drawing.Point(11, 431);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 44);
            this.panel1.TabIndex = 0;
            // 
            // BtnVuelos
            // 
            this.BtnVuelos.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnVuelos.FlatAppearance.BorderSize = 0;
            this.BtnVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVuelos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVuelos.Location = new System.Drawing.Point(12, 179);
            this.BtnVuelos.Name = "BtnVuelos";
            this.BtnVuelos.Size = new System.Drawing.Size(185, 44);
            this.BtnVuelos.TabIndex = 12;
            this.BtnVuelos.Text = "Vuelos";
            this.BtnVuelos.UseVisualStyleBackColor = false;
            this.BtnVuelos.Click += new System.EventHandler(this.BtnVuelos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 44);
            this.panel3.TabIndex = 11;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BtnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 431);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(197, 44);
            this.BtnEstadisticas.TabIndex = 8;
            this.BtnEstadisticas.Text = "Estadísticas";
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.PnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnPrincipal.Location = new System.Drawing.Point(200, 35);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(1100, 524);
            this.PnPrincipal.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.IndianRed;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.LblFecha);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(200, 601);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1100, 49);
            this.panel18.TabIndex = 3;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FloralWhite;
            this.LblFecha.Location = new System.Drawing.Point(55, 4);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(89, 31);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "label4";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Firebrick;
            this.panel19.Controls.Add(this.LblHora);
            this.panel19.Location = new System.Drawing.Point(200, 538);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1100, 64);
            this.panel19.TabIndex = 4;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblHora.ForeColor = System.Drawing.Color.FloralWhite;
            this.LblHora.Location = new System.Drawing.Point(52, 11);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(112, 40);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "label3";
            // 
            // TmrFechaYHora
            // 
            this.TmrFechaYHora.Tick += new System.EventHandler(this.TmrFechaYHora_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.PnMenu);
            this.Controls.Add(this.PnTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyEase Manager";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnTitulo.ResumeLayout(false);
            this.PnMenu.ResumeLayout(false);
            this.PnContenedorMenu.ResumeLayout(false);
            this.PnContenedorMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnSubmenuEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnTitulo;
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.PictureBox PbLogoPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnContenedorMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAeropuertos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnAviones;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BtnEstadisticas;
        private System.Windows.Forms.Panel PnSubmenuEstadisticas;
        private System.Windows.Forms.Button BtnDineroGenerado;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button BtnTiempoxMeses;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button BtnDestinosPopulares;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button BtnEstadoVuelos;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer TmrFechaYHora;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnBoletosVendidos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnVuelos;
    }
}