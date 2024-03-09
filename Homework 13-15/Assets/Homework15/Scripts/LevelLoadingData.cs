public class LevelLoadingData
{
    private PlayMode _playMode; 

    public LevelLoadingData(PlayMode playMode)
    {
        _playMode = playMode;
    }

    public PlayMode PlayMode => _playMode;

}
