namespace GGJ2021
{
	public class PlayersTurnState : IState
	{
		private readonly ISelectionInputSystem selectionInputSystem;
		private readonly ITurnSystem turnSystem;
		
		public PlayersTurnState(ISelectionInputSystem selectionInputSystem, ITurnSystem turnSystem)
		{
			this.selectionInputSystem = selectionInputSystem;
			this.turnSystem = turnSystem;
		}
		
		public void Initialize()
		{
			selectionInputSystem.Enable();
			turnSystem.BeginNextPlayerTurn();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			selectionInputSystem.Disable();
		}
	}
}