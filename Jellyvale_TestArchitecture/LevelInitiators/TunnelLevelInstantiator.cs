using System;

namespace Jellyvale_TestArchitecture
{
	public sealed class TunnelLevelInstantiator : BaseLevelInstantiator<TunnelLevelStarter, TunnelLevelInitializer>
	{
		//Do some stuff here
		public override void LevelInit()
		{
			Console.WriteLine($"{GetType()} activated");
			LevelInitializer.Execute(new Match3LevelParams(LoadedLevelType.Debug, "d_tunnel_1"));
		}
	}
}