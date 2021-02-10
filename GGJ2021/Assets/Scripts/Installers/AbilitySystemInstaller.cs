using Zenject;

namespace GGJ2021
{
	public class AbilitySystemInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<IAbilitySystem>().To<AbilitySystem>().AsTransient();
		}
	}
}