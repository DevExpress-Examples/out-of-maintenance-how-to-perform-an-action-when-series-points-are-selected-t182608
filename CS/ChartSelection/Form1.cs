using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ChartSelection {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        PaletteEntry[] paletteEntries;

        private void Form1_Load(object sender, EventArgs e) {

            // Specify selection mode for the Pie chart.
            this.cbSelectionMode.Properties.Items.AddRange(Enum.GetValues(typeof(ElementSelectionMode)));
            this.cbSelectionMode.SelectedIndex = 2;
            pieChart.SeriesSelectionMode = SeriesSelectionMode.Point;

            // Handle the SelectedItemsChanged event for the Pie chart.                
            pieChart.SelectedItemsChanged += pieChart_SelectedItemsChanged;

            // Handle the CustomDrawSeriesPoint event for the Bar chart. 
            barChart.CustomDrawSeriesPoint += barChart_CustomDrawSeriesPoint;

            // Get palette entries of the pie chart.
            paletteEntries = pieChart.GetPaletteEntries(pieChart.Series[0].Points.Count);
        }

        private void cbSelectionMode_SelectedIndexChanged(object sender, EventArgs e) {
            pieChart.SelectionMode = (ElementSelectionMode)this.cbSelectionMode.SelectedItem;
        }

        private void pieChart_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e) {
            barChart.Series[0].Points.Clear();

            foreach (SeriesPoint piePoint in pieChart.SelectedItems) {
                SeriesPoint barPoint = new SeriesPoint(piePoint.Argument, piePoint.Values[0]);
                barPoint.Tag = pieChart.Series[0].Points.IndexOf(piePoint);
                barChart.Series[0].Points.Add(barPoint);
            }
        }

        private void barChart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            BarDrawOptions barOptions = e.SeriesDrawOptions as BarDrawOptions;
            int colorIndex = (int)e.SeriesPoint.Tag;
            barOptions.Color = paletteEntries[colorIndex].Color;
        }
    }
}

