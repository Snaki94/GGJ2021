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
		[Inject]
		private IScoreSystem scoreSystem;

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
			signalSystem.FireSignal<TileCheckingFinished>();
		}
		
		private void CollectTiles()
		{
			firstSelected.Hide();
			DeselectFirst();
			secondSelected.Hide();
			DeselectSecond();
			matchSystem.DecreaseCount();
			scoreSystem.IncreaseScore();
		}
		
		private void ResetSelection()
		{
			soundSystem.PlayTestSound();
			firstSelected.FlipDown();
			firstSelected.ScaleDown();
			DeselectFirst();
			secondSelected.FlipDown();
			secondSelected.ScaleDown();
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