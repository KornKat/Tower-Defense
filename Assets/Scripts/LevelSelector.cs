using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string backToMenu = "MainMenu";
    public string levelOne = "LevelOne";

    public void FirstLevel()
    {
        SceneManager.LoadScene(levelOne);
        Time.timeScale = 1f;

    }

    public void Menu()
    {
        SceneManager.LoadScene(backToMenu);

    }
}
