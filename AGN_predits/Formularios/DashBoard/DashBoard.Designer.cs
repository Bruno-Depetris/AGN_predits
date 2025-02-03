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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.label_dineroInvertido = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.airSeparator2 = new ReaLTaiizor.Controls.AirSeparator();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Arboria Thin", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(98, 3);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(615, 115);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "BIENVENIDO";
            // 
            // label_dineroInvertido
            // 
            this.label_dineroInvertido.AutoSize = true;
            this.label_dineroInvertido.BackColor = System.Drawing.Color.Transparent;
            this.label_dineroInvertido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label_dineroInvertido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.label_dineroInvertido.Location = new System.Drawing.Point(372, 499);
            this.label_dineroInvertido.Name = "label_dineroInvertido";
            this.label_dineroInvertido.Size = new System.Drawing.Size(88, 20);
            this.label_dineroInvertido.TabIndex = 2;
            this.label_dineroInvertido.Text = "Cargando...";
            // 
            // airSeparator1
            // 
            this.airSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(243)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(-33, 127);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(871, 1);
            this.airSeparator1.TabIndex = 3;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // airSeparator2
            // 
            this.airSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airSeparator2.BackColor = System.Drawing.Color.Black;
            this.airSeparator2.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator2.Customization = "";
            this.airSeparator2.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator2.Image = null;
            this.airSeparator2.Location = new System.Drawing.Point(-34, 125);
            this.airSeparator2.Name = "airSeparator2";
            this.airSeparator2.NoRounding = false;
            this.airSeparator2.Size = new System.Drawing.Size(871, 1);
            this.airSeparator2.TabIndex = 4;
            this.airSeparator2.Text = "airSeparator2";
            this.airSeparator2.Transparent = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.airSeparator2);
            this.Controls.Add(this.airSeparator1);
            this.Controls.Add(this.label_dineroInvertido);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel label_dineroInvertido;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator2;
    }
}