using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float minSpawnTime;
    public float maxSpawnTime;
    public GameObject[] obstacles;
    public GameObject player;
    public bgloop bgloop;
    public bool isGameOver;
    public bool isGamePlay;
    private int _score;

    public int Score { get => _score; set => _score = value; }

    public override void Awake()
    {
        MakeSingleton(false);
    }
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        while (!isGameOver)
        {
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(spawnTime);

            if (obstacles != null&&obstacles.Length>0)
            {
                int obIndex = Random.Range(0, obstacles.Length);

                GameObject obstacle = obstacles[obIndex];

                if (obstacle)
                {
                    Vector3 spawnPos = new Vector3(Random.Range(-4f, 0f), 8f, 0f);
                    ObstacleControllerV1 controller = obstacle.GetComponent<ObstacleControllerV1>();
                    if (!controller.isFaceFront)
                    {
                        spawnPos = new Vector3(Random.Range(0f, 4f), -8f, 0f);
                    }
                    
                    Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
                }
            }
        }
    }
}
