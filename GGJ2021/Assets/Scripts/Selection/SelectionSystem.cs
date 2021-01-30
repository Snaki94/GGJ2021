using Zenject;

namespace GGJ2021
{
	public class SelectionSystem : ISelectionSystem
	{
		[Inject]
		private ISignalSystem signalSystem;
		
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
				signalSystem.FireSignal<TileSelectionFinished>();
			}
		}
		
		public void CheckSelection()
		{
			if(firstSelected.Data.Type == secondSelected.Data.Type)
				CollectTiles();
			else
				ResetSelection();
		}
		
		private void CollectTiles()
		{
			firstSelected.Hide();
			firstSelected.State = TileState.Unselected;
			firstSelected = null;
			secondSelected.Hide();
			secondSelected.State = TileState.Unselected;
			secondSelected = null;
		}
		
		private void ResetSelection()
		{
			// TODO: flip down
			firstSelected.State = TileState.Unselected;
			firstSelected = null;
			secondSelected.State = TileState.Unselected;
			secondSelected = null;
		}
	}
}