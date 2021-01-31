using Zenject;

namespace GGJ2021
{
	public class TurnSystem : ITurnSystem
	{
		[Inject]
		private FirstPlayerFactory firstPlayerFactory;
		[Inject]
		private SecondPlayerFactory secondPlayerFactory;
		
		private Player currentPlayer;
		private Player waitingPlayer;

		public void CreatePlayers()
		{
			currentPlayer = firstPlayerFactory.Create();
			waitingPlayer = secondPlayerFactory.Create();
		}

		public void BeginNextPlayerTurn()
		{
			Player temp = currentPlayer;
			currentPlayer = waitingPlayer;
			waitingPlayer = temp;
			UpdateTurnToken();
		}
		
		private void UpdateTurnToken()
		{
			currentPlayer.Token.gameObject.SetActive(true);
			waitingPlayer.Token.gameObject.SetActive(false);
		}
	}
}