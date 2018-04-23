using DevExpress.Xpf.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace ShowToolTips {
    class MapItemPopulationAttributeToStringTypeConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            ShapeTitle title = value as ShapeTitle;
            MapItem item;
            if (title == null)
                item = value as MapItem;
            else
                item = title.MapShape;

            if (item == null) return null;

            var attr = item.Attributes["POP_EST"];
            if (attr == null) return null;

            return attr.Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    class MapItemGdpAttributeToStringTypeConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            ShapeTitle title = value as ShapeTitle;
            MapItem item;
            if (title == null)
                item = value as MapItem;
            else
                item = title.MapShape;

            if (item == null) return null;

            var attr = item.Attributes["GDP_MD_EST"];
            if (attr == null) return null;

            return attr.Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
