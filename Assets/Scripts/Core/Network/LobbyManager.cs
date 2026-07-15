using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Netcode;

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
        Debug.Log("Host setup - players count: " + NetworkManager.Singleton.ConnectedClientsList.Count);
        playersListText.text = "Waiting for players...";
        startGameButton.SetActive(true);
    }

    private void SetupJoin()
    {
        startGameButton.SetActive(false);
        Debug.Log("Join setup");
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
