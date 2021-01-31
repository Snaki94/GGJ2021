using TMPro;
using UnityEngine.UI;

namespace GGJ2021
{
	public class Player
	{
		public Image Token { get; }
		public TMP_Text ScoreText { get; }
		public int Score { get; set; }
		
		public Player(Image token, TMP_Text scoreText)
		{
			Token = token;
			ScoreText = scoreText;
		}
	}
}