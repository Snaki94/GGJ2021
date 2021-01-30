namespace GGJ2021
{
	public class PlayersTurnState : IState
	{
		private readonly IRoot root;
		private readonly ISignalSystem signalSystem;
		private readonly ISelectionInputSystem selectionInputSystem;
		private readonly ITurnSystem turnSystem;
		
		public PlayersTurnState(IRoot root,
			ISignalSystem signalSystem,
			ISelectionInputSystem selectionInputSystem,
			ITurnSystem turnSystem)
		{
			this.root = root;
			this.signalSystem = signalSystem;
			this.selectionInputSystem = selectionInputSystem;
			this.turnSystem = turnSystem;
		}
		
		public void Initialize()
		{
			signalSystem.SubscribeSignal<TileSelectionFinished>(OnTileSelectionFinished);
			selectionInputSystem.Enable();
			turnSystem.BeginNextPlayerTurn();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			selectionInputSystem.Disable();
			signalSystem.UnsubscribeSignal<TileSelectionFinished>(OnTileSelectionFinished);
		}
		
		private void OnTileSelectionFinished()
		{
			root.ChangeState<CheckingTilesState>();
		}
	}
}