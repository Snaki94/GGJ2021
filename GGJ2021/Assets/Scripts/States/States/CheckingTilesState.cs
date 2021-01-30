namespace GGJ2021
{
	public class CheckingTilesState : IState
	{
		private readonly IRoot root;
		private readonly ISelectionSystem selectionSystem;
		
		public CheckingTilesState(IRoot root, ISelectionSystem selectionSystem)
		{
			this.root = root;
			this.selectionSystem = selectionSystem;
		}
		
		public void Initialize()
		{
			selectionSystem.CheckSelection();
			root.ChangeState<PlayersTurnState>();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}
