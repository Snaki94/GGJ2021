using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class GameplayController : MonoBehaviour, IGameplayController
	{
		public void Show()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}
	}
}
