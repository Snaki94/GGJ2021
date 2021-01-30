namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly IRoot root;
		private readonly ILevelGenerator levelGenerator;
		
		public BeginGameState(IRoot root, ILevelGenerator levelGenerator)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			root.ChangeState<PlayersTurnState>();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}