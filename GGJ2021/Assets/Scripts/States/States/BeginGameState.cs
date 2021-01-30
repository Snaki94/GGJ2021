namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly IRoot root;
		private readonly ILevelGenerator levelGenerator;
		private readonly ITurnSystem turnSystem;
		
		public BeginGameState(IRoot root, ILevelGenerator levelGenerator, ITurnSystem turnSystem)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
			this.turnSystem = turnSystem;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			turnSystem.CreatePlayers();
			root.ChangeState<PlayersTurnState>();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}