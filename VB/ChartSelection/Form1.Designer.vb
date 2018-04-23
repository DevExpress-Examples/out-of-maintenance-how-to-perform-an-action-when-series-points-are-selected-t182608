Namespace ChartSelection
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim simpleDiagram1 As New DevExpress.XtraCharts.SimpleDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (DirectCast(201.1R, Object))}, 0)
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (DirectCast(1184.1R, Object))}, 1)
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (DirectCast(1347.6R, Object))}, 2)
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("United States", New Object() { (DirectCast(309.2R, Object))}, 3)
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Argentina", New Object() { (DirectCast(41.3R, Object))}, 4)
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (DirectCast(139.4R, Object))}, 5)
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
            Me.pieChart = New DevExpress.XtraCharts.ChartControl()
            Me.barChart = New DevExpress.XtraCharts.ChartControl()
            Me.cbSelectionMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label1 = New System.Windows.Forms.Label()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            DirectCast(Me.pieChart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(simpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barChart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbSelectionMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pieChart
            ' 
            Me.pieChart.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            simpleDiagram1.Dimension = 1
            simpleDiagram1.EqualPieSize = False
            simpleDiagram1.Margins.Bottom = 10
            simpleDiagram1.Margins.Left = 10
            simpleDiagram1.Margins.Right = 10
            simpleDiagram1.Margins.Top = 10
            Me.pieChart.Diagram = simpleDiagram1
            Me.pieChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.pieChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.pieChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.pieChart.Location = New System.Drawing.Point(12, 44)
            Me.pieChart.Name = "pieChart"
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6})
            pieSeriesView1.RuntimeExploding = False
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise
            series1.View = pieSeriesView1
            Me.pieChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.pieChart.Size = New System.Drawing.Size(460, 460)
            Me.pieChart.TabIndex = 0
            chartTitle1.Text = "Largest Countries by Area"
            Me.pieChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' barChart
            ' 
            Me.barChart.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.barChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V} M"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.barChart.Diagram = xyDiagram1
            Me.barChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.barChart.Location = New System.Drawing.Point(473, 44)
            Me.barChart.Name = "barChart"
            Me.barChart.SeriesDataMember = "Region"
            series2.Name = "Series 1"
            sideBySideBarSeriesView1.ColorEach = True
            series2.View = sideBySideBarSeriesView1
            Me.barChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
            Me.barChart.SeriesTemplate.ArgumentDataMember = "Year"
            Me.barChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Me.barChart.SeriesTemplate.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            Me.barChart.SeriesTemplate.DataFiltersConjunctionMode = DevExpress.XtraCharts.ConjunctionTypes.Or
            Me.barChart.SeriesTemplate.ValueDataMembersSerializable = "GSP"
            Me.barChart.Size = New System.Drawing.Size(513, 460)
            Me.barChart.TabIndex = 0
            chartTitle2.Text = "Population Dynamics in 2010"
            Me.barChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})

            ' 
            ' cbSelectionMode
            ' 
            Me.cbSelectionMode.Location = New System.Drawing.Point(105, 9)
            Me.cbSelectionMode.Name = "cbSelectionMode"
            Me.cbSelectionMode.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.cbSelectionMode.Properties.AllowFocused = False
            Me.cbSelectionMode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.cbSelectionMode.Properties.AutoComplete = False
            Me.cbSelectionMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSelectionMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbSelectionMode.Size = New System.Drawing.Size(125, 20)
            Me.cbSelectionMode.TabIndex = 2
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(15, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(84, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Selection Mode:"
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.label2)
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Controls.Add(Me.cbSelectionMode)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(993, 38)
            Me.panel3.TabIndex = 4
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label2.Location = New System.Drawing.Point(292, 11)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(359, 18)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Select a country in a pie chart to see population trend."
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(993, 510)
            Me.Controls.Add(Me.barChart)
            Me.Controls.Add(Me.pieChart)
            Me.Controls.Add(Me.panel3)
            Me.Name = "Form1"
            Me.Text = "Selection Modes"
            DirectCast(simpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pieChart, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barChart, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbSelectionMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pieChart As DevExpress.XtraCharts.ChartControl
        Private barChart As DevExpress.XtraCharts.ChartControl
        Private WithEvents cbSelectionMode As DevExpress.XtraEditors.ComboBoxEdit
        Private label1 As System.Windows.Forms.Label
        Private panel3 As System.Windows.Forms.Panel
        Private label2 As System.Windows.Forms.Label
    End Class
End Namespace

