using System;

namespace Jellyvale_TestArchitecture
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("\n//mode added");
			Match3GameMode match3GameMode = new Match3GameMode();
			match3GameMode.ActivateMode();

			Console.WriteLine("\n//mode added");
			TunnelMatch3GameMode tunnelMatch3GameMode = new TunnelMatch3GameMode();
			tunnelMatch3GameMode.ActivateMode();
		}
	}
}