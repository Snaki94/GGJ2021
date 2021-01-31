using Zenject;

namespace GGJ2021
{
	public class MainMenuControllerInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<IMainMenuController>().To<MainMenuController>().FromResolve();
			Container.Bind<ICreditsController>().To<CreditsController>().FromResolve();
			Container.Bind<IGameplayController>().To<GameplayController>().FromResolve();
			Container.Bind<IGameOverController>().To<GameOverController>().FromResolve();
		}
	}
}