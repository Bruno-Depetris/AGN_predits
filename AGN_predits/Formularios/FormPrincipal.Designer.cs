namespace AGN_predits
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel_ContenedorLateral = new System.Windows.Forms.Panel();
            this.parrotButton_Clientes = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Dashboard = new ReaLTaiizor.Controls.ParrotButton();
            this.airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            this.bigLabel_Fecha_completa = new ReaLTaiizor.Controls.BigLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_BLUE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.bigLabel_Hora = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel_Dia = new ReaLTaiizor.Controls.BigLabel();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.parrotButton_Stock = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_imhere = new System.Windows.Forms.Panel();
            this.parrotButton_Config = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Vender = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Caja = new ReaLTaiizor.Controls.ParrotButton();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.timer_Fecha = new System.Windows.Forms.Timer(this.components);
            this.parrotButton_Tecnico = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_ContenedorLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ContenedorLateral
            // 
            this.panel_ContenedorLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Tecnico);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Clientes);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Dashboard);
            this.panel_ContenedorLateral.Controls.Add(this.airSeparator2);
            this.panel_ContenedorLateral.Controls.Add(this.bigLabel_Fecha_completa);
            this.panel_ContenedorLateral.Controls.Add(this.panel2);
            this.panel_ContenedorLateral.Controls.Add(this.parrotGradientPanel1);
            this.panel_ContenedorLateral.Controls.Add(this.bigLabel_Hora);
            this.panel_ContenedorLateral.Controls.Add(this.bigLabel_Dia);
            this.panel_ContenedorLateral.Controls.Add(this.airSeparator1);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Stock);
            this.panel_ContenedorLateral.Controls.Add(this.panel_imhere);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Config);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Vender);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Caja);
            this.panel_ContenedorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContenedorLateral.Location = new System.Drawing.Point(0, 40);
            this.panel_ContenedorLateral.Name = "panel_ContenedorLateral";
            this.panel_ContenedorLateral.Size = new System.Drawing.Size(241, 540);
            this.panel_ContenedorLateral.TabIndex = 1;
            this.panel_ContenedorLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContenedorLateral_Paint);
            // 
            // parrotButton_Clientes
            // 
            this.parrotButton_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Clientes.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Clientes.ButtonImage")));
            this.parrotButton_Clientes.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Clientes.ButtonText = "Clientes";
            this.parrotButton_Clientes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Clientes.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Clientes.CornerRadius = 5;
            this.parrotButton_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Clientes.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Clientes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Clientes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Clientes.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Clientes.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Clientes.Location = new System.Drawing.Point(12, 163);
            this.parrotButton_Clientes.Name = "parrotButton_Clientes";
            this.parrotButton_Clientes.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Clientes.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Clientes.TabIndex = 31;
            this.parrotButton_Clientes.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Clientes.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Clientes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Clientes.Click += new System.EventHandler(this.parrotButton_Clientes_Click);
            // 
            // parrotButton_Dashboard
            // 
            this.parrotButton_Dashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Dashboard.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Dashboard.ButtonImage")));
            this.parrotButton_Dashboard.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Dashboard.ButtonText = "DashBoard";
            this.parrotButton_Dashboard.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Dashboard.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Dashboard.CornerRadius = 5;
            this.parrotButton_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Dashboard.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Dashboard.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Dashboard.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Dashboard.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Dashboard.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Dashboard.Location = new System.Drawing.Point(12, 51);
            this.parrotButton_Dashboard.Name = "parrotButton_Dashboard";
            this.parrotButton_Dashboard.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Dashboard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Dashboard.TabIndex = 30;
            this.parrotButton_Dashboard.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Dashboard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Dashboard.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Dashboard.Click += new System.EventHandler(this.parrotButton_Dashboard_Click);
            // 
            // airSeparator2
            // 
            this.airSeparator2.BackColor = System.Drawing.Color.Black;
            this.airSeparator2.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator2.Customization = "";
            this.airSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.airSeparator2.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator2.Image = null;
            this.airSeparator2.Location = new System.Drawing.Point(0, 517);
            this.airSeparator2.Name = "airSeparator2";
            this.airSeparator2.NoRounding = false;
            this.airSeparator2.Size = new System.Drawing.Size(241, 1);
            this.airSeparator2.TabIndex = 29;
            this.airSeparator2.Text = "airSeparator2";
            this.airSeparator2.Transparent = false;
            // 
            // bigLabel_Fecha_completa
            // 
            this.bigLabel_Fecha_completa.AutoSize = true;
            this.bigLabel_Fecha_completa.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel_Fecha_completa.Font = new System.Drawing.Font("Arboria Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel_Fecha_completa.ForeColor = System.Drawing.Color.Black;
            this.bigLabel_Fecha_completa.Location = new System.Drawing.Point(51, 438);
            this.bigLabel_Fecha_completa.Name = "bigLabel_Fecha_completa";
            this.bigLabel_Fecha_completa.Size = new System.Drawing.Size(136, 40);
            this.bigLabel_Fecha_completa.TabIndex = 28;
            this.bigLabel_Fecha_completa.Text = "11/01/25";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label_BLUE);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 22);
            this.panel2.TabIndex = 27;
            // 
            // label_BLUE
            // 
            this.label_BLUE.AutoSize = true;
            this.label_BLUE.Font = new System.Drawing.Font("Arboria Book", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BLUE.ForeColor = System.Drawing.Color.Silver;
            this.label_BLUE.Location = new System.Drawing.Point(132, 4);
            this.label_BLUE.Name = "label_BLUE";
            this.label_BLUE.Size = new System.Drawing.Size(37, 15);
            this.label_BLUE.TabIndex = 1;
            this.label_BLUE.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arboria Book", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARS/USD (BLUE): $";
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(241, 12);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            this.parrotGradientPanel1.TabIndex = 2;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(203)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            // 
            // bigLabel_Hora
            // 
            this.bigLabel_Hora.AutoSize = true;
            this.bigLabel_Hora.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel_Hora.Font = new System.Drawing.Font("Arboria Thin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel_Hora.ForeColor = System.Drawing.Color.Black;
            this.bigLabel_Hora.Location = new System.Drawing.Point(69, 15);
            this.bigLabel_Hora.Name = "bigLabel_Hora";
            this.bigLabel_Hora.Size = new System.Drawing.Size(100, 33);
            this.bigLabel_Hora.TabIndex = 26;
            this.bigLabel_Hora.Text = "18:13:10";
            // 
            // bigLabel_Dia
            // 
            this.bigLabel_Dia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bigLabel_Dia.AutoSize = true;
            this.bigLabel_Dia.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel_Dia.Font = new System.Drawing.Font("Arboria Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel_Dia.ForeColor = System.Drawing.Color.Black;
            this.bigLabel_Dia.Location = new System.Drawing.Point(65, 478);
            this.bigLabel_Dia.Name = "bigLabel_Dia";
            this.bigLabel_Dia.Size = new System.Drawing.Size(104, 40);
            this.bigLabel_Dia.TabIndex = 25;
            this.bigLabel_Dia.Text = "Lunes";
            // 
            // airSeparator1
            // 
            this.airSeparator1.BackColor = System.Drawing.Color.Black;
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(13, 462);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(210, 1);
            this.airSeparator1.TabIndex = 24;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // parrotButton_Stock
            // 
            this.parrotButton_Stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Stock.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Stock.ButtonImage")));
            this.parrotButton_Stock.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Stock.ButtonText = "Stock";
            this.parrotButton_Stock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Stock.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Stock.CornerRadius = 5;
            this.parrotButton_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Stock.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Stock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Stock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Stock.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Stock.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Stock.Location = new System.Drawing.Point(13, 331);
            this.parrotButton_Stock.Name = "parrotButton_Stock";
            this.parrotButton_Stock.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Stock.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Stock.TabIndex = 23;
            this.parrotButton_Stock.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Stock.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Stock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Stock.Click += new System.EventHandler(this.parrotButton_Stock_Click);
            // 
            // panel_imhere
            // 
            this.panel_imhere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_imhere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_imhere.Location = new System.Drawing.Point(0, 18);
            this.panel_imhere.Name = "panel_imhere";
            this.panel_imhere.Size = new System.Drawing.Size(10, 61);
            this.panel_imhere.TabIndex = 0;
            // 
            // parrotButton_Config
            // 
            this.parrotButton_Config.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Config.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Config.ButtonImage")));
            this.parrotButton_Config.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Config.ButtonText = "Config";
            this.parrotButton_Config.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Config.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Config.CornerRadius = 5;
            this.parrotButton_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Config.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Config.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Config.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Config.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Config.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Config.Location = new System.Drawing.Point(12, 275);
            this.parrotButton_Config.Name = "parrotButton_Config";
            this.parrotButton_Config.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Config.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Config.TabIndex = 22;
            this.parrotButton_Config.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Config.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Config.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Config.Click += new System.EventHandler(this.parrotButton_Config_Click);
            // 
            // parrotButton_Vender
            // 
            this.parrotButton_Vender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Vender.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Vender.ButtonImage")));
            this.parrotButton_Vender.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Vender.ButtonText = "Ventas";
            this.parrotButton_Vender.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Vender.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Vender.CornerRadius = 5;
            this.parrotButton_Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Vender.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Vender.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Vender.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Vender.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Vender.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Vender.Location = new System.Drawing.Point(12, 107);
            this.parrotButton_Vender.Name = "parrotButton_Vender";
            this.parrotButton_Vender.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Vender.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Vender.TabIndex = 20;
            this.parrotButton_Vender.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Vender.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Vender.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Vender.Click += new System.EventHandler(this.parrotButton_Vender_Click);
            // 
            // parrotButton_Caja
            // 
            this.parrotButton_Caja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Caja.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Caja.ButtonImage")));
            this.parrotButton_Caja.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Caja.ButtonText = "Caja";
            this.parrotButton_Caja.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Caja.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Caja.CornerRadius = 5;
            this.parrotButton_Caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Caja.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Caja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Caja.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Caja.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Caja.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Caja.Location = new System.Drawing.Point(12, 219);
            this.parrotButton_Caja.Name = "parrotButton_Caja";
            this.parrotButton_Caja.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Caja.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Caja.TabIndex = 21;
            this.parrotButton_Caja.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Caja.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Caja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Caja.Click += new System.EventHandler(this.parrotButton_Caja_Click);
            // 
            // hopeForm1
            // 
            this.hopeForm1.BackColor = System.Drawing.Color.White;
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.Black;
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.Black;
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.Black;
            this.hopeForm1.Image = ((System.Drawing.Image)(resources.GetObject("hopeForm1.Image")));
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(1040, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Aplicacion Gestion";
            this.hopeForm1.ThemeColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(241, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1, 540);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(242, 40);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel2.Size = new System.Drawing.Size(798, 12);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            this.parrotGradientPanel2.TabIndex = 4;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.White;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(242, 52);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(798, 528);
            this.panel_Contenedor.TabIndex = 5;
            // 
            // timer_Fecha
            // 
            this.timer_Fecha.Enabled = true;
            this.timer_Fecha.Tick += new System.EventHandler(this.timer_movimientos_Tick);
            // 
            // parrotButton_Tecnico
            // 
            this.parrotButton_Tecnico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Tecnico.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Tecnico.ButtonImage")));
            this.parrotButton_Tecnico.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Tecnico.ButtonText = "Tecnico";
            this.parrotButton_Tecnico.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Tecnico.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.parrotButton_Tecnico.CornerRadius = 5;
            this.parrotButton_Tecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Tecnico.Font = new System.Drawing.Font("Arboria Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Tecnico.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Tecnico.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.parrotButton_Tecnico.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(250)))));
            this.parrotButton_Tecnico.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Tecnico.Location = new System.Drawing.Point(13, 385);
            this.parrotButton_Tecnico.Name = "parrotButton_Tecnico";
            this.parrotButton_Tecnico.Size = new System.Drawing.Size(229, 50);
            this.parrotButton_Tecnico.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Tecnico.TabIndex = 32;
            this.parrotButton_Tecnico.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Tecnico.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Tecnico.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Tecnico.Click += new System.EventHandler(this.parrotButton_Tecnico_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 580);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.parrotGradientPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ContenedorLateral);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel_ContenedorLateral.ResumeLayout(false);
            this.panel_ContenedorLateral.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ContenedorLateral;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Vender;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Stock;
        private System.Windows.Forms.Panel panel_imhere;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Config;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Caja;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel_Hora;
        private ReaLTaiizor.Controls.BigLabel bigLabel_Dia;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.BigLabel bigLabel_Fecha_completa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_BLUE;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Dashboard;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Timer timer_Fecha;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Clientes;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Tecnico;
    }
}

