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
		private readonly IAbilitySystem abilitySystem;

		public BeginGameState(IRoot root,
			ILevelGenerator levelGenerator,
			ITurnSystem turnSystem,
			IMatchSystem matchSystem,
			IGameplayController gameplayController,
			IScoreSystem scoreSystem,
			IAbilitySystem abilitySystem)
		{
			this.root = root;
			this.levelGenerator = levelGenerator;
			this.turnSystem = turnSystem;
			this.matchSystem = matchSystem;
			this.gameplayController = gameplayController;
			this.scoreSystem = scoreSystem;
			this.abilitySystem = abilitySystem;
		}
		
		public void Initialize()
		{
			levelGenerator.Generate();
			turnSystem.CreatePlayers();
			scoreSystem.ResetScore();
			matchSystem.StartSet();
			root.ChangeState<PlayersTurnState>();
			gameplayController.Show();
			turnSystem.GetCurrentPlayer().PlayerController.HideAbilityPanel();
			turnSystem.GetWaitingPlayer().PlayerController.HideAbilityPanel();
			turnSystem.GetCurrentPlayer().AbilitySystem.ResetMana();
			turnSystem.GetWaitingPlayer().AbilitySystem.ResetMana();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}