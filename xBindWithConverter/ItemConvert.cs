using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace xBindWithConverter
{
    public class ItemConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                System.Diagnostics.Debug.WriteLine(value.GetType());
                //var item = value as Item;
                //return string.Format("Name: {0}, Number {1}", item.Name, item.Number);
                return value.ToString();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("value is null");
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}