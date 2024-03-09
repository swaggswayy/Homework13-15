using Zenject;

public class LoadLevelMediator 
{
    [Inject] SceneLoader _sceneLoader;

    public void LoadLevelWithAllBalloonsPattern()
    {
        _sceneLoader.Load(new LevelLoadingData(new AllBalloonsWinPattern()));
    }

    public void LoadLevelWithColorsBalloonsPattern()
    {
        _sceneLoader.Load(new LevelLoadingData(new ColorsBalloonsWinPattern()));
    }
}
