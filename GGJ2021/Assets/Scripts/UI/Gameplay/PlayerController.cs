using UnityEngine;

namespace GGJ2021
{
	public class PlayerController : MonoBehaviour, IPlayerController
	{
		[SerializeField]
		private PlayerView playerView;
		
		public void ShowAbilityPanel()
		{
			playerView.ShowAbilityPanel();
		}

		public void HideAbilityPanel()
		{
			playerView.HideAbilityPanel();
		}
	}
}