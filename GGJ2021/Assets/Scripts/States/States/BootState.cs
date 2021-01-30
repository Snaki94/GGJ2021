namespace GGJ2021
{
	public class BootState : IState
	{
		private readonly IRoot root;
		private readonly ILevelInitializer levelInitializer;
		
		public BootState(IRoot root, ILevelInitializer levelInitializer)
		{
			this.root = root;
			this.levelInitializer = levelInitializer;
		}
		
		public void Initialize()
		{
			levelInitializer.InitializeLevel();
			root.ChangeState<BeginGameState>();
		}

		public void Tick()
		{}

		public void Dispose()
		{}
	}
}