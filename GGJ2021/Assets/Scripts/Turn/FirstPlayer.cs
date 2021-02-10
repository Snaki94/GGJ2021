using TMPro;
using UnityEngine.UI;
using Zenject;

namespace GGJ2021
{
	public class FirstPlayer : Player
	{
		public FirstPlayer(Image token, TMP_Text scoreText, [Inject(Id = "FirstPlayer")]IPlayerController playerController, IAbilitySystem abilitySystem)
			: base(token, scoreText, "Player #1", playerController, abilitySystem)
		{}
	}
}