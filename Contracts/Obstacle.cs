using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaaObstruction
{
	public class Obstacle
	{
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
		public string Action { get; set; }

		public DateTime JulianDate { get; set; }
	}
}
