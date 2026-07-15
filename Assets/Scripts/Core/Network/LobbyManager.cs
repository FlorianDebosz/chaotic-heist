using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] private GameObject startGameButton;
    [SerializeField] private TMP_Text playersListText;

    public void Start()
    {
        string mode = PlayerPrefs.GetString("LobbyMode", "Host");
        if (mode == "Host") SetupHost();
        else SetupJoin();
    }

    private void SetupHost()
    {
        startGameButton.SetActive(true);
        playersListText.text = "Waiting for players...";
    }

    private void SetupJoin()
    {
        startGameButton.SetActive(false);
        playersListText.text = "Connected to lobby";
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Museum");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
