using System;

namespace Jellyvale_TestArchitecture
{
	public class DebugDefaultLevelGenerator : BaseLevelGenerator
	{
		public DebugDefaultLevelGenerator()
		{
			//nothing to do
		}

		public override LevelData GetLevelData()
		{
			Console.WriteLine($"Trying to get data from {GetType()}");
			return null;
		}
	}
}