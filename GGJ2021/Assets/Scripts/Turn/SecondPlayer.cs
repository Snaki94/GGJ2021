using TMPro;
using UnityEngine.UI;

namespace GGJ2021
{
	public class SecondPlayer : Player
	{
		public SecondPlayer(Image token, TMP_Text scoreText)
			: base(token, scoreText, "Player #2")
		{}
	}
}