using System.Collections.Generic;

namespace Jellyvale_TestArchitecture
{
	public sealed class DefaultLevelInitializer : BaseLevelInitializer
	{
		protected override IDictionary<GeneratedLevelType, BaseLevelGenerator> LevelGenerators { get; }
			= new Dictionary<GeneratedLevelType, BaseLevelGenerator>
			{
				{ GeneratedLevelType.Default, new DefaultLevelGenerator() },
				{ GeneratedLevelType.Debug, new DebugDefaultLevelGenerator() }
			};
	}
}