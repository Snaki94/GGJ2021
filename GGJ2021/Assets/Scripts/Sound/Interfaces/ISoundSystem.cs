namespace GGJ2021
{
	public interface ISoundSystem
	{
		void PlaySuccessSound();
		void PlayFailureSound();

		void PlayFlipCardSound();

		void PlayCreditsEnterSound();

		void PlayStartSound();
		void PlayGameOverSound();
	}
}