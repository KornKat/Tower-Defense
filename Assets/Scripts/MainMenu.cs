using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "LevelOne";
    public string levelSelect = "LevelSelect";

    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
        Time.timeScale = 1f;



    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(levelSelect);
        



    }

    public void Quit()
    {
        EditorApplication.ExitPlaymode();

        Application.Quit();
    }
}
