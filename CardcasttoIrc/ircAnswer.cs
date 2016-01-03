using System;

namespace CardcasttoIrc
{
	public class ircAnswer
	{
		public string type{ get { return "Answer"; }}
		public string value{ get; set; }
		public string keep { get { return "Yes"; }}
		public int draw { get; set;}
		public int pick { get { return 1; }}
		public string source{get;set;}
	}
}

