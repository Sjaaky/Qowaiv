﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace Qowaiv.Conversion
{
	/// <summary>Provides a conversion for an email address.</summary>
	public class EmailAddressTypeConverter : TypeConverter
	{
		#region Convert From

		/// <summary>Returns whether this converter can convert an string to
		/// an email address, using the specified context.
		/// </summary>
		/// <param name="context">
		/// An System.ComponentModel.ITypeDescriptorContext that provides a format context.
		/// </param>
		/// <param name="sourceType">
		/// A System.Type that represents the type you want to convert from.
		/// </param>
		/// <returns>
		/// true if this converter can perform the conversion; otherwise, false.
		/// </returns>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}
		/// <summary>Converts a string to an email address, using the specified
		/// context and culture information.
		/// </summary>
		/// <param name="context">
		/// An System.ComponentModel.ITypeDescriptorContext that provides a format context.
		/// </param>
		/// <param name="culture">
		/// The System.Globalization.CultureInfo to use as the current culture.
		/// </param>
		/// <param name="value">
		/// The System.Object to convert.
		/// </param>
		/// <returns>
		/// An System.Object that represents the converted value.
		/// </returns>
		/// <exception cref="System.NotSupportedException">
		/// The conversion cannot be performed.
		/// </exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var str = value as string;
			if (value == null || str != null)
			{
				return EmailAddress.Parse(str, culture);
			}
			return base.ConvertFrom(context, culture, value);
		}
		#endregion

		#region Convert To

		/// <summary>Converts an email address to string, using the specified context and culture information.</summary>
		/// <param name="culture">
		///  A System.Globalization.CultureInfo. If null is passed, the current culture is assumed.
		/// </param>
		/// <param name="context">
		/// An System.ComponentModel.ITypeDescriptorContext that provides a format context.
		/// </param>
		/// <param name="value">
		/// The email address to convert.
		/// </param>
		/// <param name="destinationType">
		/// The System.Type to convert the value parameter to.
		/// </param>
		/// <returns>
		/// A string that represents the converted email address.
		/// </returns>
		/// <exception cref="System.ArgumentNullException">
		/// The destinationType parameter is null.
		/// </exception>
		/// <exception cref="System.NotSupportedException">
		/// The conversion cannot be performed.
		/// </exception>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return base.ConvertTo(context, culture, value, destinationType);
		}
		#endregion
	}
}