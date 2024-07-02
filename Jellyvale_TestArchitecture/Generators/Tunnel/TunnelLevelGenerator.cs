using System;

namespace Jellyvale_TestArchitecture
{
	public class TunnelLevelGenerator : BaseLevelGenerator
	{
		public TunnelLevelGenerator()
		{
			//get saved state from protodata
			//parse and generate existing level
		}

		public override LevelData GetLevelData()
		{
			Console.WriteLine($"Trying to get data from {GetType()}");
			return null;
		}
	}
}