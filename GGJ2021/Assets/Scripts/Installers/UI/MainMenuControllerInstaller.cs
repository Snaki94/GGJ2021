using Zenject;

namespace GGJ2021
{
	public class MainMenuControllerInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<IMainMenuController>().To<MainMenuController>().FromResolve();
		}
	}
}