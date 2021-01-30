using UnityEngine;

namespace GGJ2021
{
	public class SelectionSystem : ISelectionSystem
	{
		private Tile firstSelected;
		private Tile secondSelected;
		
		public void Select(Tile tile)
		{
			tile.State = TileState.Selected;
			if(firstSelected == null)
				firstSelected = tile;
			else
			{
				secondSelected = tile;
				Debug.Log("Selection finished");
			}
		}

		public void Deselect(Tile tile)
		{
			tile.State = TileState.Unselected;
			firstSelected = null;
		}
		
		// TODO: reset selection
	}
}