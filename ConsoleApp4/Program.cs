namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args) {
			Time time = new();
			//time.SetHours(5.5);
			time.Hours = -2;


			//Console.WriteLine("Time in hours is: " + time.GetHours());
			Console.WriteLine($"Time in hours is: {time.Hours}" + " and time in seconds is: " + time.Seconds);
			Console.WriteLine("Time in seconds is: " + time.Seconds);

			time.Seconds = 1800;
			Console.WriteLine("Time in hours is: " + time.Hours);
			Console.WriteLine("Time in seconds is: " + time.Seconds);
		}
	}

}
