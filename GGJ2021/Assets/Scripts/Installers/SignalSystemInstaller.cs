using Zenject;

namespace GGJ2021
{
    public class SignalSystemInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            Container.Bind<ISignalSystem>().To<SignalSystem>().AsSingle();
            DeclareSignals();
        }

        private void DeclareSignals()
        {
            Container.DeclareSignal<TileSelectionFinished>();
        }
    } 
}