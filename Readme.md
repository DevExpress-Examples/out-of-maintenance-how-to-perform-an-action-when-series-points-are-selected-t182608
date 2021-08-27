<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575213/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T182608)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ChartSelection/Form1.cs) (VB: [Form1.vb](./VB/ChartSelection/Form1.vb))
<!-- default file list end -->
# How to perform an action when series points are selected


This example shows how to obtain currently selected series points and show them in another chart. For this, the <strong>ChartControl.SelectedItemsChanged</strong> event should be used.<br /><br />In this example, you can choose the selection behavior (<strong>Single</strong>, <strong>Multiple </strong>or <strong>Extended</strong>) via the Selection Mode combo box. When any country is selected in the pie chart, you can see the population dynamics for each country in the bar chart.  To cancel pie segment selection, choose <strong>None</strong> in the Selection Mode combo box.<br /><br />In addition, this example demonstrates how to colorize each bar series point in the pie specific color using the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraChartsChartControl_CustomDrawSeriesPointtopic">ChartControl.CustomDrawSeriesPoint </a> event.

<br/>


