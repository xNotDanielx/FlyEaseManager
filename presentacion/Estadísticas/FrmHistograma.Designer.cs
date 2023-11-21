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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartTiempoVsVuelos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CbAno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTiempoVsVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTiempoVsVuelos
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTiempoVsVuelos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTiempoVsVuelos.Legends.Add(legend1);
            this.ChartTiempoVsVuelos.Location = new System.Drawing.Point(65, 79);
            this.ChartTiempoVsVuelos.Name = "ChartTiempoVsVuelos";
            series1.ChartArea = "ChartArea1";
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartTiempoVsVuelos.Series.Add(series1);
            this.ChartTiempoVsVuelos.Size = new System.Drawing.Size(937, 390);
            this.ChartTiempoVsVuelos.TabIndex = 0;
            title1.Name = "Historial de vuelos por mes en un año especifico";
            title1.Text = "Historial de vuelos por mes en un año especifico";
            this.ChartTiempoVsVuelos.Titles.Add(title1);
            // 
            // CbAno
            // 
            this.CbAno.BackColor = System.Drawing.Color.White;
            this.CbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAno.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAno.ForeColor = System.Drawing.Color.Black;
            this.CbAno.FormattingEnabled = true;
            this.CbAno.Location = new System.Drawing.Point(440, 49);
            this.CbAno.Name = "CbAno";
            this.CbAno.Size = new System.Drawing.Size(185, 24);
            this.CbAno.TabIndex = 2;
            this.CbAno.SelectedIndexChanged += new System.EventHandler(this.CbAño_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Vuelos por mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(218, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Seleccione un año:";
            // 
            // FrmHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbAno);
            this.Controls.Add(this.ChartTiempoVsVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistograma";
            this.Text = "FrmHistograma";
            this.Load += new System.EventHandler(this.FrmHistograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTiempoVsVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTiempoVsVuelos;
        private System.Windows.Forms.ComboBox CbAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}