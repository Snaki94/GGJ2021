using Zenject;

namespace GGJ2021
{
	public class TurnSystem : ITurnSystem
	{
		[Inject]
		private PlayerFactory playerFactory;
		
		private Player currentPlayer;
		private Player waitingPlayer;

		public void CreatePlayers()
		{
			currentPlayer = playerFactory.Create();
			waitingPlayer = playerFactory.Create();
		}

		public void BeginNextPlayerTurn()
		{
			Player temp = currentPlayer;
			currentPlayer = waitingPlayer;
			waitingPlayer = temp;
		}
	}
}