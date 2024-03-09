using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class WinPanel : MonoBehaviour, IDisposable
{
    [SerializeField] private Button _lobbyButton;

    private ReturnLobbyMediator _finalHUDMediator;
    private GameManager _gameManager;

    [Inject]
    private void Construct(ReturnLobbyMediator finalHUDMediator, GameManager gameManager)
    {
        _finalHUDMediator = finalHUDMediator;
        _gameManager = gameManager;
        Initial();
    }

    private void Initial()
    {
        _gameManager.EndGame += ShowEndPanel;
        _lobbyButton.onClick.AddListener(ReturnToLobby);
        HideEndPanel();
    }

    public void Dispose()
    {
        _lobbyButton.onClick.RemoveListener(ReturnToLobby);
        _gameManager.EndGame -= ShowEndPanel;
    }

    private void ShowEndPanel()
    {
        _lobbyButton.gameObject.SetActive(true);
    }

    private void HideEndPanel()
    {
        _lobbyButton.gameObject.SetActive(false);
    }

    private void ReturnToLobby()
    {
        _finalHUDMediator.ReturnToLobby();
    }

}
