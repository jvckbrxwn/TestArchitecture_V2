namespace Jellyvale_TestArchitecture
{
	public struct Match3LevelParams
	{
		private GeneratedLevelType type;
		private string levelId;

		public Match3LevelParams(GeneratedLevelType type, string levelId)
		{
			this.type = type;
			this.levelId = levelId;
		}
	}
}