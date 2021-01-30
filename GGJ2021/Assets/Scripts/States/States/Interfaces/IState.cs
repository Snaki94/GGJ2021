namespace GGJ2021
{
	public interface IState
	{
		void Initialize();
		void Tick();
		void Dispose();
	}
}