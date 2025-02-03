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
            this.materialCard_ContenedorDataGreed = new ReaLTaiizor.Controls.MaterialCard();
            this.poisonDataGridView_Stock = new ReaLTaiizor.Controls.PoisonDataGridView();
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
            this.Columni_Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ventas.SuspendLayout();
            this.materialCard_ContenedorDataGreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.White;
            this.Ventas.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            // materialCard_ContenedorDataGreed
            // 
            this.materialCard_ContenedorDataGreed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_ContenedorDataGreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_ContenedorDataGreed.Controls.Add(this.poisonDataGridView_Stock);
            this.materialCard_ContenedorDataGreed.Depth = 0;
            this.materialCard_ContenedorDataGreed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_ContenedorDataGreed.Location = new System.Drawing.Point(23, 23);
            this.materialCard_ContenedorDataGreed.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard_ContenedorDataGreed.Name = "materialCard_ContenedorDataGreed";
            this.materialCard_ContenedorDataGreed.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.Size = new System.Drawing.Size(999, 534);
            this.materialCard_ContenedorDataGreed.TabIndex = 1;
            // 
            // poisonDataGridView_Stock
            // 
            this.poisonDataGridView_Stock.AllowUserToAddRows = false;
            this.poisonDataGridView_Stock.AllowUserToResizeRows = false;
            this.poisonDataGridView_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView_Stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_Stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Columni_Imprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_Stock.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_Stock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_Stock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Stock.Location = new System.Drawing.Point(14, 14);
            this.poisonDataGridView_Stock.Name = "poisonDataGridView_Stock";
            this.poisonDataGridView_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_Stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.poisonDataGridView_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_Stock.ShowRowErrors = false;
            this.poisonDataGridView_Stock.Size = new System.Drawing.Size(968, 503);
            this.poisonDataGridView_Stock.TabIndex = 0;
            this.poisonDataGridView_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_Stock_CellContentClick);
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
            this.Column_Borrar.Name = "Column_Borrar";
            // 
            // Columni_Imprimir
            // 
            this.Columni_Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columni_Imprimir.HeaderText = "Imprimir";
            this.Columni_Imprimir.Name = "Columni_Imprimir";
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
            this.materialCard_ContenedorDataGreed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm Ventas;
        private ReaLTaiizor.Controls.MaterialCard materialCard_ContenedorDataGreed;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_Stock;
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
        private System.Windows.Forms.DataGridViewImageColumn Columni_Imprimir;
    }
}