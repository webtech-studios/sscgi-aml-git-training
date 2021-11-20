using System;

namespace SSCGI.AML
{
	public class SampleClass1
	{
		private string _privateMember = "test";

		public SampleClass1()
		{
		
		}

		internal void EchoMessage(string message)
		{
			Console.WriteLine($"Echo message: {message}");
		}

		public override string ToString()
		{
			return _privateMember;
		}

		public DateTime CurrentDate { get; set; }

		private DateTime _targetDate;
		public DateTime TargetDate
		{
			get
			{
				return _targetDate;
			}

			set
			{
				this._targetDate = value;
			}
		}
	}
}	
