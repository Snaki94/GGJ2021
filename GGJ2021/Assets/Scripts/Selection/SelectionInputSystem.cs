﻿using UnityEngine;
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

			if(tile.State == TileState.Unselected)
				selectionSystem.Select(tile);
		}
	}
}