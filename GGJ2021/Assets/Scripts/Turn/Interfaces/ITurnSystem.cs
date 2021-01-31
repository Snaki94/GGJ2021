namespace GGJ2021
{
	public interface ITurnSystem
	{
		void CreatePlayers();
		void BeginNextPlayerTurn();
		Player GetCurrentPlayer();
		Player GetWaitingPlayer();
	}
}