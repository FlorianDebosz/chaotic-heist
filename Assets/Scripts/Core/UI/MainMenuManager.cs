using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void HostGame()
    {
        PlayerPrefs.SetString("LobbyMode", "Host");
        SceneManager.LoadScene("Lobby");
    }

    public void JoinGame()
    {
        PlayerPrefs.SetString("LobbyMode", "Join");
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
