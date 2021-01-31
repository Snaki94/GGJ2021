using System;
using System.Collections;
using UnityEngine;

namespace GGJ2021
{
	public class MethodCaller : MonoBehaviour, IMethodCaller
	{
		public void CallMethodAfterSeconds(Action action, float seconds)
		{
			StartCoroutine(CallMethod(action, seconds));
		}
		
		private IEnumerator CallMethod(Action action, float seconds)
		{
			yield return new WaitForSeconds(seconds);
			action.Invoke();
		}
	}
}