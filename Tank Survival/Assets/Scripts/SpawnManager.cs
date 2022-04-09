using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    private float zEnemySpawn = 20f;
    private float xEnemySpawn = 20f;
    private float zRepairSpawn = 15f;
    private float xRepairSpawn = 15f;
    private float yPos = 0.5f;
    private int waveCount = 1;
    private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveCount);
        }
    }
    void SpawnEnemy()
    {
    
        float randomEX = Random.Range(-xEnemySpawn, xEnemySpawn);
        float randomEZ = Random.Range(-zEnemySpawn, zEnemySpawn);
        int randomIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(randomEX, yPos, randomEZ);


        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
    void SpawnPowerup()
    {
        float randomHX = Random.Range(-xRepairSpawn, xRepairSpawn);
        float randomHZ = Random.Range(-zRepairSpawn, zRepairSpawn);

        Vector3 spawnPos = new Vector3(randomHX, yPos, randomHZ);
        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        if (GameObject.FindGameObjectsWithTag("Heal").Length == 0)
        {
            SpawnPowerup();
        }

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            SpawnEnemy();
        }

        waveCount++;
    }
}
