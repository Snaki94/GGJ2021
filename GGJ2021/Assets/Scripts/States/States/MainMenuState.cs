namespace GGJ2021
{
	public class MainMenuState : IState
	{
		private readonly IMainMenuController mainMenuController;
		
		public MainMenuState(IMainMenuController mainMenuController)
		{
			this.mainMenuController = mainMenuController;
		}
		
		public void Initialize()
		{
			mainMenuController.Show();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			mainMenuController.Hide();
		}
	}
}