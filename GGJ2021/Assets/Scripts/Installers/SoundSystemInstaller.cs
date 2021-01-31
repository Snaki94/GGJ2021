using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class SoundSystemInstaller : MonoInstaller
	{
		[SerializeField]
		private AudioClip[] audioClips = null;
		
		[SerializeField]
		private AudioSource[] audioSources = null;
		
		public override void InstallBindings()
		{
			Container.Bind<ISoundSystem>().To<SoundSystem>().AsSingle();
			Container.BindInstance(audioClips);
			Container.BindInstance(audioSources);
		}
	}
}