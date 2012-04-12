using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Faa.Contracts
{
	public sealed class DigitalObstacleFileReader : StreamReader
	{
		private static readonly Regex _currencyDateRegex = new Regex(@"(?i)(?<=CURRENCY DATE\s*=\s*)(?<month>\d{2})/(?<day>\d{2})/(?<year>\d+)");

		public DateTime CurrencyDate { get; private set; }

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
			var obstacle = Obstacle.TryParse(line);

			return obstacle;
		}

		public List<Obstacle> ReadObstacles()
		{
			var list = new List<Obstacle>();

			string line = base.ReadLine();

			while (line != null)
			{
				list.Add(Obstacle.TryParse(line));
				line = base.ReadLine();
			}

			return list;
		}


	}
}
