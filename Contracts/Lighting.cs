using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faa.Contracts
{
	public enum Lighting
	{
		/// <summary>Red</summary>
		Red = 'R',

		/// <summary>Medium intensity White Strobe & Red</summary>
		MediumIntensityWhiteStrobeAndRed = 'D',

		/// <summary>High Intensity White Strobe & Red</summary>
		HighIntensityWhiteStrobeAndRed = 'H',

		/// <summary>Medium Intensity White Strobe</summary>
		MediumIntensityWhiteStrobe = 'M',

		/// <summary>High Intensity White Strobe</summary>
		HighIntensityWhiteStrobe = 'S',

		/// <summary>Flood</summary>
		Flood = 'F',

		/// <summary>Dual Medium Catenary</summary>
		DualMediumCatenary = 'C',

		/// <summary>Synchronized Red Lighting</summary>
		SynchronizedRedLighting = 'W',

		/// <summary>Lighted (Type Unknown)</summary>
		LightedTypeUnknown = 'L',

		/// <summary>None</summary>
		None = 'N',

		/// <summary>Unknown</summary>
		Unknown = 'U'

	}
}
