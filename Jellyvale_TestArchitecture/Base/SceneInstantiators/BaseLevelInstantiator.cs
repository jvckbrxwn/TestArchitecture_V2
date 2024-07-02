using System;

namespace Jellyvale_TestArchitecture
{
	public abstract class BaseLevelInstantiator<TBaseLevelStarter, TBaseLevelInitializer> : ILoopable, IActivatable
		where TBaseLevelStarter : BaseLevelStarter
		where TBaseLevelInitializer : BaseLevelInitializer
	{
		protected readonly TBaseLevelInitializer LevelInitializer = Activator.CreateInstance<TBaseLevelInitializer>();
		protected readonly TBaseLevelStarter LevelStarter = Activator.CreateInstance<TBaseLevelStarter>();

		public virtual void ResetLoop()
		{
			Console.WriteLine($"Reseting loop from {GetType()}");
		}

		public virtual void Cancel()
		{
			Console.WriteLine($"Canceling from {GetType()}");
		}

		public abstract void LevelInit();

		public void StartLevel()
		{
			LevelStarter.Execute();
		}
	}
}