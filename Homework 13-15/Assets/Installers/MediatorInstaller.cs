using UnityEngine;
using Zenject;

public class MediatorInstaller : MonoInstaller
{
    [SerializeField] private GameplayMediator _gameplayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;

    public override void InstallBindings()
    {
        Container.Bind<GameplayMediator>().FromInstance(_gameplayMediator);
        Container.Bind<DefeatPanel>().FromInstance(_defeatPanel);
        Container.Bind<Level>().FromInstance(new Level());
    }
}
