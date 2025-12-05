using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "LevelOne";
    public string levelSelect = "LevelSelect";
    public string gameCredits = "Credits";

    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1f;



    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(levelSelect);
        



    }
    public void Credits()
    {
        SceneManager.LoadScene(gameCredits);
    }

    public void Quit()
    {
       //EditorApplication.ExitPlaymode();

        Application.Quit();
    }
}
