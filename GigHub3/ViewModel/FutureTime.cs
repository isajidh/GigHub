using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace GigHub3.ViewModel
{
    public class FutureTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dateTime);

            return (isValid);
        }

    }
}