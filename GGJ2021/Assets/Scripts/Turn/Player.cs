﻿using TMPro;
using UnityEngine.UI;

namespace GGJ2021
{
	public class Player
	{
		public Image Token { get; }
		public TMP_Text ScoreText { get; }
		public string Name { get; }
		public int Score { get; set; }
		
		public Player(Image token, TMP_Text scoreText, string name)
		{
			Token = token;
			ScoreText = scoreText;
			Name = name;
		}
	}
}