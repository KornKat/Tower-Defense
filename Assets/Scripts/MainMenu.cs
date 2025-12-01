using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "LevelOne";
    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1f;

    }
    
    public void Quit()
    {
        EditorApplication.ExitPlaymode();

        Application.Quit();
    }
}
