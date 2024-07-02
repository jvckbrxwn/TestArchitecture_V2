using System;

namespace Jellyvale_TestArchitecture
{
	public sealed class TunnelLevelInstantiator : BaseLevelInstantiator<TunnelLevelStarter, TunnelLevelInitializer>
	{
		//Do some stuff here
		public override void LevelInit()
		{
			Console.WriteLine($"{GetType()} activated");
			LevelInitializer.Execute(GeneratedLevelType.Debug);
		}
	}
}