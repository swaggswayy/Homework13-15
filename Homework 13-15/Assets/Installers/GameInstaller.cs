using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private BalloonsList _balloons;

    public override void InstallBindings()
    {
        BindGame();
        BindHUD();
    }

    private void BindGame()
    {
        Container.BindInterfacesAndSelfTo<GameManager>().AsSingle();
        Container.Bind<BalloonsList>().FromInstance(_balloons).AsSingle();
    }

    private void BindHUD()
    {
        Container.BindInterfacesAndSelfTo<ReturnLobbyMediator>().AsSingle();
    }
}
