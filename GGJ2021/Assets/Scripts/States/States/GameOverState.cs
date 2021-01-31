namespace GGJ2021
{
	public class GameOverState : IState
	{
		private readonly IGameplayController gameplayController;
		private readonly IGameOverController gameOverController;
		private readonly IScoreSystem scoreSystem;
		
		public GameOverState(IGameplayController gameplayController,
			IGameOverController gameOverController,
			IScoreSystem scoreSystem)
		{
			this.gameplayController = gameplayController;
			this.gameOverController = gameOverController;
			this.scoreSystem = scoreSystem;
		}
		
		public void Initialize()
		{
			gameplayController.Hide();
			gameOverController.SetWinner(scoreSystem.GetWinner());
			gameOverController.Show();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			gameOverController.Hide();
		}
	}
}