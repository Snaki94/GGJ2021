using Zenject;

namespace GGJ2021
{
	public class ScoreSystem : IScoreSystem
	{
		[Inject]
		private ITurnSystem turnSystem;
		
		public int GetScore()
		{
			return turnSystem.GetCurrentPlayer().Score;
		}

		public void IncreaseScore()
		{
			turnSystem.GetCurrentPlayer().Score++;
			turnSystem.GetCurrentPlayer().ScoreText.text = turnSystem.GetCurrentPlayer().Score.ToString();
		}

		public void ResetScore()
		{
			turnSystem.GetCurrentPlayer().Score = 0;
			turnSystem.GetCurrentPlayer().ScoreText.text = turnSystem.GetCurrentPlayer().Score.ToString();
			turnSystem.GetWaitingPlayer().Score = 0;
			turnSystem.GetWaitingPlayer().ScoreText.text = turnSystem.GetWaitingPlayer().Score.ToString();
		}
		
		public string GetWinner()
		{
			if(turnSystem.GetCurrentPlayer().Score > turnSystem.GetWaitingPlayer().Score)
			{
				return turnSystem.GetCurrentPlayer().Name;
			}
			else
			{
				return turnSystem.GetWaitingPlayer().Name;
			}
		}
	}
}