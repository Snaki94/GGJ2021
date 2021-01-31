using TMPro;
using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class ScoreSystemInstaller : MonoInstaller
	{
		[SerializeField]
		private TMP_Text firstPlayerScore = null;
		[SerializeField]
		private TMP_Text secondPlayerScore = null;
		
		public override void InstallBindings()
		{
			Container.Bind<IScoreSystem>().To<ScoreSystem>().AsSingle();
			Container.BindInstance(firstPlayerScore).WhenInjectedInto<FirstPlayer>();
			Container.BindInstance(secondPlayerScore).WhenInjectedInto<SecondPlayer>();
		}
	}
}