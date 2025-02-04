namespace AGN_predits.Formularios.Vender {
    partial class Lista_Ventas {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Ventas));
            this.Ventas = new ReaLTaiizor.Forms.AirForm();
            this.label_Cargando = new System.Windows.Forms.Label();
            this.pictureBox_Cargando = new System.Windows.Forms.PictureBox();
            this.materialCard_ContenedorDataGreed = new ReaLTaiizor.Controls.MaterialCard();
            this.poisonDataGridView_Ventas = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column_ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MedioPagoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DetalleVentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).BeginInit();
            this.materialCard_ContenedorDataGreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.White;
            this.Ventas.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Ventas.Controls.Add(this.label_Cargando);
            this.Ventas.Controls.Add(this.pictureBox_Cargando);
            this.Ventas.Controls.Add(this.materialCard_ContenedorDataGreed);
            this.Ventas.Customization = "AAAA/1paWv9ycnL/";
            this.Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ventas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ventas.Image = null;
            this.Ventas.Location = new System.Drawing.Point(0, 0);
            this.Ventas.MinimumSize = new System.Drawing.Size(112, 35);
            this.Ventas.Movable = true;
            this.Ventas.Name = "Ventas";
            this.Ventas.NoRounding = false;
            this.Ventas.Sizable = true;
            this.Ventas.Size = new System.Drawing.Size(1045, 580);
            this.Ventas.SmartBounds = true;
            this.Ventas.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Ventas.TabIndex = 0;
            this.Ventas.Text = "Ventas";
            this.Ventas.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Ventas.Transparent = false;
            // 
            // label_Cargando
            // 
            this.label_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Cargando.AutoSize = true;
            this.label_Cargando.Location = new System.Drawing.Point(64, 553);
            this.label_Cargando.Name = "label_Cargando";
            this.label_Cargando.Size = new System.Drawing.Size(68, 15);
            this.label_Cargando.TabIndex = 5;
            this.label_Cargando.Text = "Cargando...";
            // 
            // pictureBox_Cargando
            // 
            this.pictureBox_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Cargando.Location = new System.Drawing.Point(23, 542);
            this.pictureBox_Cargando.Name = "pictureBox_Cargando";
            this.pictureBox_Cargando.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Cargando.TabIndex = 4;
            this.pictureBox_Cargando.TabStop = false;
            // 
            // materialCard_ContenedorDataGreed
            // 
            this.materialCard_ContenedorDataGreed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_ContenedorDataGreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_ContenedorDataGreed.Controls.Add(this.poisonDataGridView_Ventas);
            this.materialCard_ContenedorDataGreed.Depth = 0;
            this.materialCard_ContenedorDataGreed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_ContenedorDataGreed.Location = new System.Drawing.Point(23, 23);
            this.materialCard_ContenedorDataGreed.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard_ContenedorDataGreed.Name = "materialCard_ContenedorDataGreed";
            this.materialCard_ContenedorDataGreed.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.Size = new System.Drawing.Size(999, 514);
            this.materialCard_ContenedorDataGreed.TabIndex = 1;
            // 
            // poisonDataGridView_Ventas
            // 
            this.poisonDataGridView_Ventas.AllowUserToAddRows = false;
            this.poisonDataGridView_Ventas.AllowUserToResizeRows = false;
            this.poisonDataGridView_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_Ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClienteID,
            this.Column_ProductoID,
            this.Column_MedioPagoID,
            this.Column_Fecha,
            this.Column_DetalleVentaID,
            this.Column_Cliente,
            this.Column_Producto,
            this.Column_MedioPago,
            this.Column_Plan,
            this.Column_Cuotas,
            this.Column_Detalles,
            this.Column_Borrar,
            this.Column_Imprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_Ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_Ventas.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_Ventas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_Ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Ventas.Location = new System.Drawing.Point(14, 14);
            this.poisonDataGridView_Ventas.Name = "poisonDataGridView_Ventas";
            this.poisonDataGridView_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Ventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_Ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.poisonDataGridView_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_Ventas.ShowRowErrors = false;
            this.poisonDataGridView_Ventas.Size = new System.Drawing.Size(968, 483);
            this.poisonDataGridView_Ventas.TabIndex = 0;
            this.poisonDataGridView_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_Ventas_CellContentClick);
            // 
            // Column_ClienteID
            // 
            this.Column_ClienteID.HeaderText = "ClienteID";
            this.Column_ClienteID.Name = "Column_ClienteID";
            this.Column_ClienteID.Visible = false;
            // 
            // Column_ProductoID
            // 
            this.Column_ProductoID.HeaderText = "ProductoID";
            this.Column_ProductoID.Name = "Column_ProductoID";
            this.Column_ProductoID.Visible = false;
            // 
            // Column_MedioPagoID
            // 
            this.Column_MedioPagoID.HeaderText = "MedioPagoID";
            this.Column_MedioPagoID.Name = "Column_MedioPagoID";
            this.Column_MedioPagoID.Visible = false;
            // 
            // Column_Fecha
            // 
            this.Column_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Fecha.HeaderText = "Fecha";
            this.Column_Fecha.Name = "Column_Fecha";
            // 
            // Column_DetalleVentaID
            // 
            this.Column_DetalleVentaID.HeaderText = "ID Venta";
            this.Column_DetalleVentaID.Name = "Column_DetalleVentaID";
            // 
            // Column_Cliente
            // 
            this.Column_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Cliente.HeaderText = "Cliente";
            this.Column_Cliente.Name = "Column_Cliente";
            // 
            // Column_Producto
            // 
            this.Column_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Producto.HeaderText = "Producto";
            this.Column_Producto.Name = "Column_Producto";
            // 
            // Column_MedioPago
            // 
            this.Column_MedioPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_MedioPago.HeaderText = "Forma Pago";
            this.Column_MedioPago.Name = "Column_MedioPago";
            // 
            // Column_Plan
            // 
            this.Column_Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Plan.HeaderText = "Plan";
            this.Column_Plan.Name = "Column_Plan";
            // 
            // Column_Cuotas
            // 
            this.Column_Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Cuotas.HeaderText = "Cuotas";
            this.Column_Cuotas.Name = "Column_Cuotas";
            // 
            // Column_Detalles
            // 
            this.Column_Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Detalles.HeaderText = "Detalles";
            this.Column_Detalles.Name = "Column_Detalles";
            // 
            // Column_Borrar
            // 
            this.Column_Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Borrar.HeaderText = "Borrar";
            this.Column_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Borrar.Image")));
            this.Column_Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Borrar.Name = "Column_Borrar";
            // 
            // Column_Imprimir
            // 
            this.Column_Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Imprimir.HeaderText = "Imprimir";
            this.Column_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Column_Imprimir.Image")));
            this.Column_Imprimir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Imprimir.Name = "Column_Imprimir";
            // 
            // Lista_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 580);
            this.Controls.Add(this.Ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Lista_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Lista_Ventas_Load);
            this.Ventas.ResumeLayout(false);
            this.Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).EndInit();
            this.materialCard_ContenedorDataGreed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm Ventas;
        private ReaLTaiizor.Controls.MaterialCard materialCard_ContenedorDataGreed;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_Ventas;
        private System.Windows.Forms.Label label_Cargando;
        private System.Windows.Forms.PictureBox pictureBox_Cargando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MedioPagoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DetalleVentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Detalles;
        private System.Windows.Forms.DataGridViewImageColumn Column_Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Imprimir;
    }
}