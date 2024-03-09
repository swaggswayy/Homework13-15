using UnityEngine;
using Zenject;

public class LevelInstaller : MonoInstaller
{
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private LoadLevelMediator _loadLevelMediator;

    public override void InstallBindings()
    {
        Container.Bind<ZenjectSceneLoaderWrapper>().AsSingle();
        Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
        Container.Bind<LoadLevelMediator>().AsSingle();
    }
}
