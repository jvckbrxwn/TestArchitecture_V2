using System.Collections.Generic;

namespace Jellyvale_TestArchitecture
{
	public sealed class DefaultLevelInitializer : BaseLevelInitializer
	{
		protected override IDictionary<LoadedLevelType, BaseLevelGenerator> LevelGenerators { get; }
			= new Dictionary<LoadedLevelType, BaseLevelGenerator>
			{
				{ LoadedLevelType.Default, new DefaultLevelGenerator() },
				{ LoadedLevelType.Debug, new DebugDefaultLevelGenerator() }
			};
	}
}