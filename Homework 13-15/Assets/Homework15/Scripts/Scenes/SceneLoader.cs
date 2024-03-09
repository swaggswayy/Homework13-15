using System;

public class SceneLoader  : ILevelLoader, ISceneLoader
{
    private ZenjectSceneLoaderWrapper _zenjectSceneLoader;

    private SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoader)
    {
        _zenjectSceneLoader = zenjectSceneLoader;
    }   

    public void Load(ScenesEnum scene)
    {
        if (scene == ScenesEnum.GameScene)
            throw new ArgumentException(nameof(scene));

        _zenjectSceneLoader.Load(scene);
    }

    public void Load(LevelLoadingData levelLoadingData)
    {
        _zenjectSceneLoader.Load(ScenesEnum.GameScene, container =>
        {
            container.BindInstance(levelLoadingData).AsSingle();
        });
    }
}
