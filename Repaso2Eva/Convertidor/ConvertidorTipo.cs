using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Repaso2Eva
{
    class ConvertidorTipo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals("Procesador"))
            {
                return "/Imagenes/micro.png";

            }
            else if(value.Equals("Tarjeta"))
            {
                return "/Imagenes/tarjeta.png";
            }
            else
            {
                return "/Imagenes/placa.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
