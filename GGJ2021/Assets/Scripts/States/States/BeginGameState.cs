namespace GGJ2021
{
	public class BeginGameState : IState
	{
		private readonly IRoot root;
		private readonly ILevelGenerator levelGenerator;
		private readonly ITurnSystem turnSystem;
		private readonly IMatchSystem matchSystem;
		private readonly IGameplayController gameplayController;
		private readonly IScoreSystem scoreSystem;
		
		public BeginGameState(IRoot root,
			ILevelGenerator levelGenerator,
			ITurnSystem turnSystem,
			IMatchSystem matchSystem,
			IGameplayController gameplayController,
			IScoreSystem scoreSystem)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
			this.turnSystem = turnSystem;
			this.matchSystem = matchSystem;
			this.gameplayController = gameplayController;
			this.scoreSystem = scoreSystem;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			turnSystem.CreatePlayers();
			scoreSystem.ResetScore();
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