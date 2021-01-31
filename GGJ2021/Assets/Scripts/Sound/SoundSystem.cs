using UnityEngine;

namespace GGJ2021
{
	public class SoundSystem : ISoundSystem
	{
		private readonly AudioClip[] audioClips;
		private readonly AudioSource[] audioSources;
		
		public SoundSystem(AudioClip[] audioClips, AudioSource[] audioSources)
		{
			this.audioClips = audioClips;
			this.audioSources = audioSources;
		}
		public void PlayFailureSound()
		{
			PlaySound(audioClips[0]);
		}
		
		public void PlaySuccessSound()
		{
			PlaySound(audioClips[1]);
		}

		public void PlayFlipCardSound()
		{
			PlaySound(audioClips[2]);
		}

		public void PlayCreditsEnterSound()
		{
			PlaySound(audioClips[3]);
		}

		public void PlayStartSound()
		{
			PlaySound(audioClips[4]);
		}

		public void PlayGameOverSound()
		{
			PlaySound(audioClips[5]);
		}

		private void PlaySound(AudioClip clip)
		{
			AudioSource audioSource = FindFreeAudioSource();
			if(audioSource == null)
				return;
			
			audioSource.PlayOneShot(clip);
		}
		
		private AudioSource FindFreeAudioSource()
		{
			for(int i = 0; i < audioSources.Length; i++)
			{
				if(!audioSources[i].isPlaying)
					return audioSources[i];
			}
			return null;
		}
	}
}