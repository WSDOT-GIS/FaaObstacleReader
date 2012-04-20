using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Faa.Contracts
{
	/// <summary>
	/// A class used to read FAA Digital Obstacle Files (DOF).
	/// </summary>
	public sealed class DigitalObstacleFileReader : StreamReader
	{
		private static readonly Regex _currencyDateRegex = new Regex(@"(?i)(?<=CURRENCY DATE\s*=\s*)(?<month>\d{2})/(?<day>\d{2})/(?<year>\d+)");

		/// <summary>
		/// The "currency date" of the DOF.
		/// </summary>
		public DateTime CurrencyDate { get; private set; }

		/// <summary>
		/// Creates a new <see cref="DigitalObstacleFileReader"/> for the given file.
		/// </summary>
		/// <param name="path">The file that will be read by this class.</param>
		public DigitalObstacleFileReader(string path) : base(path)
		{
			// Read the pre-data lines.
			// Read the first line, which has the "currency date".
			string line = base.ReadLine();
			var match = _currencyDateRegex.Match(line);
			if (match != null && match.Success)
			{
				this.CurrencyDate = DateTime.Parse(match.Value);
			}
			// Skip the next few lines which do not have data.
			for (int i = 0; i < 3; i++)
			{
				base.ReadLine();
			}
		}

		public Obstacle ReadObstacle()
		{
			string line = base.ReadLine();
			var obstacle = Obstacle.Parse(line);

			return obstacle;
		}

		public List<Obstacle> ReadObstacles()
		{
			var list = new List<Obstacle>();

			string line = base.ReadLine();

			while (line != null)
			{
				list.Add(Obstacle.Parse(line));
				line = base.ReadLine();
			}

			return list;
		}


	}
}
