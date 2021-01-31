using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class UtilsInstaller : MonoInstaller
	{
		[SerializeField]
		private MethodCaller methodCaller;

		public override void InstallBindings()
		{
			Container.Bind<IMethodCaller>().FromInstance(methodCaller);
		}
	}
}