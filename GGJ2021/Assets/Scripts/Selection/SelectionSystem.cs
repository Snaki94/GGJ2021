using Zenject;

namespace GGJ2021
{
	public class SelectionSystem : ISelectionSystem
	{
		[Inject]
		private ISignalSystem signalSystem;
		[Inject]
		private IMatchSystem matchSystem;
		[Inject]
		private ISoundSystem soundSystem;
		
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
			DeselectFirst();
			secondSelected.Hide();
			DeselectSecond();
			matchSystem.DecreaseCount();
		}
		
		private void ResetSelection()
		{
			soundSystem.PlayTestSound();
			firstSelected.FlipDown();
			DeselectFirst();
			secondSelected.FlipDown();
			DeselectSecond();
		}
		
		private void DeselectFirst()
		{
			firstSelected.State = TileState.Unselected;
			firstSelected = null;
		}
		
		private void DeselectSecond()
		{
			secondSelected.State = TileState.Unselected;
			secondSelected = null;
		}
	}
}