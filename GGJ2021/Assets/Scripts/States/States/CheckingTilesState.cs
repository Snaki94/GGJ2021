namespace GGJ2021
{
	public class CheckingTilesState : IState
	{
		private readonly IRoot root;
		private readonly ISignalSystem signalSystem;
		private readonly ISelectionSystem selectionSystem;
		private readonly IMethodCaller methodCaller;
		
		public CheckingTilesState(IRoot root,
			ISignalSystem signalSystem,
			ISelectionSystem selectionSystem,
			IMethodCaller methodCaller)
		{
			this.root = root;
			this.signalSystem = signalSystem;
			this.selectionSystem = selectionSystem;
			this.methodCaller = methodCaller;
		}
		
		public void Initialize()
		{
			signalSystem.SubscribeSignal<TileCheckingFinished>(OnCheckingTilesFinished);
			methodCaller.CallMethodAfterSeconds(selectionSystem.CheckSelection, 1.5f);
		}

		public void Tick()
		{}

		public void Dispose()
		{
			signalSystem.UnsubscribeSignal<TileCheckingFinished>(OnCheckingTilesFinished);
		}
		
		private void OnCheckingTilesFinished()
		{
			root.ChangeState<PlayersTurnState>();
		}
	}
}
