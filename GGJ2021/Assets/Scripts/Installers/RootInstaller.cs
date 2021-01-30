using Zenject;

namespace GGJ2021
{
	public class RootInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.BindInterfacesAndSelfTo<Root>().AsSingle();
		}
	}
}