namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly IRoot root;
		private readonly ILevelGenerator levelGenerator;
		private readonly ITurnSystem turnSystem;
		private readonly IMatchSystem matchSystem;
		private readonly IGameplayController gameplayController;
		
		public BeginGameState(IRoot root,
			ILevelGenerator levelGenerator,
			ITurnSystem turnSystem,
			IMatchSystem matchSystem,
			IGameplayController gameplayController)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
			this.turnSystem = turnSystem;
			this.matchSystem = matchSystem;
			this.gameplayController = gameplayController;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			turnSystem.CreatePlayers();
			matchSystem.StartSet();
			root.ChangeState<PlayersTurnState>();
			gameplayController.Show();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}