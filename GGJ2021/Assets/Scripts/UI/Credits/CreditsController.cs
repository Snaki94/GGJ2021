using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class CreditsController : MonoBehaviour, ICreditsController
	{
		[Inject]
		private IRoot root;
		
		[Inject]
		private ISoundSystem soundSystem;
		
		public void Show()
		{
			gameObject.SetActive(true);
			soundSystem.PlayCreditsEnterSound();
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}
		
		public void OnBackButton()
		{
			root.ChangeState<MainMenuState>();
		}
	}
}