﻿using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;

namespace RichardLawley.EF.AttributeConfig
{
	/// <summary>
	/// Configures the precision of a decimal type within the datastore
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public sealed class DecimalPrecisionAttribute : Attribute
	{
		public DecimalPrecisionAttribute(byte precision, byte scale)
		{
			Precision = precision;
			Scale = scale;
		}

		public byte Precision { get; set; }

		public byte Scale { get; set; }
	}
}