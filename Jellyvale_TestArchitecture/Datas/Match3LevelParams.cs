namespace Jellyvale_TestArchitecture
{
	public struct Match3LevelParams
	{
		private readonly LoadedLevelType type;
		private readonly string levelId;

		public Match3LevelParams(LoadedLevelType type, string levelId)
		{
			this.type = type;
			this.levelId = levelId;
		}

		public LoadedLevelType Type => type;
		public string LevelId => levelId;
	}
}