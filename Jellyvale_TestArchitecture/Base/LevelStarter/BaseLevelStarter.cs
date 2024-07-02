namespace Jellyvale_TestArchitecture
{
	public enum LoadedLevelType
	{
		Default, Debug
	}

	public abstract class BaseLevelStarter : ILevelStarter
	{
		public void Dispose()
		{ }

		public abstract void Execute();

		public abstract void ResetCurrentLoop();
	}
}