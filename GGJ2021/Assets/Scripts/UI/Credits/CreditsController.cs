using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class CreditsController : MonoBehaviour, ICreditsController
	{
		[Inject]
		private IRoot root;
		
		public void Show()
		{
			gameObject.SetActive(true);
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