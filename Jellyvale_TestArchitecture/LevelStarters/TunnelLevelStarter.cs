using System;

namespace Jellyvale_TestArchitecture
{
	public sealed class TunnelLevelStarter : BaseLevelStarter
	{
		public override void Execute()
		{
			Console.WriteLine($"{GetType()} executing");
		}

		public override void ResetCurrentLoop()
		{
			Console.WriteLine($"{GetType()} reseting current loop");
		}
	}
}