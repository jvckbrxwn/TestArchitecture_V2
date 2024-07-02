using System;

namespace Jellyvale_TestArchitecture
{
	public interface ILevelStarter : IDisposable
	{
		void Execute();
		void ResetCurrentLoop();
	}
}