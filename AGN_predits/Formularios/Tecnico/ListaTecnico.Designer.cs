namespace AGN_predits.Formularios.Tecnico {
    partial class ListaTecnico {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTecnico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Cargando = new System.Windows.Forms.Label();
            this.pictureBox_Cargando = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialCard_ContenedorDataGreed = new ReaLTaiizor.Controls.MaterialCard();
            this.poisonDataGridView_StockTecnico = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column_TecnicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Bateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PrecioArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Reparado = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).BeginInit();
            this.materialCard_ContenedorDataGreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_StockTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Cargando
            // 
            this.label_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Cargando.AutoSize = true;
            this.label_Cargando.BackColor = System.Drawing.Color.Transparent;
            this.label_Cargando.ForeColor = System.Drawing.Color.Black;
            this.label_Cargando.Location = new System.Drawing.Point(310, 488);
            this.label_Cargando.Name = "label_Cargando";
            this.label_Cargando.Size = new System.Drawing.Size(62, 13);
            this.label_Cargando.TabIndex = 7;
            this.label_Cargando.Text = "Cargando...";
            // 
            // pictureBox_Cargando
            // 
            this.pictureBox_Cargando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Cargando.Location = new System.Drawing.Point(269, 477);
            this.pictureBox_Cargando.Name = "pictureBox_Cargando";
            this.pictureBox_Cargando.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Cargando.TabIndex = 6;
            this.pictureBox_Cargando.TabStop = false;
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
            this.materialButton1.Location = new System.Drawing.Point(23, 476);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(239, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Cargar Nuevo Producto";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialCard_ContenedorDataGreed
            // 
            this.materialCard_ContenedorDataGreed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_ContenedorDataGreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_ContenedorDataGreed.Controls.Add(this.poisonDataGridView_StockTecnico);
            this.materialCard_ContenedorDataGreed.Depth = 0;
            this.materialCard_ContenedorDataGreed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_ContenedorDataGreed.Location = new System.Drawing.Point(23, 16);
            this.materialCard_ContenedorDataGreed.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard_ContenedorDataGreed.Name = "materialCard_ContenedorDataGreed";
            this.materialCard_ContenedorDataGreed.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_ContenedorDataGreed.Size = new System.Drawing.Size(753, 440);
            this.materialCard_ContenedorDataGreed.TabIndex = 4;
            // 
            // poisonDataGridView_StockTecnico
            // 
            this.poisonDataGridView_StockTecnico.AllowUserToAddRows = false;
            this.poisonDataGridView_StockTecnico.AllowUserToResizeRows = false;
            this.poisonDataGridView_StockTecnico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_StockTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_StockTecnico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_StockTecnico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_StockTecnico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_StockTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_StockTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_TecnicoID,
            this.Column_Marca,
            this.Column_Modelo,
            this.Column_Almacenamiento,
            this.Column_Bateria,
            this.Column_Falla,
            this.Column_Email,
            this.Column_PrecioArreglo,
            this.Column_Costo,
            this.Column_Editar,
            this.Column_Borrar,
            this.Column_Reparado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_StockTecnico.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_StockTecnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonDataGridView_StockTecnico.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_StockTecnico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_StockTecnico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_StockTecnico.Location = new System.Drawing.Point(14, 14);
            this.poisonDataGridView_StockTecnico.Name = "poisonDataGridView_StockTecnico";
            this.poisonDataGridView_StockTecnico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_StockTecnico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_StockTecnico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.poisonDataGridView_StockTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_StockTecnico.ShowRowErrors = false;
            this.poisonDataGridView_StockTecnico.Size = new System.Drawing.Size(725, 412);
            this.poisonDataGridView_StockTecnico.TabIndex = 0;
            this.poisonDataGridView_StockTecnico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_StockTecnico_CellContentClick);
            // 
            // Column_TecnicoID
            // 
            this.Column_TecnicoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_TecnicoID.HeaderText = "TecnicoID";
            this.Column_TecnicoID.Name = "Column_TecnicoID";
            this.Column_TecnicoID.Visible = false;
            // 
            // Column_Marca
            // 
            this.Column_Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Marca.HeaderText = "Marca";
            this.Column_Marca.Name = "Column_Marca";
            // 
            // Column_Modelo
            // 
            this.Column_Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Modelo.HeaderText = "Modelo";
            this.Column_Modelo.Name = "Column_Modelo";
            // 
            // Column_Almacenamiento
            // 
            this.Column_Almacenamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Almacenamiento.HeaderText = "Almacenamiento";
            this.Column_Almacenamiento.Name = "Column_Almacenamiento";
            // 
            // Column_Bateria
            // 
            this.Column_Bateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Bateria.HeaderText = "Bateria";
            this.Column_Bateria.Name = "Column_Bateria";
            // 
            // Column_Falla
            // 
            this.Column_Falla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Falla.HeaderText = "Falla";
            this.Column_Falla.Name = "Column_Falla";
            // 
            // Column_Email
            // 
            this.Column_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Email.HeaderText = "Email";
            this.Column_Email.Name = "Column_Email";
            // 
            // Column_PrecioArreglo
            // 
            this.Column_PrecioArreglo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PrecioArreglo.HeaderText = "Costo Arreglo";
            this.Column_PrecioArreglo.Name = "Column_PrecioArreglo";
            // 
            // Column_Costo
            // 
            this.Column_Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Costo.HeaderText = "Costo";
            this.Column_Costo.Name = "Column_Costo";
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
            // Column_Borrar
            // 
            this.Column_Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Borrar.HeaderText = "Borrar";
            this.Column_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Borrar.Image")));
            this.Column_Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Borrar.Name = "Column_Borrar";
            this.Column_Borrar.ReadOnly = true;
            // 
            // Column_Reparado
            // 
            this.Column_Reparado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Reparado.HeaderText = "Reparado";
            this.Column_Reparado.Image = ((System.Drawing.Image)(resources.GetObject("Column_Reparado.Image")));
            this.Column_Reparado.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Reparado.Name = "Column_Reparado";
            // 
            // ListaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 528);
            this.Controls.Add(this.label_Cargando);
            this.Controls.Add(this.pictureBox_Cargando);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialCard_ContenedorDataGreed);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaTecnico";
            this.Text = "ListaTecnico";
            this.Load += new System.EventHandler(this.ListaTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cargando)).EndInit();
            this.materialCard_ContenedorDataGreed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_StockTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Cargando;
        private System.Windows.Forms.PictureBox pictureBox_Cargando;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialCard materialCard_ContenedorDataGreed;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_StockTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TecnicoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Bateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Falla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PrecioArreglo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Costo;
        private System.Windows.Forms.DataGridViewImageColumn Column_Editar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Reparado;
    }
}