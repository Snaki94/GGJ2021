namespace GGJ2021
{
	public interface ISelectionInputSystem
	{
		void Enable();
		void Disable();
		void OnTileClick(Tile tile);
	}
}