using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public Text roundsText;

    public string backToMenu = "MainMenu";


    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }


    public void Retry ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;

    }

    public void Menu()
    {
        SceneManager.LoadScene(backToMenu);

    }

}
