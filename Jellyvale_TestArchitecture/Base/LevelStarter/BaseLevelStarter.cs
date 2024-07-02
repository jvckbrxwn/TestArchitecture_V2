using System;
using System.Collections.Generic;

namespace Jellyvale_TestArchitecture
{
	public enum GeneratedLevelType
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

	public abstract class BaseLevelInitializer : ILevelInitializer
	{
		protected abstract IDictionary<GeneratedLevelType, BaseLevelGenerator> LevelGenerators { get; }

		public virtual void Execute(GeneratedLevelType type)
		{
			Console.WriteLine($"{GetType()} executing");
			LevelGenerators[type].GetLevelData();
		}
	}
}