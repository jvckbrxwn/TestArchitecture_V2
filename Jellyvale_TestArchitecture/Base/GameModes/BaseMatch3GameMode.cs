using System;

namespace Jellyvale_TestArchitecture
{
	public abstract class BaseMatch3GameMode<T> where T : ILoopable, IActivatable
	{
		//Will be replaced with Context.Container.Resolve(out T value);
		private readonly T levelInitiator = Activator.CreateInstance<T>();
		// ^ should be protected
		//if we want to override ActivatedMode()

		public virtual void ActivateMode()
		{
			if (levelInitiator == null)
			{
				Console.WriteLine($"Level Initiator is not initialized {GetType()}");
				return;
			}

			//here we have to get id level data
			//something like

			levelInitiator.LevelInit();
			levelInitiator.StartLevel();
		}
	}
}