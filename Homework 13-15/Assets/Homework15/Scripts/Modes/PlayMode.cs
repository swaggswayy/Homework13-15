using System;
using System.Collections.Generic;
public abstract class PlayMode
{
    private BalloonsList _balloonsList;
    protected List<Balloon> BalloonsList => _balloonsList.Balloons;

    public Action EndGame;

    public void Init(BalloonsList balloons)
    {
        _balloonsList = balloons;
        foreach (Balloon balloon in BalloonsList)
        {
            balloon.BreakBalloon += OnBreakBalloon;
        }
    }

    protected abstract void OnBreakBalloon(Balloon balloon);
}
