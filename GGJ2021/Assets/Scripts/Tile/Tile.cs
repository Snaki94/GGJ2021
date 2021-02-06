using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace GGJ2021
{
	public class Tile : MonoBehaviour
	{
		public TileData Data { get; set; }
		public TileState State { get; set; }
		
		[Inject]
		private ISelectionInputSystem selectionInputSystem;

		[Inject] private ISoundSystem soundSystem;

		[SerializeField] private Transform tileRevers;
		[SerializeField] private Transform tileAvers;
		[SerializeField] private Image imageValue;
		[SerializeField] private float flipSpeed = 0.2f;

		private bool isActive = false;

		
		public void Initialize()
		{
			imageValue.sprite = Data.Sprite;
			imageValue.color = Data.Color;
			tileRevers.gameObject.SetActive(true);
			tileAvers.gameObject.SetActive(true);
			tileAvers.transform.eulerAngles = new Vector3(0, 90, 0);
			tileRevers.transform.eulerAngles = new Vector3(0, 0, 0);
		}
		
		public void Hide()
		{
			tileRevers.gameObject.SetActive(false);
			tileAvers.gameObject.SetActive(false);
			gameObject.transform.DOScale(new Vector3(1f,1f,1f),0.5f);
		}

		public void OnPointerEnter()
		{
			selectionInputSystem.OnTileEnter(this);
		}
		
		public void OnPointerClick()
		{
			selectionInputSystem.OnTileClick(this);
		}

		public void OnPointerExit()
		{
			selectionInputSystem.OnTileExit(this);
		}
		
		public void ScaleUp()
		{
			DOTween.Pause(this);
			transform.DOScale((new Vector3(1.3f,1.3f,1.3f)),0.5f);
		}
		
		public void ScaleDown()
		{
			DOTween.Pause(this);
			transform.DOScale((new Vector3(1f,1f,1f)),0.5f);
		}

		public void FlipUp()
		{
			if (isActive)
				return;
			StartCoroutine(RotateToAvers());
		}
		
		public void FlipDown()
		{
			if (isActive)
				return;
			StartCoroutine(RotateToRevers());
		}

		IEnumerator RotateToAvers()
		{
			isActive = true;
			soundSystem.PlayFlipCardSound();
			tileRevers.transform.DORotate(new Vector3(0, 90, 0), flipSpeed);
			for (float i = flipSpeed; i >= 0; i -= Time.deltaTime)
				yield return 0;
			tileAvers.transform.DORotate(new Vector3(0, 0, 0), flipSpeed);
			isActive = false;
		}

		IEnumerator RotateToRevers()
		{
			isActive = true;
			soundSystem.PlayFlipCardSound();
			tileAvers.transform.DORotate(new Vector3(0, 90, 0), flipSpeed);
			for (float i = flipSpeed; i >= 0; i -= Time.deltaTime)
				yield return 0;
			tileRevers.transform.DORotate(new Vector3(0, 0, 0), flipSpeed);
			isActive = false;
		}
	
	}
}