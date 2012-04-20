using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faa.Contracts
{
	public enum VerticalAccuracy
	{
		About3Feet = 'A',
		About10Feet = 'B',
		About20Feet = 'C',
		About50Feet = 'D',
		About125Feet = 'E',
		About250Feet = 'F',
		About500Feet = 'G',
		About1000Feet = 'H',
		Unknown = 'I'
	}
}
