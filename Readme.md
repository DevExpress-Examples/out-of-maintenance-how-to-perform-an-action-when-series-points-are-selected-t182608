# How to perform an action when series points are selected


This example shows how to obtain currently selected series points and show them in another chart. For this, the <strong>ChartControl.SelectedItemsChanged</strong> event should be used.<br /><br />In this example, you can choose the selection behavior (<strong>Single</strong>, <strong>Multiple </strong>or <strong>Extended</strong>) via the Selection Mode combo box. When any country is selected in the pie chart, you can see the population dynamics for each country in the bar chart.  To cancel pie segment selection, choose <strong>None</strong> in the Selection Mode combo box.<br /><br />In addition, this example demonstrates how to colorize each bar series point in the pie specific color using the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraChartsChartControl_CustomDrawSeriesPointtopic">ChartControl.CustomDrawSeriesPoint </a> event.

<br/>


