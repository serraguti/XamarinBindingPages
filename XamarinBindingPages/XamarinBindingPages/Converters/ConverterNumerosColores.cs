using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBindingPages.Converters
{
    public class ConverterNumerosColores : IValueConverter
    {
        public Color ColorPositivo { get; set; }
        public Color ColorNegativo { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //VAMOS A RECIBIR UN NUMERO Y YO VOY A DEVOLVER UN COLOR
            if (value != null)
            {
                int numero = (int)value;
                //DESEAMOS DEVOLVER UN COLOR PERSONALIZADO
                Color color;
                if (numero > 0)
                {
                    color = this.ColorPositivo;
                }
                else
                {
                    color = this.ColorNegativo;
                }
                return color;
            }
            else
            {
                return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
