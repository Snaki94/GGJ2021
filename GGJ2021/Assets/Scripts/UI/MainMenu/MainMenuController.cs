using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class MainMenuController : MonoBehaviour, IMainMenuController
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
		
		public void OnStartButton()
		{
			root.ChangeState<BeginGameState>();
		}
		
		public void OnCreditsButton()
		{
			root.ChangeState<CreditsState>();
		}
		
		public void OnQuitButton()
		{
			Application.Quit();
		}
	}
}