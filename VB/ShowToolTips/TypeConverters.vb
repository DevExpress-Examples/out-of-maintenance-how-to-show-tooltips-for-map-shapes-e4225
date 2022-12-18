Imports DevExpress.Xpf.Map
Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Data

Namespace ShowToolTips

    Friend Class MapItemPopulationAttributeToStringTypeConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim title As ShapeTitle = TryCast(value, ShapeTitle)
            Dim item As MapItem
            If title Is Nothing Then
                item = TryCast(value, MapItem)
            Else
                item = title.MapShape
            End If

            If item Is Nothing Then Return Nothing
            Dim attr = item.Attributes("POP_EST")
            If attr Is Nothing Then Return Nothing
            Return attr.Value
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Friend Class MapItemGdpAttributeToStringTypeConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim title As ShapeTitle = TryCast(value, ShapeTitle)
            Dim item As MapItem
            If title Is Nothing Then
                item = TryCast(value, MapItem)
            Else
                item = title.MapShape
            End If

            If item Is Nothing Then Return Nothing
            Dim attr = item.Attributes("GDP_MD_EST")
            If attr Is Nothing Then Return Nothing
            Return attr.Value
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
