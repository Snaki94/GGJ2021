namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly IRoot root;
		private readonly ILevelGenerator levelGenerator;
		private readonly ITurnSystem turnSystem;
		private readonly IMatchSystem matchSystem;
		
		public BeginGameState(IRoot root,
			ILevelGenerator levelGenerator,
			ITurnSystem turnSystem,
			IMatchSystem matchSystem)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
			this.turnSystem = turnSystem;
			this.matchSystem = matchSystem;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			turnSystem.CreatePlayers();
			matchSystem.StartSet();
			root.ChangeState<PlayersTurnState>();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}