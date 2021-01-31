using TMPro;
using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class GameOverController : MonoBehaviour, IGameOverController
	{
		[Inject]
		private IRoot root;
		
		[SerializeField]
		private TMP_Text text1;
		[SerializeField]
		private TMP_Text text2;
		
		public void Show()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}

		public void SetWinner(string winner)
		{
			text1.text = "winner: " + winner;
			text2.text = "winner: " + winner;
		}

		public void OnRestartButton()
		{
			root.ChangeState<MainMenuState>();
		}
	}
}