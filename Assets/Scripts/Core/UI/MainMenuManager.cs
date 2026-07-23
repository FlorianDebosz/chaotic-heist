using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Museum");
    }
    
    public void Settings()
    {
        Debug.Log("Settings soon");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}