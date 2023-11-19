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
            this.CbAno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // CbAno
            // 
            this.CbAno.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAno.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.CbAno.ForeColor = System.Drawing.Color.White;
            this.CbAno.FormattingEnabled = true;
            this.CbAno.Location = new System.Drawing.Point(32, 37);
            this.CbAno.Name = "CbAno";
            this.CbAno.Size = new System.Drawing.Size(176, 24);
            this.CbAno.TabIndex = 3;
            this.CbAno.SelectedIndexChanged += new System.EventHandler(this.CbAno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Destinos populares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Seleccione un año:";
            // 
            // FrmDestinosPopulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbAno);
            this.Controls.Add(this.ChartDestinosPopulares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDestinosPopulares";
            this.Text = "FrmDestinosPopulares";
            this.Load += new System.EventHandler(this.FrmDestinosPopulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDestinosPopulares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDestinosPopulares;
        private System.Windows.Forms.ComboBox CbAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}