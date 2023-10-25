using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Server
{
	public class _1
	{
		public string display { get; set; }
		public int rawMs { get; set; }
	}

	public class _2
	{
		public string display { get; set; }
		public int rawMs { get; set; }
	}

	public class _3
	{
		public string display { get; set; }
		public int rawMs { get; set; }
	}

	public class Classification
	{
		public string id { get; set; }
		public string startNumber { get; set; }
		public string name { get; set; }
		public string teamName { get; set; }
		public string className { get; set; }
		public int position { get; set; }
		public bool finished { get; set; }
		public int laps { get; set; }
		public FastestLapTime fastestLapTime { get; set; }
		public LastLapTime lastLapTime { get; set; }
		public CurrentLapSectorTimes currentLapSectorTimes { get; set; }
	}

	public class CurrentLapSectorTimes
	{
		[JsonProperty("1")]
		public _1 _1 { get; set; }

		[JsonProperty("2")]
		public _2 _2 { get; set; }

		[JsonProperty("3")]
		public _3 _3 { get; set; }
	}

	public class FastestLapTime
	{
		public string display { get; set; }
		public int rawMs { get; set; }
	}

	public class LastLapTime
	{
		public string display { get; set; }
		public int rawMs { get; set; }
	}

	public class Root
	{
		public string sessionId { get; set; }
		public string series { get; set; }
		public string name { get; set; }
		public string track { get; set; }
		public SessionState state { get; set; }
		public DateTime startTime { get; set; }
		public string duration { get; set; }
		public string timeRemaining { get; set; }
		public List<Classification> classification { get; set; }
	}

	public enum SessionState
	{
		Pending, Active, Running, Finished, Completed
	}
}
