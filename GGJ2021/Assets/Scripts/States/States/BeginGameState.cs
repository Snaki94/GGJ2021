namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly ILevelGenerator levelGenerator;
		
		public BeginGameState(ILevelGenerator levelGenerator)
		{
			this.levelGenerator = levelGenerator;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
		}

		public void Tick()
		{
		}

		public void Dispose()
		{
		}
	}
}