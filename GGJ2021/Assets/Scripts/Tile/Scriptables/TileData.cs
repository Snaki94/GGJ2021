using UnityEngine;
using Zenject;

namespace GGJ2021
{
	[CreateAssetMenu(menuName = "Data/New Tile Data", order = 0)]
	public class TileData : ScriptableObjectInstaller
	{
		[SerializeField]
		private Sprite sprite = null;

		[SerializeField] 
		private Color color;
		
		[SerializeField]
		private TileType type = TileType.Zero;
		
		public Sprite Sprite => sprite;
		public TileType Type => type;

		public Color Color => color;
	}
}
