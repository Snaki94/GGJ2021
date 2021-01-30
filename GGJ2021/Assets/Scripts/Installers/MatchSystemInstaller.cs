using Zenject;

namespace GGJ2021
{
	public class MatchSystemInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<IMatchSystem>().To<MatchSystem>().AsSingle();
		}
	}
}