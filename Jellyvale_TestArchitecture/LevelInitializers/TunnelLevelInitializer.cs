using System.Collections.Generic;

namespace Jellyvale_TestArchitecture
{
	public sealed class TunnelLevelInitializer : BaseLevelInitializer
	{
		protected override IDictionary<GeneratedLevelType, BaseLevelGenerator> LevelGenerators { get; }
			= new Dictionary<GeneratedLevelType, BaseLevelGenerator>
			{
				{ GeneratedLevelType.Default, new TunnelLevelGenerator() },
				{ GeneratedLevelType.Debug, new DebugTunnelLevelGenerator() }
			};
	}
}