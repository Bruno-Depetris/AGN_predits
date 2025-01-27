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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.parrotLineGraph1 = new ReaLTaiizor.Controls.ParrotLineGraph();
            this.SuspendLayout();
            // 
            // parrotLineGraph1
            // 
            this.parrotLineGraph1.BackGroundColor = System.Drawing.Color.White;
            this.parrotLineGraph1.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.parrotLineGraph1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotLineGraph1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotLineGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotLineGraph.Style.Curved;
            this.parrotLineGraph1.GraphTitle = "Ventas Diarias";
            this.parrotLineGraph1.GraphTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotLineGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("parrotLineGraph1.Items")));
            this.parrotLineGraph1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parrotLineGraph1.Location = new System.Drawing.Point(0, 413);
            this.parrotLineGraph1.Name = "parrotLineGraph1";
            this.parrotLineGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotLineGraph1.PointSize = 7;
            this.parrotLineGraph1.ShowBorder = false;
            this.parrotLineGraph1.ShowPoints = false;
            this.parrotLineGraph1.ShowTitle = true;
            this.parrotLineGraph1.ShowVerticalLines = false;
            this.parrotLineGraph1.Size = new System.Drawing.Size(799, 115);
            this.parrotLineGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotLineGraph1.TabIndex = 1;
            this.parrotLineGraph1.Text = "Ventas";
            this.parrotLineGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotLineGraph1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.parrotLineGraph1.VerticalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.parrotLineGraph1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotLineGraph parrotLineGraph1;
    }
}