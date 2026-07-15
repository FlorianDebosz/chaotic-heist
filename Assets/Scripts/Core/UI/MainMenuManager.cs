using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
public class MainMenuUI : MonoBehaviour
{
    private void Start()
    {
        if (NetworkManager.Singleton == null)
        {
            Debug.LogError("NetworkManager not found!");
        }
    }

    public void HostGame()
    {
        PlayerPrefs.SetString("LobbyMode", "Host");
        if (NetworkManager.Singleton != null)
            NetworkManager.Singleton.StartHost();
        SceneManager.LoadScene("Lobby");
    }

    public void JoinGame()
    {
        PlayerPrefs.SetString("LobbyMode", "Join");
        if (NetworkManager.Singleton != null)
            NetworkManager.Singleton.StartClient();
        SceneManager.LoadScene("Lobby");
    }

    public void Settings()
    {
        Debug.Log("Settings coming soon...");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
