namespace GGJ2021
{
	public class PlayersTurnState : IState
	{
		private readonly ISelectionInputSystem selectionInputSystem;
		
		public PlayersTurnState(ISelectionInputSystem selectionInputSystem)
		{
			this.selectionInputSystem = selectionInputSystem;
		}
		
		public void Initialize()
		{
			selectionInputSystem.Enable();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			selectionInputSystem.Disable();
		}
	}
}