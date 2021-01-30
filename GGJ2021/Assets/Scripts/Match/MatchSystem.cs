using UnityEngine;

namespace GGJ2021
{
	public class MatchSystem : IMatchSystem
	{
		private const int MAX_TILES_COUNT = 54;
		
		private int tilesCount;
		
		public void StartSet()
		{
			tilesCount = MAX_TILES_COUNT;
		}
		
		public void DecreaseCount()
		{
			tilesCount -= 2;
			if(tilesCount == 0)
				EndSet();
		}
		
		private void EndSet()
		{
			Debug.Log("end set");
		}
	}
}