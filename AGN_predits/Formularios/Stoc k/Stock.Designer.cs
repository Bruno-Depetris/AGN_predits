namespace AGN_predits.Formularios.Stoc_k {
    partial class Stock {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.materialCard_ContenedorDataGreed = new ReaLTaiizor.Controls.MaterialCard();
            this.poisonDataGridView_Stock = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.pictureBox_Cargando = new System.Windows.Forms.PictureBox();
            this.label_Cargando = new System.Windows.Forms.Label();
            this.Column_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Bateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard_ContenedorDataGreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).BeginInit();
            this.SuspendLayout();
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
            this.materialCard_ContenedorDataGreed.Size = new System.Drawing.Size(753, 440);
            this.materialCard_ContenedorDataGreed.TabIndex = 0;
            // 
            // poisonDataGridView_Stock
            // 
            this.poisonDataGridView_Stock.AllowUserToAddRows = false;
            this.poisonDataGridView_Stock.AllowUserToResizeRows = false;
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
            this.Column_ProductoID,
            this.Column_Marca,
            this.Column_Modelo,
            this.Column_Condicion,
            this.Column_Almacenamiento,
            this.Column_Bateria,
            this.Column_Descripcion,
            this.Column_Email,
            this.Column_Stock,
            this.Column_PrecioCosto,
            this.Column_Venta,
            this.Column_Editar,
            this.Column_Borrar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.poisonDataGridView_Stock.Size = new System.Drawing.Size(725, 412);
            this.poisonDataGridView_Stock.TabIndex = 0;
            this.poisonDataGridView_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_Stock_CellContentClick);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(23, 483);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(239, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Cargar Nuevo Producto";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pictureBox_Cargando
            // 
            this.pictureBox_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Cargando.Location = new System.Drawing.Point(269, 484);
            this.pictureBox_Cargando.Name = "pictureBox_Cargando";
            this.pictureBox_Cargando.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Cargando.TabIndex = 2;
            this.pictureBox_Cargando.TabStop = false;
            // 
            // label_Cargando
            // 
            this.label_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Cargando.AutoSize = true;
            this.label_Cargando.Location = new System.Drawing.Point(310, 495);
            this.label_Cargando.Name = "label_Cargando";
            this.label_Cargando.Size = new System.Drawing.Size(62, 13);
            this.label_Cargando.TabIndex = 3;
            this.label_Cargando.Text = "Cargando...";
            // 
            // Column_Borrar
            // 
            this.Column_Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Borrar.HeaderText = "Borrar";
            this.Column_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Borrar.Image")));
            this.Column_Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Borrar.Name = "Column_Borrar";
            this.Column_Borrar.ReadOnly = true;
            // 
            // Column_Editar
            // 
            this.Column_Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Editar.HeaderText = "Editar";
            this.Column_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Editar.Image")));
            this.Column_Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Editar.Name = "Column_Editar";
            this.Column_Editar.ReadOnly = true;
            // 
            // Column_Venta
            // 
            this.Column_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Venta.HeaderText = "Venta";
            this.Column_Venta.Name = "Column_Venta";
            // 
            // Column_PrecioCosto
            // 
            this.Column_PrecioCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PrecioCosto.HeaderText = "Costo";
            this.Column_PrecioCosto.Name = "Column_PrecioCosto";
            // 
            // Column_Stock
            // 
            this.Column_Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Stock.HeaderText = "Stock";
            this.Column_Stock.Name = "Column_Stock";
            this.Column_Stock.ReadOnly = true;
            // 
            // Column_Email
            // 
            this.Column_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Email.HeaderText = "Email";
            this.Column_Email.Name = "Column_Email";
            // 
            // Column_Descripcion
            // 
            this.Column_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Descripcion.HeaderText = "Descripcion";
            this.Column_Descripcion.Name = "Column_Descripcion";
            // 
            // Column_Bateria
            // 
            this.Column_Bateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Bateria.HeaderText = "Bateria";
            this.Column_Bateria.Name = "Column_Bateria";
            // 
            // Column_Almacenamiento
            // 
            this.Column_Almacenamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Almacenamiento.HeaderText = "Almacenamiento";
            this.Column_Almacenamiento.Name = "Column_Almacenamiento";
            // 
            // Column_Condicion
            // 
            this.Column_Condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Condicion.HeaderText = "Condicion";
            this.Column_Condicion.Name = "Column_Condicion";
            // 
            // Column_Modelo
            // 
            this.Column_Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Modelo.HeaderText = "Modelo";
            this.Column_Modelo.Name = "Column_Modelo";
            // 
            // Column_Marca
            // 
            this.Column_Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Marca.HeaderText = "Marca";
            this.Column_Marca.Name = "Column_Marca";
            // 
            // Column_ProductoID
            // 
            this.Column_ProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ProductoID.HeaderText = "ProductoID";
            this.Column_ProductoID.Name = "Column_ProductoID";
            this.Column_ProductoID.Visible = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.label_Cargando);
            this.Controls.Add(this.pictureBox_Cargando);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialCard_ContenedorDataGreed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.materialCard_ContenedorDataGreed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard_ContenedorDataGreed;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_Stock;
        private System.Windows.Forms.PictureBox pictureBox_Cargando;
        private System.Windows.Forms.Label label_Cargando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Bateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Venta;
        private System.Windows.Forms.DataGridViewImageColumn Column_Editar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Borrar;
    }
}