using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class Tile : MonoBehaviour
	{
		public TileData Data { get; set; }
		public TileState State { get; set; }
		
		[Inject]
		private ISelectionInputSystem selectionInputSystem;
		
		public void Show()
		{
			gameObject.SetActive(true);
		}
		
		public void Hide()
		{
			gameObject.SetActive(false);
		}
		
		public void OnPointerClick()
		{
			selectionInputSystem.OnTileClick(this);
		}
	}
}