using UnityEngine;

namespace GGJ2021
{
	public class LevelInitializer : ILevelInitializer
	{
		private readonly Tile[] tiles;
		private readonly TileData[] tileDatas;
		
		public LevelInitializer(Tile[] tiles, TileData[] tileDatas)
		{
			this.tiles = tiles;
			this.tileDatas = tileDatas;
		}

		public void InitializeLevel()
		{
			for(int i = 0; i < tiles.Length; i++)
			{
				tiles[i].Data = tileDatas[i / 2];
			}
		}
	}
}