using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Hemi = FaaObstruction.Hemisphere;

namespace FaaObstruction
{
	public struct Dms
	{
		private int _degrees;
		private int _minutes;
		private float _seconds;
		private Hemisphere? _hemisphere;

		public int Degrees
		{
			get { return _degrees; }
			set { _degrees = value; }
		}

		public int Minutes
		{
			get { return _minutes; }
			set { _minutes = value; }
		}


		public float Seconds
		{
			get { return _seconds; }
			set { _seconds = value; }
		}


		public Hemisphere? Hemisphere
		{
			get { return _hemisphere; }
			set { _hemisphere = value; }
		}

		/// <summary>
		/// Creates a new <see cref="Dms"/>.
		/// </summary>
		/// <param name="degrees"></param>
		/// <param name="minutes"></param>
		/// <param name="seconds"></param>
		/// <param name="hemisphere">This can be null if <paramref name="degrees"/>, <paramref name="minutes"/>, and <paramref name="seconds"/> all equal zero.</param>
		public Dms(int degrees, int minutes, float seconds, Hemisphere? hemisphere)
		{
			if (!hemisphere.HasValue && (degrees != 0 || minutes != 0 || seconds != 0))
			{
				throw new ArgumentException("The hemisphere value cannot be null unless all of the other parameters are zero.");
			}
			_degrees = degrees;
			_minutes = minutes;
			_seconds = seconds;
			_hemisphere = hemisphere;
		}

		/// <summary>
		/// Creates a new <see cref="Dms"/>.
		/// </summary>
		/// <param name="decimalDegrees">The value in decimal degrees that will be converted to <see cref="Dms"/>.</param>
		/// <param name="isLatitude">Set to true if this is a latitude value, false for longitude</param>
		public Dms(decimal decimalDegrees, bool isLatitude)
		{
			var dd = Math.Abs(decimalDegrees);
			_degrees = Convert.ToInt32(Math.Truncate(dd));
			_minutes = Convert.ToInt32(Math.Truncate(dd * 60) % 60);
			_seconds = Convert.ToSingle((dd * 3600) % 60);

			if (dd == 0)
			{
				_hemisphere = default(Hemisphere?);
			}
			else
			{
				if (isLatitude)
				{
					_hemisphere = decimalDegrees > 0 ? FaaObstruction.Hemisphere.North : FaaObstruction.Hemisphere.South;
				}
				else
				{
					_hemisphere = decimalDegrees > 0 ? FaaObstruction.Hemisphere.East : FaaObstruction.Hemisphere.West;
				}
			}
		}

		public decimal ToDecimalDegrees()
		{
			return (Degrees + Minutes / 60 + Convert.ToDecimal(Seconds) / 3600) * (this.Hemisphere == Hemi.North || this.Hemisphere == Hemi.East ? 1 : -1);
		}

		public override bool Equals(object obj)
		{
			if (obj != null && obj.GetType() == typeof(Dms))
			{
				var other = (Dms)obj;
				return this.Degrees == other.Degrees && this.Seconds == other.Seconds && this.Minutes == other.Minutes && this.Hemisphere == other.Hemisphere;
			}
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return _degrees.GetHashCode() ^ _minutes.GetHashCode() ^ _seconds.GetHashCode() ^ (_hemisphere.HasValue ? _hemisphere.Value.GetHashCode() : 0);
		}

		public override string ToString()
		{
			return String.Format("{0}°{1}'{2}\"{3}", _degrees, _minutes, _seconds, _hemisphere.HasValue ? ((char)_hemisphere.Value).ToString() : "");
		}

		public static bool operator ==(Dms dms1, Dms dms2)
		{
			return dms1.Equals(dms2);
		}

		public static bool operator !=(Dms dms1, Dms dms2)
		{
			return !dms1.Equals(dms2);
		}
	}

	public enum Hemisphere
	{
		North = 'N',
		South = 'S',
		East = 'E',
		West = 'W'
	}
}
