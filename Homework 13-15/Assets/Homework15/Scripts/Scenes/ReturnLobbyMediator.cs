using Zenject;

public class ReturnLobbyMediator 
{
    [Inject] private SceneLoader _sceneLoader;

    public void ReturnToLobby()
    {
        _sceneLoader.Load(ScenesEnum.LobbyScene);
    }
}
