using UnityEngine;

namespace GGJ2021
{
	public class Tile : MonoBehaviour
	{
		public TileData Data { get; set; }
		
		public void Show()
		{
			gameObject.SetActive(true);
		}
		
		public void Hide()
		{
			gameObject.SetActive(false);
		}
	}
}