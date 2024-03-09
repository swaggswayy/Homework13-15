using UnityEngine;
using Zenject;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;

    private Level _level;

    [Inject]
    public void Construct(Level level)
    {
        _level = level;
        _level.Defeat += OnLevelDefeat;
    }

    private void OnDestroy()
    {
        _level.Defeat -= OnLevelDefeat;
    }

    private void OnLevelDefeat()
        => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
    }
}
