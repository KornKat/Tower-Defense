using UnityEngine;
using UnityEngine.UI;
public class LivesUI : MonoBehaviour
{

    public Text livesText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString() + " LIVES";
        if(PlayerStats.Lives == 1)
        {
            livesText.text = PlayerStats.Lives.ToString() + " LIFE";
        }
        if (PlayerStats.Lives <= 0)
        {
            livesText.text = "0 LIVES";
        }
    }
}
