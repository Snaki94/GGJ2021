using DG.Tweening;
using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class Tile : MonoBehaviour
	{
		public TileData Data { get; set; }
		public TileState State { get; set; }
		
		[Inject]
		private ISelectionInputSystem selectionInputSystem;
		
		public void Show()
		{
			gameObject.SetActive(true);
		}
		
		public void Hide()
		{
			gameObject.SetActive(false);
		}
		
		public void OnPointerClick()
		{
			selectionInputSystem.OnTileClick(this);
		}

		public void OnPointerEnter()
		{
			gameObject.transform.DOScale((new Vector3(1.3f,1.3f,1.3f)),0.5f);

		}

		public void OnPointerExit()
		{
			gameObject.transform.DOScale((new Vector3(1f,1f,1f)),0.5f);
		}
	}
}