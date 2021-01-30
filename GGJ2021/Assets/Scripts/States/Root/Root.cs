using System;
using Zenject;

namespace GGJ2021
{
	public class Root : IRoot, IInitializable, ITickable, IDisposable
	{
		private IState currentState;
		private DiContainer container;
		
		public Root(DiContainer container)
		{
			this.container = container;
		}

		public void Initialize()
		{
			ChangeState<BootState>();
		}

		public void Tick()
		{
			currentState.Tick();
		}

		public void Dispose()
		{
			currentState.Dispose();
		}

		public void ChangeState<TState>() where TState : IState
		{
			currentState?.Dispose();
			currentState = container.Instantiate<TState>();
			currentState?.Initialize();
		}
	}
}