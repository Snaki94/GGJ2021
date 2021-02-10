using UnityEngine;

namespace GGJ2021
{
	public class PlayerView : MonoBehaviour, IPlayerView
	{
		[SerializeField]
		private GameObject abilityPanel = null;
		
		public void ShowAbilityPanel()
		{
			abilityPanel.SetActive(true);
		}

		public void HideAbilityPanel()
		{
			abilityPanel.SetActive(false);
		}
	}
}