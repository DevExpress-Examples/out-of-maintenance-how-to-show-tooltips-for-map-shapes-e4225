<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571836/13.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4225)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ShowToolTips/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ShowToolTips/MainWindow.xaml))
<!-- default file list end -->
# How to show tooltips for map shapes 


<p>This example illustrates how to display tooltips for shapes loaded from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).  </p><p>Note that a tooltip displays information (a country name, population) for each map shape from Shapefiles.</p><p></p>


<h3>Description</h3>

<p>To see information (a country name, population) obtained from a Shapefile on a toolltip, specify NAME and POP_EST attributes in the <a href="http://help.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_ToolTipPatterntopic"><u>VectorLayerBase.ToolTipPattern</u></a> property.</p>
<p>Then, enable map tooltips by setting the <a href="http://help.devexpress.com/#WPF/DevExpressXpfMapMapControl_ToolTipEnabledtopic"><u>MapControl.ToolTipEnabled</u></a> property to <strong>true</strong>.</p>

<br/>


