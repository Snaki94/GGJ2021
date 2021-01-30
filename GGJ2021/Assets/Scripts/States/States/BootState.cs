using UnityEngine;

namespace GGJ2021
{
	public class BootState : IState
	{
		public void Initialize()
		{
			Debug.Log("boot state initialized");
		}

		public void Tick()
		{}

		public void Dispose()
		{
			Debug.Log("boot state disposed");
		}
	}
}