﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace GigHub3.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool isValid = DateTime.TryParseExact(Convert.ToString(value), "d MMM YYY", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dateTime);

            return (isValid && dateTime > DateTime.Now);
        }

    }
}