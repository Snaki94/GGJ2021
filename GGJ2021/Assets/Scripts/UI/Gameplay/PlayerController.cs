using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class PlayerController : MonoBehaviour, IPlayerController
	{
		[Inject]
		private ITurnSystem turnSystem;
		
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
		
		public void OnShuffleButton()
		{
			playerView.HideAbilityPanel();
			turnSystem.GetCurrentPlayer().AbilitySystem.ResetMana();
		}
		
		public void OnConfusionButton()
		{
			playerView.HideAbilityPanel();
			turnSystem.GetCurrentPlayer().AbilitySystem.ResetMana();
		}
		
		public void OnLockButton()
		{
			playerView.HideAbilityPanel();
			turnSystem.GetCurrentPlayer().AbilitySystem.ResetMana();
		}
	}
}