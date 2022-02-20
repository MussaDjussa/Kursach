using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SaleApplication
{
    class MaterialConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                ICollection<Production> listProd = value as ICollection<Production>;
                if (listProd.Count() == 0)
                    return "Материал: Нет";
                string material = "Материалы: ";
                foreach (Production item in listProd)
                {
                    if (listProd.Last() == item)
                        return material += $"{item.Material.Name}";
                    material += $"{item.Material.Name}, ";
                }
                return material;
            }
            return "Материал: Нет";
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
