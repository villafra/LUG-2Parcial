namespace LUG_2Parcial
{
    partial class frmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartJuegos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPPT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTaTeTi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTaTeTi)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartJuegos
            // 
            this.ChartJuegos.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartJuegos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartJuegos.Legends.Add(legend1);
            this.ChartJuegos.Location = new System.Drawing.Point(331, 12);
            this.ChartJuegos.Name = "ChartJuegos";
            this.ChartJuegos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartJuegos.Series.Add(series1);
            this.ChartJuegos.Size = new System.Drawing.Size(387, 478);
            this.ChartJuegos.TabIndex = 0;
            this.ChartJuegos.Text = "chart1";
            // 
            // ChartPPT
            // 
            this.ChartPPT.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartPPT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartPPT.Legends.Add(legend2);
            this.ChartPPT.Location = new System.Drawing.Point(12, 276);
            this.ChartPPT.Name = "ChartPPT";
            this.ChartPPT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartPPT.Series.Add(series2);
            this.ChartPPT.Size = new System.Drawing.Size(313, 337);
            this.ChartPPT.TabIndex = 1;
            this.ChartPPT.Text = "chart1";
            // 
            // ChartTaTeTi
            // 
            this.ChartTaTeTi.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ChartTaTeTi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartTaTeTi.Legends.Add(legend3);
            this.ChartTaTeTi.Location = new System.Drawing.Point(724, 276);
            this.ChartTaTeTi.Name = "ChartTaTeTi";
            this.ChartTaTeTi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartTaTeTi.Series.Add(series3);
            this.ChartTaTeTi.Size = new System.Drawing.Size(313, 337);
            this.ChartTaTeTi.TabIndex = 2;
            this.ChartTaTeTi.Text = "chart1";
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 646);
            this.Controls.Add(this.ChartTaTeTi);
            this.Controls.Add(this.ChartPPT);
            this.Controls.Add(this.ChartJuegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            this.Load += new System.EventHandler(this.frmGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTaTeTi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartJuegos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPPT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTaTeTi;
    }
}