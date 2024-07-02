using System;
using System.Collections.Generic;

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

	public abstract class BaseLevelInitializer : ILevelInitializer
	{
		protected abstract IDictionary<LoadedLevelType, BaseLevelGenerator> LevelGenerators { get; }

		public virtual void Execute(Match3LevelParams @params)
		{
			Console.WriteLine($"{GetType()} executing");
			Console.WriteLine(@params.LevelId);
			LevelGenerators[@params.Type].GetLevelData();
		}
	}
}