Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ChartSelection

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private paletteEntries() As PaletteEntry

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' Specify selection mode for the Pie chart.
            Me.cbSelectionMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(ElementSelectionMode)))
            Me.cbSelectionMode.SelectedIndex = 2
            pieChart.SeriesSelectionMode = SeriesSelectionMode.Point

            ' Handle the SelectedItemsChanged event for the Pie chart.                
            AddHandler pieChart.SelectedItemsChanged, AddressOf pieChart_SelectedItemsChanged

            ' Handle the CustomDrawSeriesPoint event for the Bar chart. 
            AddHandler barChart.CustomDrawSeriesPoint, AddressOf barChart_CustomDrawSeriesPoint

            ' Get palette entries of the pie chart.
            paletteEntries = pieChart.GetPaletteEntries(pieChart.Series(0).Points.Count)
        End Sub

        Private Sub cbSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSelectionMode.SelectedIndexChanged
            pieChart.SelectionMode = CType(Me.cbSelectionMode.SelectedItem, ElementSelectionMode)
        End Sub

        Private Sub pieChart_SelectedItemsChanged(ByVal sender As Object, ByVal e As SelectedItemsChangedEventArgs)
            barChart.Series(0).Points.Clear()

            For Each piePoint As SeriesPoint In pieChart.SelectedItems
                Dim barPoint As New SeriesPoint(piePoint.Argument, piePoint.Values(0))
                barPoint.Tag = pieChart.Series(0).Points.IndexOf(piePoint)
                barChart.Series(0).Points.Add(barPoint)
            Next piePoint
        End Sub

        Private Sub barChart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim barOptions As BarDrawOptions = TryCast(e.SeriesDrawOptions, BarDrawOptions)
            Dim colorIndex As Integer = CInt((e.SeriesPoint.Tag))
            barOptions.Color = paletteEntries(colorIndex).Color
        End Sub
    End Class
End Namespace

