using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class SelectionInputSystem : MonoBehaviour, ISelectionInputSystem
	{
		[Inject]
		private ISelectionSystem selectionSystem;
		
		private bool isEnabled = false;
		
		public void Enable()
		{
			isEnabled = true;
		}

		public void Disable()
		{
			isEnabled = false;
		}

		public void OnTileClick(Tile tile)
		{
			if(!isEnabled)
				return;

			switch (tile.State)
			{
				case TileState.Selected:
					selectionSystem.Deselect(tile);
					break;
				
				case TileState.Unselected:
					selectionSystem.Select(tile);
					break;
				
				default:
					Debug.LogError("Unknown state of the tile: " + tile.State);
					break;
			}
		}
	}
}