using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBindingPages.Converters
{
    public class ConverterGrados : IValueConverter
    {
        public object Convert(object value
            , Type targetType, object parameter
            , CultureInfo culture)
        {
            //value: El valor enlazado al binding
            //targetType: El tipo de objeto enlazado
            //parameter: Parametros asociados al binding
            //culture: El tipo de cultura actual de la App
            if (value != null)
            {
                if (value.ToString() != "")
                {
                    double celsius = double.Parse(value.ToString());
                    double farenhait = (celsius * 9 / 5) + 32;
                    return farenhait;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
