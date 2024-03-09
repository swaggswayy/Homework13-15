using UnityEngine;

public class AllBalloonsWinPattern : PlayMode
{
    protected override void OnBreakBalloon(Balloon balloon)
    {
        balloon.BreakBalloon -= OnBreakBalloon;
        BalloonsList.Remove(balloon);
        Debug.Log(BalloonsList.Count);
        if (BalloonsList.Count == 0)
        {
            EndGame?.Invoke();
        }
    }
}
