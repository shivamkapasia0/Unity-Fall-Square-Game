using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyBlockPrefab;
    public Vector2 secondsBetweenSpawnsMinMax;
    private float nextSpawnTime;
    public float spawnAngleMax;
     Vector2 screenSize;
    void Start()
    {
        screenSize = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize+ .5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, DifficultyLevel.GetDifficultyPercent());
            print(secondsBetweenSpawns);
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
            Vector2 spawnPosition = new Vector2(Random.Range(-screenSize.x/2, screenSize.x/2), screenSize.y +1f);
            Instantiate(enemyBlockPrefab, spawnPosition, Quaternion.Euler(Vector3.forward * spawnAngle));
        }
    }
}
