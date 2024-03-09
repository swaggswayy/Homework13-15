using System;
using Zenject;

public class GameManager : IInitializable, IDisposable
{
    private PlayMode _playMode;
    private LevelLoadingData _levelLoadingData;
    private BalloonsList _balloons;

    public Action EndGame;

    [Inject]
    private void Construct(LevelLoadingData levelLoadingData, BalloonsList balloons)
    {
        _levelLoadingData = levelLoadingData;
        _balloons = balloons;
    }

    public void Initialize()
    {
        _playMode = _levelLoadingData.PlayMode;
        _playMode.Init(_balloons);
        _playMode.EndGame += OnEndGame;
    }
    public void Dispose()
    {
        _playMode.EndGame -= OnEndGame;
    }

    private void OnEndGame() => EndGame.Invoke();
}
