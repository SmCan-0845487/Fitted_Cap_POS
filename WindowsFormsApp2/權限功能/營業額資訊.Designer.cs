namespace WindowsFormsApp2.權限功能
{
    partial class 營業額資訊
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
            this.chart每隊賣出 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart每隊賣出)).BeginInit();
            this.SuspendLayout();
            // 
            // chart每隊賣出
            // 
            this.chart每隊賣出.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart每隊賣出.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart每隊賣出.Legends.Add(legend1);
            this.chart每隊賣出.Location = new System.Drawing.Point(237, 67);
            this.chart每隊賣出.Name = "chart每隊賣出";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "team";
            this.chart每隊賣出.Series.Add(series1);
            this.chart每隊賣出.Size = new System.Drawing.Size(716, 490);
            this.chart每隊賣出.TabIndex = 1;
            this.chart每隊賣出.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "每隊賣出的多寡";
            this.chart每隊賣出.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "每隊賣出的多寡";
            // 
            // 營業額資訊
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1181, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart每隊賣出);
            this.Name = "營業額資訊";
            this.Text = "營業額資訊";
            this.Load += new System.EventHandler(this.營業額資訊_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart每隊賣出)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart每隊賣出;
        private System.Windows.Forms.Label label1;
    }
}