using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Model.Services
{
    /// <summary>
    ///  Представляет реализацию для конвертирования bool значений.
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение в соотвествующие значение из перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура.</param>
        /// <returns>Значение видимости элемента.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !bool.Parse(value.ToString() ?? bool.FalseString) ? Visibility.Visible : Visibility.Hidden;
        }

        /// <summary>
        /// Конвертирует значение из перечисления <see cref="Visibility"/> в соотвествующие булевое значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура.</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !Visibility.Visible.Equals(value);
        }
    }
}