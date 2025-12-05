using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;
    

    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 5f;

    public Text waveCountdownText;
    public GameObject waveCounter;

    public Text waveTrackerText;
    public GameObject waveTracker;

    public GameManager gameManager;

    private int waveIndex = 0;
    
    
 

    void OnEnable()
    {
        EnemiesAlive = 0;
    }

    void Update ()
    {

        if (EnemiesAlive > 0)
        {
            return;
        }
        else
        {
            waveCounter.SetActive(true);
        }



        if (waveIndex == waves.Length)
        {
            if (PlayerStats.Lives <= 0)
            {
                gameManager.EndGame();
                this.enabled = false;

            }
            else
            {
                
                gameManager.WinLevel();
                this.enabled = false;

            }
        }

        if (countdown <= 0f)
        {
            waveCounter.SetActive(false);
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = "NEXT WAVE IN  " + string.Format("{0:0}", countdown);
        
    }

    IEnumerator SpawnWave ()
    {
        PlayerStats.Rounds++;
        waveTrackerText.text = "WAVE  " + PlayerStats.Rounds.ToString() + "/10";

        Wave wave = waves[waveIndex];

        EnemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            int enemyType = Random.Range(0, wave.enemies.Length);
            SpawnEnemy(wave.enemies[enemyType]);
            yield return new WaitForSeconds(1f / wave.rate);
            //SpawnSecondaryEnemy(wave.enemy);
            //yield return new WaitForSeconds(1f / wave.secondRate);
        }
        waveIndex++;

        //Wave wave = waves[waveIndex];

        //EnemiesAlive = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;

        //for (int i = 0; i < wave.count; i++)
        //{
            //int enemyType = Random.Range(0, wave.enemies.Length);
            //for (int x = 0; x < wave.enemies.Length; x++)
            //{
               // SpawnEnemy(wave.enemies[x]);
                //yield return new WaitForSeconds(1f / wave.rate);
            //}

        }

    void SpawnEnemy (GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnSecondaryEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
