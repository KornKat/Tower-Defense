using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
            
        }
    }

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }


    public void WinLevel()
    {

        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }

}
