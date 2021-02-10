using TMPro;
using UnityEngine.UI;
using Zenject;

namespace GGJ2021
{
	public class SecondPlayer : Player
	{
		public SecondPlayer(Image token, TMP_Text scoreText, [Inject(Id = "SecondPlayer")]IPlayerController playerController, IAbilitySystem abilitySystem)
			: base(token, scoreText, "Player #2", playerController, abilitySystem)
		{}
	}
}