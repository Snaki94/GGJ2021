using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class SelectionSystemInstaller : MonoInstaller
	{
		[SerializeField]
		private SelectionInputSystem selectionInputSystem = null;
		
		public override void InstallBindings()
		{
			Container.Bind<ISelectionSystem>().To<SelectionSystem>().AsSingle();
			Container.Bind<ISelectionInputSystem>().FromInstance(selectionInputSystem);
		}
	}
}