
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float startSpeed = 10f;

    public float speed;

    public int startHealth = 100;
    private float health;

    public int value = 50;

    public int damage = 1;

    public GameObject healthUI;

    public GameObject deathEffect;

    public AudioSource deathSound;

    [Header("Unity Stuff")]
    public Image healthBar;

    private bool isDead = false;

    private Transform target;
    private int wavepointindex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = Waypoints.points[0];
        speed = startSpeed;
        health = startHealth;
        healthUI.SetActive(false);
    }



    public void TakeDamage (int amount)
    {
        health -= amount;
        healthUI.SetActive(true);


        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }


    void Die()
    {
        isDead = true;

        PlayerStats.Money += value;
        deathSound = GetComponent<AudioSource>();
        deathSound.Play();

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointindex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointindex++;
        target = Waypoints.points[wavepointindex];
    }

    void EndPath()
    {
        PlayerStats.Lives -= damage;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }



}
