using System;

namespace Jellyvale_TestArchitecture
{
	public sealed class DefaultLevelInstantiator : BaseLevelInstantiator<DefaultLevelStarter, DefaultLevelInitializer>
	{
		//Do some stuff here

		public override void LevelInit()
		{
			Console.WriteLine($"{GetType()} activated");
			//These params we have to send into generator to understand with mode (default or debug) he have to instantiate
			Match3LevelParams @params = new Match3LevelParams(GeneratedLevelType.Default, "d_level_123");
			LevelInitializer.Execute(GeneratedLevelType.Default);
		}
	}
}