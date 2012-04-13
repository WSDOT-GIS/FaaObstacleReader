using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faa.Contracts
{
	public enum VerticalDatum
	{
		/// <summary>
		/// National Geodetic Vertical Datum of 1929 (NGVD 29)
		/// </summary>
		/// <see href="http://en.wikipedia.org/wiki/North_American_Vertical_Datum_of_1988"/>
		Ngvd29,
		/// <summary>
		/// North American Vertical Datum of 1988 (NAVD 88)
		/// </summary>
		/// <see href="http://en.wikipedia.org/wiki/National_Geodetic_Vertical_Datum_of_1929"/>
		Navd88
	}
}
