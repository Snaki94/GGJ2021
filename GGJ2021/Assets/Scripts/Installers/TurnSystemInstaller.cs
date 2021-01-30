using Zenject;

namespace GGJ2021
{
	public class TurnSystemInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<ITurnSystem>().To<TurnSystem>().AsSingle();
			Container.BindFactory<Player, PlayerFactory>().AsSingle();
		}
	}
}