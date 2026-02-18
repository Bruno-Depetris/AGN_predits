namespace AGN_predits.Formularios.DashBoard {
    partial class DashBoard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();

            // ══════════════════════════════════════════════════════════════
            // HEADER
            // ══════════════════════════════════════════════════════════════
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_Titulo = new ReaLTaiizor.Controls.BigLabel();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.label_EstadoCaja = new System.Windows.Forms.Label();
            this.label_SaldoCaja = new System.Windows.Forms.Label();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();

            // ══════════════════════════════════════════════════════════════
            // KPI CARDS (Row 1) - 4 cards
            // ══════════════════════════════════════════════════════════════
            // Card 1: Ventas Hoy
            this.panel_KPI_VentasHoy = new System.Windows.Forms.Panel();
            this.label_KPI_VentasHoy_Titulo = new System.Windows.Forms.Label();
            this.label_KPI_VentasHoy_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_KPI_VentasHoy_Sub = new System.Windows.Forms.Label();
            this.label_KPI_VentasHoy_Icono = new System.Windows.Forms.Label();

            // Card 2: Ventas Mes
            this.panel_KPI_VentasMes = new System.Windows.Forms.Panel();
            this.label_KPI_VentasMes_Titulo = new System.Windows.Forms.Label();
            this.label_KPI_VentasMes_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_KPI_VentasMes_Sub = new System.Windows.Forms.Label();
            this.label_KPI_VentasMes_Icono = new System.Windows.Forms.Label();

            // Card 3: Productos Stock
            this.panel_KPI_Stock = new System.Windows.Forms.Panel();
            this.label_KPI_Stock_Titulo = new System.Windows.Forms.Label();
            this.label_KPI_Stock_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_KPI_Stock_Sub = new System.Windows.Forms.Label();
            this.label_KPI_Stock_Icono = new System.Windows.Forms.Label();

            // Card 4: Clientes
            this.panel_KPI_Clientes = new System.Windows.Forms.Panel();
            this.label_KPI_Clientes_Titulo = new System.Windows.Forms.Label();
            this.label_KPI_Clientes_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_KPI_Clientes_Sub = new System.Windows.Forms.Label();
            this.label_KPI_Clientes_Icono = new System.Windows.Forms.Label();

            // ══════════════════════════════════════════════════════════════
            // ROW 2: Inversión + Cotizaciones
            // ══════════════════════════════════════════════════════════════
            this.panel_Inversion = new System.Windows.Forms.Panel();
            this.label_Inversion_Titulo = new System.Windows.Forms.Label();
            this.label_Inversion_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_Inversion_Sub = new System.Windows.Forms.Label();

            this.panel_Cotizaciones = new System.Windows.Forms.Panel();
            this.label_Cotizaciones_Titulo = new System.Windows.Forms.Label();
            this.label_DolarOficial = new System.Windows.Forms.Label();
            this.label_DolarOficial_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_DolarBlue = new System.Windows.Forms.Label();
            this.label_DolarBlue_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label_DolarTarjeta = new System.Windows.Forms.Label();
            this.label_DolarTarjeta_Valor = new ReaLTaiizor.Controls.DungeonHeaderLabel();

            // ══════════════════════════════════════════════════════════════
            // ROW 3: Últimas Ventas + Alertas Stock
            // ══════════════════════════════════════════════════════════════
            this.panel_UltimasVentas = new System.Windows.Forms.Panel();
            this.label_UltimasVentas_Titulo = new System.Windows.Forms.Label();
            this.dgv_UltimasVentas = new ReaLTaiizor.Controls.PoisonDataGridView();

            this.panel_AlertasStock = new System.Windows.Forms.Panel();
            this.label_AlertasStock_Titulo = new System.Windows.Forms.Label();
            this.panel_Alerta_SinStock = new System.Windows.Forms.Panel();
            this.label_SinStock_Valor = new System.Windows.Forms.Label();
            this.label_SinStock_Texto = new System.Windows.Forms.Label();
            this.panel_Alerta_StockBajo = new System.Windows.Forms.Panel();
            this.label_StockBajo_Valor = new System.Windows.Forms.Label();
            this.label_StockBajo_Texto = new System.Windows.Forms.Label();
            this.panel_Alerta_StockOk = new System.Windows.Forms.Panel();
            this.label_StockOk_Valor = new System.Windows.Forms.Label();
            this.label_StockOk_Texto = new System.Windows.Forms.Label();

            // Loading indicator
            this.pictureBox_Cargando = new System.Windows.Forms.PictureBox();
            this.label_Cargando = new System.Windows.Forms.Label();

            // ScrollPanel to contain everything
            this.panel_Contenido = new System.Windows.Forms.Panel();

            this.panel_Header.SuspendLayout();
            this.panel_KPI_VentasHoy.SuspendLayout();
            this.panel_KPI_VentasMes.SuspendLayout();
            this.panel_KPI_Stock.SuspendLayout();
            this.panel_KPI_Clientes.SuspendLayout();
            this.panel_Inversion.SuspendLayout();
            this.panel_Cotizaciones.SuspendLayout();
            this.panel_UltimasVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UltimasVentas)).BeginInit();
            this.panel_AlertasStock.SuspendLayout();
            this.panel_Alerta_SinStock.SuspendLayout();
            this.panel_Alerta_StockBajo.SuspendLayout();
            this.panel_Alerta_StockOk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).BeginInit();
            this.panel_Contenido.SuspendLayout();
            this.SuspendLayout();

            // ──────────────────────────────────────────────────────────────
            // panel_Header
            // ──────────────────────────────────────────────────────────────
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel_Header.Controls.Add(this.label_SaldoCaja);
            this.panel_Header.Controls.Add(this.label_EstadoCaja);
            this.panel_Header.Controls.Add(this.label_Fecha);
            this.panel_Header.Controls.Add(this.label_Titulo);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(799, 70);
            this.panel_Header.TabIndex = 0;

            // label_Titulo
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(16, 10);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(200, 32);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "AGN_predits";

            // label_Fecha
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_Fecha.Location = new System.Drawing.Point(18, 44);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(180, 15);
            this.label_Fecha.TabIndex = 1;
            this.label_Fecha.Text = "Panel de Control";

            // label_EstadoCaja
            this.label_EstadoCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EstadoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.label_EstadoCaja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_EstadoCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label_EstadoCaja.Location = new System.Drawing.Point(540, 14);
            this.label_EstadoCaja.Name = "label_EstadoCaja";
            this.label_EstadoCaja.Size = new System.Drawing.Size(100, 22);
            this.label_EstadoCaja.TabIndex = 2;
            this.label_EstadoCaja.Text = "CAJA ABIERTA";
            this.label_EstadoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label_SaldoCaja
            this.label_SaldoCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SaldoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label_SaldoCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_SaldoCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.label_SaldoCaja.Location = new System.Drawing.Point(650, 12);
            this.label_SaldoCaja.Name = "label_SaldoCaja";
            this.label_SaldoCaja.Size = new System.Drawing.Size(136, 26);
            this.label_SaldoCaja.TabIndex = 3;
            this.label_SaldoCaja.Text = "Saldo: Cargando...";
            this.label_SaldoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // airSeparator1
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(0, 70);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(799, 2);
            this.airSeparator1.TabIndex = 1;
            this.airSeparator1.Transparent = false;

            // airSeparator2
            this.airSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.airSeparator2.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator2.Customization = "";
            this.airSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.airSeparator2.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator2.Image = null;
            this.airSeparator2.Location = new System.Drawing.Point(0, 72);
            this.airSeparator2.Name = "airSeparator2";
            this.airSeparator2.NoRounding = false;
            this.airSeparator2.Size = new System.Drawing.Size(799, 1);
            this.airSeparator2.TabIndex = 2;
            this.airSeparator2.Transparent = false;

            // ──────────────────────────────────────────────────────────────
            // panel_Contenido (scrollable content area)
            // ──────────────────────────────────────────────────────────────
            this.panel_Contenido.AutoScroll = true;
            this.panel_Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenido.Location = new System.Drawing.Point(0, 73);
            this.panel_Contenido.Name = "panel_Contenido";
            this.panel_Contenido.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panel_Contenido.Size = new System.Drawing.Size(799, 455);
            this.panel_Contenido.TabIndex = 3;
            this.panel_Contenido.Controls.Add(this.panel_AlertasStock);
            this.panel_Contenido.Controls.Add(this.panel_UltimasVentas);
            this.panel_Contenido.Controls.Add(this.panel_Cotizaciones);
            this.panel_Contenido.Controls.Add(this.panel_Inversion);
            this.panel_Contenido.Controls.Add(this.panel_KPI_Clientes);
            this.panel_Contenido.Controls.Add(this.panel_KPI_Stock);
            this.panel_Contenido.Controls.Add(this.panel_KPI_VentasMes);
            this.panel_Contenido.Controls.Add(this.panel_KPI_VentasHoy);

            // ══════════════════════════════════════════════════════════════
            // KPI CARD 1: Ventas Hoy (185 x 90)
            // ══════════════════════════════════════════════════════════════
            this.panel_KPI_VentasHoy.BackColor = System.Drawing.Color.White;
            this.panel_KPI_VentasHoy.Location = new System.Drawing.Point(16, 12);
            this.panel_KPI_VentasHoy.Name = "panel_KPI_VentasHoy";
            this.panel_KPI_VentasHoy.Size = new System.Drawing.Size(182, 88);
            this.panel_KPI_VentasHoy.TabIndex = 10;
            this.panel_KPI_VentasHoy.Controls.Add(this.label_KPI_VentasHoy_Icono);
            this.panel_KPI_VentasHoy.Controls.Add(this.label_KPI_VentasHoy_Titulo);
            this.panel_KPI_VentasHoy.Controls.Add(this.label_KPI_VentasHoy_Valor);
            this.panel_KPI_VentasHoy.Controls.Add(this.label_KPI_VentasHoy_Sub);

            this.label_KPI_VentasHoy_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.label_KPI_VentasHoy_Icono.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label_KPI_VentasHoy_Icono.Location = new System.Drawing.Point(10, 14);
            this.label_KPI_VentasHoy_Icono.Name = "label_KPI_VentasHoy_Icono";
            this.label_KPI_VentasHoy_Icono.Size = new System.Drawing.Size(40, 40);
            this.label_KPI_VentasHoy_Icono.Text = "💰";
            this.label_KPI_VentasHoy_Icono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_KPI_VentasHoy_Titulo.AutoSize = true;
            this.label_KPI_VentasHoy_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_KPI_VentasHoy_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_VentasHoy_Titulo.Location = new System.Drawing.Point(58, 10);
            this.label_KPI_VentasHoy_Titulo.Name = "label_KPI_VentasHoy_Titulo";
            this.label_KPI_VentasHoy_Titulo.Size = new System.Drawing.Size(70, 13);
            this.label_KPI_VentasHoy_Titulo.Text = "VENTAS HOY";

            this.label_KPI_VentasHoy_Valor.AutoSize = true;
            this.label_KPI_VentasHoy_Valor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_KPI_VentasHoy_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label_KPI_VentasHoy_Valor.Location = new System.Drawing.Point(56, 26);
            this.label_KPI_VentasHoy_Valor.Name = "label_KPI_VentasHoy_Valor";
            this.label_KPI_VentasHoy_Valor.Size = new System.Drawing.Size(30, 32);
            this.label_KPI_VentasHoy_Valor.Text = "—";

            this.label_KPI_VentasHoy_Sub.AutoSize = true;
            this.label_KPI_VentasHoy_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label_KPI_VentasHoy_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_VentasHoy_Sub.Location = new System.Drawing.Point(59, 62);
            this.label_KPI_VentasHoy_Sub.Name = "label_KPI_VentasHoy_Sub";
            this.label_KPI_VentasHoy_Sub.Size = new System.Drawing.Size(70, 13);
            this.label_KPI_VentasHoy_Sub.Text = "Cargando...";

            // ══════════════════════════════════════════════════════════════
            // KPI CARD 2: Ventas Mes
            // ══════════════════════════════════════════════════════════════
            this.panel_KPI_VentasMes.BackColor = System.Drawing.Color.White;
            this.panel_KPI_VentasMes.Location = new System.Drawing.Point(206, 12);
            this.panel_KPI_VentasMes.Name = "panel_KPI_VentasMes";
            this.panel_KPI_VentasMes.Size = new System.Drawing.Size(182, 88);
            this.panel_KPI_VentasMes.TabIndex = 11;
            this.panel_KPI_VentasMes.Controls.Add(this.label_KPI_VentasMes_Icono);
            this.panel_KPI_VentasMes.Controls.Add(this.label_KPI_VentasMes_Titulo);
            this.panel_KPI_VentasMes.Controls.Add(this.label_KPI_VentasMes_Valor);
            this.panel_KPI_VentasMes.Controls.Add(this.label_KPI_VentasMes_Sub);

            this.label_KPI_VentasMes_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_KPI_VentasMes_Icono.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label_KPI_VentasMes_Icono.Location = new System.Drawing.Point(10, 14);
            this.label_KPI_VentasMes_Icono.Name = "label_KPI_VentasMes_Icono";
            this.label_KPI_VentasMes_Icono.Size = new System.Drawing.Size(40, 40);
            this.label_KPI_VentasMes_Icono.Text = "📊";
            this.label_KPI_VentasMes_Icono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_KPI_VentasMes_Titulo.AutoSize = true;
            this.label_KPI_VentasMes_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_KPI_VentasMes_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_VentasMes_Titulo.Location = new System.Drawing.Point(58, 10);
            this.label_KPI_VentasMes_Titulo.Name = "label_KPI_VentasMes_Titulo";
            this.label_KPI_VentasMes_Titulo.Size = new System.Drawing.Size(75, 13);
            this.label_KPI_VentasMes_Titulo.Text = "VENTAS MES";

            this.label_KPI_VentasMes_Valor.AutoSize = true;
            this.label_KPI_VentasMes_Valor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_KPI_VentasMes_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label_KPI_VentasMes_Valor.Location = new System.Drawing.Point(56, 26);
            this.label_KPI_VentasMes_Valor.Name = "label_KPI_VentasMes_Valor";
            this.label_KPI_VentasMes_Valor.Size = new System.Drawing.Size(30, 32);
            this.label_KPI_VentasMes_Valor.Text = "—";

            this.label_KPI_VentasMes_Sub.AutoSize = true;
            this.label_KPI_VentasMes_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label_KPI_VentasMes_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_VentasMes_Sub.Location = new System.Drawing.Point(59, 62);
            this.label_KPI_VentasMes_Sub.Name = "label_KPI_VentasMes_Sub";
            this.label_KPI_VentasMes_Sub.Size = new System.Drawing.Size(70, 13);
            this.label_KPI_VentasMes_Sub.Text = "Cargando...";

            // ══════════════════════════════════════════════════════════════
            // KPI CARD 3: Stock
            // ══════════════════════════════════════════════════════════════
            this.panel_KPI_Stock.BackColor = System.Drawing.Color.White;
            this.panel_KPI_Stock.Location = new System.Drawing.Point(396, 12);
            this.panel_KPI_Stock.Name = "panel_KPI_Stock";
            this.panel_KPI_Stock.Size = new System.Drawing.Size(182, 88);
            this.panel_KPI_Stock.TabIndex = 12;
            this.panel_KPI_Stock.Controls.Add(this.label_KPI_Stock_Icono);
            this.panel_KPI_Stock.Controls.Add(this.label_KPI_Stock_Titulo);
            this.panel_KPI_Stock.Controls.Add(this.label_KPI_Stock_Valor);
            this.panel_KPI_Stock.Controls.Add(this.label_KPI_Stock_Sub);

            this.label_KPI_Stock_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.label_KPI_Stock_Icono.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label_KPI_Stock_Icono.Location = new System.Drawing.Point(10, 14);
            this.label_KPI_Stock_Icono.Name = "label_KPI_Stock_Icono";
            this.label_KPI_Stock_Icono.Size = new System.Drawing.Size(40, 40);
            this.label_KPI_Stock_Icono.Text = "📦";
            this.label_KPI_Stock_Icono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_KPI_Stock_Titulo.AutoSize = true;
            this.label_KPI_Stock_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_KPI_Stock_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_Stock_Titulo.Location = new System.Drawing.Point(58, 10);
            this.label_KPI_Stock_Titulo.Name = "label_KPI_Stock_Titulo";
            this.label_KPI_Stock_Titulo.Size = new System.Drawing.Size(65, 13);
            this.label_KPI_Stock_Titulo.Text = "PRODUCTOS";

            this.label_KPI_Stock_Valor.AutoSize = true;
            this.label_KPI_Stock_Valor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_KPI_Stock_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label_KPI_Stock_Valor.Location = new System.Drawing.Point(56, 26);
            this.label_KPI_Stock_Valor.Name = "label_KPI_Stock_Valor";
            this.label_KPI_Stock_Valor.Size = new System.Drawing.Size(30, 32);
            this.label_KPI_Stock_Valor.Text = "—";

            this.label_KPI_Stock_Sub.AutoSize = true;
            this.label_KPI_Stock_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label_KPI_Stock_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_Stock_Sub.Location = new System.Drawing.Point(59, 62);
            this.label_KPI_Stock_Sub.Name = "label_KPI_Stock_Sub";
            this.label_KPI_Stock_Sub.Size = new System.Drawing.Size(70, 13);
            this.label_KPI_Stock_Sub.Text = "Cargando...";

            // ══════════════════════════════════════════════════════════════
            // KPI CARD 4: Clientes
            // ══════════════════════════════════════════════════════════════
            this.panel_KPI_Clientes.BackColor = System.Drawing.Color.White;
            this.panel_KPI_Clientes.Location = new System.Drawing.Point(586, 12);
            this.panel_KPI_Clientes.Name = "panel_KPI_Clientes";
            this.panel_KPI_Clientes.Size = new System.Drawing.Size(182, 88);
            this.panel_KPI_Clientes.TabIndex = 13;
            this.panel_KPI_Clientes.Controls.Add(this.label_KPI_Clientes_Icono);
            this.panel_KPI_Clientes.Controls.Add(this.label_KPI_Clientes_Titulo);
            this.panel_KPI_Clientes.Controls.Add(this.label_KPI_Clientes_Valor);
            this.panel_KPI_Clientes.Controls.Add(this.label_KPI_Clientes_Sub);

            this.label_KPI_Clientes_Icono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.label_KPI_Clientes_Icono.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label_KPI_Clientes_Icono.Location = new System.Drawing.Point(10, 14);
            this.label_KPI_Clientes_Icono.Name = "label_KPI_Clientes_Icono";
            this.label_KPI_Clientes_Icono.Size = new System.Drawing.Size(40, 40);
            this.label_KPI_Clientes_Icono.Text = "👥";
            this.label_KPI_Clientes_Icono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_KPI_Clientes_Titulo.AutoSize = true;
            this.label_KPI_Clientes_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_KPI_Clientes_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_Clientes_Titulo.Location = new System.Drawing.Point(58, 10);
            this.label_KPI_Clientes_Titulo.Name = "label_KPI_Clientes_Titulo";
            this.label_KPI_Clientes_Titulo.Size = new System.Drawing.Size(60, 13);
            this.label_KPI_Clientes_Titulo.Text = "CLIENTES";

            this.label_KPI_Clientes_Valor.AutoSize = true;
            this.label_KPI_Clientes_Valor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_KPI_Clientes_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label_KPI_Clientes_Valor.Location = new System.Drawing.Point(56, 26);
            this.label_KPI_Clientes_Valor.Name = "label_KPI_Clientes_Valor";
            this.label_KPI_Clientes_Valor.Size = new System.Drawing.Size(30, 32);
            this.label_KPI_Clientes_Valor.Text = "—";

            this.label_KPI_Clientes_Sub.AutoSize = true;
            this.label_KPI_Clientes_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label_KPI_Clientes_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label_KPI_Clientes_Sub.Location = new System.Drawing.Point(59, 62);
            this.label_KPI_Clientes_Sub.Name = "label_KPI_Clientes_Sub";
            this.label_KPI_Clientes_Sub.Size = new System.Drawing.Size(70, 13);
            this.label_KPI_Clientes_Sub.Text = "Cargando...";

            // ══════════════════════════════════════════════════════════════
            // ROW 2: Panel Inversión (left - gradient blue)
            // ══════════════════════════════════════════════════════════════
            this.panel_Inversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.panel_Inversion.Location = new System.Drawing.Point(16, 110);
            this.panel_Inversion.Name = "panel_Inversion";
            this.panel_Inversion.Size = new System.Drawing.Size(372, 100);
            this.panel_Inversion.TabIndex = 20;
            this.panel_Inversion.Controls.Add(this.label_Inversion_Titulo);
            this.panel_Inversion.Controls.Add(this.label_Inversion_Valor);
            this.panel_Inversion.Controls.Add(this.label_Inversion_Sub);

            this.label_Inversion_Titulo.AutoSize = true;
            this.label_Inversion_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label_Inversion_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.label_Inversion_Titulo.Location = new System.Drawing.Point(16, 14);
            this.label_Inversion_Titulo.Name = "label_Inversion_Titulo";
            this.label_Inversion_Titulo.Size = new System.Drawing.Size(200, 13);
            this.label_Inversion_Titulo.Text = "INVERSIÓN TOTAL EN INVENTARIO";

            this.label_Inversion_Valor.AutoSize = true;
            this.label_Inversion_Valor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label_Inversion_Valor.ForeColor = System.Drawing.Color.White;
            this.label_Inversion_Valor.Location = new System.Drawing.Point(12, 34);
            this.label_Inversion_Valor.Name = "label_Inversion_Valor";
            this.label_Inversion_Valor.Size = new System.Drawing.Size(120, 45);
            this.label_Inversion_Valor.Text = "Cargando...";

            this.label_Inversion_Sub.AutoSize = true;
            this.label_Inversion_Sub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_Inversion_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.label_Inversion_Sub.Location = new System.Drawing.Point(16, 80);
            this.label_Inversion_Sub.Name = "label_Inversion_Sub";
            this.label_Inversion_Sub.Size = new System.Drawing.Size(180, 13);
            this.label_Inversion_Sub.Text = "Calculado sobre productos en stock";

            // ══════════════════════════════════════════════════════════════
            // ROW 2: Panel Cotizaciones (right)
            // ══════════════════════════════════════════════════════════════
            this.panel_Cotizaciones.BackColor = System.Drawing.Color.White;
            this.panel_Cotizaciones.Location = new System.Drawing.Point(396, 110);
            this.panel_Cotizaciones.Name = "panel_Cotizaciones";
            this.panel_Cotizaciones.Size = new System.Drawing.Size(372, 100);
            this.panel_Cotizaciones.TabIndex = 21;
            this.panel_Cotizaciones.Controls.Add(this.label_Cotizaciones_Titulo);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarOficial);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarOficial_Valor);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarBlue);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarBlue_Valor);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarTarjeta);
            this.panel_Cotizaciones.Controls.Add(this.label_DolarTarjeta_Valor);

            this.label_Cotizaciones_Titulo.AutoSize = true;
            this.label_Cotizaciones_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label_Cotizaciones_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label_Cotizaciones_Titulo.Location = new System.Drawing.Point(14, 10);
            this.label_Cotizaciones_Titulo.Name = "label_Cotizaciones_Titulo";
            this.label_Cotizaciones_Titulo.Size = new System.Drawing.Size(140, 13);
            this.label_Cotizaciones_Titulo.Text = "COTIZACIÓN DEL DÓLAR";

            // Dolar Oficial
            this.label_DolarOficial.AutoSize = true;
            this.label_DolarOficial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DolarOficial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_DolarOficial.Location = new System.Drawing.Point(14, 34);
            this.label_DolarOficial.Name = "label_DolarOficial";
            this.label_DolarOficial.Size = new System.Drawing.Size(80, 15);
            this.label_DolarOficial.Text = "Dólar Oficial";

            this.label_DolarOficial_Valor.AutoSize = true;
            this.label_DolarOficial_Valor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label_DolarOficial_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.label_DolarOficial_Valor.Location = new System.Drawing.Point(260, 32);
            this.label_DolarOficial_Valor.Name = "label_DolarOficial_Valor";
            this.label_DolarOficial_Valor.Size = new System.Drawing.Size(90, 20);
            this.label_DolarOficial_Valor.Text = "Cargando...";
            this.label_DolarOficial_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            // Dolar Blue
            this.label_DolarBlue.AutoSize = true;
            this.label_DolarBlue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DolarBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_DolarBlue.Location = new System.Drawing.Point(14, 56);
            this.label_DolarBlue.Name = "label_DolarBlue";
            this.label_DolarBlue.Size = new System.Drawing.Size(70, 15);
            this.label_DolarBlue.Text = "Dólar Blue";

            this.label_DolarBlue_Valor.AutoSize = true;
            this.label_DolarBlue_Valor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label_DolarBlue_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label_DolarBlue_Valor.Location = new System.Drawing.Point(260, 54);
            this.label_DolarBlue_Valor.Name = "label_DolarBlue_Valor";
            this.label_DolarBlue_Valor.Size = new System.Drawing.Size(90, 20);
            this.label_DolarBlue_Valor.Text = "Cargando...";
            this.label_DolarBlue_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            // Dolar Tarjeta
            this.label_DolarTarjeta.AutoSize = true;
            this.label_DolarTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_DolarTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_DolarTarjeta.Location = new System.Drawing.Point(14, 78);
            this.label_DolarTarjeta.Name = "label_DolarTarjeta";
            this.label_DolarTarjeta.Size = new System.Drawing.Size(80, 15);
            this.label_DolarTarjeta.Text = "Dólar Tarjeta";

            this.label_DolarTarjeta_Valor.AutoSize = true;
            this.label_DolarTarjeta_Valor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label_DolarTarjeta_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.label_DolarTarjeta_Valor.Location = new System.Drawing.Point(260, 76);
            this.label_DolarTarjeta_Valor.Name = "label_DolarTarjeta_Valor";
            this.label_DolarTarjeta_Valor.Size = new System.Drawing.Size(90, 20);
            this.label_DolarTarjeta_Valor.Text = "Cargando...";
            this.label_DolarTarjeta_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            // ══════════════════════════════════════════════════════════════
            // ROW 3: Últimas Ventas (DataGridView)
            // ══════════════════════════════════════════════════════════════
            this.panel_UltimasVentas.BackColor = System.Drawing.Color.White;
            this.panel_UltimasVentas.Location = new System.Drawing.Point(16, 220);
            this.panel_UltimasVentas.Name = "panel_UltimasVentas";
            this.panel_UltimasVentas.Size = new System.Drawing.Size(490, 200);
            this.panel_UltimasVentas.TabIndex = 30;
            this.panel_UltimasVentas.Controls.Add(this.label_UltimasVentas_Titulo);
            this.panel_UltimasVentas.Controls.Add(this.dgv_UltimasVentas);

            this.label_UltimasVentas_Titulo.AutoSize = true;
            this.label_UltimasVentas_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label_UltimasVentas_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label_UltimasVentas_Titulo.Location = new System.Drawing.Point(14, 10);
            this.label_UltimasVentas_Titulo.Name = "label_UltimasVentas_Titulo";
            this.label_UltimasVentas_Titulo.Size = new System.Drawing.Size(110, 13);
            this.label_UltimasVentas_Titulo.Text = "ÚLTIMAS VENTAS";

            // dgv_UltimasVentas
            this.dgv_UltimasVentas.AllowUserToAddRows = false;
            this.dgv_UltimasVentas.AllowUserToDeleteRows = false;
            this.dgv_UltimasVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_UltimasVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UltimasVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_UltimasVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_UltimasVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UltimasVentas.Location = new System.Drawing.Point(8, 32);
            this.dgv_UltimasVentas.Name = "dgv_UltimasVentas";
            this.dgv_UltimasVentas.ReadOnly = true;
            this.dgv_UltimasVentas.RowHeadersVisible = false;
            this.dgv_UltimasVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UltimasVentas.Size = new System.Drawing.Size(474, 158);
            this.dgv_UltimasVentas.TabIndex = 1;

            // ══════════════════════════════════════════════════════════════
            // ROW 3: Alertas de Stock (right)
            // ══════════════════════════════════════════════════════════════
            this.panel_AlertasStock.BackColor = System.Drawing.Color.White;
            this.panel_AlertasStock.Location = new System.Drawing.Point(514, 220);
            this.panel_AlertasStock.Name = "panel_AlertasStock";
            this.panel_AlertasStock.Size = new System.Drawing.Size(254, 200);
            this.panel_AlertasStock.TabIndex = 31;
            this.panel_AlertasStock.Controls.Add(this.label_AlertasStock_Titulo);
            this.panel_AlertasStock.Controls.Add(this.panel_Alerta_SinStock);
            this.panel_AlertasStock.Controls.Add(this.panel_Alerta_StockBajo);
            this.panel_AlertasStock.Controls.Add(this.panel_Alerta_StockOk);

            this.label_AlertasStock_Titulo.AutoSize = true;
            this.label_AlertasStock_Titulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label_AlertasStock_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label_AlertasStock_Titulo.Location = new System.Drawing.Point(14, 10);
            this.label_AlertasStock_Titulo.Name = "label_AlertasStock_Titulo";
            this.label_AlertasStock_Titulo.Size = new System.Drawing.Size(110, 13);
            this.label_AlertasStock_Titulo.Text = "ALERTAS DE STOCK";

            // Sin Stock alert
            this.panel_Alerta_SinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_Alerta_SinStock.Location = new System.Drawing.Point(10, 34);
            this.panel_Alerta_SinStock.Name = "panel_Alerta_SinStock";
            this.panel_Alerta_SinStock.Size = new System.Drawing.Size(232, 48);
            this.panel_Alerta_SinStock.TabIndex = 0;
            this.panel_Alerta_SinStock.Controls.Add(this.label_SinStock_Valor);
            this.panel_Alerta_SinStock.Controls.Add(this.label_SinStock_Texto);

            this.label_SinStock_Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label_SinStock_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label_SinStock_Valor.Location = new System.Drawing.Point(10, 6);
            this.label_SinStock_Valor.Name = "label_SinStock_Valor";
            this.label_SinStock_Valor.Size = new System.Drawing.Size(50, 34);
            this.label_SinStock_Valor.Text = "—";
            this.label_SinStock_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_SinStock_Texto.AutoSize = true;
            this.label_SinStock_Texto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_SinStock_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.label_SinStock_Texto.Location = new System.Drawing.Point(64, 16);
            this.label_SinStock_Texto.Name = "label_SinStock_Texto";
            this.label_SinStock_Texto.Size = new System.Drawing.Size(120, 15);
            this.label_SinStock_Texto.Text = "Productos sin stock";

            // Stock Bajo alert
            this.panel_Alerta_StockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.panel_Alerta_StockBajo.Location = new System.Drawing.Point(10, 88);
            this.panel_Alerta_StockBajo.Name = "panel_Alerta_StockBajo";
            this.panel_Alerta_StockBajo.Size = new System.Drawing.Size(232, 48);
            this.panel_Alerta_StockBajo.TabIndex = 1;
            this.panel_Alerta_StockBajo.Controls.Add(this.label_StockBajo_Valor);
            this.panel_Alerta_StockBajo.Controls.Add(this.label_StockBajo_Texto);

            this.label_StockBajo_Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label_StockBajo_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.label_StockBajo_Valor.Location = new System.Drawing.Point(10, 6);
            this.label_StockBajo_Valor.Name = "label_StockBajo_Valor";
            this.label_StockBajo_Valor.Size = new System.Drawing.Size(50, 34);
            this.label_StockBajo_Valor.Text = "—";
            this.label_StockBajo_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_StockBajo_Texto.AutoSize = true;
            this.label_StockBajo_Texto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_StockBajo_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.label_StockBajo_Texto.Location = new System.Drawing.Point(64, 16);
            this.label_StockBajo_Texto.Name = "label_StockBajo_Texto";
            this.label_StockBajo_Texto.Size = new System.Drawing.Size(140, 15);
            this.label_StockBajo_Texto.Text = "Productos con stock bajo";

            // Stock OK alert
            this.panel_Alerta_StockOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.panel_Alerta_StockOk.Location = new System.Drawing.Point(10, 142);
            this.panel_Alerta_StockOk.Name = "panel_Alerta_StockOk";
            this.panel_Alerta_StockOk.Size = new System.Drawing.Size(232, 48);
            this.panel_Alerta_StockOk.TabIndex = 2;
            this.panel_Alerta_StockOk.Controls.Add(this.label_StockOk_Valor);
            this.panel_Alerta_StockOk.Controls.Add(this.label_StockOk_Texto);

            this.label_StockOk_Valor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label_StockOk_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.label_StockOk_Valor.Location = new System.Drawing.Point(10, 6);
            this.label_StockOk_Valor.Name = "label_StockOk_Valor";
            this.label_StockOk_Valor.Size = new System.Drawing.Size(50, 34);
            this.label_StockOk_Valor.Text = "—";
            this.label_StockOk_Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label_StockOk_Texto.AutoSize = true;
            this.label_StockOk_Texto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_StockOk_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.label_StockOk_Texto.Location = new System.Drawing.Point(64, 16);
            this.label_StockOk_Texto.Name = "label_StockOk_Texto";
            this.label_StockOk_Texto.Size = new System.Drawing.Size(100, 15);
            this.label_StockOk_Texto.Text = "Productos OK";

            // ══════════════════════════════════════════════════════════════
            // Loading indicator
            // ══════════════════════════════════════════════════════════════
            this.pictureBox_Cargando.Location = new System.Drawing.Point(370, 240);
            this.pictureBox_Cargando.Name = "pictureBox_Cargando";
            this.pictureBox_Cargando.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_Cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Cargando.TabIndex = 50;
            this.pictureBox_Cargando.TabStop = false;
            this.pictureBox_Cargando.Visible = false;

            this.label_Cargando.AutoSize = true;
            this.label_Cargando.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_Cargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label_Cargando.Location = new System.Drawing.Point(350, 305);
            this.label_Cargando.Name = "label_Cargando";
            this.label_Cargando.Size = new System.Drawing.Size(100, 19);
            this.label_Cargando.Text = "Cargando datos...";
            this.label_Cargando.Visible = false;

            // ══════════════════════════════════════════════════════════════
            // DashBoard Form
            // ══════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.pictureBox_Cargando);
            this.Controls.Add(this.label_Cargando);
            this.Controls.Add(this.panel_Contenido);
            this.Controls.Add(this.airSeparator2);
            this.Controls.Add(this.airSeparator1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);

            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_KPI_VentasHoy.ResumeLayout(false);
            this.panel_KPI_VentasHoy.PerformLayout();
            this.panel_KPI_VentasMes.ResumeLayout(false);
            this.panel_KPI_VentasMes.PerformLayout();
            this.panel_KPI_Stock.ResumeLayout(false);
            this.panel_KPI_Stock.PerformLayout();
            this.panel_KPI_Clientes.ResumeLayout(false);
            this.panel_KPI_Clientes.PerformLayout();
            this.panel_Inversion.ResumeLayout(false);
            this.panel_Inversion.PerformLayout();
            this.panel_Cotizaciones.ResumeLayout(false);
            this.panel_Cotizaciones.PerformLayout();
            this.panel_UltimasVentas.ResumeLayout(false);
            this.panel_UltimasVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UltimasVentas)).EndInit();
            this.panel_AlertasStock.ResumeLayout(false);
            this.panel_AlertasStock.PerformLayout();
            this.panel_Alerta_SinStock.ResumeLayout(false);
            this.panel_Alerta_SinStock.PerformLayout();
            this.panel_Alerta_StockBajo.ResumeLayout(false);
            this.panel_Alerta_StockBajo.PerformLayout();
            this.panel_Alerta_StockOk.ResumeLayout(false);
            this.panel_Alerta_StockOk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).EndInit();
            this.panel_Contenido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Header
        private System.Windows.Forms.Panel panel_Header;
        private ReaLTaiizor.Controls.BigLabel label_Titulo;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.Label label_EstadoCaja;
        private System.Windows.Forms.Label label_SaldoCaja;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;

        // Content area
        private System.Windows.Forms.Panel panel_Contenido;

        // KPI Cards
        private System.Windows.Forms.Panel panel_KPI_VentasHoy;
        private System.Windows.Forms.Label label_KPI_VentasHoy_Titulo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_KPI_VentasHoy_Valor;
        private System.Windows.Forms.Label label_KPI_VentasHoy_Sub;
        private System.Windows.Forms.Label label_KPI_VentasHoy_Icono;

        private System.Windows.Forms.Panel panel_KPI_VentasMes;
        private System.Windows.Forms.Label label_KPI_VentasMes_Titulo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_KPI_VentasMes_Valor;
        private System.Windows.Forms.Label label_KPI_VentasMes_Sub;
        private System.Windows.Forms.Label label_KPI_VentasMes_Icono;

        private System.Windows.Forms.Panel panel_KPI_Stock;
        private System.Windows.Forms.Label label_KPI_Stock_Titulo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_KPI_Stock_Valor;
        private System.Windows.Forms.Label label_KPI_Stock_Sub;
        private System.Windows.Forms.Label label_KPI_Stock_Icono;

        private System.Windows.Forms.Panel panel_KPI_Clientes;
        private System.Windows.Forms.Label label_KPI_Clientes_Titulo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_KPI_Clientes_Valor;
        private System.Windows.Forms.Label label_KPI_Clientes_Sub;
        private System.Windows.Forms.Label label_KPI_Clientes_Icono;

        // Inversión
        private System.Windows.Forms.Panel panel_Inversion;
        private System.Windows.Forms.Label label_Inversion_Titulo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_Inversion_Valor;
        private System.Windows.Forms.Label label_Inversion_Sub;

        // Cotizaciones
        private System.Windows.Forms.Panel panel_Cotizaciones;
        private System.Windows.Forms.Label label_Cotizaciones_Titulo;
        private System.Windows.Forms.Label label_DolarOficial;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_DolarOficial_Valor;
        private System.Windows.Forms.Label label_DolarBlue;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_DolarBlue_Valor;
        private System.Windows.Forms.Label label_DolarTarjeta;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_DolarTarjeta_Valor;

        // Últimas Ventas
        private System.Windows.Forms.Panel panel_UltimasVentas;
        private System.Windows.Forms.Label label_UltimasVentas_Titulo;
        private ReaLTaiizor.Controls.PoisonDataGridView dgv_UltimasVentas;

        // Alertas Stock
        private System.Windows.Forms.Panel panel_AlertasStock;
        private System.Windows.Forms.Label label_AlertasStock_Titulo;
        private System.Windows.Forms.Panel panel_Alerta_SinStock;
        private System.Windows.Forms.Label label_SinStock_Valor;
        private System.Windows.Forms.Label label_SinStock_Texto;
        private System.Windows.Forms.Panel panel_Alerta_StockBajo;
        private System.Windows.Forms.Label label_StockBajo_Valor;
        private System.Windows.Forms.Label label_StockBajo_Texto;
        private System.Windows.Forms.Panel panel_Alerta_StockOk;
        private System.Windows.Forms.Label label_StockOk_Valor;
        private System.Windows.Forms.Label label_StockOk_Texto;

        // Loading
        private System.Windows.Forms.PictureBox pictureBox_Cargando;
        private System.Windows.Forms.Label label_Cargando;
    }
}
