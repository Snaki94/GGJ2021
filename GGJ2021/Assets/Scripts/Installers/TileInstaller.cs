using UnityEngine;
using Zenject;

namespace GGJ2021
{
	public class TileInstaller : MonoInstaller
	{
		[SerializeField]
		private TileData[] tileDatas = null;

		public override void InstallBindings()
		{
			Container.BindInstance(tileDatas);
		}
	}
}