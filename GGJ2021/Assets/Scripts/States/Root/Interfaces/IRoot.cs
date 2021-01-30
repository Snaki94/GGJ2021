namespace GGJ2021
{
	public interface IRoot
	{
		void ChangeState<TState>() where TState : IState;
	}
}