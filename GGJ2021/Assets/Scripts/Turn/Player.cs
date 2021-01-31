using UnityEngine.UI;

namespace GGJ2021
{
	public class Player
	{
		public Image Token { get; }
		
		public Player(Image token)
		{
			Token = token;
		}
	}
}