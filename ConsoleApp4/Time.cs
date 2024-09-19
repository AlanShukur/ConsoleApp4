using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

	public class Time {
		private double _hours;

		private double _seconds;

		public double Hours {
			get {
				return _seconds / 3600;
			}

			set {
				if (value >= 0) {
					_seconds = value * 3600;
				}
			}
		} // dette gjør all koden under gjør

		public double Seconds
		{
			get
			{
				return _seconds;
			}
			set
			{
				_seconds = value;
			}
		}


		 
/*
		public void SetHours(double hours) {
			if (hours >= 0) { 
				_hours = hours;
			}
		}

		public double GetHours() {
			return _hours;
		}*/
	}
}
