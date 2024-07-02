namespace Jellyvale_TestArchitecture
{
	public abstract class BaseLevelGenerator
	{
		//field -> current already generated level

		public abstract LevelData GetLevelData();

		//a lot of functions with data returning as score calculation
		//chest loot table
		//etc.
	}
}