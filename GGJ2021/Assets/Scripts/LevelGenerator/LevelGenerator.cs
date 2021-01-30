using UnityEngine;

namespace GGJ2021
{
	public class LevelGenerator : ILevelGenerator
	{
		private readonly Tile[] tiles;
		
		public LevelGenerator(Tile[] tiles)
		{
			this.tiles = tiles;
		}
		
		public void Generate()
		{
			for (int i = tiles.Length - 1; i > 0; i--)  
			{ 
				int newIndex = Random.Range(0, i+1); 
				TileData temp = tiles[i].Data; 
				tiles[i].Data = tiles[newIndex].Data; 
				tiles[newIndex].Data = temp; 
			} 
		}
	}
}