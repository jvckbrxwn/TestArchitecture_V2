using System;

namespace Jellyvale_TestArchitecture
{
	public class DebugTunnelLevelGenerator : BaseLevelGenerator
	{
		public DebugTunnelLevelGenerator()
		{
			//nothing to do here
		}

		public override LevelData GetLevelData()
		{
			Console.WriteLine($"Trying to get data from {GetType()}");
			return null;
		}
	}
}