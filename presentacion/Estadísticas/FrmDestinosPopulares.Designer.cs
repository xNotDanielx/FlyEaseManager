namespace WindowsFormsApp1
{
    partial class FrmDestinosPopulares
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartDestinosPopulares = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDestinosPopulares)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDestinosPopulares
            // 
            this.ChartDestinosPopulares.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ChartDestinosPopulares.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            chartArea1.Name = "ChartArea1";
            this.ChartDestinosPopulares.ChartAreas.Add(chartArea1);
            this.ChartDestinosPopulares.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend";
            this.ChartDestinosPopulares.Legends.Add(legend1);
            this.ChartDestinosPopulares.Location = new System.Drawing.Point(223, 12);
            this.ChartDestinosPopulares.Name = "ChartDestinosPopulares";
            this.ChartDestinosPopulares.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend";
            series1.Name = "Series1";
            this.ChartDestinosPopulares.Series.Add(series1);
            this.ChartDestinosPopulares.Size = new System.Drawing.Size(641, 500);
            this.ChartDestinosPopulares.TabIndex = 0;
            // 
            // FrmDestinosPopulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.ChartDestinosPopulares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDestinosPopulares";
            this.Text = "FrmDestinosPopulares";
            this.Load += new System.EventHandler(this.FrmDestinosPopulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDestinosPopulares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDestinosPopulares;
    }
}