using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHolder : MonoBehaviour
{
    public GameObject item;
    public float spawnRate;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Ins.isGamePlay)
        {
            if (spawnRate < spawnTime)
            {
                spawnRate += Time.deltaTime;
            }
            else if(spawnRate > spawnTime)
            {
                spawnRate = 0;
                int percent = Random.Range(0, 10);
                if (percent < 4)
                {
                    Vector3 spawnPos = new Vector3(Random.Range(-4f, 0f), 8f, -8f);
                    Instantiate(item, spawnPos, gameObject.transform.rotation);
                    
                }
            }
        }
    }
}
