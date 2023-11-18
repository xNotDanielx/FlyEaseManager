namespace WindowsFormsApp1
{
    partial class FrmHistograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartTiempoVsVuelos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CbAño = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTiempoVsVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTiempoVsVuelos
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartTiempoVsVuelos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartTiempoVsVuelos.Legends.Add(legend2);
            this.ChartTiempoVsVuelos.Location = new System.Drawing.Point(365, 85);
            this.ChartTiempoVsVuelos.Name = "ChartTiempoVsVuelos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartTiempoVsVuelos.Series.Add(series2);
            this.ChartTiempoVsVuelos.Size = new System.Drawing.Size(300, 300);
            this.ChartTiempoVsVuelos.TabIndex = 0;
            // 
            // CbAño
            // 
            this.CbAño.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAño.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAño.ForeColor = System.Drawing.Color.White;
            this.CbAño.FormattingEnabled = true;
            this.CbAño.Location = new System.Drawing.Point(430, 36);
            this.CbAño.Name = "CbAño";
            this.CbAño.Size = new System.Drawing.Size(185, 24);
            this.CbAño.TabIndex = 2;
            this.CbAño.SelectedIndexChanged += new System.EventHandler(this.CbAño_SelectedIndexChanged);
            // 
            // FrmHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.CbAño);
            this.Controls.Add(this.ChartTiempoVsVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistograma";
            this.Text = "FrmHistograma";
            this.Load += new System.EventHandler(this.FrmHistograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTiempoVsVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTiempoVsVuelos;
        private System.Windows.Forms.ComboBox CbAño;
    }
}