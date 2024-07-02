using System.Collections.Generic;

namespace Jellyvale_TestArchitecture
{
	public sealed class TunnelLevelInitializer : BaseLevelInitializer
	{
		protected override IDictionary<LoadedLevelType, BaseLevelGenerator> LevelGenerators { get; }
			= new Dictionary<LoadedLevelType, BaseLevelGenerator>
			{
				{ LoadedLevelType.Default, new TunnelLevelGenerator() },
				{ LoadedLevelType.Debug, new DebugTunnelLevelGenerator() }
			};
	}
}