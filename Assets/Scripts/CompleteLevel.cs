using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string backToMenu = "MainMenu";
    public string nextLevel = "LevelTwo";


    public void Menu()
    {
        SceneManager.LoadScene(backToMenu);

    }

    public void Continue()
    {
        SceneManager.LoadScene(nextLevel);

    }
}
