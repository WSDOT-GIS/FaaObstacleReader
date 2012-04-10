using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaaObstruction
{
	public enum MarkingType
	{
		/// <summary>Orange or Orange and White Paint</summary>
		OrangeOrOrangeAndWhitePaint = 'W',

		/// <summary>White Paint Only</summary>
		WhitePaintOnly = 'P',

		/// <summary>Marked</summary>
		Marked = 'M',

		/// <summary>Flag Marker</summary>
		FlagMarker = 'F',

		/// <summary>Spherical Marker</summary>
		SphericalMarker = 'S',

		/// <summary>None</summary>
		None = 'N',

		/// <summary>Unknown</summary>
		Unknown = 'U'
	}
}
