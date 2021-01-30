using Zenject;

namespace GGJ2021
{
	public class GeneratorInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<ILevelInitializer>().To<LevelInitializer>().AsSingle();
			Container.Bind<ILevelGenerator>().To<LevelGenerator>().AsSingle();
		}
	}
}