using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 500;

    public static int Lives;
    public int startLives = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
