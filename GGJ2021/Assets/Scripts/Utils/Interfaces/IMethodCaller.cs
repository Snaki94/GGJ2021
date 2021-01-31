using System;

namespace GGJ2021
{
	public interface IMethodCaller
	{
		void CallMethodAfterSeconds(Action action, float seconds);
	}
}