using UnityEngine;
using UnityEngine.UI;
public class MoneyUI : MonoBehaviour
{
    public Text moneyText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }
}
