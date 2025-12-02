using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string backToMenu = "MainMenu";


    public void Menu()
    {
        SceneManager.LoadScene(backToMenu);

    }
}
