using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Faa.Contracts
{
	public class Obstacle
	{
		private static readonly Regex _julianDateRe = new Regex(@"(?<year>\d{4})(?<days>\d{3})");
		private static readonly Calendar _calendar = new JulianCalendar();

		/// <summary>
		/// ORS Code
		/// </summary>
		public string OrsCode { get; set; }

		public string ObstacleNumber { get; set; }

		public VerificationStatus VerificationStatus { get; set; }

		public string CountryIdentifier { get; set; }

		public string StateIdentifier { get; set; }

		public string CityName { get; set; }

		public Dms Latitude { get; set; }
		public Dms Longitude { get; set; }

		public string ObstacleType { get; set; }

		public int Quantity { get; set; }

		public int AboveGroundLevelHeightInFeet { get; set; }

		public int AboveMeanSeaLevelHeightInFeet { get; set; }

		public Lighting Lighting { get; set; }

		public int? HorizontalAccuracy { get; set; }

		public char? VerticalAccuracy { get; set; }

		public MarkingType? MarkIndicator { get; set; }

		public string FaaStudyNumber { get; set; }

		/// <summary>
		/// A, C, D, Add, Change, Dismantle
		/// </summary>
		public Action Action { get; set; }

		public DateTime JulianDate { get; set; }

		private static DateTime ParseDate(string dateString)
		{
			var match = _julianDateRe.Match(dateString);
			DateTime output;
			if (match != null)
			{
				int year, days;
				year = int.Parse(match.Groups["year"].Value);
				days = int.Parse(match.Groups["days"].Value);
				output = new DateTime(year, 1, 1).AddDays(days - 1);
			}
			else
			{
				output = default(DateTime);
			}

			return output;
		}

		public static Obstacle TryParse(string line)
		{
			Obstacle obstacle = null;

			if (string.IsNullOrWhiteSpace(line))
			{
				return null;
			}

			if (line.Length < 120)
			{
				return null;
			}

			obstacle = new Obstacle
			{
				OrsCode = line.Substring(0, 2),
				ObstacleNumber = line.Substring(3, 6),
				VerificationStatus = (VerificationStatus)line[10],
				CountryIdentifier = line.Substring(12, 2),
				StateIdentifier = line.Substring(15, 2),
				CityName = line.Substring(18, 33 - 18 + 1).Trim(),
				ObstacleType = line.Substring(62, 73 - 62 + 1).Trim(),
				Quantity = int.Parse(line.Substring(75,1)),
				AboveGroundLevelHeightInFeet = int.Parse(line.Substring(77, 81-77+1)),
				AboveMeanSeaLevelHeightInFeet = int.Parse(line.Substring(83,88-83+1)),
				Lighting = (Lighting)line[89],
				VerticalAccuracy = line[93] != ' ' ? line[93] : default(char?),
				MarkIndicator = line[95] != ' ' ? (MarkingType)line[95] : default(MarkingType?),
				FaaStudyNumber = line.Substring(97, 110-97+1).Trim(),
				Action = (Action)line[112],
				JulianDate = ParseDate(line.Substring(114, 120-114+1)) //DateTime.ParseExact(line.Substring(114, 120-114+1), "yyyyMMdd", DateTimeFormatInfo.CurrentInfo)
			};

			int tempInt;

			if (int.TryParse(line.Substring(91), out tempInt))
			{
				obstacle.HorizontalAccuracy = tempInt;
			}


			return obstacle;
		}
	}
}
