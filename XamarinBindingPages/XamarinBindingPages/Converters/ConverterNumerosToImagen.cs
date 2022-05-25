using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBindingPages.Converters
{
    public class ConverterNumerosToImagen : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //RECIBIMOS UN NUMERO Y DEVOLVEMOS EL NOMBRE
            //DE LA IMAGEN A MOSTRAR
            if (value != null)
            {
                int numero = (int)value;
                if (numero > 0)
                {
                    //IMAGEN PARA POSITIVO
                    return "arriba.png";
                }
                else
                {
                    //IMAGEN PARA VALOR NEGATIVO
                    return "abajo.png";
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
