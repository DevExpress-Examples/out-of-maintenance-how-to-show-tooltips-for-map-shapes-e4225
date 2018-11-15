<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/ShowToolTips/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ShowToolTips/MainWindow.xaml))**
* [TypeConverters.cs](./CS/ShowToolTips/TypeConverters.cs) (VB: [TypeConverters.vb](./VB/ShowToolTips/TypeConverters.vb))
<!-- default file list end -->
# How to show tooltips for map shapes 


<p>This example illustrates how to display tooltips for shapes loaded from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).  </p><p>Note that a tooltip displays information (a country name, population) for each map shape from Shapefiles.</p><p></p>


<h3>Description</h3>

<p>To customize the appearance of tooltips, you can use the following properties.<br /> -&nbsp;<a href="http://help.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_ToolTipPatterntopic">VectorLayerBase.ToolTipPattern</a>&nbsp;allows you to specify the pattern used to&nbsp;generate&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapToolTipInfo_ToolTipTexttopic">ToolTipInfo.ToolTipText</a>.<u><br /> </u>-&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_ToolTipContentTemplatetopic">VectorLayerBase.ToolTipContentTemplate</a>&nbsp;allows you to specify the content template used to display tooltip data. Note that this template is bound to the&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfMapToolTipInfotopic">ToolTipInfo</a>&nbsp;object.<br /> -&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_ToolTipTemplatetopic">MapControl.ToolTipTemplate</a>&nbsp;allows you to customize the&nbsp;appearance of a tooltip.</p>
<p>Note that&nbsp;to show tooltips, the&nbsp;<a href="http://help.devexpress.com/#WPF/DevExpressXpfMapMapControl_ToolTipEnabledtopic">MapControl.ToolTipEnabled</a>&nbsp;property should be set to&nbsp;<strong>true</strong>.</p>

<br/>


