namespace GGJ2021
{
	public class CreditsState : IState
	{
		private readonly ICreditsController creditsController;
		
		public CreditsState(ICreditsController creditsController)
		{
			this.creditsController = creditsController;
		}
		
		public void Initialize()
		{
			creditsController.Show();
		}

		public void Tick()
		{}

		public void Dispose()
		{
			creditsController.Hide();
		}
	}
}