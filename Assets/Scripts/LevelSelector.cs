using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string backToMenu = "MainMenu";
    public string levelOne = "LevelOne";
    public string levelTwo = "LevelTwo";

    public void FirstLevel()
    {
        SceneManager.LoadScene(levelOne);
        Time.timeScale = 1f;

    }
    public void SecondLevel()
    {
        SceneManager.LoadScene(levelTwo);
        Time.timeScale = 1f;

    }

    public void Menu()
    {
        SceneManager.LoadScene(backToMenu);

    }
}
