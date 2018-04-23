namespace ChartSelection {
    partial class Form1 {
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Brazil", new object[] {
            ((object)(201.1D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("India", new object[] {
            ((object)(1184.1D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("China", new object[] {
            ((object)(1347.6D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("United States", new object[] {
            ((object)(309.2D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Argentina", new object[] {
            ((object)(41.3D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Russia", new object[] {
            ((object)(139.4D))}, 5);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.pieChart = new DevExpress.XtraCharts.ChartControl();
            this.barChart = new DevExpress.XtraCharts.ChartControl();
            this.cbSelectionMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectionMode.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            simpleDiagram1.Dimension = 1;
            simpleDiagram1.EqualPieSize = false;
            simpleDiagram1.Margins.Bottom = 10;
            simpleDiagram1.Margins.Left = 10;
            simpleDiagram1.Margins.Right = 10;
            simpleDiagram1.Margins.Top = 10;
            this.pieChart.Diagram = simpleDiagram1;
            this.pieChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.pieChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.pieChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.pieChart.Location = new System.Drawing.Point(12, 44);
            this.pieChart.Name = "pieChart";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6});
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series1.View = pieSeriesView1;
            this.pieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.pieChart.Size = new System.Drawing.Size(460, 460);
            this.pieChart.TabIndex = 0;
            chartTitle1.Text = "Largest Countries by Area";
            this.pieChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // barChart
            // 
            this.barChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V} M";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.barChart.Diagram = xyDiagram1;
            this.barChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.Location = new System.Drawing.Point(473, 44);
            this.barChart.Name = "barChart";
            this.barChart.SeriesDataMember = "Region";
            series2.Name = "Series 1";
            sideBySideBarSeriesView1.ColorEach = true;
            series2.View = sideBySideBarSeriesView1;
            this.barChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.barChart.SeriesTemplate.ArgumentDataMember = "Year";
            this.barChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.barChart.SeriesTemplate.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.SeriesTemplate.DataFiltersConjunctionMode = DevExpress.XtraCharts.ConjunctionTypes.Or;
            this.barChart.SeriesTemplate.ValueDataMembersSerializable = "GSP";
            this.barChart.Size = new System.Drawing.Size(513, 460);
            this.barChart.TabIndex = 0;
            chartTitle2.Text = "Population Dynamics in 2010";
            this.barChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
         
            // 
            // cbSelectionMode
            // 
            this.cbSelectionMode.Location = new System.Drawing.Point(105, 9);
            this.cbSelectionMode.Name = "cbSelectionMode";
            this.cbSelectionMode.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbSelectionMode.Properties.AllowFocused = false;
            this.cbSelectionMode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbSelectionMode.Properties.AutoComplete = false;
            this.cbSelectionMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSelectionMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSelectionMode.Size = new System.Drawing.Size(125, 20);
            this.cbSelectionMode.TabIndex = 2;
            this.cbSelectionMode.SelectedIndexChanged += new System.EventHandler(this.cbSelectionMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selection Mode:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbSelectionMode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 38);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a country in a pie chart to see population trend.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 510);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Selection Modes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectionMode.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl pieChart;
        private DevExpress.XtraCharts.ChartControl barChart;
        private DevExpress.XtraEditors.ComboBoxEdit cbSelectionMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

