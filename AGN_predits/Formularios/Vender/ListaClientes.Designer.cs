namespace AGN_predits.Formularios.Vender {
    partial class ListaClientes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.poisonDataGridView_Clientes = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column_ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.airForm1.SuspendLayout();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.panel_Contenedor);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(800, 450);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "Lista de clientes";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Contenedor.Controls.Add(this.poisonDataGridView_Clientes);
            this.panel_Contenedor.Location = new System.Drawing.Point(12, 45);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(776, 393);
            this.panel_Contenedor.TabIndex = 0;
            // 
            // poisonDataGridView_Clientes
            // 
            this.poisonDataGridView_Clientes.AllowUserToAddRows = false;
            this.poisonDataGridView_Clientes.AllowUserToResizeRows = false;
            this.poisonDataGridView_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arboria Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClienteID,
            this.Column_Nombre,
            this.Column_Apellido,
            this.Column_Dni,
            this.Column_Telefono,
            this.Column_Gmail,
            this.Column_Editar,
            this.Column_Borrar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonDataGridView_Clientes.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_Clientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_Clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_Clientes.Location = new System.Drawing.Point(0, 0);
            this.poisonDataGridView_Clientes.Name = "poisonDataGridView_Clientes";
            this.poisonDataGridView_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.poisonDataGridView_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_Clientes.ShowRowErrors = false;
            this.poisonDataGridView_Clientes.Size = new System.Drawing.Size(776, 393);
            this.poisonDataGridView_Clientes.TabIndex = 1;
            this.poisonDataGridView_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_Clientes_CellContentClick);
            // 
            // Column_ClienteID
            // 
            this.Column_ClienteID.HeaderText = "ClienteID";
            this.Column_ClienteID.Name = "Column_ClienteID";
            this.Column_ClienteID.Visible = false;
            // 
            // Column_Nombre
            // 
            this.Column_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Nombre.HeaderText = "Nombre";
            this.Column_Nombre.Name = "Column_Nombre";
            // 
            // Column_Apellido
            // 
            this.Column_Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Apellido.HeaderText = "Apellido";
            this.Column_Apellido.Name = "Column_Apellido";
            // 
            // Column_Dni
            // 
            this.Column_Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Dni.HeaderText = "Dni";
            this.Column_Dni.Name = "Column_Dni";
            // 
            // Column_Telefono
            // 
            this.Column_Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Telefono.HeaderText = "Telefono";
            this.Column_Telefono.Name = "Column_Telefono";
            // 
            // Column_Gmail
            // 
            this.Column_Gmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Gmail.HeaderText = "Gmail";
            this.Column_Gmail.Name = "Column_Gmail";
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
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.airForm1.ResumeLayout(false);
            this.panel_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private System.Windows.Forms.Panel panel_Contenedor;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gmail;
        private System.Windows.Forms.DataGridViewImageColumn Column_Editar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Borrar;
    }
}