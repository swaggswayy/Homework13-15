public class ColorsBalloonsWinPattern : PlayMode
{
    protected override void OnBreakBalloon(Balloon balloon)
    {
        balloon.BreakBalloon -= OnBreakBalloon;
        BalloonsList.Remove(balloon);
        for (int i = 0; i < BalloonsList.Count; i++)
        {
            if (BalloonsList[i].Color == balloon.Color) return;
        }
        EndGame?.Invoke();
    }
}
