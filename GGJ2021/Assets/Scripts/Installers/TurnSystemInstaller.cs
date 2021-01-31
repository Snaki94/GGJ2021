using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace GGJ2021
{
	public class TurnSystemInstaller : MonoInstaller
	{
		[SerializeField]
		private Image firstPlayerToken = null;
		[SerializeField]
		private Image secondPlayerToken = null;
		
		public override void InstallBindings()
		{
			Container.Bind<ITurnSystem>().To<TurnSystem>().AsSingle();
			Container.BindInstance(firstPlayerToken).WhenInjectedInto<FirstPlayer>();
			Container.BindInstance(secondPlayerToken).WhenInjectedInto<SecondPlayer>();
			Container.BindFactory<FirstPlayer, FirstPlayerFactory>().AsSingle();
			Container.BindFactory<SecondPlayer, SecondPlayerFactory>().AsSingle();
		}
	}
}