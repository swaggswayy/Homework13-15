using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LobbyHUD : MonoBehaviour
{
    [SerializeField] private Button _allBalloonsModeButton;
    [SerializeField] private Button _colorsBalloonsModeButton;

    [Inject] private LoadLevelMediator _loadLevelMediator;

    private void OnEnable()
    {
        _allBalloonsModeButton.onClick.AddListener(SelectAllBalloonsPattern);
        _colorsBalloonsModeButton.onClick.AddListener(SelectColorsBalloonsPattern);
    }

    private void OnDisable()
    {
        _allBalloonsModeButton.onClick.RemoveListener(SelectAllBalloonsPattern);
        _colorsBalloonsModeButton.onClick.RemoveListener(SelectColorsBalloonsPattern);
    }

    private void SelectAllBalloonsPattern()
    {
        _loadLevelMediator.LoadLevelWithAllBalloonsPattern();
    }

    private void SelectColorsBalloonsPattern()
    {
        _loadLevelMediator.LoadLevelWithColorsBalloonsPattern();
    }
}
