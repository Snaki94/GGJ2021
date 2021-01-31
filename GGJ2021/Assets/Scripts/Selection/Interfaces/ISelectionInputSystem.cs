namespace GGJ2021
{
	public interface ISelectionInputSystem
	{
		void Enable();
		void Disable();
		void OnTileEnter(Tile tile);
		void OnTileClick(Tile tile);
		void OnTileExit(Tile tile);
	}
}